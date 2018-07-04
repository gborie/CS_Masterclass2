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
            int num1 = 10;
            int num2 = 0;

            int result;

            try
            {
                result = num1 / num2;

            }
            catch (Exception)
            {

                Console.WriteLine("Can't divide by zero!");
            }

            Console.ReadKey();

        }

    }
}
