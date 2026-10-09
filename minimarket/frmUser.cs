using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            tampilkanData();
        }
        public SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        public SqlDataReader rs;
        public SqlCommand cmd;
        String id;

        private void aktif()
        {
            txtNamaUser.Enabled = true;
            txtPassword.Enabled = true;
            txtUsername.Enabled = true;
            cmbRole.Enabled = true;
            btnBatal.Enabled = true;
            btnSimpan.Enabled = true;
            btnHapus.Enabled = true;
            btnUbah.Enabled = true;
        }

        private void nonaktif()
        {
            txtNamaUser.Enabled = false;
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            cmbRole.Enabled = false;
            btnBatal.Enabled = false;
            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnUbah.Enabled = false;
        }

        private void kosong()
        {
            txtNamaUser.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            cmbRole.SelectedIndex = 0;
        }

        string getsha256(string sandi)
        {
            return string.Join("", SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(sandi)).Select(b => b.ToString("X2")));
        }

        private void simpan()
        {
            koneksi.Open();
            cmd = new SqlCommand("insert into t_user (nama,username,password,role) values ('"+txtNamaUser.Text+"', '"+txtUsername.Text+"', '"+getsha256(txtPassword.Text) +"', '" +
                ""+cmbRole.Text+"')",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di simpan", "infromasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void ubah()
        {
            koneksi.Open();
            try
            {
                if (txtPassword.Text == "")
                {
                    cmd = new SqlCommand("update t_user set nama = '" + txtNamaUser.Text
                     + "', username = '" + txtUsername.Text + "', role = '" + cmbRole.Text + "' where id_user = '" + id + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di ubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd = new SqlCommand("update t_user set nama = '" + txtNamaUser.Text
            + "', username = '" + txtUsername.Text + "', password = '" + getsha256(txtPassword.Text) + "', role = '" + cmbRole.Text + "' where id_user = '" + id + "'", koneksi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil di ubah", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
            }
            catch(Exception ex)
            {
                
            }
            koneksi.Close();
        }

        private void hapus()
        {
            koneksi.Open();
            cmd = new SqlCommand("delete t_user where id_user = '"+id+"'",koneksi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data berhasil di hapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            koneksi.Close();
        }

        private void tampilkanData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select id_user as ID, nama as NAMA, username as USERNAME, password as PASSWORD, role as ROLE from t_user",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void ambilData()
        {
            int row = dgvTampil.CurrentCell.RowIndex;

            id = dgvTampil.Rows[row].Cells[0].Value.ToString();
            txtNamaUser.Text = dgvTampil.Rows[row].Cells[1].Value.ToString();
            txtUsername.Text = dgvTampil.Rows[row].Cells[2].Value.ToString();
            txtPassword.Text = dgvTampil.Rows[row].Cells[3].Value.ToString();
            cmbRole.Text = dgvTampil.Rows[row].Cells[4].Value.ToString();
            txtPassword.Text = "";
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            aktif();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
           if(txtNamaUser.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin menyimpan data ini?", "simpan?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            if (txtNamaUser.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (txtNamaUser.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin mengubah data ini?", "ubah?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    ubah();
                    kosong();
                }
                tampilkanData();
            }
        }

        private void dgvTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ambilData();
            aktif();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            kosong();
            cmbRole.SelectedIndex = -1;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDashboard frm = new frmDashboard();
            frm.ShowDialog();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if(cmbCari.Text == "nama")
            {
                sql = "select * from t_user where nama like '%" + txtCari.Text + "%'";
            }
            else if(cmbCari.Text == "role")
            {
                sql = "select * from t_user where role like '%" + txtCari.Text + "%'";
            }
            else
            {
                sql = "select * from t_user where username like '%" + txtCari.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampil.DataSource = ds.Tables[0];
        }

        private void dgvTampil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private void txtNamaUser_TextChanged(object sender, EventArgs e)
        {
                
        }
    }
}
