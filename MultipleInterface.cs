using System;

namespace myApplication()
{
    interface IFirstInterface 
    {
       void myMethod(); 
    }

    interface ISecondInterface
    {
        void myMethod();
    }

    class DemoClass : IFirstInterface,ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("MyMethod implementation");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("MyOtherMethod implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass obj = new DemoClass();
            obj.myMethod();
            obj.myOtherMethod();
        }
    }
}