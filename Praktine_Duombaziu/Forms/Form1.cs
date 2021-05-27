using Praktine_Duombaziu.Data;
using Praktine_Duombaziu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private void loadButton_Click(object sender, EventArgs e)
        {
            string selection = comboBox1.SelectedItem.ToString();
            var select = $"SELECT * FROM {selection}";
            conn = new SqlConnection(@"Server=.;Database=duombaze;Trusted_Connection=true;");
            var dataAdapter = new SqlDataAdapter(select, conn);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    repository.addDataToTable(comboBox1.Text, dataGridView1.SelectedRows[0], dataGridView1.Columns);
                    loadButton_Click(sender, e);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
                MessageBox.Show("Pasirinkite eilute!");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
                repository.updateDataInTable(comboBox1.Text, dataGridView1.SelectedRows[0], dataGridView1.Columns);
            else
                MessageBox.Show("Pasirinkite eilute!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    repository.deleteDataFromTable(comboBox1.Text, dataGridView1.SelectedRows[0], dataGridView1.Columns);
                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
                MessageBox.Show("Pasirinkite eilute!");
        }
    }
}
