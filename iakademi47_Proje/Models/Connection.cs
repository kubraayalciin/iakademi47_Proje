using Microsoft.Data.SqlClient;

namespace iakademi47_Proje.Models
{
    public class Connection
    {
        public static SqlConnection ServerConnect
        {
            get
            {
                SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-RO444BM;Database=iakademi47Core_Proje;trusted_connection=True;TrustServerCertificate=True;");
                return sqlConnection;
            }
        }
    }
}
