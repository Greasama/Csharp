global using static System.Console;   //全局，适用整个项目
global using Ex0801;   //导入文件范围命名空间

//基类的对象
School ScienceEngineer = new();
ScienceEngineer.ShowMsg();

//派生类的对象
Education choiceStu = new();
choiceStu.Display(20);

////HW二.2.
////基类的对象
//School ScienceEngineer = new School();
////派生类的对象
//Education choice = new Education("英文写作", 1208, "Jeffrey");
//Education choiceStu = choice;
//choiceStu.Display(20);

ReadKey();