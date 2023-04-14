using System;

namespace String_username_and_password
{
    public class checking
    {
        string User, PW;
        public bool Flag = true;

       public void function(string user, string pw)
        {
            
            User = user;
            PW = pw;
           
                if((PW=="pass"&&User== "uesr") || (PW == "1234" && User == "abcd"))
                {
                
                    Console.WriteLine("loged in Successfully.......");
                    
                }
                else
                {
                    Console.WriteLine("wrong passwor or user name.....try again");
                    
                    
                }
                 
            }
            
            
            
        }
    }
    
