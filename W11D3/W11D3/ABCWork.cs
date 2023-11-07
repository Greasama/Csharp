global using static System.Console;//全局，适用整个项目
global using Ex0809;   //全局，导入文件范围命名空间

//以数组方式声明每个继承类的实现对象
Staff[] staffs = {
            new Team("Annabelle", 52_480, 1_800),
            new Worker("Michelle", 1_780, 25),
            new Provisional("Benedict", 310, 5, 18)
         };

WriteLine("**  列出员工薪资  **");

//foreach读取数组元素，并调用showMessage()方法输出信息
foreach (Staff sf in staffs)
    sf.ShowMessage();

ReadKey();