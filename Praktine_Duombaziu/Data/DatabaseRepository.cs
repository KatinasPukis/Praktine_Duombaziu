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
        public List<Isvezimas> GetIsvezimas()
        {
            List<Isvezimas> isvezamasList = new List<Isvezimas>();
            try
            {
                string sql = "select IsvezimoID, Nurodytas_Adresas, Nurodytas_Laikas, KurjerioID from Isvezimas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int IsvezimoID = int.Parse(reader["IsvezimoID"].ToString());
                    string Nurodytas_Adresas = reader["Nurodytas_Adresas"].ToString();
                    DateTime Nurodytas_Laikas = DateTime.Parse(reader["Nurodytas_Laikas"].ToString());
                    int KurjerioID = int.Parse(reader["KurjerioID"].ToString());

                    isvezamasList.Add(new Isvezimas(IsvezimoID,Nurodytas_Adresas,Nurodytas_Laikas,KurjerioID));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return isvezamasList;
        }
        public List<Ivertinimas> GetIvertinimas()
        {
            List<Ivertinimas> ivertinimasList = new List<Ivertinimas>();
            try
            {
                string sql = "select IvertinimoID, Kurjerio_Ivertinmas, Produkto_Ivertinimas, Komentaras, KlientoID, UzsakymoID from Ivertinimas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int IvertinimoID = int.Parse(reader["IvertinimoID"].ToString());
                    int Kurjerio_Ivertinimas = int.Parse(reader["Kurjerio_Ivertinimas"].ToString());
                    int Produkto_Ivertinimas = int.Parse(reader["Produkto_Ivertinimas"].ToString());
                    string Komentaras = reader["Komentaras"].ToString();
                    int KlientoID = int.Parse(reader["KlientoID"].ToString());
                    int UzsakymoID = int.Parse(reader["UzsakymoID"].ToString());
                   

                    ivertinimasList.Add(new Ivertinimas(IvertinimoID,Kurjerio_Ivertinimas,Produkto_Ivertinimas,Komentaras,KlientoID,UzsakymoID));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return ivertinimasList;
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
        public List<Kurjerio_transportas> GetKurjerio_Transportas()
        {
            List<Kurjerio_transportas> kurjerio_TransportasList = new List<Kurjerio_transportas>();
            try
            {
                string sql = "select ID, Kurjerio_ID, Uzsakymo_ID, Transporto_ID, data from Kurjerio_transportas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ID = int.Parse(reader["ID"].ToString());
                    int Kurjerio_ID = int.Parse(reader["Kurjerio_ID"].ToString());
                    int Uzsakymo_ID = int.Parse(reader["Uzsakymo_ID"].ToString());
                    int Transporto_ID = int.Parse(reader["Transporto_ID"].ToString());
                    DateTime data = DateTime.Parse(reader["data"].ToString());
                    kurjerio_TransportasList.Add(new Kurjerio_transportas(ID,Kurjerio_ID,Uzsakymo_ID,Transporto_ID,data));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return kurjerio_TransportasList;
        }
        public List<Kurjeris> GetKurjeris()
        {
            List<Kurjeris> kurjeriai = new List<Kurjeris>();
            try
            {
                string sql = "select KurjerioID, Vardas, Pavarde, ElPastas, TelNr, TransportoID from Kurjeris";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int kurjerio_id = int.Parse(reader["KurjerioID"].ToString());
                    string vardas = reader["Vardas"].ToString();
                    string pavarde = reader["Pavarde"].ToString();
                    string el_pastas = reader["ElPastas"].ToString();
                    string tel_nr = reader["TelNr"].ToString();
                    int transporto_id = int.Parse(reader["TransportoID"].ToString());

                    kurjeriai.Add(new Kurjeris(kurjerio_id, vardas, pavarde, el_pastas, tel_nr, transporto_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return kurjeriai;
        }
        public List<Partnere_imone> GetPartnereImone()
        {
            List<Partnere_imone> imones = new List<Partnere_imone>();
            try
            {
                string sql = "select ImonesID, Pavadinimas from Partnere_Imone";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ImonesID"].ToString());
                    string pavadinimas = reader["Pavadinimas"].ToString();

                    imones.Add(new Partnere_imone(id, pavadinimas));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return imones;
        }

        public List<Partneres_imones_meniu> GetPartneresImonesMeniu()
        {
            List<Partneres_imones_meniu> imoniu_meniu = new List<Partneres_imones_meniu>();
            try
            {
                string sql = "select ID, ProduktoTipas, ProduktoKiekis, ProduktoKaina, Partneres_ImonesID from Partneres_Imones_Meniu";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    string produkto_tipas = reader["ProduktoTipas"].ToString();
                    int produkto_kiekis = int.Parse(reader["ProduktoKiekis"].ToString());
                    double produkto_kaina = double.Parse(reader["ProduktoKaina"].ToString());
                    int partneres_id = int.Parse(reader["Partneres_ImonesID"].ToString());

                    imoniu_meniu.Add(new Partneres_imones_meniu(id, produkto_tipas, produkto_kiekis, produkto_kaina, partneres_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return imoniu_meniu;
        }

        public List<Pristatymas> GetPristatymas()
        {
            List<Pristatymas> pristatymai = new List<Pristatymas>();
            try
            {
                string sql = "select PristatymoID, Busena, Nurodytas_Adresas, Nurodytas_Laikas, KurjerioID from Pristatymas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["PristatymoID"].ToString());
                    string busena = reader["Busena"].ToString();
                    string adresas = reader["Nurodytas_Adresas"].ToString();
                    DateTime laikas = DateTime.Parse(reader["Nurodytas_Laikas"].ToString());
                    int kurjerio_id = int.Parse(reader["KurjerioID"].ToString());

                    pristatymai.Add(new Pristatymas(id, busena, adresas, laikas, kurjerio_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return pristatymai;
        }

        public List<TechninePagalba> GetTechninePagalba()
        {
            List<TechninePagalba> pagalbos = new List<TechninePagalba>();
            try
            {
                string sql = "select ID, Transporto_ID, Seno_Kurjerio_ID, Naujo_Kurjerio_ID, Uzssakymo_ID from Technine_pagalba";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["ID"].ToString());
                    int transporto_id = int.Parse(reader["Transporto_ID"].ToString());
                    int seno_kurjerio_id = int.Parse(reader["Seno_Kurjerio_ID"].ToString());
                    int naujo_kurjerio_id = int.Parse(reader["Naujo_Kurjerio_ID"].ToString());
                    int uzsakymo_id = int.Parse(reader["Uzssakymo_ID"].ToString());

                    pagalbos.Add(new TechninePagalba(id, transporto_id, seno_kurjerio_id, naujo_kurjerio_id, uzsakymo_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return pagalbos;
        }

        public List<Transportas> GetTransportas()
        {
            List<Transportas> transportai = new List<Transportas>();
            try
            {
                string sql = "select TransportoID, ValstybinisNumeris, AutomobilioMarke from Transportas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["TransportoID"].ToString());
                    string vals_nr = reader["ValstybinisNumeris"].ToString();
                    string marke = reader["AutomobilioMarke"].ToString();

                    transportai.Add(new Transportas(id, vals_nr, marke));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return transportai;
        }

        public List<Uzsakymas> GetUzsakymas()
        {
            List<Uzsakymas> uzsakymai = new List<Uzsakymas>();
            try
            {
                string sql = "select UzsakymoID, Busena, UzsakymoData, IvykdymoData, KlientoID, PristatymoID, IsvezimoID from Uzsakymas";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["UzsakymoID"].ToString());
                    string busena = reader["Busena"].ToString();
                    DateTime uzsakymo_data = DateTime.Parse(reader["UzsakymoData"].ToString());
                    DateTime ivykdymo_data = DateTime.Parse(reader["IvykdymoData"].ToString());
                    int kliento_id = int.Parse(reader["KlientoID"].ToString());
                    int pristatymo_id = int.Parse(reader["PristatymoID"].ToString());
                    int isvezimo_id = int.Parse(reader["IsvezimoID"].ToString());

                    uzsakymai.Add(new Uzsakymas(id, busena, uzsakymo_data, ivykdymo_data, kliento_id, pristatymo_id, isvezimo_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return uzsakymai;
        }

        public List<UzsakymoIstorija> GetUzsakymoIstorija()
        {
            List<UzsakymoIstorija> istorija = new List<UzsakymoIstorija>();
            try
            {
                string sql = "select Istorijos_ID, Uzsakymo_ID, Kliento_ID, Kurjerio_ID, Apmokejimo_ID from Uzsakymo_Istorija";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["Istorijos_ID"].ToString());
                    int uzsakymo_id = int.Parse(reader["Uzsakymo_ID"].ToString());
                    int kliento_id = int.Parse(reader["Kliento_ID"].ToString());
                    int kurjerio_id = int.Parse(reader["Kurjerio_ID"].ToString());
                    int apmokejimo_id = int.Parse(reader["Apmokejimo_ID"].ToString());

                    istorija.Add(new UzsakymoIstorija(id, uzsakymo_id, kliento_id, kurjerio_id, apmokejimo_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return istorija;
        }

        public List<UzsakymoPreke> GetUzsakymoPreke()
        {
            List<UzsakymoPreke> prekes = new List<UzsakymoPreke>();
            try
            {
                string sql = "select OperacijosNr, PrekesID, Kiekis, Kaina, Part_ImonesMeniuID, UzsakymoID from Uzsakymo_Preke";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int operacijos_id = int.Parse(reader["OperacijosNr"].ToString());
                    int prekes_id = int.Parse(reader["PrekesID"].ToString());
                    int kiekis = int.Parse(reader["Kiekis"].ToString());
                    double kaina = double.Parse(reader["Kaina"].ToString());
                    int part_im_men_id = int.Parse(reader["Part_ImonesMeniuID"].ToString());
                    int uzsakymo_id = int.Parse(reader["UzsakymoID"].ToString());

                    prekes.Add(new UzsakymoPreke(operacijos_id, prekes_id, kiekis, kaina, part_im_men_id, uzsakymo_id));
                }

                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
            }

            return prekes;
        }
    }
}
