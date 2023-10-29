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
    public partial class Form4UpPlh : Form
    {
        private PelatihanController pltcontroller;
        public Form4UpPlh()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pltcontroller = new PelatihanController();
            pltcontroller.tambahPelatihan(txtID.Text, txtNP.Text, txtDes.Text, dateTimePicker1.Value, dateTimePicker2.Value, txtIns.Text, txtLok.Text, txtHarga.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNP.Focus();
            MessageBox.Show("Data Disimpan");
            Form4UpPlh lk = new Form4UpPlh();

            lk.Show();
            this.Hide();
        }
        

        private void Form4UpPlh_Load(object sender, EventArgs e)
        {
            txtID.MaxLength = 3;
            txtNP.MaxLength = 255;
            txtDes.MaxLength = 255;
            txtIns.MaxLength = 100;
            txtLok.MaxLength = 255;
            txtHarga.MaxLength = 10;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2Pel frAddPlth = new Form2Pel();
            frAddPlth.Show();
            this.Hide();
        }
    }
}
