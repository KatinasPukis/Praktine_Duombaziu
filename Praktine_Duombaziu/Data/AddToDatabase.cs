using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktine_Duombaziu.Data
{
    public class AddToDatabase
    {
        private SqlConnection conn;
        public AddToDatabase()
        {
            conn = new SqlConnection(@"Server=.;Database=duombaze;Trusted_Connection=true;");
        }
        public void AddNewAddress(int adresoID, string salis, string miestas, string gatve, int namonr, int butonr, string pastoindeksas, int klientoid)
        {
            try
            {
                string sql = " insert into Adresas(Salis, Miestas, Gatve, Namo_Nr, Buto_Nr, Pasto_Indeksas, KlientoID)" + "values(@Salis, @Miestas, @Gatve, @Namo_Nr, @Buto_Nr, @Pasto_Indeksas, @KlientoID)";
                SqlCommand cmd = new SqlCommand(sql, conn);
               // cmd.Parameters.AddWithValue("@AdresoID", adresoID);
                cmd.Parameters.AddWithValue("@Salis", salis);
                cmd.Parameters.AddWithValue("@Miestas", miestas);
                cmd.Parameters.AddWithValue("@Gatve", gatve);
                cmd.Parameters.AddWithValue("@Namo_Nr", namonr);
                cmd.Parameters.AddWithValue("@Buto_Nr", butonr);
                cmd.Parameters.AddWithValue("@Pasto_Indeksas", pastoindeksas);
                cmd.Parameters.AddWithValue("@KlientoID", klientoid);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }


        }
    }
}
