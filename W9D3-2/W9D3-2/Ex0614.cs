namespace Ex0614
{
    internal class Circle
    {
        static readonly int k = 1;//被静态方法调用，类成员必须为static
        public static double calcPeriphery(string one)
        {
            double periphery = double.Parse(one);
            double result = k* periphery*Math.PI;
            return result;
        }
        //静态类第二个方法，计算圆面积
        public static double CalcArea(string two)
        {
            double area = double.Parse(two);
            double circleArea = area * area * Math.PI;
            return circleArea;
        }
    }
}