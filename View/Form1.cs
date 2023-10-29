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
using TugasPertemuan11_Hilwa.View;

namespace TugasPertemuan11_Hilwa
{
    public partial class PelatihanPemrograman : Form
    {
        private PelatihanController pltcontroller;
        public PelatihanPemrograman()
        {
            pltcontroller = new PelatihanController();
            InitializeComponent();
        }
        private void btnPelatihan_Click(object sender, EventArgs e)
        {
            Form2Pel frPel = new Form2Pel();
            frPel.Show();
            this.Hide();
        }

        private void btnPeserta_Click(object sender, EventArgs e)
        {
            Form6Pes frPs = new Form6Pes();
            frPs.Show();
            this.Hide();
        }

    }
}
