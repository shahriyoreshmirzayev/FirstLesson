namespace ConsoleApp1._3_dars
{
    internal class Duck
    {
        public virtual void display()
        {
            Console.WriteLine("Oynaga Duckning displayi chiqdi :===> 1");
        }
        public void swim()
        {
            Console.WriteLine("O'rdaklar suza oladi");
        }
        public void quack()
        {
            Console.WriteLine("O'rdaklar doimo quack-quack qilib yurishadi");
        }
    }
    class MallardDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("looks like a mallard");
        }
    }
    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("looks like a redhead");
        }
    }
}
