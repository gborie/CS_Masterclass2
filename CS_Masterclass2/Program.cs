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
            Console.WriteLine(Add(Add(4, 3), Add(6, 9)));
            Console.WriteLine(Add(15,31));
            Console.WriteLine(Multiply(34, 67));
            Console.WriteLine(Divide(25,13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }



    }
}
