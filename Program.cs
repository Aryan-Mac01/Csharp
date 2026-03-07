using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            ////declaring variables
            //int age = 23;
            //Console.WriteLine(age);

            //long bigNumber = 23423423243L; //The L in the end tells the compiler that this number is Long and not a normal integer

            //double negative = -44.2D; //Similarly D tell that the number is Decimal

            //float precision = 5.000001F;

            //decimal money = 14.99M;

            ////TEXT BASED INPUT
            //string name = "aba";
            //char letter = 'a';

            ////converting string to numbers
            //string textAge = "23";
            //int age = Convert.ToInt32(textAge);

            //string textBigNumber = "90000000";
            //long bigNumber = Convert.ToInt64(textBigNumber);

            //string textNegative = "-55.2";
            //double negative = Convert.ToDouble(textNegative);




            //Console.ReadLine();//here this command will prevent the application from closing

            //Exercise: 1
            /*
             * Define variable to hold your name
             * Define a variable to hold your phone number
             * Define a variable to hold your age
             * Print variables line-by-line to the screen
             * Extra: define variables using var keyword
             */

            //var name = "Aryan";
            //var phone = 90909099;
            //var age = 19;

            //Console.WriteLine(name);
            //Console.WriteLine(phone);
            //Console.WriteLine(age);

            //Console.ReadLine();

            //EXERCISE 2
            /*
             *Create and initialise two ints
             *Make a variable to work out the remainder
             *output remainder to the screen
             *Change the first int variable to other number
                * and recalculate the remainder
                * output new remainder to the screen
             */

            //int a = 10;
            //int b = 20;
            //int result = a % b;
            //Console.WriteLine(result);
            //a = 40;
            //Console.WriteLine(a % b);
            //Console.ReadLine();

            //CONSOLE INPUT/OUTPUT

            //Console.WriteLine("Hello my name is Aryan");

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            ////Console.WriteLine(name);

            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine(age);

            //Console.Write("Your name is ");
            //Console.Write(name);
            //Console.Write(" Your age is " + age);


            ////TERNARY/CONDITIONAL OPERATOR
            //string result = age >= 0 ? " Valid" : " Invalid";
            //Console.WriteLine(result); 

            //TRY PARSE
            //Console.WriteLine("Enter a number: ");
            //string numInput = Console.ReadLine();
            //int num = 0;

            //bool success = int.TryParse(numInput, out num);
            //Console.WriteLine(num);


            //EXERCISE - TIME TABLE
            /*
             *Ask the user for a number for the table
             *write a for loop to print X time table
             */

            //Console.WriteLine("Write a number for the table: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2}", i, number, i*number);
            //}

            Console.ReadLine();
        }
    }
}
