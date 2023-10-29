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

namespace TugasPertemuan11_Hilwa.View
{
    public partial class Form7AddPes : Form
    {
        private PesertaController pescontroller;
        public Form7AddPes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pescontroller = new PesertaController();
            pescontroller.tambahPeserta(txtID.Text, txtNP.Text, txtEmail.Text, txtNT.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtNP.Focus();
            MessageBox.Show("Data Disimpan");
            Form7AddPes lk = new Form7AddPes();

            lk.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form6Pes cl = new Form6Pes();
            cl.Show();
            this.Hide();
        }

        private void Form7AddPes_Load(object sender, EventArgs e)
        {
            txtID.MaxLength = 4;
            txtNP.MaxLength = 40;
            txtEmail.MaxLength = 30;
            txtNT.MaxLength = 13;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
