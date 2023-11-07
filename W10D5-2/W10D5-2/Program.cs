global using static System.Console;   //全局，适用整个项目
global using Ex0802;          //全局，导入文件范围命名空间

Person Peter = new();        //声明基类的对象
Human Junior = new("黑色");  //声明派生类的对象

Peter.showMessage();
Junior.Show();

ReadKey();