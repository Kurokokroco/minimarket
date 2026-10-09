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
    public partial class frmJual : Form
    {
        public frmJual()
        {
            InitializeComponent();
            getUser();
            try
            {
                nontaktif();
                getProduk();
                getPelanggan();
                cmbNamaPelanggan.SelectedValue = 3;
                //kodeotomatis();
            }
            catch
            {

            }

        }
        SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        SqlCommand cmd;
        SqlDataReader rs;
        float total_nota;
        int stok;
        static string idPenjualan;
        int idPelangganSelected;

 

        private void nontaktif()
        {
            txtNoNota.Enabled = false;
            txtHarga.Enabled = false;
            txtDiskon.Enabled = false;
            txtTotalHarga.Enabled = false;
            dtTgl.Value = DateTime.Now;
            dtTgl.Enabled = false;
            txtTotalNota.Enabled = false;
            txtUser.Enabled = false;
        }

        private void getPelanggan()
        {
            koneksi.Open();
            cmd = new SqlCommand("select *from t_pelanggan", koneksi);
            rs = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rs);

            cmbNamaPelanggan.DataSource = dt;
            cmbNamaPelanggan.ValueMember = "id_pelanggan";
            cmbNamaPelanggan.DisplayMember = "nama";

            cmd.Dispose();
            rs.Close();
            koneksi.Close();
        }

        private void getProduk()
        {
            koneksi.Open();
            cmd = new SqlCommand("SELECT * FROM t_produk", koneksi);
            rs = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rs);

            cmbProduk.DataSource = dt;
            cmbProduk.ValueMember = "id_produk";
            cmbProduk.DisplayMember = "nama_produk";

            cmd.Dispose();
            rs.Close();
            koneksi.Close();

            try
            {
                cmbProduk.SelectedIndex = 0;
            }
            catch
            {

            }
        }


        private void getUser()
        {
            txtUser.Text = frmLogin.idUser + "-" + frmLogin.namaUser;
        }

        private void kosong()
        {
            cmbProduk.SelectedIndex = 0;
            txtHarga.Text = "0";
            txtDiskon.Text = "0";
            txtJumlah.Text = "0";
            txtTotalHarga.Text = "0";
            dtTgl.Value = DateTime.Now;
        }

        //private void kodeotomatis()
        //{
        //    koneksi.Open();
        //    cmd = new SqlCommand("select * from t_dppenjualan order by id_detail_penjualan desc", koneksi);
        //    rs = cmd.ExecuteReader();
        //    rs.Read();
        //    if (rs.HasRows)
        //    {
        //        String kode = rs["id_detail_penjualan"].ToString();
        //        int valcode = int.Parse(kode.Substring(1, 4));
        //        string codefix = (valcode + 1).ToString();

        //        if (codefix.Length == 1)
        //        {
        //            txtNoNota.Text = "J" + "000" + codefix;
        //        }
        //        if (codefix.Length == 2)
        //        {
        //            txtNoNota.Text = "J" + "00" + codefix;
        //        }
        //        if (codefix.Length == 3)
        //        {
        //            txtNoNota.Text = "J" + "0" + codefix;
        //        }
        //        if (codefix.Length == 4)
        //        {
        //            txtNoNota.Text = "J" + "" + codefix;
        //        }
        //    }
        //    else
        //    {
        //        txtNoNota.Text = "J" + "0001";
        //    }
        //    cmd.Dispose();
        //    rs.Close();
        //    koneksi.Close();
        //}

        private void cekStok()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_produk where id_produk = '" + cmbProduk.SelectedValue.ToString() + "'", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();
            if (rs.HasRows)
            {
               
                int jumlah = 0;
                if (txtJumlah.Text != "")
                {
                    jumlah = int.Parse(txtJumlah.Text.Replace(".", ""));
                }

                stok = int.Parse(rs["stok"].ToString());
                {

                    if (jumlah > stok)
                    {
                        MessageBox.Show("Stok barang tidak cukup!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtJumlah.Focus();
                        txtJumlah.Text = "";
                        txtDiskon.Text = "";
                        txtTotalHarga.Text = "";
                    }
                }
            }
            else
            {
                stok = 0;
            }
            cmd.Dispose();
            rs.Close();
            koneksi.Close();
        }

        private void getHargaBarang()
        {
            koneksi.Open();
            cmd = new SqlCommand("select * from t_produk where id_produk = '" + cmbProduk.SelectedValue.ToString() + "'", koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();

            if (rs.HasRows)
            {
                txtHarga.Text = string.Format("{0:n0}", double.Parse(rs["harga"].ToString()));
            }
            cmd.Dispose();
            rs.Close();
            koneksi.Close();
        }

        private void hitung()
        {
            
            double harga = 0;
            if (txtHarga.Text != "") harga = double.Parse(txtHarga.Text.Replace(".", ""));

            double jumlah = 0;
            if (txtJumlah.Text != "") jumlah = double.Parse(txtJumlah.Text.Replace(".", ""));

            double totalHarga = harga * jumlah;
            double diskon = 0;

            if (totalHarga > 100000)
            {
                diskon = 15;
            }
            else if (totalHarga > 50000)
            {
                diskon = 10;
            }
            else if (totalHarga > 20000)
            {
                diskon = 5;
            }
            else
            {
                diskon = 0;
            }
            txtDiskon.Text = diskon.ToString();
            totalHarga = totalHarga - (totalHarga * diskon / 100);
            txtTotalHarga.Text = String.Format("{0:n0}", totalHarga);
        }

        private void simpan()
        {
            SqlTransaction transaction;
            koneksi.Open();
            transaction = koneksi.BeginTransaction();
            try
            {
              
                cmd = new SqlCommand("insert into t_penjualan (id_user, id_pelanggan, tgl, total) values ('" + frmLogin.idUser + "','" + cmbNamaPelanggan.SelectedValue + "', '" + dtTgl.Value.ToString("MM-dd-yyyy") + "', '" + txtTotalNota.Text.Replace(".", "") + "'); SELECT SCOPE_IDENTITY();", koneksi, transaction);

                idPenjualan = cmd.ExecuteScalar().ToString();


                for (int i = 0; i < dgvTampil.Rows.Count; i++)
                {
                    cmd = new SqlCommand("insert into t_dppenjualan (id_produk, jumlah, harga, diskon, subtotal, id_penjualan) values (" +
                        "'" + dgvTampil.Rows[i].Cells[0].Value.ToString() + "'," +
                        "'" + dgvTampil.Rows[i].Cells[1].Value.ToString() + "'," +
                        "'" + dgvTampil.Rows[i].Cells[2].Value.ToString() + "'," +
                        "'" + dgvTampil.Rows[i].Cells[3].Value.ToString() + "'," +
                        "'" + dgvTampil.Rows[i].Cells[4].Value.ToString() + "', '"+idPenjualan+"')", koneksi, transaction);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update t_produk set stok = stok - '" + dgvTampil.Rows[i].Cells[1].Value.ToString() + "' where id_produk = '" + dgvTampil.Rows[i].Cells[0].Value.ToString() + "'", koneksi, transaction);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                MessageBox.Show("Transaksi berhasil di simpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.Close();
                kosong();
                //kodeotomatis();
                dgvTampil.Rows.Clear();
                dgvTampil.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                transaction.Rollback();
                kosong();

                dgvTampil.Rows.Clear();
                dgvTampil.Refresh();
            }
            koneksi.Close();
        }

        private void tambah()
        {

            if (cmbProduk.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih produk terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbProduk.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtJumlah.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) ||
                string.IsNullOrWhiteSpace(txtTotalHarga.Text))
            {
                MessageBox.Show("Jumlah, Harga, dan Total Harga tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float subTotal = float.Parse(txtTotalHarga.Text.Replace(".", ""));
            total_nota += subTotal;
            txtTotalNota.Text = total_nota.ToString();

            int row = dgvTampil.Rows.Add();
            dgvTampil.Rows[row].Cells[0].Value = cmbProduk.SelectedValue.ToString();
            dgvTampil.Rows[row].Cells[1].Value = txtJumlah.Text;
            dgvTampil.Rows[row].Cells[2].Value = txtHarga.Text.Replace(".", ""); 
            dgvTampil.Rows[row].Cells[3].Value = txtDiskon.Text.Replace(".", "");
            dgvTampil.Rows[row].Cells[4].Value = txtTotalHarga.Text.Replace(".", "");
            
            

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtHarga.Text == "")
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tambah();
            }
            
        }

        private void btnKePelanggan_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmPelanggan frm = new frmPelanggan();
            frm.ShowDialog();
           
        }

        private void btnKeProduk_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmProduk frm = new frmProduk();
            frm.ShowDialog();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            kosong();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if(txtHarga.Text == "")
            {
                MessageBox.Show("Silahkan input data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult tanya = MessageBox.Show("Apakah anda yakin ingin menyimpan data ini?", "simpan?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (tanya == DialogResult.Yes)
                {
                    simpan();
                }
            }//aadminaidj
           
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

            if (txtHarga.Text == "")
            {
                MessageBox.Show("Silahkan input data terlebih dahulu", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (dgvTampil.CurrentCell == null || dgvTampil.CurrentRow == null)
                {
                    MessageBox.Show("Silakan pilih data yang ingin dihapus terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int row = dgvTampil.CurrentCell.RowIndex;

                var cellValue = dgvTampil.Rows[row].Cells[4].Value;
                if (cellValue != null && !string.IsNullOrWhiteSpace(cellValue.ToString()))
                {

                    string strHarga = cellValue.ToString().Replace(".", "").Replace(",", "");

                    if (float.TryParse(strHarga, out float totalHarga))
                    {
                        total_nota -= totalHarga;
                        txtTotalNota.Text = total_nota.ToString("N0");
                    }
                }

                dgvTampil.Rows.RemoveAt(row);
            }
        }

        private void cmbProduk_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                getHargaBarang();
                hitung();
            }
            catch
            {

            }
        }

        private void txtJumlah_Leave(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmDashboard frm = new frmDashboard();
            frm.ShowDialog();
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char delete = (char)8;
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void txtTotalNota_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalNota.Text != "")
            {
                txtTotalNota.Text = String.Format("{0:n0}", double.Parse(txtTotalNota.Text.Replace(".", "")));
            }
            txtTotalNota.SelectionStart = txtTotalNota.TextLength;
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cekStok();
                hitung();
            }
            catch (Exception ex)
            {

            }

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if (txtHarga.Text != "")
            {
                txtHarga.Text = String.Format("{0:n0}", double.Parse(txtHarga.Text.Replace(".", "")));
            }
            txtHarga.SelectionStart = txtHarga.TextLength;
        }

        private void txtDiskon_TextChanged(object sender, EventArgs e)
        {
            if (txtDiskon.Text != "")
            {
                txtDiskon.Text = String.Format("{0:n0}", double.Parse(txtDiskon.Text.Replace(".", "")));
            }
            txtDiskon.SelectionStart = txtDiskon.TextLength;
        }

        private void txtTotalHarga_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalHarga.Text != "")
            {

                txtTotalHarga.Text = String.Format("{0:n0}", double.Parse(txtTotalHarga.Text.Replace(".", "")));
            }
         
            txtTotalHarga.SelectionStart = txtTotalHarga.TextLength;
        }

        private void txtNoNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}