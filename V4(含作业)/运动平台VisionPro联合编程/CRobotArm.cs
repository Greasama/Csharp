using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

public class CRobotArm
{
    private SerialPort serialPort = new SerialPort();
    private int m_id = 1;
    public int getinc()
    {
        lock (this)
        {
            m_id++;
            return m_id;
        }
    }
    public string ReadtoId(int id)
    {
        while (true)
        {
            try
            {
                string str = serialPort.ReadLine();
                if (str != null && str.IndexOf("$" + id + " ")>=0)
                {
                    return str;
                }
            } catch {
                return "";
            }
        }
    }
    /************************************
     * 功能：连接机械臂
     * 参数：
     *   str:机械臂设备的串口号
     * 返回值：
     *   成功1，失败0
     *************************************/
    public bool ConnectRobot(string com)
    {
        try
        {
            serialPort.PortName = com;
            serialPort.BaudRate = 115200;
            serialPort.Open();
            serialPort.ReadTimeout = 3000;
            serialPort.WriteLine("");//打开后发送一个空命令以初始化机械臂！！
            serialPort.WriteLine("M2400 S0");            
            int id = getinc();
            serialPort.WriteLine("#"+id+" M17");//锁住电机，同时测试当前端口是否是机械臂
            string readstr = ReadtoId(id);
            if (string.IsNullOrEmpty(readstr))
            {
                if (serialPort.IsOpen) 
                {
                    serialPort.Close();//如果返回值为空，是代表当前端口不是机械臂，返回false处理
                }
                return false;
            }

            serialPort.ReadTimeout = -1;
        }
        catch
        {
            if (serialPort.IsOpen)
            {
                return true;
            }
            return false;

        }
        return serialPort.IsOpen;
    }

    /************************************
    * 功能：断开连接机械臂
    * 参数：无
    * 返回值：
    *  无
    *************************************/
    public void DisConnectRobot()
    {
        serialPort.Close();
    }
    /************************************
    * 功能：控制机械臂运动---XYZ
    * 参数：
    *   X:相对于基座的X坐标运动位置
    *   Y:相对于基座的Y坐标运动位置
    *	 Z:相对于基座的Z坐标运动位置
    * 返回值：
    *   成功1，失败0
    *************************************/

    public bool MoveXYZ(float X, float Y, float Z,float _speed=1000)
    {
        if (!serialPort.IsOpen)
        {
            return false;
        }
        string Commadstr = "G0 X" + X.ToString() + "Y" + Y.ToString() + "Z" + Z.ToString() + " F" + _speed.ToString();
        serialPort.WriteLine("");
        serialPort.WriteLine(Commadstr);
        return true;
    }
    public bool MoveXYZWait(float X, float Y, float Z, float _speed = 1000)
    {
        if (!serialPort.IsOpen)
        {
            return false;
        }
        int id = getinc();
        string Commadstr = "#" + id + " G0 X" + X.ToString() + "Y" + Y.ToString() + "Z" + Z.ToString() + " F" + _speed.ToString();
        serialPort.WriteLine("");
        serialPort.WriteLine(Commadstr);
        string readstr;
        string checkstrFist = "$" + id;
        readstr = ReadtoId(id);
        string checkstr = "$" + id + " ok";

        if (!string.IsNullOrEmpty(readstr) && readstr.StartsWith(checkstr))
        {
            string check2 = checkstr + " E22 unreachable";
            if (readstr.StartsWith(check2))
            {
                return false;
            }
            return true;
        }
        else
        {
            return false;
        }

    }

