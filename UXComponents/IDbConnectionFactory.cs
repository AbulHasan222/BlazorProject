using System.Data;
using System.Data.SqlClient;


namespace UXComponents
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
    public class SqlConnectionFactory : IDbConnectionFactory
    {

        public string _connectionString; //= "Data Source=SHAKIL-DEV\\SHAKIL;Initial Catalog=testdb;Integrated Security=True;TrustServerCertificate=true;";
        

        public SqlConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
