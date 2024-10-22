using System;

namespace myApplication
	{
    class Program
    	{
        static void Main(string[] args)
        	{
            for(int j = 1; j < 3; ++j)
            	{
                Console.WriteLine("Outer: 1");
            for(int i = 1; i < 4; ++i)
            		{
                    Console.WriteLine("Inner: 2");
                    }
                }
            }
        }
    }