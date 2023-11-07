using static System.Console;
//Queue<T>类, 调用Enqueue()方法将表项加入到队列末端，Dequeue()从队列最前端删除表项

Int32 one, index = 6;
//创建队列对象

Queue<string> fruit = new();
string[] name = {"Strawberry", "Watermelon", "Apple",
            "Orange", "Banana", "Mango"};

foreach (var item in name)
    fruit.Enqueue(item); //从队列末端加入表项
//调用Peek()方法显示第一种水果
if (fruit.Count > 0)
{
    one = index - fruit.Count + 1;
    WriteLine($"第{one}种水果 - {fruit.Peek()}");
}
itemPrint(fruit);

//Dequeue()从队列最前端删除表项
if (fruit.Count > 0)
{
    one = index - fruit.Count + 1;
    WriteLine($"\n删除第{one}种水果 - {fruit.Dequeue()}");
}
itemPrint(fruit);

ReadKey();

static void itemPrint(Queue<string> plant)
{
    Int32 index = 0;//存储索引
    foreach (var item in plant)
    {
        WriteLine($"[{index}] - {item,-10}");
        index++;
    }
    WriteLine($"有{plant.Count}种水果");

}