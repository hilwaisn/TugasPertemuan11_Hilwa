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
    internal class PelatihanController : Model.Connection
    {
        Connection conn = new Connection();
        public DataTable tampilPelatihan()
        {
            DataTable data = new DataTable();
            try
            {
                string tampil = "SELECT * FROM Pelatihan";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public bool valName(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' ||
                name[a] == ',' | name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' ||
                name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public bool valDes(string name)
        {
            for (int a = 0; a < name.Length; a++)
            {
                if ((name[a] >= '0' && name[a] <= '9') || name[0] == ' ' || name[name.Length - 1] == ' ' || name[a] == ':' || name[a] == ',' || name[0] == '-' || name[name.Length - 1] == '-' || name[a] == '/' || name[a] == '\\' || name[a] == '?')
                {
                    MessageBox.Show("Input Name field", "Add Pelatihan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        public void tambahPelatihan(string idpelatihan, string namapelatihan, string deskripsipelatihan, DateTime tanggalmulai, DateTime tanggalselesai, string instrukturpelatihan, string lokasipelatihan, string hargapelatihan)
        {
            string tambah = "INSERT INTO Pelatihan VALUES(" + "@id,@nama_pelatihan,@deskripsi,@tanggal_mulai,@tanggal_selesai,@instruktur,@lokasi,@harga)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = idpelatihan;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsipelatihan;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.VarChar).Value = tanggalmulai;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.VarChar).Value = tanggalselesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = instrukturpelatihan;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasipelatihan;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hargapelatihan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal" + ex.Message);
            }
        }
        public void updatePelatihan(string id, string namapelatihan, string deskripsipelatihan, DateTime tanggalmulai, DateTime tanggalselesai, string instrukturpelatihan, string lokasipelatihan, string hargapelatihan)
        {
            string update = "UPDATE Pelatihan SET " + "id=@id,nama_pelatihan=@nama_pelatihan,deskripsi=@deskripsi, tanggal_mulai=@tanggal_mulai, tanggal_selesai=@tanggal_selesai, instruktur=@instruktur, lokasi=@lokasi, harga=@harga" + "WHERE id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@nama_pelatihan", MySqlConnector.MySqlDbType.VarChar).Value = namapelatihan;
                cmd.Parameters.Add("@deskripsi", MySqlConnector.MySqlDbType.VarChar).Value = deskripsipelatihan;
                cmd.Parameters.Add("@tanggal_mulai", MySqlConnector.MySqlDbType.DateTime).Value = tanggalmulai;
                cmd.Parameters.Add("@tanggal_selesai", MySqlConnector.MySqlDbType.DateTime).Value = tanggalselesai;
                cmd.Parameters.Add("@instruktur", MySqlConnector.MySqlDbType.VarChar).Value = instrukturpelatihan;
                cmd.Parameters.Add("@lokasi", MySqlConnector.MySqlDbType.VarChar).Value = lokasipelatihan;
                cmd.Parameters.Add("@harga", MySqlConnector.MySqlDbType.VarChar).Value = hargapelatihan;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Data Gagal" + ex.Message);
            }
        }
        public void hapusPelatihan(string id)
        {
            string hapus = "delete from pelatihan where id=" + id;
            try
            {
                cmd = new MySqlConnector.MySqlCommand(hapus, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Data Gagal" + ex.Message);
            }
        }
        public DataTable searchPelatihan(string search)
        {
            DataTable table = new DataTable();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM Pelatihan WHERE CONCAT(id, nama_pelatihan,deskripsi," +
                    "tanggal_mulai,tanggal_selesai,instruktur, lokasi, harga)LIKE '%" + search + "%'", conn.GetConn());
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
