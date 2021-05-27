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
        public List<Akcija> GetAkcija()
        {
            List<Akcija> akcijusList = new List<Akcija>();
            try
            {
                string sql = "select AkcijosID, KlientoID, Nuolaida from Akcija";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int AkcijosID = int.Parse(reader["AkcijosID"].ToString());
                    int KlientoID = int.Parse(reader["KlientoID"].ToString());
                    int Nuolaida = int.Parse(reader["Nuolaida"].ToString());
                   
                    akcijusList.Add(new Akcija(AkcijosID, KlientoID, Nuolaida));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return akcijusList;
        }
        public List<Apmokejimas> GetApmokejimas()
        {
            List<Apmokejimas> apmokejimuList = new List<Apmokejimas>();
            try
            {
                string sql = "select ApmokejimoID, Apmokejimo_Tipas, Suma, ApmokejimoLaikas from Apmokejimas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ApmokejimoID = int.Parse(reader["ApmokejimoID"].ToString());
                    string Apmokejimo_Tipas = reader["Apmokejimo_Tipas"].ToString();
                    double Suma = double.Parse(reader["Suma"].ToString());
                    DateTime ApmokejimoLaikas = DateTime.Parse(reader["ApmokejimoLaikas"].ToString());

                    apmokejimuList.Add(new Apmokejimas(ApmokejimoID,Apmokejimo_Tipas,Suma,ApmokejimoLaikas));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return apmokejimuList;
        }
        public List<IsvezamaPreke> GetIsvezamaPreke()
        {
            List<IsvezamaPreke> isvezamaPrekeList = new List<IsvezamaPreke>();
            try
            {
                string sql = "select OperacijosNr, IsvezamosTechnikosPav, Kiekis, UzsakymoID, IsvezimoID from IsvezamaPreke";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int OperacijosNr = int.Parse(reader["OperacijosNr"].ToString());
                    string IsvezamostechnikosPav = reader["IsvezamosTechnikosPav"].ToString();
                    int Kiekis = int.Parse(reader["Kiekis"].ToString());
                    int UzsakymoID = int.Parse(reader["UzsakymoID"].ToString());
                    int IsvezimoID = int.Parse(reader["IsvezimoID"].ToString());

                    isvezamaPrekeList.Add(new IsvezamaPreke(OperacijosNr,IsvezamostechnikosPav,Kiekis,UzsakymoID,IsvezimoID));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return isvezamaPrekeList;
        }
    }
}
