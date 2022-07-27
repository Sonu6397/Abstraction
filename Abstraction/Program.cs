using System;

namespace Abstraction
{
    abstract class Example
    {
        public abstract void MyMethod();
        
        public void Add()
        {
            Console.WriteLine("method is non-static");
        }

    }

    class Demo : Example
    {
        public override void MyMethod()
        {
            Console.WriteLine("this method is MyMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.MyMethod();
            d.Add();
            Console.ReadLine();

        }
    }
}
