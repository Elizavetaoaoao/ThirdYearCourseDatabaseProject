using System.Data.SqlClient;
namespace Base
{
    internal class Classs
    {
        SqlConnection conn = new SqlConnection(@"Data Source=A1420EM;Initial Catalog=Base;Integrated Security=True;TrustServerCertificate=True");
        public SqlConnection getConnection() {  return conn; }
    }
}