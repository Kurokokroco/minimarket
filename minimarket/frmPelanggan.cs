using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket
{
    public partial class frmPelanggan : Form
    {
        public frmPelanggan()
        {
            InitializeComponent();
            kosong();
            tampilkanData();
        }
        SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        SqlCommand cmd;
        SqlDataReader rs;
        public static string idPelanggan;

        private void kosong()
        {
            txtNamaPelanggan.Clear();
            txtAlamat.Clear();
            txtNohp.Clear();
        }

        private void simpan()
        {
            koneksi.Open();
            cmd = new SqlCommand("insert into t_pelanggan (nama,alamat,no_hp) values ('"+txtNamaPelanggan.Text+"', '"+txtAlamat.Text+"', '"+txtNohp.Text+"')",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }
        

        private void ubah()
        {
            koneksi.Open();
            cmd = new SqlCommand("update t_pelanggan set nama = '"+txtNamaPelanggan.Text+"', alamat = '"+txtAlamat.Text+"', no_hp = '"+txtNohp.Text+"', where id_pelanggan = '"+idPelanggan+"'",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di ubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void hapus()
        {
            koneksi.Open();
            cmd = new SqlCommand("delete t_pelanggam where id_pelanggan = '"+idPelanggan+"'",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from t_pelanggan", koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void ambilData()
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            idPelanggan = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNamaPelanggan.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtAlamat.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            txtNohp.Text = dgvTampil.Rows[row].Cells[3].Value.ToString();
        }

        private void txtNohp_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNamaPelanggan.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin menyimpan data ini?", "Simpan?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    simpan();
                    kosong();
                }
                tampilkanData();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtNamaPelanggan.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "hapus?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    hapus();
                    kosong();
                }
                tampilkanData();
            }
           
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtNamaPelanggan.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin mengubah data ini?", "ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    ubah();
                    kosong();
                }
                tampilkanData();
            }
          
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            kosong();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmJual frm  = new frmJual();
            frm.ShowDialog();

        }

        private void dgvTampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ambilData();
        }

        private void frmPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if(cmbCari.Text == "nama")
            {
                sql = "select * from t_pelanggan where nama like '%" + txtCari.Text + "%'";
            }
            else if(cmbCari.Text == "alamat")
            {
                sql = "select * from t_pelanggan where alamat like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_pelanggan where no_hp like '%" + txtCari.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }
    }
}
