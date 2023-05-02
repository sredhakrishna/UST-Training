using System;
using Mail1;



namespace Mail1
{
    internal class Mail
    {
        private long _id;
        private string _to;
        private string _from;
        private string _subject;
        private string _content;
        private DateTime _recieved;
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
        public string Content
        {
            get
            {
                return _content;

            }
            set
            {
                _content = value;
            }

        }


        public DateTime Recieved
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
        public Mail()
        {

        }
        public Mail(long _id, string _to, string _from, string _subject, string _content,DateTime _recieved, double _size)
        {
            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            Recieved = _recieved;
            Size = _size;
        }
        public override string ToString()
        {
            return string.Format("id:{0}\n To:{1}\n From:{2}\n Subject:{3}\n Content:{4}\n RecievedDate:{5}\n size:{6}\n", _id, _to, _from, _subject, _content, _recieved.ToString("dd-mm-yyyy", null), _size);
        }
        public static Mail CreateMail(string details)
        {
            string[] s = details.Split(',');

            DateTime dt = DateTime.ParseExact(s[5],"dd-mm-yyyy",null);
            Mail mailobj = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4],dt,double.Parse(s[6]));
            return mailobj;

        }
    }
}
