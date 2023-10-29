﻿using MySqlConnector;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TugasPertemuan11_Hilwa
{
    public partial class Form3AddPlth : Form
    {
        private PelatihanController pltcontroller;
        public Form3AddPlth()
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
            Form3AddPlth lk = new Form3AddPlth();

            lk.Show();
            this.Hide();
        }

        private void Form3AddPlth_Load(object sender, EventArgs e)
        {
            txtID.MaxLength = 3;
            txtNP.MaxLength = 255;
            txtDes.MaxLength = 255;
            txtIns.MaxLength = 100;
            txtLok.MaxLength = 255;
            txtHarga.MaxLength = 10;
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtDes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtIns_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
            private void txtLok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form2Pel cl = new Form2Pel();
            cl.Show();
            this.Hide();
        }
    }
}
