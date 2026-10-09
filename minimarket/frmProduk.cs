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
    public partial class frmProduk : Form
    {
        public frmProduk()
        {
            InitializeComponent();
            tampilkanData();

        }
        public SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        String id;

        private void nonaktif()
        {
            txtNamaProduk.Enabled = false;
            txtHarga.Enabled = false;
            txtStok.Enabled = false;

            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void kosong()
        {
            txtNamaProduk.Clear();
            txtHarga.Clear();
            txtStok.Clear();
        }

        private void simpan()
        {
            koneksi.Open();
            try
            {
                int harga = int.Parse(txtHarga.Text.Replace(".", ""));
                cmd = new SqlCommand("insert into t_produk (nama_produk, harga, stok) values ('" + txtNamaProduk.Text + "', '" + harga + "', '" + txtStok.Text + "')", koneksi);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil di simpan", "infromasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
            }
            catch
            {

            }
           
        }

        private void ubah()
        {
            koneksi.Open();
            try
            {
                int harga = int.Parse(txtHarga.Text.Replace(".", ""));
                cmd = new SqlCommand("update t_produk set nama_produk = '" + txtNamaProduk.Text + "',harga = '" + harga + "',stok = '" + txtStok.Text + "' where id_produk = '"+id+"'", koneksi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di ubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
            }
            catch
            {
                    
            }
           
        }

        private void hapus()
        {
            koneksi.Close();
            koneksi.Open();
            cmd = new SqlCommand("delete t_produk where id_produk = '"+id+"'",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id_produk as ID, nama_produk as [NAMA PRODUK], harga as HARGA, stok as STOK from t_produk",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void ambildata()
        {
            int row = dgvTampil.CurrentCell.RowIndex;
            id = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNamaProduk.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtHarga.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            txtStok.Text = dgvTampil.Rows[row].Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtNamaProduk.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            if (txtNamaProduk.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    hapus();
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
            frmDashboard frm = new frmDashboard();
            frm.ShowDialog();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if(txtHarga.Text != "")
            {
                txtHarga.Text = String.Format("{0:n0}", double.Parse(txtHarga.Text));
            }
            txtHarga.SelectionStart = txtHarga.TextLength;
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {
            if(txtStok.Text != "")
            {
                txtStok.Text = String.Format("{0:n0}", double.Parse(txtStok.Text));
            }
            txtStok.SelectionStart = txtStok.TextLength;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin mengubah data ini??", "ubah", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(tanya == DialogResult.Yes)
            {
                ubah();
                kosong();
            }
            tampilkanData();
        }

        private void dgvTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ambildata();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if(cmbCari.Text == "nama")
            {
                sql = "select * from t_produk where nama_produk like '%" + txtCari.Text + "%'";
            }
            else if(cmbCari.Text == "harga")
            {
                sql = "select * from t_produk where harga like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_produk where stok like '%" + txtCari.Text + "%'";
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }
    }
}
