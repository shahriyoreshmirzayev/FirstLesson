using System.Text.RegularExpressions;

namespace ConsoleApp1.Advanced._2_dars
{
    internal class AdvancedMasala
    {
        public void AdvanceddaRegexgaOidAmaliyTopshiriq()
        {
            string name = "aa";

            string pattern = @"^[a]{3}$";

            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine("To'g'ri kiritildi");
            }
            else {
                Console.WriteLine("Noto'g'ri kiritildi");
            }
        }
        
        public void AdvancedRegexgaOidAmaliyTopshiriq()
        {
            string[] phones = { "99 339 65 31", "99-339-65-31", "99 339-65-31", "993396531" };

            foreach (string phone in phones)
            {
                if (InvalidPhoneNumbers(phone))
                {
                    Console.WriteLine($"{phone} to'g'ri kiritilgan telefon raqam");
                }
                else
                {
                    Console.WriteLine($"{phone} noto'g'ri kiritilgan telefon raqam");
                }
            }
        }
        static bool InvalidPhoneNumbers(string phone)
        {
            string pattern = @"^([0-9]{2} [0-9]{3} [0-9]{2} [0-9]{2})|([0-9]{2}-[0-9]{3}-[0-9]{2}-[0-9]{2})|([0-9]{2} [0-9]{3}-[0-9]{2}-[0-9]{2})|([0-9]{9})$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phone);
            return match.Success;
        }
        public void AdvancedRegexgaOidVazifaTopshiriq()
        {
            string[] names = { "Shahriyor", "Azamat", "Asadbek", "Samariddin", "Otabek", "Sarvar", "Faxriddin", "Kamron" };
            foreach (string name in names)
            {
                if(InvalidName(name))
                {
                    Console.WriteLine($"{name} ismi mos keladi");
                }
                else
                {
                    Console.WriteLine($"{name} ismi umuman mos emas");
                }
            }
        }
        public static bool InvalidName(string name)
        {
            string pattern = @"^([S]{1}[a-z]+)$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(name);
            return match.Success;
        }

        public void AdvancedRegexgaOidTopshiriq2()
        {
            Console.Write("Matnni kiriting: ");
            string satr = Console.ReadLine();
            string s = "";
            for (int i = 0; i < satr.Length; i++)
            {
                if (InvalidInteger(satr[i].ToString()))
                {
                    s += satr[i];
                }
            }
            Console.WriteLine($"Natija: {s}");
        }
        static bool InvalidInteger(string integer)
        {
            string pattern = @"^[0-9]*$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(integer);
            return match.Success;
        }
    }
}
