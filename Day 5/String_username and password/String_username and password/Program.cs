using System;
/*Test Data :
Input a username: uesr
Input a password: pass
Input a username: abcd
Input a password: 1234*/

namespace String_username_and_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            checking e1 = new checking();
            bool flag = e1.Flag;
            while(flag==true)
            {
                Console.WriteLine("enter your username and password");
                string user = Console.ReadLine();
                string pw = Console.ReadLine();
                e1.function(user, pw);
            }
            
        }
        
    }
}
