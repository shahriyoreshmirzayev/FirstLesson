namespace ConsoleApp1.Advanced._3_dars
{
    internal class SanaVaVaqtBilanIshlash
    {
        public void SanaVaVaqtBilanIshlashVazifa1()
        {
            /*DateTime dateTime = DateTime.Now;
            Console.WriteLine("Hozirgi sana: " + dateTime.ToString("d"));
            Console.WriteLine("Hozirgi vaqt: " + dateTime.ToString("t"));*/

            Console.WriteLine("Hozirgi sana: " + DateTime.Now.ToString("d"));
            Console.WriteLine("Hozirgi vaqt: " + DateTime.Now.ToString("t"));
        }
        public void SanaVaVaqtBilanIshlashVazifa2()
        {
            DateTime dateTime = DateTime.Parse("13:56:32");
            int hours = dateTime.Hour;
            int minutes = dateTime.Minute;
            int seconds = dateTime.Second;
            DateTime dt = DateTime.Now;
            var oraliq_vaqt = DateTime.Now - dateTime;
            Console.WriteLine($"Foydalanuvchi kiritgan vaqt: {hours}:{minutes}:{seconds}");
            Console.WriteLine($"Foydalanuvchi kiritgan vaqt: "+ dateTime.ToString("hh:mm:ss"));
            Console.WriteLine("Vaqt farqi: " + oraliq_vaqt.ToString());
        }
        public void SanaVaVaqtBilanIshlashVazifa3()
        {
            /*Console.Write("Tug'ilgan yilingizni kiriting: ");
            int yil = int.Parse(Console.ReadLine());
            Console.Write("Tug'ilgan oyingizni kiriting: ");
            int oy = int.Parse(Console.ReadLine());
            Console.Write("Tug'ilgan kuningizni kiriting: ");
            int kun = int.Parse(Console.ReadLine());
            DateTime dt = new DateTime(yil, oy, kun);
            DateTime now = DateTime.Now;
            int years = now.Year - dt.Year;
            int months = now.Month - dt.Month;
            int days = now.Day - dt.Day;
            if(days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(now.Year, now.Month == 1 ? 12 : now.Month - 1);
            }
            if (months < 0)
            {
                years--;
                months += 12;
            }
            Console.WriteLine($"Sizning tug'ilganingizga {years} yil {months} oy {days} kun bo'lgan");*/
            DateTime datetime1 = DateTime.Parse("12 Dec, 2000");
            DateTime datetime2 = DateTime.Now;
            TimeSpan difficultyinyears = datetime2 - datetime1;
            var kun = difficultyinyears.Days;
            Console.WriteLine($"Kun: {kun}");
            Console.WriteLine($"Oy: {kun / 12}");
            Console.WriteLine($"Yil: {kun / 365}");
            Console.WriteLine(">>> " + (kun - kun/365*kun));
            //                   umumiy kun - yashagan yil 
        }
        public void SanaVaVaqtBilanIshlashVazifa4()
        {
            DateTime today = DateTime.Today;

            DateTime previousSunday = today.AddDays(-(int)today.DayOfWeek);
            DateTime nextSunday = today.AddDays(7 - (int)today.DayOfWeek);

            Console.WriteLine($"Oldingi yakshanba: {previousSunday:yyyy.MM.dd}");
            Console.WriteLine($"Keyingi yakshanba: {nextSunday:yyyy.MM.dd}");
        }
        public void SanaVaVaqtBilanIshlashVazifa6()
        {
            DateTime now = DateTime.UtcNow;
            foreach (TimeZoneInfo timeZone in TimeZoneInfo.GetSystemTimeZones())
            {
                DateTime localTime = TimeZoneInfo.ConvertTimeFromUtc(now, timeZone);
                Console.WriteLine($"{timeZone.DisplayName}: {localTime:yyyy.MM.dd HH:mm:ss}");
            }
        }
    }
}   
