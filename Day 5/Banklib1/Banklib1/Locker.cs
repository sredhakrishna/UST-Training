namespace Banklib1
{
    public class Locker
    {
        private int _number;
        private string _lockType;
        private string _password;
        private double _amount;
        private DateTime _lastOpened;
        public int Number
        {
            get { return _number; }
            set { _number = value; }    
        }
        public Locker()
        {

        }
        public Locker(int number, string lockType, string password, double amount, DateTime lastOpened)
        {
            _number = number;
            _lockType = lockType;
            _password = password;
            _amount = amount;
            _lastOpened = lastOpened;
            
        }   
    }
}