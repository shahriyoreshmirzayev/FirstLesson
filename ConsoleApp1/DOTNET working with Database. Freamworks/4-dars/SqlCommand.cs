namespace ConsoleApp1.DOTNET_working_with_Database._Freamworks._4_dars
{
    internal class SqlCommand
    {
        private string query;
        private SqlConnection connection;

        public SqlCommand(string query, SqlConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }
    }
}