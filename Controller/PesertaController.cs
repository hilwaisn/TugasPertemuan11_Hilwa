using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TugasPertemuan11_Hilwa.Model;


namespace TugasPertemuan11_Hilwa.Controller
{
    internal class PesertaController : Model.Connection
    {
        Connection conn = new Connection();
        public DataTable tampilPeserta()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Peserta";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public bool valNama(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' || name[a] == ',' || name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add Peserta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public void tambahPeserta(string id, string namaPes, string email, string noTele)
        {
            string tambah = "insert into Peserta values(" + "@id, @nama_peserta, @email, @no_telepon)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPes;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTele;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah data gagal" + ex.Message);
            }

        }

        public void updatePeserta(string id, string namaPes, string email, string noTele)
        {
            string update = "update Peserta set " + "id=@id,nama_peserta=@nama_peserta, email=@email, no_telepon=@no_telepon " + "where id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_peserta", MySqlConnector.MySqlDbType.VarChar).Value = namaPes;
                cmd.Parameters.Add("@email", MySqlConnector.MySqlDbType.VarChar).Value = email;
                cmd.Parameters.Add("@no_telepon", MySqlConnector.MySqlDbType.VarChar).Value = noTele;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update data gagal" + ex.Message);
            }

        }

        public void deletePeserta(string id)
        {
            string delete = "delete from Peserta where id=" + id;

            try
            {
                cmd = new MySqlConnector.MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal delete" + ex.Message);
            }
        }
        public DataTable searchPeserta(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Peserta WHERE CONCAT(id, nama_peserta," +
                    "email, no_telepon)LIKE '%" + search + "%'", conn.GetConn());
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return table;
        }
    }
}