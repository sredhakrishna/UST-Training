﻿using System;


namespace Mail
{
    internal class Mail
    {   
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
       // private DateTime _recieved;
        private double _size;
        
        public long Id
        {
            get
            {
                return _id;

            }
            set
            {
                _id = value; 
            }

        }

        public string To
        {
            get
            {
                return _to;

            }
            set
            {
                _to = value;
            }

        }
        public string From
        {
            get
            {
                return _from;

            }
            set
            {
                _from = value;
            }

        }

        public string Subject
        {
            get
            {
                return _subject;

            }
            set
            {
                _subject = value;
            }

        }
        public string  Content
        {
            get
            {
                return _content;

            }
            set
            {
                _content= value;
            }

        }


     /*   public DateTime RecievedDate
        {
            get
            {
                return _recieved;

            }
            set
            {
                _recieved = value;
            }

        }
     */
        public double Size
        {
            get
            {
                return _size;

            }
            set
            {
                _size = value;
            }

        }
        public  Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content,  double _size)
        {
            Id= _id;
            To= _to;
            From= _from;
            Subject= _subject;
            Content= _content;
            //RecievedDate= _receivedDate;
            Size= _size;
        }
        public override string ToString()
        {
            return "Id:" + +Id + "\n" + " To" + To + "\n";
        }


    }
}
