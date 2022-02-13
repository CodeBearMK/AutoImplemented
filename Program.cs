namespace AutoImplemented
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 10; //可以透過set寫入值
            rectangle.SetLength1(100); //只能透過方法改寫
            Console.WriteLine(rectangle.Length);
            Console.WriteLine(rectangle.Length1);
            Console.Read();
        }
    }
}