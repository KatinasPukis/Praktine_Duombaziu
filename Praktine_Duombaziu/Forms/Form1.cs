using Praktine_Duombaziu.Data;
using Praktine_Duombaziu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktine_Duombaziu
{
    public partial class Form1 : Form
    {
        public DatabaseRepository repository = new DatabaseRepository();
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            List<Adresas> adresuList = repository.GetAdresas();
            List<Akcija> akcijuList = repository.GetAkcija();
            List<Apmokejimas> apmokejimuList = repository.GetApmokejimas();
            List<IsvezamaPreke> isvezamaPrekesList = repository.GetIsvezamaPreke();
            List<Isvezimas> isvezimasList = repository.GetIsvezimas();
            List<Ivertinimas> ivertinimuList = repository.GetIvertinimas();
            List<Klientas> klientuList = repository.GetKlientas();
            List<Kurjerio_transportas> kurjerio_TransportuList = repository.GetKurjerio_Transportas();
            List<Kurjeris> kurjeriuList = repository.GetKurjeris();
            List<Partnere_imone> partnere_ImoniuList = repository.GetPartnereImone();
            List<Partneres_imones_meniu> partneres_Imones_MeniuList = repository.GetPartneresImonesMeniu();
            List<Pristatymas> pristatymuList = repository.GetPristatymas();
            List<TechninePagalba> techninePagalbaList = repository.GetTechninePagalba();
            List<Transportas> transportoList = repository.GetTransportas();
            List<Uzsakymas> uzsakymoList = repository.GetUzsakymas();
            List<UzsakymoIstorija> uzsakymoIstorijasList = repository.GetUzsakymoIstorija();
            List<UzsakymoPreke> uzsakymoPrekesList = repository.GetUzsakymoPreke();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string selection = comboBox1.SelectedItem.ToString();
            var select = $"SELECT * FROM {selection}";
            conn = new SqlConnection(@"Server=.;Database=duombaze;Trusted_Connection=true;");
            var dataAdapter = new SqlDataAdapter(select, conn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
