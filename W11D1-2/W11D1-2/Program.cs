global using static System.Console;//全局，适用整个项目
global using Ex0804;   //全局，导入文件范围命名空间
using System;

Person pernOne = new();//父类对象
pernOne.Show();
pernOne.BaseMoney = 100;

Employee empWorker = new();//子类对象
string info = ",增加自定义代码->";
empWorker.Display(info);
//empWorker.Show();

ReadKey();