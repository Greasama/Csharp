global using static System.Console;//全局，适用整个项目
global using Ex0803;   //导入文件范围命名空间，全局

//初始化onePrn对象，并传入初始值
Person anna = new("Annabelle", 35_678);
anna.ShowTime();

//实例化派生类，加入参数值
Employee partOne = new("Tomas", 24_413);
partOne.HireTime();

ReadKey();