using System;

namespace ChapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

         // Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong //in order to assign them the following values:
            float value1 = 52.130F;
            sbyte value2 = -115;
            byte value3 = 97;
            long value4 = -10000;
            ushort value5 = 20000;
            byte value6 = 224;
            int value7 = 970700000;
            byte value8 = 112;
            sbyte value9 = -44;
            int value10 = -1000000;
            ushort value11 = 1990;
            ulong value12 = 123456789123456789;
            Console.WriteLine("     ");

            //2. Which of the following values can be assigned to variables of type float, double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467 ?
           float value13 = 5;
            float value14 = -5.01f;
            double value15 = 34.567839023;
            float value16 = 12.345f;
            double value17 = 8923.1234857;
            decimal value18 = 3456.091124875956542151256683467m;
            Console.WriteLine("       ");

            //3. Write a program, which compares correctly two real numbers with accuracy at least 0.000001.            
            bool result = false;
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());
            //string sNumber1 = Convert.ToString(number1);
            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());
            double deduction = number1 - number2;
            deduction = Math.Abs(deduction);
            Console.WriteLine(deduction);
            if (deduction < 0.000001)
            {
                result = true;
            }
            Console.WriteLine("({0};{1});{2}", number1, number2, result);
            Console.WriteLine("         ");

            //4. Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).
            int varInt = 0x100;
            Console.WriteLine(varInt);
             Console.WriteLine("       ");    

            //5.Declare a variable of type char and assign it as a value the character, which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).
            char varChar = '\u0048';
            Console.WriteLine(varChar);
            Console.WriteLine("      ");

            //6.Declare a variable isMale of type bool and assign a value to it depending on your gender.
            bool isMale = false;
            Console.WriteLine(isMale);
            Console.WriteLine("       ");

            //7.Declare two variables of type string with values "Hello" and "World".Declare a variable of type object. 
            //Assign the value obtained of concatenation of the two string variables(add space if necessary) to this variable.
            //Print the variable of type object.
            string hello = "Hello";
            string world = "World";
            object sayHello = hello + " " + world;
            Console.WriteLine(sayHello);
            Console.WriteLine("      ");

            //8.Declare two variables of type string and give them values "Hello" and "World".Assign the value obtained by the concatenation
            //of the two variables of type string(do not miss the space in the middle) to a variable of type object.Declare a third variable of
            // type string and initialize it with the value of the variable of
            //type object(you should use type casting).
            string sayHello2 = (string)sayHello;
            Console.WriteLine("       ");

            //9.Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” (without the outer quotes). 
            //In one of the variables use quoted string and in the other do not use it.
            string quotes1 = "The \"use\" of quotations causes difficulties.";
            string quotes2 = "\"The \"use\" of quotations causes difficulties.\"";
            Console.WriteLine(quotes1);
            Console.WriteLine(quotes2);
            Console.WriteLine("      ");

           //Write a program to print a figure in the shape of a heart by the sign "o"
            Console.WriteLine("   o        o     ");
            Console.WriteLine("  o  o     o  o      ");
            Console.WriteLine("  o   o   o   o       ");
            Console.WriteLine("   o    o   o         ");
            Console.WriteLine("     o    o       ");
            Console.WriteLine("        o         ");
            Console.WriteLine("     ");
      
          // Write a program that prints on the console isosceles triangle which 
           //sides consist of the copyright character "©".
           Console.WriteLine("              c            ");
            Console.WriteLine("            c c            ");
            Console.WriteLine("           c   c           ");
            Console.WriteLine("          c     c          ");
            Console.WriteLine("         c       c         ");
            Console.WriteLine("        c         c        ");
            Console.WriteLine("       c           c       ");
            Console.WriteLine("      ccccccccccccccc     ");
            Console.WriteLine("       ");

           /* company dealing with marketing wants to keep a data record of its 
           employees. Each record should have the following characteristic – first 
           name, last name, age, gender (‘m’ or ‘f’) and unique employee number 
          (27560000 to 27569999). Declare appropriate variables needed to 
          maintain the information for an employee by using the appropriate data 
           types and attribute names.*/

           Console.WriteLine("Input firstname :");
           string firstName = Console.ReadLine();
           Console.WriteLine("Input lastname:");
           string secondName = Console.ReadLine();
           Console.WriteLine("Input age :");
           int age = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Input gender:");
           string gender = Console.ReadLine();
           Console.WriteLine("Input number:");
           int number = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("   \n   ");


         // Declare two variables of type int. Assign to them values 5 and 10 respectively.Exchange(swap) thier value and print them
         int a = 5;
         int b = 10;
         a = a + b;
         b = a - b;
         a = a - b;
         Console.WriteLine("a, b");
         Console.WriteLine("   \n  ");

        }
    }
}
