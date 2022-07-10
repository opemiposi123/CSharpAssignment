using System;

namespace ChapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

         // Write a program that reads from the console three numbers of type int
         // and prints their sum.
            
            int a, b, c;
            Console.Write("Enter the first number a:");
            bool isaInt = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second number b:");
            bool isbInt = int.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the third number c:");
            bool iscInt = int.TryParse(Console.ReadLine(), out c);
 
            if (isaInt & isbInt & iscInt)
            {
                Console.WriteLine("sum={0}",a+b+c);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not integer!");
            }
           // A given company has name, address, phone number, fax number, web 
           // site and manager. The manager has name, surname and phone number.
            //Write a program that reads information about the company and its 
            //manager and then prints it on the console
            
         /*  Console.WriteLine("Input company name :");
          string companyName = Console.ReadLine();
          Console.WriteLine("Input company address :");
          string companyAddress = Console.ReadLine();
          Console.WriteLine("Input company phone number :");
          double companyPhoneNumber = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Input company fax number :");
          int companyFaxNumber = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Input your website :");
          string yourWebsite = Console.ReadLine();
          Console.WriteLine("Input manager name :");
          string managerName = Console.ReadLine();
          Console.WriteLine("Input manager surname :");
          string managerSurnameName = Console.ReadLine();
          Console.WriteLine("Input manager phone number :");
          int managerPhoneNumber = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("The company name is:" + companyName,"and it is located at:" + companyAddress."The company Telephone is:" + companyPhoneNumber,"and tne company fax number:" + companyFaxNumber."The company website is:" + yourWebsite.);*/
          

         /* Write a program that reads from the console two integer numbers (int)
           and prints how many numbers between them exist, such that the 
           remainder of their division by 5 is 0. Example: in the range (14, 25) 
          there are 3 such numbers: 15, 20 and 25*/
            int x; int y;
            int min; int max;
            Console.WriteLine("Enter 1st integer: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter a 2nd integer: ");
            y = int.Parse(Console.ReadLine());
       
            //using ternary operator
            max = (x > y) ? x : y;
            min = (x < y) ? x : y;

          /*  if (x!=y)
                Console.WriteLine("The minimum number is: " + min);
                Console.WriteLine("The maximum number is: " + max + "\n");
            }         
            else
            {
                Console.WriteLine("The numbers are both equal therefore there are 0 numbers in between them that are divisible by 5 and results to zero.");
            }*/


           // Write a program that reads five numbers from the console and prints the 
            //greatest of them

             /*Console.WriteLine("Please write 5 numbers:");
             decimal a = decimal.parse(Console.ReadLine());
             decimal b = decimal.Parse(Console.ReadLine());
             decimal c = decimal.Parse(Console.ReadLine());
             decimal d = decimal.Parse(Console.ReadLine());
             decimal e = decimal.Parse(Console.ReadLine());
 
            if ((a >= b) && (a >= c) && (a >= d) && (a >= e))
           {
            Console.WriteLine("The biggest number is: {0}", a);
            return;
          }
           if ((b >= a) && (b >= c) && (b >= d) && (b >= c))
         {
            Console.WriteLine("The biggest number is: {0}", b);
            return;
         }
         if ((c >= a) && (c >= b) && (c >= d) && (c >= e))
         {
            Console.WriteLine("The biggest number is: {0}", c);
            return;
         }
         if ((d >= a) && (d >= b) && (d >= c) && (d >= e))
         {
            Console.WriteLine("The biggest number is: {0}", d);
            return;
         }
         if ((e >= a) && (e >= b) && (e >= c) && (e >= d))
         {
            Console.WriteLine("The biggest number is: {0}", e);
            return;
         }*/

         /*Write a program that reads five integer numbers and prints their 
         sum. If an invalid number is entered the program should prompt the user 
         to enter another number.*/




         Console.WriteLine("Enter first number :");
         int firstNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter second number :");
         int secondNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter third number :");
         int thirdNumber = Convert.ToInt32(Console.ReadLine());
         int sumOfNumbers = firstNumber + secondNumber + thirdNumber;
         Console.WriteLine("The sum of all the number is:" + sumOfNumbers);

         //Write a program that reads two numbers from the console and prints the 
         //greater of them. Solve the problem without using conditional 
         //statements
         Console.WriteLine(Math.Max(5,6));
        }
    }      
}    
