namespace minimarket
{
    partial class frmJual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtTgl = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalNota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvTampil = new System.Windows.Forms.DataGridView();
            this.produk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diskon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalharga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDiskon = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbProduk = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNoNota = new System.Windows.Forms.TextBox();
            this.cmbNamaPelanggan = new System.Windows.Forms.ComboBox();
            this.btnKePelanggan = new System.Windows.Forms.Button();
            this.btnKeProduk = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 113);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(511, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PENJUALAN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal";
            // 
            // dtTgl
            // 
            this.dtTgl.CalendarFont = new System.Drawing.Font("Tahoma", 14.25F);
            this.dtTgl.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.dtTgl.Location = new System.Drawing.Point(201, 266);
            this.dtTgl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTgl.Name = "dtTgl";
            this.dtTgl.Size = new System.Drawing.Size(231, 28);
            this.dtTgl.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(179, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // txtTotalNota
            // 
            this.txtTotalNota.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtTotalNota.Location = new System.Drawing.Point(197, 322);
            this.txtTotalNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalNota.Name = "txtTotalNota";
            this.txtTotalNota.Size = new System.Drawing.Size(235, 36);
            this.txtTotalNota.TabIndex = 9;
            this.txtTotalNota.TextChanged += new System.EventHandler(this.txtTotalNota_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Nota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(780, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Produk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(780, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = ":";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtJumlah.Location = new System.Drawing.Point(799, 258);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(235, 36);
            this.txtJumlah.TabIndex = 15;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            this.txtJumlah.Leave += new System.EventHandler(this.txtJumlah_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(671, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Jumlah";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(780, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = ":";
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtHarga.Location = new System.Drawing.Point(799, 314);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(235, 36);
            this.txtHarga.TabIndex = 18;
            this.txtHarga.TextChanged += new System.EventHandler(this.txtHarga_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(671, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 29);
            this.label13.TabIndex = 17;
            this.label13.Text = "Harga";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(780, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 29);
            this.label14.TabIndex = 22;
            this.label14.Text = ":";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtTotalHarga.Location = new System.Drawing.Point(799, 418);
            this.txtTotalHarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.Size = new System.Drawing.Size(235, 36);
            this.txtTotalHarga.TabIndex = 21;
            this.txtTotalHarga.TextChanged += new System.EventHandler(this.txtTotalHarga_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(616, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Total Harga";
            // 
            // dgvTampil
            // 
            this.dgvTampil.AllowUserToAddRows = false;
            this.dgvTampil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampil.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.produk,
            this.jumlah,
            this.harga,
            this.diskon,
            this.totalharga});
            this.dgvTampil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampil.Location = new System.Drawing.Point(0, 490);
            this.dgvTampil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTampil.Name = "dgvTampil";
            this.dgvTampil.RowHeadersWidth = 51;
            this.dgvTampil.RowTemplate.Height = 24;
            this.dgvTampil.Size = new System.Drawing.Size(1212, 206);
            this.dgvTampil.TabIndex = 23;
            // 
            // produk
            // 
            this.produk.HeaderText = "Produk";
            this.produk.MinimumWidth = 6;
            this.produk.Name = "produk";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            // 
            // diskon
            // 
            this.diskon.HeaderText = "Diskon";
            this.diskon.MinimumWidth = 6;
            this.diskon.Name = "diskon";
            // 
            // totalharga
            // 
            this.totalharga.HeaderText = "Total Harga";
            this.totalharga.MinimumWidth = 6;
            this.totalharga.Name = "totalharga";
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnTambah.Location = new System.Drawing.Point(31, 449);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(92, 34);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnBatal.Location = new System.Drawing.Point(147, 449);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(92, 34);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnSimpan.Location = new System.Drawing.Point(799, 702);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(92, 34);
            this.btnSimpan.TabIndex = 26;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnHapus.Location = new System.Drawing.Point(919, 702);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(92, 34);
            this.btnHapus.TabIndex = 27;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.btnKeluar.Location = new System.Drawing.Point(1044, 702);
            this.btnKeluar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(92, 34);
            this.btnKeluar.TabIndex = 28;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(780, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 29);
            this.label16.TabIndex = 31;
            this.label16.Text = ":";
            // 
            // txtDiskon
            // 
            this.txtDiskon.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtDiskon.Location = new System.Drawing.Point(799, 366);
            this.txtDiskon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiskon.Name = "txtDiskon";
            this.txtDiskon.Size = new System.Drawing.Size(235, 36);
            this.txtDiskon.TabIndex = 30;
            this.txtDiskon.TextChanged += new System.EventHandler(this.txtDiskon_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(671, 368);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 29);
            this.label17.TabIndex = 29;
            this.label17.Text = "Diskon";
            // 
            // cmbProduk
            // 
            this.cmbProduk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduk.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cmbProduk.FormattingEnabled = true;
            this.cmbProduk.Location = new System.Drawing.Point(799, 213);
            this.cmbProduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProduk.Name = "cmbProduk";
            this.cmbProduk.Size = new System.Drawing.Size(235, 29);
            this.cmbProduk.TabIndex = 32;
            this.cmbProduk.SelectedValueChanged += new System.EventHandler(this.cmbProduk_SelectedValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(339, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 29);
            this.label18.TabIndex = 35;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtUser.Location = new System.Drawing.Point(12, 121);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(235, 36);
            this.txtUser.TabIndex = 34;
            // 
            // txtNoNota
            // 
            this.txtNoNota.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNoNota.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.txtNoNota.Location = new System.Drawing.Point(448, 322);
            this.txtNoNota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNoNota.Name = "txtNoNota";
            this.txtNoNota.Size = new System.Drawing.Size(133, 36);
            this.txtNoNota.TabIndex = 36;
            this.txtNoNota.TextChanged += new System.EventHandler(this.txtNoNota_TextChanged);
            // 
            // cmbNamaPelanggan
            // 
            this.cmbNamaPelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamaPelanggan.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cmbNamaPelanggan.FormattingEnabled = true;
            this.cmbNamaPelanggan.Location = new System.Drawing.Point(201, 206);
            this.cmbNamaPelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNamaPelanggan.Name = "cmbNamaPelanggan";
            this.cmbNamaPelanggan.Size = new System.Drawing.Size(235, 29);
            this.cmbNamaPelanggan.TabIndex = 37;
            // 
            // btnKePelanggan
            // 
            this.btnKePelanggan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKePelanggan.Location = new System.Drawing.Point(448, 206);
            this.btnKePelanggan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKePelanggan.Name = "btnKePelanggan";
            this.btnKePelanggan.Size = new System.Drawing.Size(92, 28);
            this.btnKePelanggan.TabIndex = 38;
            this.btnKePelanggan.Text = "+";
            this.btnKePelanggan.UseVisualStyleBackColor = true;
            this.btnKePelanggan.Click += new System.EventHandler(this.btnKePelanggan_Click);
            // 
            // btnKeProduk
            // 
            this.btnKeProduk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeProduk.Location = new System.Drawing.Point(1044, 213);
            this.btnKeProduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeProduk.Name = "btnKeProduk";
            this.btnKeProduk.Size = new System.Drawing.Size(92, 28);
            this.btnKeProduk.TabIndex = 39;
            this.btnKeProduk.Text = "+";
            this.btnKeProduk.UseVisualStyleBackColor = true;
            this.btnKeProduk.Click += new System.EventHandler(this.btnKeProduk_Click);
            // 
            // frmJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1212, 794);
            this.Controls.Add(this.btnKeProduk);
            this.Controls.Add(this.btnKePelanggan);
            this.Controls.Add(this.cmbNamaPelanggan);
            this.Controls.Add(this.txtNoNota);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmbProduk);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtDiskon);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dgvTampil);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalHarga);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtTgl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmJual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJual";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtTgl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvTampil;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDiskon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn produk;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn diskon;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalharga;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNoNota;
        private System.Windows.Forms.ComboBox cmbNamaPelanggan;
        private System.Windows.Forms.Button btnKePelanggan;
        private System.Windows.Forms.Button btnKeProduk;
    }
}