using System;

namespace MyApplication
{

class Program
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    static void Main(string[] args)
    {
        Level myVar = Level.Medium;
        Console.WriteLine(myVar);
    }
    }
}

// my program

using System;

namespace myApplication
{
class Program
	{
    	enum Months
        {
          January,
          February,
          March,
          April,
          May,
          June,
          July,
          August,
          September,
          October,
          November,
          December
        }
    
    

static void Main(string[] args)
  {
  int myMonth = (int)Months.December;
  Console.WriteLine(myMonth);
  }
}
}