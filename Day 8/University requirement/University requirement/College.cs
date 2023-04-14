using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_requirement
{
    internal class College
    {
        private string name;
        private string website;
        private string mobile;
        private string founder;
        private int numberOfDept;
        private string location;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public string Founder
        { 
            get { return founder; }
            set {  founder = value; }
        }
        public int NumberOfDept
        {
            get { return numberOfDept; }
            set
            {
                numberOfDept = value;
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                location = value;
            }
        }
       
        public College()
        {

        }
        public College(string name,string website,string mobile , string founder, int numberOfDept,string location)
        {
            this.name = name;
            this.website = website;
            this.mobile = mobile;
            this.founder = founder;
            this.numberOfDept = numberOfDept;
            this.location = location;
            
        }

        
        public void display()
        {
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Website:" + website);
            Console.WriteLine("mobile:" + mobile);
            Console.WriteLine("Founder" + founder);
            Console.WriteLine("numOfDept:" + numberOfDept);
            Console.WriteLine("Location:" + location);
           
;        }
    }
}
