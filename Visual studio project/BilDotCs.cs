﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SQL_C_Værksted_Superclass_Test
{
    public class BilDotCs : Superclass
    {
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);
                foreach (DataRow bil in table.Rows)
                {
                    Console.WriteLine(bil["id"].ToString());
                    Console.WriteLine(bil["mærke"].ToString());
                    Console.WriteLine(bil["model"].ToString());
                    Console.WriteLine(bil["årgang"].ToString());
                    Console.WriteLine(bil["km"].ToString());
                    Console.WriteLine(bil["brændstoftype"].ToString());
                    Console.WriteLine(bil["vægt"].ToString());

                }


                // denførsterække = table.Rows[0] ["navn"].ToString();            
            }
        }
    }
}
