using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Console.WriteLine("Enter first number:");
          double a = double.Parse(Console.ReadLine());
          Console.Clear();
          Console.WriteLine("Enter second number:");
          double b = double.Parse(Console.ReadLine());
          Console.WriteLine("Enter third number:");
          double c = double.Parse(Console.ReadLine());
          if ((a>b) &&(a>c))
          {
           if (b>c)
           {
             Console.WriteLine("{0},{1},{2}", a,b,c);
           } 
            else
            {
              Console.WriteLine("{0},{1},{3}",a,c,b);
            }
          }
           else if((b>a) &&(b>c))
          {
             if (a>b)
            {
              Console.WriteLine("{0},{1},{2}",b,a,c);
            }
            else
            {
              Console.WriteLine("{0},{1},{2}",b,c,a);
            }
          }
           else if ((c>a) && (c>b))
           {
             if (a>c)
             {
               Console.WriteLine("{0},{1},{2}",c,a,b);
             }
             else
             {
               Console.WriteLine("{0},{1},{2}",c,b,a);
             }
           } 
        } 
    }
}
