using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minimarket
{
    public partial class frmDashboard : Form
    {


        public frmDashboard()
        {
            InitializeComponent();
            if(frmLogin.role == "Admin")
            {
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label5.Visible = false;
                dgvTampilProduk.Visible = false;
                txtCari.Visible = false;
                cmbCari.Visible = false;
                label8.Visible = false;
            }
            tampilakanDataProduk();
            tampilkanDataPenjualan();
        }
        SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        SqlCommand cmd;
        SqlDataReader rs;
        
        
        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmUser frm = new frmUser();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmProduk frm = new frmProduk();
            frm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
            this.Dispose();
            frmJual frm = new frmJual();
            frm.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin Logout", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tanya == DialogResult.Yes)
            {
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tampilakanDataProduk()
        {
            SqlDataAdapter da = new SqlDataAdapter("select nama_produk as NAMA, harga as HARGA, stok as STOK from t_produk",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampilProduk.DataSource = ds.Tables[0];
        }

        private void tampilkanDataPenjualan()
        {
            SqlDataAdapter da = new SqlDataAdapter("select nama as [NAMA USER], Expr1 as [NAMA PELANGGAN], tgl as [TANGGAL], total as [TOTAL], nama_produk as [NAMA PRODUK], jumlah as [JUMLAH], harga as [HARGA], diskon as [DISKON], subtotal as [SUBTOTAL] from v_penjualan",koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampilPenjualan.DataSource = ds.Tables[0];
        }

        private void dgvTampil_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cmbCari.Text == "nama")
            {
                sql = "select * from t_produk where nama_produk like '%" + txtCari.Text + "%'";
            }
            else if (cmbCari.Text == "harga")
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
            dgvTampilProduk.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
            string queryDasar = "select nama as [NAMA USER], Expr1 as [NAMA PELANGGAN], tgl as [TANGGAL], total as [TOTAL], nama_produk as [NAMA PRODUK], jumlah as [JUMLAH], harga as [HARGA], diskon as [DISKON], subtotal as [SUBTOTAL] from v_penjualan";

            string sql;

  
            if (cmbCariPenjualan.Text == "nama user")
            {
                sql = queryDasar + " where nama like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "nama pelanggan")
            {
                sql = queryDasar + " where Expr1 like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "tanggal")
            {
                sql = queryDasar + " where tgl like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "total")
            {
                sql = queryDasar + " where total like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "nama produk")
            {
                sql = queryDasar + " where nama_produk like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "jumlah")
            {
                sql = queryDasar + " where jumlah like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "harga")
            {
                sql = queryDasar + " where harga like '%" + txtCariPenjualan.Text + "%'";
            }
            else if (cmbCariPenjualan.Text == "diskon")
            {
                sql = queryDasar + " where diskon like '%" + txtCariPenjualan.Text + "%'";
            }
            else
            {
                sql = queryDasar + " where subtotal like '%" + txtCariPenjualan.Text + "%'";
            }

            SqlDataAdapter da = new SqlDataAdapter(sql, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTampilPenjualan.DataSource = ds.Tables[0];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }   
}
