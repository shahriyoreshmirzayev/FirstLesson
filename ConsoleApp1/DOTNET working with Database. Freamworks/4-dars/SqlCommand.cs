namespace ConsoleApp1;

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