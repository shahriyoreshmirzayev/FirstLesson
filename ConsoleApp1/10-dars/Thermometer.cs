namespace ConsoleApp1._10_dars
{
    class Thermometer
    {
        private int maxTemperature;
        public event EventHandler<EventArgs> OnTemperatureChanged = delegate { };

        public Thermometer(int maxTemperature)
        {
            this.maxTemperature = maxTemperature;
        }
        public int Temperature
        {
            set
            {
                if (value > maxTemperature)
                {
                    OnTemperatureChanged(this, new EventArgs());
                }
            }
        }
    }
}
        