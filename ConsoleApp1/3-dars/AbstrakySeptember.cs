namespace ConsoleApp1._3_dars
{
    internal class AbstrakySeptember
    {
        public virtual void Speak()
        {
            Console.WriteLine("Woow");
        }
    }
    class Cat : AbstrakySeptember
    {
        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine("Myoow");
        }
    }
}
