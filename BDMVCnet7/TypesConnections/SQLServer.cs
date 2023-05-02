using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BDMVCnet7.TypesConnections
{
    public  class SQLServer : BaseConnection, IBDConnection
    {
        public SQLServer(string _Server, string _Catalog, string _User, string _Password) : base(_Server, _Catalog, _User, _Password)
        {

        }

        public override object ExecutionQuery(string query)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = base.Server;
            builder.UserID = base.User;
            builder.Password = base.Password;
            builder.InitialCatalog = base.Catalog;
            builder.TrustServerCertificate = true;

            SqlConnection conn = new SqlConnection(builder.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            DataTable dataTable = new DataTable();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            return dataTable;


            /*
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = base.Server;
                builder.UserID = base.User;
                builder.Password = base.Password;
                builder.InitialCatalog = base.Catalog;

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    //Console.WriteLine("\nQuery data example:");
                    //Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = query;//"SELECT name, collation_name FROM sys.databases";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();

            */
            //return null;
        }
    }
}
