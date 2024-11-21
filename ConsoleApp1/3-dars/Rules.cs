namespace ConsoleApp1._3_dars
{
    internal class Rules
    {
        public virtual void  GroupRules()
        {
            Console.WriteLine("1.Guruhda doimo odob saqlang\n2.Kattalarni hurmat qiling");
        }
    }
    class MathRules : Rules
    {
        public override void GroupRules()
        {
            Console.WriteLine("===== Matematika guruh qoidalari ======");
            base.GroupRules();
            Console.WriteLine("3.Kuniga bittadan misol ishlab guruhga tashlash");
        }
    }
    class ProgrammingRules : Rules
    {
        public override void GroupRules()
        {
            Console.WriteLine("===== Programming guruh qoidalari =====");
            base.GroupRules();
            Console.WriteLine("3.Dasturlashdan boshqa chet mavzularda suhbatlashish ta'qiqlanadi");
        }
    }
}