    /************************************
    * 功能：/开启气泵工作
    * 参数：
    *  isOpen： true 开启，false 关闭
    * 返回值：无
    *************************************/
    public void OpenAirPump(bool isOpen)
    {
        if (!serialPort.IsOpen)
        {
            return;
        }

        if (isOpen)
        {
            int id = getinc();
            string Commadstr = "#" + id + " M2231 V1";
            serialPort.WriteLine("");
            serialPort.WriteLine(Commadstr);
            string readstr = ReadtoId(id);
            
        }
        else
        {
            int id = getinc();
            serialPort.WriteLine("");
            string Commadstr = "#" + id + " M2231 V0";
            serialPort.WriteLine(Commadstr);
            string readstr = ReadtoId(id);
        }

    }



/************************************
* 功能：获得机器人的姿态
* 参数: 无
* 返回值：返回机器人的末端位姿
*************************************/
    public bool GetCurrentRobotPose(out float x, out float y, out float z)
    {
        x = 0; y = 0; z = 0;
        if (!serialPort.IsOpen)
        {
            return false;
        }
        serialPort.WriteLine("");
        serialPort.WriteLine("P2220");
        string strPose = serialPort.ReadLine();
        if (string.IsNullOrEmpty(strPose))
        {
            return false;
        }
        string[] Arraystr = strPose.Split(' ');
        int count = 0;
        foreach (string item in Arraystr)
        {
            if (item.StartsWith("X"))
            {
                string temp1 = item.Remove(0, 1);
                if (float.TryParse(temp1, out x))
                {
                    count++;
                }
            }
            if (item.StartsWith("Y"))
            {
                string temp1 = item.Remove(0, 1);
                if (float.TryParse(temp1, out y))
                {
                    count++;
                }
            }
            if (item.StartsWith("Z"))
            {
                string temp1 = item.Remove(0, 1);
                if (float.TryParse(temp1, out z))
                {
                    count++;
                }
            }

        }
        return count == 3;
    }
    /************************************
     * 功能：机械臂使能---上电
     * 参数：
     *   isEnable:  
     *        true:上电（控制模式)
     *	      false:下电(自由模式）
     * 返回值：无
     *************************************/
    public void RobotArmPowerOn(bool isEnable)
    {
        if (!serialPort.IsOpen)
        {
            return;
        }
        if (isEnable)
        {
            int id = getinc();
            string Commadstr = "#" + id + " M2019";
            serialPort.WriteLine("");
            serialPort.WriteLine(Commadstr+"\r");
            string readstr = serialPort.ReadLine();
        }
        else
        {
            if (!serialPort.IsOpen)
            {
                return;
            }

            int id = getinc();
            string Commadstr = "#" + id + " M17";
            serialPort.WriteLine("");
            serialPort.WriteLine(Commadstr);
            string readstr = serialPort.ReadLine();
        }

    }
    public void RunScript(string Script, float x = 150, float y = 0)
    {
        if (string.IsNullOrEmpty(Script))
        {
            return;
        }
        try
        {
            string[] cmds = Script.Split('\n');
            foreach (string lineCMD in cmds)
            {
                if (!string.IsNullOrEmpty(lineCMD))
                {
                    string[] Itmecmd = lineCMD.Split('=');
                    if (Itmecmd.Length >= 2)
                    {
                        string cmdName = Itmecmd[0].Trim();
                        string cmdParam = Itmecmd[1].Trim();
                        if (cmdName == "气泵")
                        {
                            if (cmdParam == "打开")
                            {
                                OpenAirPump(true);
                            }
                            if (cmdParam == "关闭")
                            {
                                OpenAirPump(false);
                            }
                        }
                        if (cmdName == "停止")
                        {
                            int s = int.Parse(cmdParam);
                            if (s > 10000) { s = 10000; }
                            if (s < 0) { s = 0; }
                            Thread.Sleep(s);
                        }
                            
                        if (cmdName == "电机")
                        {
                            if (cmdParam == "打开")
                            {
                                RobotArmPowerOn(true);
                            }
                            if (cmdParam == "关闭")
                            {
                                RobotArmPowerOn(false);
                            }
                        }
                        if (cmdName == "移动")
                        {
                            string[] ParamArr = cmdParam.Split(',');
                            if (ParamArr.Length >= 4)
                            {
                                float X = x; float Y = y; float Z; float F;
                                string str_x = ParamArr[0].Trim().ToUpper();
                                if (str_x != "X")
                                {
                                    X = float.Parse(str_x);
                                }
                                string str_y = ParamArr[1].Trim().ToUpper();
                                if (str_y != "Y")
                                {
                                    Y = float.Parse(str_y);
                                }
                                string str_z = ParamArr[2];
                                Z = float.Parse(str_z);
                                string str_f = ParamArr[3];
                                
                                F = float.Parse(str_f);
                                if (F < 20)
                                    F = 20;
                                MoveXYZWait(X, Y, Z, F);
                            }
                        }
                    }
                }
            }
        }
        catch { }
    }
}
