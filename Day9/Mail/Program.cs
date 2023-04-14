using System;

namespace Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter _id, _to,  _from,  _subject,  _content,  _receivedDate,  _size with comas");
            string input=Console.ReadLine();
            string[] arrinput=input.Split(',');
            long id =long.Parse(arrinput[0]);
            string to = arrinput[1];
            string from = arrinput[2];  
            string subject = arrinput[3];
            string content = arrinput[4];
            //DateTime receivedDate = DateTime.Parse(arrinput[5]);
            double size = long.Parse(arrinput[5]);


            Console.WriteLine("enter second _id, _to,  _from,  _subject,  _content,  _receivedDate,  _size with comas");
            string input1 = Console.ReadLine();
            string[] arrinpu1t = input.Split(',');
            long id1 = long.Parse(arrinput[0]);
            string to1 = arrinput[1];
            string from1 = arrinput[2];
            string subject1 = arrinput[3];
            string content1 = arrinput[4];
           // DateTime receivedDate1 = DateTime.Parse(arrinput[5]);
            double size1 = long.Parse(arrinput[5]);

            
            Mail e1= new Mail(id,to,from,subject,content,size);
            Mail e2= new Mail(id1,to1,from1,subject1,content1,size1);
            Console.WriteLine(e1.ToString());
            Equals(id, id1, to, to1, from, from1);

        }
        public static void Equals(long id,long id1, string to,string to1,string from,string from1)
        {
            if (id == id1 && to == to1 && from == from1)
            {
                Console.WriteLine("mail 1 and mail 2 are equal");
            }
            else { Console.WriteLine("mail1 and mail2 are not equal"); }
        }
    }
}
