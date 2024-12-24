using Npgsql;

namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._4_dars
{
    internal class Data_Provieders
    {
        public static void Start()
        {
            Connection();
            //Database_Table();
            //      - postgres
            //      - mydb1
            //      - todoapp
            
        }
        public static void Connection()
        {
            string connection_str = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connection_str))
            {
                connection.Open();

                Console.WriteLine("Database learning");
                connection.Close();
            }
        }
        public static void Database_Table()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=postgres;";
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Bog'lanish muvaffaqiyatli!");

                    string query = "SELECT datname FROM pg_database WHERE datistemplate = false;";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Mavjud ma'lumotlar bazalari:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"- {reader["datname"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Xatolik yuz berdi: {ex.Message}");
            }
        }
    }
}
