using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //One Dimen Array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string val in cars)
            {
                Console.WriteLine(val);
            }
            Console.Read();
        }
    }
}
