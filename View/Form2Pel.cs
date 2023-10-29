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

namespace TugasPertemuan11_Hilwa
{
    public partial class Form2Pel : Form
    {
        private PelatihanController pltcontroller;
        public Form2Pel()
        {
            pltcontroller = new PelatihanController();
            InitializeComponent();
            showTable();
        }
        private void btnAddPlth_Click(object sender, EventArgs e)
        {
            Form3AddPlth frAddPlth = new Form3AddPlth();
            frAddPlth.Show();
            this.Hide();
        }

        private void btnCancelPlth_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Contiue or not", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.No)
                Application.Exit();
            Form2Pel cl = new Form2Pel();
            cl.Show();
            this.Hide();
        }
        private void Form2Pel_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dataGridViewPlt.DataSource = pltcontroller.tampilPelatihan();
            dataGridViewPlt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PelatihanPemrograman clp = new PelatihanPemrograman();
            clp.Show();
            this.Hide();
        }

        private void btnUpdatePlth_Click(object sender, EventArgs e)
        {
            Form4UpPlh frAddPlth = new Form4UpPlh();
            frAddPlth.Show();
            this.Hide();
        }
    }
}
