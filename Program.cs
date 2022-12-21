using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, x ;

            Console.WriteLine("enter first num");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num");

            for(n1=int.Parse(Console.ReadLine()); n1<=n2; n1++)
            {
                for(x = 2; x<=n1; x++)
                
                    if(n1%x==0)
                    {
                        break;
                    }
                    if(n1==x)
                    {
                        Console.WriteLine(n1);
                    }
                }
            }
        }
    }

