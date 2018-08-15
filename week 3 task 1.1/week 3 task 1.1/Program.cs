using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3_task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("HELLO, can you guess my favorite: ");
            string Pet = (Console.ReadLine());
            switch (Pet)
            {
                case "sheep":
                case "cat":
                case "cow":
                    Console.WriteLine("Na");
                    break;
                case "dog":
                    Console.WriteLine("yea");
                    break;
                default:
                    Console.WriteLine("hmm thats not a pet");
                    break;

            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}
