//for (statement 1, statement 2, statement 3)
// {
    // block of codes to be executed
//} 

// statement 1 is executed (one time ) before the execution of the code block
// statement 2 defines the condition for executing the code block
// statement 3 is executed (every time) after the code block has been executed.

using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Why are you Gay");
            }
        }
    }
}