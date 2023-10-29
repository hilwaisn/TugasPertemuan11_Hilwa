using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11_Hilwa.Controller;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasPertemuan11_Hilwa.View
{
    public partial class Form6Pes : Form
    {
        private PesertaController pescontroller;

        public Form6Pes()
        {
            pescontroller = new PesertaController();
            InitializeComponent();
            showTable();
        }
        public void showTable()
        {
            dataGridViewPes.DataSource = pescontroller.tampilPeserta();
            dataGridViewPes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3AddPlth frAddPlth = new Form3AddPlth();
            frAddPlth.Show();
            this.Hide();
        }

        private void btnAddPes_Click(object sender, EventArgs e)
        {
            Form7AddPes frPes = new Form7AddPes();
            frPes.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PelatihanPemrograman cl = new PelatihanPemrograman();
            cl.Show();
            this.Hide();
        }

        private void btnUpdatePes_Click(object sender, EventArgs e)
        {
            Form8UpPes cl = new Form8UpPes();
            cl.Show();
            this.Hide();
        }

        private void btnDeletePes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}