using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCP_558
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int t = 0; t < T; t++)
            {
                string line = Console.ReadLine();
                if (line.Equals("Quill"))
                {
                    Console.WriteLine("I am going to ask you this one time, where is Gamora?");
                }
                else if (line.Equals("Stark"))
                {
                    Console.WriteLine("I will do you one better, who is Gamora?");
                }
                else if (line.Equals("Drax"))
                {
                    Console.WriteLine("I will do you one better, why is Gamora?");
                }
                else
                {
                    Console.WriteLine("What is Gamora?");
                }
            }
        }
    }
}
