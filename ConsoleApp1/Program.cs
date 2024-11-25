using ConsoleApp1._1_dars;
using ConsoleApp1._10_dars;
using ConsoleApp1.Advanced._1_dars;
using ConsoleApp1.Advanced._5_dars;
using System.Collections;
using System.Diagnostics;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Threading.Tasks;
using ConsoleApp1.DOTNET_working_with_Database._Freamworks._1_dars;

internal class Program
{
    static void Main(string[] args)
    {
        LinqLesson();
    }
    static void LinqLesson()
    {
        int[] scores = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        //Query syntax
        var scoreQuery =
            from score in scores
            where score % 2 == 0
            select score;
        Console.WriteLine("Query Syntax");
        foreach (int i in scoreQuery)
        {
            Console.WriteLine($"Juft sonlar: {i}");
        }
        //Method syntax
        var MethodQuerySyntax = scores.Where(x => x % 2 == 0);
        Console.WriteLine("Method Syntax");
        foreach (var i in MethodQuerySyntax)
        {
            Console.WriteLine($"Juft sonlar: {i}");
        }
    }
    static string DoSomething()
    {
        Console.WriteLine("Nimadur");
        
        Console.WriteLine($"Main Thread: {Thread.CurrentThread.ManagedThreadId}");

        return "Hello";
    }
    public static void ThreadAmaliyot()
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Excecuiton of thread");

        stopwatch.Start();
        ProcessWithThreadPoolMethod();
        stopwatch.Stop();

        Console.WriteLine($"Proccess execuited: {stopwatch.ElapsedTicks}");


        stopwatch.Start();
        ProcessWithThreadMethod();
        stopwatch.Stop();

