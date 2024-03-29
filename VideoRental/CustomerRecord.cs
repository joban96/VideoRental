﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace VideoRental
{

    class CustomerRecord : DataBase
    {
        public void Ins(String qry)
        {
            connection = new SqlConnection(connection_String);
            connection.Open();
            command = new SqlCommand(qry, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            Datareader = command.ExecuteReader();

            tbl.Load(Datareader);

            connection.Close();

            return tbl;
        }
        public int CountSrch(String qry)
        {
            connection = new SqlConnection(connection_String);

            connection.Open();
            command = new SqlCommand(qry, connection);

            return Convert.ToInt32(command.ExecuteScalar().ToString());
        }
    }
}
