namespace ConsoleApp1._2_dars
{
    internal class Bookss
    {
        public string _author;
        public int _price;
        public string _title;
        public int _papeerCount;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                if (_author != value)
                {

                    _author = value;
                }
                else
                {
                    Console.WriteLine("Siz xato kiritdingiz");
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (_price != value && value > 100)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Xato");
                }
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value != _title)
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("xato");
                }
            }
        }
        public int PaperCount
        {
            get
            {
                return _papeerCount;
            }
            set
            {
                if (value != _papeerCount)
                {
                    _papeerCount = value;
                }
                else
                {
                    Console.WriteLine("Xatooo");
                }
            }
        }
    }
    class EBooks : Bookss
    {
        public string _siteName;
        public int _siteHajmi;
        public static void EBookConfiguration(string siteName, int siteHajmi)
        {
            Console.WriteLine($"Sayt hajmi {siteHajmi} va nomi {siteName}");
        }
    }
    class PaperBook : Bookss
    {
        public int massasi;
        public int yetkazish_vaqti;
    }
}
