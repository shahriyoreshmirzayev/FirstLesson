using HashingWithSalt;

while (true)
{
    Console.WriteLine("Quyidagilardan birini kiriting: ");
    Console.WriteLine("1-Parolni HASH qilish");
    Console.WriteLine("2-Parol HASH'nu tekshirish");

    string userInputOptionStr = Console.ReadLine();
    bool isUserInputOptionValid = int.TryParse(userInputOptionStr, out int userInputOption);
    if (!isUserInputOptionValid)
    {
        Console.WriteLine("Notug'ri parol kiritildi");
    }
    else
    {
        if (userInputOption == 1)
        {
            Console.WriteLine("Parolni kiriting: ");
            string hashStr = Console.ReadLine();

            string hashedPassword = HashingHelper.GetHash(hashStr);
            Console.WriteLine($"Parolning HASH qiymati: {hashedPassword}");
        }
        if(userInputOption == 2)
        {
            Console.WriteLine("HASH'ni kiriting: ");
            string hashStr = Console.ReadLine();

            Console.WriteLine("Solishtirmoqchi bo'lgan parolni kiriting: ");
            string input = Console.ReadLine();

            bool isValid = HashingHelper.IsHashValid(input, hashStr);
            string output = isValid ? "HASH to'g'ri" : "HASH to'g'ri emas";

            Console.WriteLine(output);
            Console.WriteLine("\n");
        }
    }
}
