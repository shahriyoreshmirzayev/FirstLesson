namespace ConsoleApp1._4_dars
{
    abstract class Animall
    {
        public string Color { get; set; }
        public int Age { get; set; }
        public abstract void Voice();
        public override string ToString()
        {
            return $"Yoshi: {Age}, Rangi: {Color}";
        }
    }
    class Cats : Animall
    {
        public override void Voice()
        {
            Console.WriteLine("Mushuk Myoow degan ovoz chiqaradi: ");
        }
    }
    class Dog : Animall
    {
        public override void Voice()
        {
            Console.WriteLine("Doglar Wooow degan ovoz chiqaradi: ");
        }
    }
}
