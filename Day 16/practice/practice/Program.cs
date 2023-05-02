using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size");
            int b=int.Parse(Console.ReadLine());
            ArrayList arr=new ArrayList() ;
            Console.WriteLine("enter the elements");
            for (int i=0 ; i<b ; i++)
            {
                i=int.Parse(Console.ReadLine()) ;
                arr.Add(i);
            }
            Console.WriteLine("asdfghjkl");
            int temp = 0;
            for (int i=0 ; i<b ;i++)
            {
                temp=temp+i ;
                if (temp == 12)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    for(int j=i+1 ; j<b ; j++)
                    {
                        temp = temp + j;
                        if (temp == 12)
                        {
                            Console.WriteLine(i+j);
                        }
                    }
                }
                Console.WriteLine();
            }
           
        }
    }
}
