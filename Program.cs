namespace ProjectHashrTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to stack");
         //   UC1 obj = new UC1();
            //UC2 obj = new UC2();
            //obj.push(70);
            //obj.push(30);
            //obj.push(56);

        
            //obj.Peek();
            //Console.WriteLine("After pop operation:");
            //obj.Pop();
            //obj.IsEmpty();

            //obj.Display();
            //Console.ReadLine();
            UC3 obj = new UC3();
            obj.Enqueue(70);
            obj.Enqueue(30);
            obj.Enqueue(56);
            Console.ReadLine();

        }
    }
}