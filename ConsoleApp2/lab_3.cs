using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class lab_3
    {
        static void Main(string[] args)
        {
            Console.Write($" Hello! What's your name? ");
            string name = Console.ReadLine();
            string response = "y";
            while (response == "y")
            {

                Console.WriteLine(name + " Please enter a number from 1 - 100! ");
                int userNum;
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum % 2 == 0 && userNum >= 60)
                {
                    Console.WriteLine(name + " The number you picked is " + userNum + " Which is even. ");
                }
                else if (userNum % 2 == 0 && userNum <= 25 && userNum >= 2)
                {
                    Console.WriteLine(name + " The Number you picked is Even and less than 25!");
                }
                else if (userNum % 2 == 0 && userNum >= 26)
                {
                    Console.WriteLine(name + " The Number you picked is Even!");
                }
                else
                {
                    Console.WriteLine(name + " The number you picked is " + userNum + " Which is odd! ");
                }
                Console.WriteLine(name + " Would you like to select a new number y/n ");
                response = Console.ReadLine();
            }
            Console.WriteLine("Very well , we can stop for now " + name);
            Console.ReadLine();
        }
    }
}
