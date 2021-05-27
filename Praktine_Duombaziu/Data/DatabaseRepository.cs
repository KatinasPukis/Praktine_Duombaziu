using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktine_Duombaziu.Models;

namespace Praktine_Duombaziu.Data
{
    public class DatabaseRepository
    {
        private SqlConnection conn;
        public DatabaseRepository()
        {
            conn = new SqlConnection(@"Server=.;Database=duombaze;Trusted_Connection=true;");
        }
        public List<Klientas> GetKlientas()
        {
            List<Klientas> klientuList = new List<Klientas>();
            try
            {
                string sql = "select KlientoID, Vardas, Pavarde, ElPastas, TelNr, Gimtadienis from Klientas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int KlientoID = int.Parse(reader["KlientoID"].ToString());
                    string Vardas = reader["Vardas"].ToString();
                    string Pavarde = reader["Pavarde"].ToString();
                    string ElPastas = reader["ElPastas"].ToString();
                    string TelNr = reader["TelNr"].ToString();
                    DateTime Gimtadienis = DateTime.Parse(reader["Gimtadienis"].ToString());
                    klientuList.Add(new Klientas(KlientoID, Vardas, Pavarde, ElPastas, TelNr, Gimtadienis));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return klientuList;
        }
    }
}
