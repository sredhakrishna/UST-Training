using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail1
{
    internal class Mailfolder
    {
        private string _name;
        private List<Mail> _mailList;

        public string Name
        {
            get { return _name; }   
            set { _name = value; }
        }
        public List<Mail> MailList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }
        public Mailfolder()
        {

        }
        public Mailfolder(string Name,List<Mail>mailList)
        {
            Name = Name; 
            MailList = mailList;
        }

        public void AddMailToFolder(Mail mail)
        {
            MailList.Add(mail);
        }
        public bool RemoveMailFromFolder(long id)
        {
            int count = 0;
            foreach (var item in MailList)
            {
                if (item.Id == id)
                {
                    MailList.Remove(item);
                    count = 1; break;

                }
            }
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public void DisplayMails()
        {
            if (MailList.Count > 0)
            {
                foreach (var item in MailList)
                {
                    Console.WriteLine("mail{0}", Name);
                    Console.WriteLine(item.ToString());
                }
            }
            else 
            {
                Console.WriteLine("No mails to show");
            }
        }


        }
    }   

