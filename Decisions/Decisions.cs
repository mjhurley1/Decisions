﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mike's Big Giveaway");
            Console.Write("Choose a Door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                string message = "You won a new motorcycle";
                Console.WriteLine(message);
            }

            Console.ReadLine();

        
        }
    }
}
