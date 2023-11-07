using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 相机机械臂VisionPro联合编程
{
    internal class MyApp
    {
         public static void SetValue(string key, string value)
        {
            try
            {
                Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (cfa.AppSettings.Settings[key] != null)
                    cfa.AppSettings.Settings[key].Value = value;
                else
                    cfa.AppSettings.Settings.Add(key, value);
                cfa.Save();
            }
            catch
            { }
        }
        public static string GetValue(string key)
        {
            string str = ConfigurationManager.AppSettings[key];
            return str;
        }
        public static int GetValueAsInt(string key, int defalut = 0)
        {
            string str = ConfigurationManager.AppSettings[key];
            int value;
            if (int.TryParse(str, out value))
            {
                return value;
            }
            else
            {
                return defalut;
            }
        }
        public static double GetValueAsDouble(string key, double defalut = 0)
        {
            string str = ConfigurationManager.AppSettings[key];
            double value;
            if (double.TryParse(str, out value))
            {
                return value;
            }
            else
            {
                return defalut;
            }
        }
    }
}
