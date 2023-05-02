using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter i");
            int k = 10;
            int[] arr=new int[5];
           
            try
            {
                int i = int.Parse(Console.ReadLine());
                k = k / i;
                Console.WriteLine(k);
                Console.WriteLine("hellooooo");
                arr[10] = 7;
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("hiiii");
            
        }
    }
}
