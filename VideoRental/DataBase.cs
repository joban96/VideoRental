using System;
using System.Data.SqlClient;


namespace VideoRental
{
    public class DataBase
    {
        //global declaration of the variable 
        public SqlConnection connection;
        public String connection_String = System.Configuration.ConfigurationManager.ConnectionStrings["Conn_String"].ConnectionString;
        public SqlCommand command;
        public SqlDataReader Datareader;
    }
}
