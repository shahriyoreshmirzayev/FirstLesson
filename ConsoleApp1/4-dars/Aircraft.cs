namespace ConsoleApp1._4_dars
{
    public class Aircraft
    {
        public string Color { get; set; }
        public object Engine { get; set; }
        public virtual void Start()
        {
            Console.WriteLine("Aircraft is starting");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Aircraft is stopping");
        }
        public virtual void TakeOff()
        {
            Console.WriteLine("Aircraft is taking off");
        }
        public virtual void Land()
        {
            Console.WriteLine("Aircraft is landing");
        }
    }
    public class PassengerPlane : Aircraft
    {
        public int Passengers { get; set; }
        public override void Start()
        {
            Console.WriteLine("Passenger plane is starting with " + Passengers + " passengers");
        }
        public override void Stop()
        {
            Console.WriteLine("Passenger plane is stopping");
        }
        public override void TakeOff()
        {
            Console.WriteLine("Passenger plane is taking off");
        }
        public override void Land()
        {
            Console.WriteLine("Passenger plane is landing");
        }
    }
    public class PropellerPlane : Aircraft
    {
        public int Propellers { get; set; }

        public override void Start()
        {
            Console.WriteLine("Propeller plane is starting with " + Propellers + " propellers");
        }
        public override void Stop()
        {
            Console.WriteLine("Propeller plane is stopping");
        }
        public override void TakeOff()
        {
            Console.WriteLine("Propeller plane is taking off");
        }
        public override void Land()
        {
            Console.WriteLine("Propeller plane is landing");
        }
    }
    public class FighterPlane : Aircraft
    {
        public new object Engine { get; set; }

        public override void Start()
        {
            Console.WriteLine("Fighter plane is starting with engine: " + Engine);
        }
        public override void Stop()
        {
            Console.WriteLine("Fighter plane is stopping");
        }
        public override void TakeOff()
        {
            Console.WriteLine("Fighter plane is taking off");
        }
        public override void Land()
        {
            Console.WriteLine("Fighter plane is landing");
        }
    }
}
