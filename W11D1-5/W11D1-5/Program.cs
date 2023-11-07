global using static System.Console;//全局，适用整个项目
global using Ex0807;   //全局，文件范围命名空间

//Person Peter = new();//声明基类的对象
//Peter.ShowMessage();
//Human Junior = new();
//Junior.ShowMessage();//派生类的对象调用自己的方法
//Son Datt = new();
//Datt.ShowMessage();//子类的子类
//ReadKey();

string PlaceHolder = new('-', 40);
Write(PlaceHolder + "\r\t\t   第一代相关信息\n");
Person Peter = new();//声明基类的对象
Peter.ShowMessage();

Write(PlaceHolder + "\r\t\t   第二代相关信息\n");
Human Junior = new();
Junior.ShowMessage();//派生类的对象调用自己的方法

Write(PlaceHolder + "\r\t\t   第三代相关信息\n");
Son Son = new Son();
Son.ShowMessage();


ReadKey();











