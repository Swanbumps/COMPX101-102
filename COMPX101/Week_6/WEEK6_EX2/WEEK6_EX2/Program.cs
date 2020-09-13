using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK6_EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                
                for(int i=1; i <= number; i++)
                {
                    string line = "";
                    for (int ii = 1; ii <=number; ii++)
                    {
                        if(i % 3 == 0)
                        {
                            line += "=";
                        }
                        else
                        {
                            line += "*";
                        }
                    }
                    Console.WriteLine(line);
                }
                Console.Read();
            }
            catch(Exception ex)
            {
                Console.Beep();
                Console.WriteLine("you idiot\n" + ex);

            }
        }
    }
}
