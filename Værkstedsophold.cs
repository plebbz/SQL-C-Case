﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_C_Værksted_Superclass_Test
{
    class Værkstedsophold : Superclass
    {
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);
                Console.WriteLine("Registreringsnummer | ID | Check-ind dato | Check-ud dato");
                foreach (DataRow værkstedsophold in table.Rows)
                {
                    Console.Write(værkstedsophold["regnr"].ToString());
                    Console.Write(" ");
                    Console.Write(værkstedsophold["id"].ToString());
                    Console.Write(" ");
                    Console.Write(værkstedsophold["DatoforCheckIn"].ToString());
                    Console.Write(" ");
                    Console.Write(værkstedsophold["DatoforCheckUd"].ToString());
                    Console.WriteLine();

                }

                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
    }
}
