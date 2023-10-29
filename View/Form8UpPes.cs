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
    public partial class Form8UpPes : Form
    {
        public Form8UpPes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PesertaController pescontroller = new PesertaController();

            pescontroller.updatePeserta(txtID.Text, txtNP.Text, txtEmail.Text, txtNT.Text);
            this.Controls.Clear();
            this.InitializeComponent();
            txtID.Focus();
            MessageBox.Show("Data Berhasil Diupdate");
            Form6Pes up = new Form6Pes();

            up.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form6Pes ca = new Form6Pes();
            ca.Show();
            this.Close();
        }
    }
}
