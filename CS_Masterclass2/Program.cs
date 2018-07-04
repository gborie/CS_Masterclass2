using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Add());
            Console.Read();
        }

        public static int Add()
        {
            Console.WriteLine("Please enter the first number");
            string input1 = Console.ReadLine();
            int num1 = int.Parse(input1);

            Console.WriteLine("Please enter the second number");
            string input2 = Console.ReadLine();
            int num2 = int.Parse(input2);


            return num1 + num2;
        }

    }
}
