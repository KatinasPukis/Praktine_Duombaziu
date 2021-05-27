using Praktine_Duombaziu.Data;
using Praktine_Duombaziu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //test
            //dusk
            MessageBox.Show("narkomanas");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            List<Klientas> klientuList = repository.GetKlientas();
            Console.WriteLine("test");
        }
    }
}
