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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public SqlConnection koneksi = new SqlConnection(minimarket.Properties.Resources.koneksi.ToString());
        public SqlCommand cmd;
        public SqlDataReader rs;
        public static String idUser;
        public static String namaUser;
        public static string role;

        private void kosong()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        string gethsa256(string sandi)
        {
            return string.Join("", SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(sandi)).Select(b => b.ToString("X2")));
        }

        private void getRole()
        {
            koneksi.Close();
            koneksi.Open();
            cmd = new SqlCommand("select role from t_user where username = '"+txtUsername.Text+"'",koneksi);
            rs = cmd.ExecuteReader();
            rs.Read();
            if (rs.HasRows)
            {
                role = rs["role"].ToString();
            }
            cmd.Dispose();
            rs.Close();
            koneksi.Close();
        }

        private void masuk()
        {
            koneksi.Open();
            if(txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from t_user where username = '"+txtUsername.Text+"' and password = '"+gethsa256(txtPassword.Text) +"'",koneksi);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    idUser = dt.Rows[0]["id_user"].ToString();
                    namaUser = dt.Rows[0]["nama"].ToString();
                    role = dt.Rows[0]["role"].ToString();
                    this.Hide();
                    frmDashboard frm = new frmDashboard();
                    frm.ShowDialog();   
                }
                else
                {
                    MessageBox.Show("Username atau password tidak tepat silahkan login kembali", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
            koneksi.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            masuk();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
        }
    }
}