        Console.WriteLine($"Process execuited is Pool: {stopwatch.ElapsedTicks}");
    }
    static void Process(object callBack)
    { }
    static void ProcessWithThreadMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread newThead = new Thread(Process);
            newThead.Start();
        }
    }
    static void ProcessWithThreadPoolMethod()
    {
        for (int i = 0; i < 10; i++)
        {
            ThreadPool.QueueUserWorkItem(Process);
        }
    }
    static void ThreadgaOidAmaliyot()
    {
        Console.WriteLine("Starting....");
        Thread thread = Thread.CurrentThread;
        thread.Name = "Main Thread";
        Thread countDownThread = new Thread(() => CountDown("Count Down")); // asosiy o'zgarish bu yerda
        Thread countUpThread = new Thread(() => CountUp("Count Up"));     // asosiy o'zgarish bu yerda
        countDownThread.Name = "CountDown Thread";
        countUpThread.Name = "CountUp Thread";
        Console.WriteLine($"{countDownThread.ThreadState}"); // kod bu yerda ishlashga tayyorligini bildiradi
        Console.WriteLine($"{countUpThread.ThreadState}");   // kod bu yerda ishlashga tayyorligini bildiradi
        countDownThread.Start();
        countDownThread.Join(); // bu boshqa Threadlarni to'xtatib shu thread ishga tushmaguncha to'xtatib turadi
        countUpThread.Start();
        Console.WriteLine($"{Thread.CurrentThread.Name} has stoped");
    }
    static void CountDown(string name)
    {
        Console.WriteLine($"{name}: {Thread.CurrentThread.ThreadState}");

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"{name} {i}");
            Thread.Sleep(1000);                        // 1 sekuunda sleep
        }
        Console.WriteLine($"{Thread.CurrentThread.Name} metodi o'z ishini yakunladi");
    }
    static void CountUp(string name)
    {
        Console.WriteLine($"{name}: {Thread.CurrentThread.ThreadState}");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{name} {i}");
            Thread.Sleep(1000);                        // 1 sekuunda sleep ms(milli sekund)
        }
        Console.WriteLine($"{Thread.CurrentThread.Name} metodi o'z ishini yakunladi");
    }
    static void SerializedgaOidBinary()
    {
        Tutorial tutorial = new Tutorial
        {
            Name = "Azamat",
            Description = "Men .net o'rganishni shu hafta ichida boshlayman",
            Url = "https://t.me/koinotdaman",
            Tags = new string[]
            {
                "C#",
                "C++",
                "SQL"
            }
        };
    }
    static void SerializedXML()
    {
        Tutorial tutorial = new Tutorial
        {
            Name = "Azamat",
            Description = "Men .net o'rganishni shu hafta ichida boshlayman",
            Url = "https://t.me/koinotdaman",
            Tags = new string[]
            {
                "C#",
                "C++",
                "SQL"
            }
        };
        string path = "tutorial.xml";
        // Serialize to XML
        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
        {
            var xmlSerializer = new XmlSerializer(typeof(Tutorial));
            xmlSerializer.Serialize(sw, tutorial);
        }
        // Deserialize from XML
        using (StreamReader sr = new StreamReader(path))
        {
            var xmlSerializer = new XmlSerializer(typeof(Tutorial));
            var deserializedTutorial = (Tutorial)xmlSerializer.Deserialize(sr);
            Console.WriteLine(deserializedTutorial.ToString());
        }
    }
    static void SerializedXMLgaOidMDC()
    {
        var defaultColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        var currentDirectory = Directory.GetCurrentDirectory().Split(new[] { "\\bin" }, StringSplitOptions.None).First();
        Console.WriteLine(currentDirectory);
        Tutorial tutorial = new Tutorial
        {
            Name = "Azamat",
            Description = "Men .net o'rganishni shu hafta ichida boshlayman",
            Url = "https://t.me/koinotdaman",
            Tags = new string[]
            {
                "C#",
                "C++",
                "SQL"
            }
        };

        string path = Path.Combine(currentDirectory, "tutorial.xml");
        // Serialize to XML
        using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
        {
            var xmlSerializer = new XmlSerializer(typeof(Tutorial));
            xmlSerializer.Serialize(sw, tutorial);
        }
        // Deserialize from XML
        using (StreamReader sr = new StreamReader(path))
        {
            var xmlSerializer = new XmlSerializer(typeof(Tutorial));
            var deserializedTutorial = (Tutorial)xmlSerializer.Deserialize(sr);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(deserializedTutorial.ToString());
        }
        Console.ForegroundColor = defaultColor;
        Console.WriteLine(File.ReadAllText(path));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(path);
        Console.ForegroundColor = defaultColor;
        Console.ReadKey();
    }
    static void SerializedgaOidAmaliyot_JSON()
    {
        Tutorial tutorial = new Tutorial
        {
            Name = "Test",
            Description = "Learn to C# code IDE Visual Studio",
            Url = "https://t.me/koinotdaman",
            Tags = new string[]
            {
                "C#",
                ".net",
                "C++",
                "Java"
            }
        };
        string path = "tutorial.json";
        using (StreamWriter sw = new StreamWriter(path))
        {
            var serializabletutorial = JsonSerializer.Serialize(tutorial);
            sw.Write(serializabletutorial);
        }
        using (StreamReader sr = new StreamReader(path))
        {
            //var serializabletutorial = new XmlSerializer(typeof (Tutorial));
            var deserialiazbletutorial = JsonSerializer.Deserialize<Tutorial>(sr.ReadToEnd());
            Console.WriteLine(deserialiazbletutorial);
        }
    }
    static void RegexgaOidMasala()
    {
        string[] names = { "Shahriyor", "shahriyor", "Shahriyor1" };
        foreach (var name in names)
        {
            if (char.IsUpper(name[0]) && name.All(char.IsLetter))
            {
                Console.WriteLine($"{name} is a valid name");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid name");
            }
        }
    }
    static void RegexgaOidMasala2()
    {
        string[] names = { "Shahriyor", "shahriyor", "Shahriyor1" };

        foreach (string name in names)
        {
            if (IsValidNameRegex(name))
            {
                Console.WriteLine($"{name} is a valid name");
            }
            else
            {
                Console.WriteLine($"{name} is a not valid name");
            }
        }
    }
    static bool IsValidNameRegex(string name)
    {
        string pattern = @"^[A-Z]{1}[a-z]+";
        return Regex.IsMatch(name, pattern);
    }
    static void MatnUzunliginiAniqlash()
    {
        try
        {
            Console.Write("Matn kiriting: ");
            string input = Console.ReadLine();
            int length = GetTextLength(input);
            Console.WriteLine($"Kiritilgan matn uzunligi: {length}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static int GetTextLength(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentException("Kiritilgan matn bo'sh bo'lmasligi kerak");
        }
        return str.Length;
    }
    public static void Exceptionga_oid()
    {

        try
        {
            int qiymat = DoSomething(-1);
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Console.WriteLine("Bu qism doimo ishlaydi");
        }
    }
    static int DoSomething(int index)
    {
        int[] numbers = new int[4];
        if (index < 0 || index >= numbers.Length - 1)
        {
            throw new ToplamdanTashqariElementException("Index manfiy yoki massiv uzunligidan katta bo'lmasligi kerak");
        }
        return numbers[index];
    }
    public static void Delegatega_oid_masala()
    {
        Matematika matematika = new Matematika();
        Matematika.MatematikOPerator matematikachi;
        matematikachi = matematika.Qoshish;
        matematikachi(12, 20);
        matematikachi = matematika.Ayirish;
        matematikachi(36, 14);
        matematikachi = matematika.Bolish;
        matematikachi(4, 36);
        matematikachi = matematika.Kopaytirish;
        matematikachi(14, 7);
    }
    static void WorkAirConditioner(object sender, EventArgs e)
    {
        Console.WriteLine("Air conditioner is working");
    }
    //static Coordinatee coordinatee;
    public static S Generik<S>(S[] massiv)
    {
        if (massiv.Length == 0)
        {
            throw new ArgumentException("Massiv elementlari xato");
        }
        return massiv[massiv.Length - 1];
    }
    static bool IsOdd(int x)
    {
        return x % 2 == 0;
    }
    static int Print1()
    {
        return 10;
    }
    public delegate void PrintDelegate(int a, int b);
    static void Print(int a, int b)
    {
        Console.WriteLine("Print orqali: {0}, {1}", a, b);
    }
    static void PrintWithInterpolation(int a, int b)
    {
        Console.WriteLine($"Interpolation orqali chiqarish: {a}, {b}");
    }

    public static void vazifa9_2()
    {
        string str = "12";
        int sanoq = 0, a = Convert.ToInt32(str);
        for (int i = 1; i < a; i++)
        {
            if (a % i == 0)
            {
                sanoq++;
                Console.WriteLine(i);
            }
        }
        var tuples = Tuple.Create(sanoq);
    }
    public static void vazifa9_1()
    {
        List<(int, int)> tupleList = new List<(int, int)>
    {
        (1, 3),
        (7, 2),
        (4, 10)
    };
        List<int> numbers = new List<int>();
        foreach (var tuple in tupleList)
        {
            numbers.Add(tuple.Item1);
            numbers.Add(tuple.Item2);
        }
        numbers.Sort();
        string result = string.Join("", numbers);
        Console.WriteLine(result);
    }
    public static void masala9_4()
    {
        int? a = null;
        int b = a ?? 0;
        Console.WriteLine(b);
    }
    public static void masala9_3()
    {
        bool? isMarried = null;

        if (isMarried.HasValue)
        {
            Console.WriteLine(isMarried.Value);
        }
        else
        {
            Console.WriteLine("Bilish imkonsiz");
        }
    }
    public static void masala9_2()
    {
        (int, int) tuple1 = (1, 2);
        (double, double) tuple2 = tuple1;
        if (tuple1 == tuple2)
            Console.WriteLine("Teng");
        else
            Console.WriteLine("Teng emas");
    }
    public static void masala9_1()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var result = FindMinMax1(array);
        Console.WriteLine($"Min: {result.min}, Max: {result.max}");
    }
    static (int min, int max) FindMinMax1(int[] array)
    {
        (int min, int max) result = (int.MaxValue, int.MinValue);
        foreach (var item in array)
        {
            if (item < result.min)
            {
                result.min = item;
            }
            if (item > result.max)
            {
                result.max = item;
            }
        }
        return result;
    }
    public static void vazifa3_7()
    {
        Dictionary<string, string> map = new Dictionary<string, string>();

    }
    public static void vazifa2_7()
    {
        List<int> son = new List<int>();
        Random random = new Random();
        for (int i = 0; i < 50; i++)
        {
            son.Add(random.Next(1, 100));
        }
        son.ForEach(x => Console.Write(x + "  "));
    }
    public static void vazifa1_7()
    {
        List<string> list = new List<string>()
        {
            "Zulpi", "Abdulloh", "Jo'rabek", "Nurislom", "Kamron",
            "Asadbek", "Faxriddin", "Otabek", "Samariddin", "Sarvar"
        };
        list.Add("Xolmat");
        list[0] = "Shahriyor";
        list[1] = "Eshmirzayev";

        //list.Add(list[0]);
        //List<string>.Enumerator enumerator = list.GetEnumerator();  // nomiga qo'yilgan
        /*foreach (string s in list)
        {
            Console.WriteLine(s);
        }*/
        list.Remove("Shahriyor");
        list.Remove("Eshmirzayev");
        string[] massiv = list.ToArray();
        Console.WriteLine("Massiv ko'rinishidagi elementlar\n");
        foreach (string s in massiv)
        {
            Console.WriteLine(s);
        }
    }
    static IEnumerable<int> GenerateNumbers(int maxValue)
    {
        //var list = new List<int>();

        for (int index = 0; index < maxValue; index++)
        {
            //list.Add(i);
            yield return index;
        }
        //return list;
    }
    public static void vazifa4_6()
    {
        List<string> list = new List<string>();
        list.Add("Jo'rabek");
        list.Add("Shahriyor");
        list.Add("Asadbek");
        list.Add("Otabek");
        list.Add("Abdulloh");
        list.Add("Sarvar");
        list.Add("NurIslom");
        list.Add("Kamron");
        list.Add("Faxriddin");
        list.Add("Samariddin");
        list.Add("Azamat");
        list.RemoveAll(list => list.StartsWith("A"));
        list.ForEach(list => Console.WriteLine(list));
    }
    public static void vazifa5_6()
    {
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        while (queue.Count != 0)
        {
            int number = queue.Dequeue();
            Console.WriteLine(number);
        }
    }
    public static void vazifa3_6()
    {
        Dictionary<int, int> map1 = new Dictionary<int, int>();
        Dictionary<string, string> map2 = new Dictionary<string, string>();
        map1.Add(1, 111);
        map1.Add(2, 222);

        map2.Add("name", "Tom");
        map2.Add("age", "25");

        foreach (var item in map1)
        {
            Console.WriteLine(item);
        }
        foreach (var item in map2)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("\nMa'lumotlar bilan chiqib kelish");
        foreach (var item in map1)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        foreach (var item in map2)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }
    public static void vazifa2_6()
    {
        List<int> ints = new List<int>() { 1, 2, 2, 4 };
        int index, sanoq = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            sanoq = 0;
            for (int j = 1; j < ints.Count; j++)
            {
                if (ints[i] == ints[j])
                {
                    sanoq++;
                }
                if (sanoq == 2)
                {
                    index = ints[i];
                    Console.WriteLine($"Eng ko'p qaytarilgan element: {index}");
                    break;
                }
            }
        }
    }
    public static void vazifa1_6()
    {
        List<int> list = new List<int>() { 12, 3, 34, 56, 11, 32, 45, 11, 43 };
        int max = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 0)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
        }
        Console.WriteLine($"Listdagi eng max son: {max}");
    }
    public static void dars4_6()
    {
        Stack<int> ints = new Stack<int>();
        ints.Push(1);
        ints.Push(2);
        ints.Push(3);
        ints.Push(4);
        ints.Push(5);
        ints.Push(6);
        ints.Push(7);
        while (ints.Count > 0)
        {
            int numbers = ints.Pop();
            Console.WriteLine(numbers);
        }
    }
    public static void dars3_6()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(12, "Shahriyor");
        hashtable.Remove(12);
        Console.WriteLine(hashtable[12]);
    }
    public static void dars2_6()
    {

        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("Hello", "Salom");
        map.Add("World", "Dunyo");

        map.Remove("Hello");

        if (map.ContainsValue("Salom"))
        {
            Console.WriteLine(map["Hello"]);
        }
        else
        {
            Console.WriteLine("Siz qidirgan so'z yo'q");
        }
    }
    public static void dars1_6()
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(12);
        arrayList.Add("Shahriyor");
        arrayList.Add(true);

        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

    }
    public static void Birnima()
    {
        MyClass myClass = new MyClass();
        int a = int.Parse(Console.ReadLine());
        myClass.First = a;
        int b = int.Parse(Console.ReadLine());
        myClass.Second = b;
        myClass.AboutFields();
        Console.WriteLine("Ikkita soni yig'indisi: " + myClass.SumOfFields());
        Console.WriteLine("Ikkita sonni eng kattasi: " + myClass.MaxOfFields());
    }
    class Point
    {
        public string Model;
        public string Brand;
        public string Color;
        public Point(string model, string brand, string color)
        {
            Model = model;
            Brand = brand;
            Color = color;
        }
        public void Start()
        {
            Console.WriteLine($"{Model} mashinasi yuradi");
        }
        public void Stop()
        {
            Console.WriteLine($"{Model} mashinasi to'xtadi");
        }
        public void Move()
        {
            Console.WriteLine($"{Model} mashinasi move qilmoqda :)");
        }
    }
    public static bool TwoStr(string s1, string s2)
    {
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1.Substring(i, s2.Length) == s2)
            {
                return true;
            }
        }
        return false;
    }
    public static string IkkitaSozQoshilishi(string satr1, string satr2)
    {
        if (satr1[satr1.Length - 1] == satr2[0])
        {
            return satr1.Substring(0, satr1.Length - 1) + satr2;
        }
        else
        {
            return satr1 + satr2;
        }
    }
    public static string OxirgiBelgilarniAlmashtirish(string str)
    {
        char c, birinchibelgi, ikkinchibelgi;
        birinchibelgi = str[str.Length - 1];
        ikkinchibelgi = str[str.Length - 2];
        c = birinchibelgi;
        birinchibelgi = ikkinchibelgi;
        ikkinchibelgi = c;
        string s = "";
        return str;
    }
    static bool BirinnchiVaIkkinchiSatrQidirish(string satr1, string satr2)
    {
        return satr1.Contains(satr2);
    }
    static string BirinchiVaIkkinchiSatrQoshish(string str1, string str2)
    {
        return str1.Substring(1, str1.Length - 1) + str2.Substring(1, str2.Length - 1);
    }
    static string ProbelOrasidagiSozlar(string satr)
    {
        satr = satr.Trim();
        int BirinchiBoshSatr = satr.IndexOf(' ');
        int OxirgiBoshSatr = satr.LastIndexOf(' ');
        return satr.Substring(BirinchiBoshSatr + 1, OxirgiBoshSatr - BirinchiBoshSatr);
    }
}
