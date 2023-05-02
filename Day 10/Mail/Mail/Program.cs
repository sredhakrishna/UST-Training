using System;
using System.Collections.Generic;

namespace Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mail> li = new List< Mail > ();
            for (int i = 0; i < 2; i++)
            {
                
                Console.WriteLine("enter _id, _to,  _from,  _subject,  _content,  _receivedDate,  _size with comas");
                string input = Console.ReadLine();
                string[] arrinput = input.Split(',');
                long id = long.Parse(arrinput[0]);
                string to = arrinput[1];
                string from = arrinput[2];
                string subject = arrinput[3];
                string content = arrinput[4];
                DateTime receivedDate = Convert.ToDateTime(arrinput[5]);
                double size = long.Parse(arrinput[6]);
                li.ToString();

            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("mails are same");
            }
            else
            {
                Console.WriteLine("not same");
            }


        }
    }
}