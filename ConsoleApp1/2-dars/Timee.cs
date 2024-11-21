namespace ConsoleApp1._2_dars
{
    internal class Timee
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hour
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value > 0 && value < 25)
                {
                    _hours = value;
                }
                else
                {
                    Console.WriteLine("Soat vaqtini xato kiritdingiz");
                }
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value > 0 && _minutes < 61)
                {
                    _minutes = value;
                }
                else
                {
                    Console.WriteLine("Daqiqani xato kiritdingiz");
                }
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value >= 0 && value < 61)
                {
                    _seconds = value;
                }
                else
                {
                    Console.WriteLine("Bunday soniya yo'q xAto");
                }
            }
        }
        public void MyTimes()
        {
            Console.WriteLine($"Vaqt {_hours:D2}:{_minutes:D2}:{_seconds:D2}");
        }
    }   
}
