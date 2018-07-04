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
            string friend1 = "Franck";
            string friend2 = "Joe";
            string friend3 = "Louise";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);

            Console.Read();
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi {0}, my friend!", name);
        }

    }
}
