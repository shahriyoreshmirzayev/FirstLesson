namespace ConsoleApp1.Advanced._4_dars
{
    internal class FilelarBilanIshlash
    {
        public void FilelarVazifa2()
        {
            string path = @"D:\Salom\test.txt";
            var files = File.ReadAllLines(path);
            int sanoq = 0;
            
            
            /*foreach (var file in files)
            {
                sanoq++;
            }*/


            Console.WriteLine(files);
            Console.WriteLine($"Berilgan faylda {sanoq} qator bor ekan");
        }
        public void Filevazifa1()
        {
            string path = @"D:\Mening hujjatlarim";
            string natija = CheckDirectoryContents(path);
            Console.WriteLine(natija);
        }
        static string CheckDirectoryContents(string path)
        {
            if (!Directory.Exists(path))
                return "Papkalar va fayllar mavjud";
            bool papkalar = Directory.GetDirectories(path).Length > 0;
            bool fayllar = Directory.GetFiles(path).Length > 0;
            if (papkalar)
                return "Faqat papkalar mavjud";
            if (fayllar)
                return "Faqat fayllar mavjud";
            if (fayllar && papkalar)
                return "Papkalar va faylllar mavjud";
            else
                return "Hech narsa mavjud emas";
        }
        public void FilelarBilanIshlashAmaliyot4()
        {
            //Ikkita faylni birlashtirib yangi faylga qo'shish
            string path1 = @"D:\Salom\phototest1.jpg";
            string path2 = @"D:\Salom\phototest2.jpg";
            string copy_path = @"D:\Salom\copy.txt";
            //File.WriteAllText(File.ReadAllText(path1) + File.ReadAllText(path2));
            //File.WriteAllBytes(path1, File.ReadAllBytes(path1) + File.ReadAllBytes(path2));
            Console.WriteLine("Fayl yaratildi va joylandi");
        }
        public void FilelarBilanIShlashAmaliyot11()
        {
            //File ichidagi ma'lumotni o'qish
            string path = @"D:\Salom\test.txt";
            //FileInfo fileInfo = new FileInfo(path); 
            var files = File.ReadAllText(path);
            foreach (var item in files)
            {
                Console.Write(item);
            }
        }
        public void FilelarBilanIshlashVazifa3()
        {
            string path = @"D:\Salom\test.txt";
            string copy_path = @"D:\SArvar\test_copy1.txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo(copy_path, true);
            Console.WriteLine("Fayl muvaffaqiyatli yaratildi");
        }
        public void FilelarBilanIShlashVazifa2()
        {
            string path = @"D:\Salom\test.txt";
            var files = File.ReadAllLines(path);
            int sanoq = 0;
            foreach (var file in files)
            {
                sanoq++;
            }
            Console.WriteLine($"Berilgan fayl ichida {sanoq} qator bor ekan");
        }
        /*public void FilelarBilanIshlashVazifa1()
        {
            string path = @"D:\Mening hujjatlarim"; // Berilgan path ni kiriting
            string result = CheckDirectoryContents(path);
            Console.WriteLine(result);
        }*/
       /* static string CheckDirectoryContents(string path)
        {
            if (!Directory.Exists(path))
            {
                return "Path mavjud emas";
            }
            bool hasDirectories = Directory.GetDirectories(path).Length > 0;
            bool hasFiles = Directory.GetFiles(path).Length > 0;
            if (hasDirectories && hasFiles)
            {
                return "Papka va fayllar bor";
            }
            else if (hasDirectories)
            {
                return "Papkalar bor";
            }
            else if (hasFiles)
            {
                return "Fayllar bor";
            }
            else
            {
                return "Papka bo'sh";
            }
        }*/
        public void FilelarBilanIshlashAmaliyot()
        {
            string path = "D:";
            var listOfDirectories = Directory.EnumerateDirectories(path);
            foreach (var directory in listOfDirectories)
            {
                Console.WriteLine(directory);
            }
            var directoryInfo = new DirectoryInfo(path);
            Console.WriteLine("===============================");
            var listOfDirectoriesWithInfo = directoryInfo.EnumerateDirectories();
            foreach (var directory in listOfDirectoriesWithInfo)
            {
                Console.WriteLine(directory);
            }
        }
        public void FilearBilanIshlashAmaliyot2()
        {
            string path = @"D:\Mening hujjatlarim";
            var files = Directory.EnumerateFileSystemEntries(path);
            foreach (var file in files)
                Console.WriteLine(file);
        }
        public void FilelarBilanIshlashAmaliyot3()
        {
            string path = @"D:\Salom\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
                fileInfo.Create();
            StreamWriter streamWriter = fileInfo.AppendText();  // File ichiga yozish
            streamWriter.WriteLine("Shahriyor .net developer"); // bu metod orqali istalgan xabar yozish mumkin file ichiga
            streamWriter.Close();                               // bu doim yopilishi kerak
        }
        public void FilelarBilanIshlashAmaliyot3_davomi()
        {
            string filePath = @"D:\Salom\music.mp3";
            byte[] fileBytes = File.ReadAllBytes(filePath);
            Array.Reverse(fileBytes);
            File.WriteAllBytes(filePath, fileBytes);
        }
        public void FilelarBilanIshlashAmaliyot41()
        {
            string path1 = $@"D:{Path.DirectorySeparatorChar}Salom";
            string path2 = "music.mp3";
            string combinedPath = Path.Combine(path1, path2);
            if (Path.HasExtension(combinedPath))
                Console.WriteLine("Ha bor");
        }
        public void FilelarBilanIshlashAmaliyot5()
        {
            string filepath = @"D:\Salom\test.txt";
            string allLines = string.Empty;
            using (StreamReader sr = new StreamReader(filepath))
            {
                allLines = sr.ReadToEnd();
            }
            //Console.WriteLine(allLines);
            allLines += "\nYang qator qo'shish";
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(allLines);
            }
        }
    }
}
