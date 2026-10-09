namespace minimarket
{
    partial class frmDashboard
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTampilProduk = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTampilPenjualan = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.cmbCari = new System.Windows.Forms.ComboBox();
            this.txtCariPenjualan = new System.Windows.Forms.TextBox();
            this.cmbCariPenjualan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilProduk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(-27, 70);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1425, 36);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Location = new System.Drawing.Point(-24, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1421, 34);
            this.panel2.TabIndex = 4;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Menu.Location = new System.Drawing.Point(688, -11);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(110, 47);
            this.Menu.TabIndex = 6;
            this.Menu.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(-27, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1428, 34);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(-5, 105);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 746);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log out";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jual";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvTampilProduk
            // 
            this.dgvTampilProduk.AllowUserToAddRows = false;
            this.dgvTampilProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampilProduk.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTampilProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilProduk.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampilProduk.Location = new System.Drawing.Point(300, 190);
            this.dgvTampilProduk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTampilProduk.Name = "dgvTampilProduk";
            this.dgvTampilProduk.RowHeadersWidth = 51;
            this.dgvTampilProduk.RowTemplate.Height = 24;
            this.dgvTampilProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampilProduk.Size = new System.Drawing.Size(1036, 251);
            this.dgvTampilProduk.TabIndex = 7;
            this.dgvTampilProduk.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTampil_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(301, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "Laporan produk";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(292, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 47);
            this.label6.TabIndex = 8;
            this.label6.Text = "Laporan Penjualan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTampilPenjualan
            // 
            this.dgvTampilPenjualan.AllowUserToAddRows = false;
            this.dgvTampilPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTampilPenjualan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTampilPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTampilPenjualan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTampilPenjualan.Location = new System.Drawing.Point(291, 569);
            this.dgvTampilPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTampilPenjualan.Name = "dgvTampilPenjualan";
            this.dgvTampilPenjualan.RowHeadersWidth = 51;
            this.dgvTampilPenjualan.RowTemplate.Height = 24;
            this.dgvTampilPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTampilPenjualan.Size = new System.Drawing.Size(1036, 251);
            this.dgvTampilPenjualan.TabIndex = 9;
            // 
            // txtCari
            // 
            this.txtCari.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCari.Location = new System.Drawing.Point(1069, 151);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(267, 27);
            this.txtCari.TabIndex = 42;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // cmbCari
            // 
            this.cmbCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCari.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCari.FormattingEnabled = true;
            this.cmbCari.Items.AddRange(new object[] {
            "nama",
            "harga",
            "stok"});
            this.cmbCari.Location = new System.Drawing.Point(893, 151);
            this.cmbCari.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCari.Name = "cmbCari";
            this.cmbCari.Size = new System.Drawing.Size(169, 27);
            this.cmbCari.TabIndex = 41;
            // 
            // txtCariPenjualan
            // 
            this.txtCariPenjualan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPenjualan.Location = new System.Drawing.Point(1059, 530);
            this.txtCariPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariPenjualan.Name = "txtCariPenjualan";
            this.txtCariPenjualan.Size = new System.Drawing.Size(267, 27);
            this.txtCariPenjualan.TabIndex = 45;
            this.txtCariPenjualan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCariPenjualan
            // 
            this.cmbCariPenjualan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCariPenjualan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCariPenjualan.FormattingEnabled = true;
            this.cmbCariPenjualan.Items.AddRange(new object[] {
            "nama user ",
            "nama pelanggan",
            "tanggal",
            "nama produk",
            "jumlah",
            "harga",
            "diskon",
            "subtotal"});
            this.cmbCariPenjualan.Location = new System.Drawing.Point(884, 530);
            this.cmbCariPenjualan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCariPenjualan.Name = "cmbCariPenjualan";
            this.cmbCariPenjualan.Size = new System.Drawing.Size(169, 27);
            this.cmbCariPenjualan.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(825, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 31);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cari";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(825, 524);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 47;
            this.label7.Text = "Cari";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1397, 842);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCariPenjualan);
            this.Controls.Add(this.cmbCariPenjualan);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cmbCari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTampilPenjualan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTampilProduk);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilProduk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTampilPenjualan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTampilProduk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTampilPenjualan;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ComboBox cmbCari;
        private System.Windows.Forms.TextBox txtCariPenjualan;
        private System.Windows.Forms.ComboBox cmbCariPenjualan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}