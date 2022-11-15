using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ADONETProba202249B
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection veza = new SqlConnection("Data Source=INF_4_PROFESOR\\SQLPBG;Initial catalog=baza2022492;Integrated security=true");
            SqlCommand naredba = new SqlCommand();
            naredba.Connection = veza;
            naredba.CommandText = "SELECT COUNT(*) FROM ucenik";
            veza.Open();
            int broj = (int)naredba.ExecuteScalar();
            veza.Close();
            Console.WriteLine("broj=" + broj);
            naredba.CommandText = "SELECT * FROM ucenik";
            SqlDataReader citac;
            veza.Open();
            citac = naredba.ExecuteReader();

            //citac.Read();
            //citac.Read();
            //Console.WriteLine(citac[1].ToString() + " " + citac[2].ToString());
            veza.Close();


            DataTable ucenik = new DataTable();
            veza.Open();
            ucenik.Load(citac);
            veza.Close();
            Console.WriteLine(ucenik.Rows[1][1]);
        }
    }
}
