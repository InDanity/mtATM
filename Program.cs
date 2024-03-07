using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string constr = "server=localhost;uid=root;pwd=JollofisNeat;database=atm";
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = constr;
        con.Open();

        string sql = "SELECT * FROM atm.customer";
        MySqlCommand cmd = new MySqlCommand(sql, con);

        MySqlDataReader reader = cmd.ExecuteReader();
        while ( reader.Read() ) 
        {
            Console.WriteLine( reader.GetString(1) );
        }

        Console.WriteLine("Hello, world!");
    }
}
