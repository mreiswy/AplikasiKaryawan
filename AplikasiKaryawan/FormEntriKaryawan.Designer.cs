namespace AplikasiKaryawan
{
    partial class FormEntriKaryawan
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
            txtID = new TextBox();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtGaji = new TextBox();
            cbDepartemen = new ComboBox();
            cbJabatan = new ComboBox();
            dtpTglLahir = new DateTimePicker();
            dtpTglGabung = new DateTimePicker();
            chkStatusTetap = new CheckBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 27);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "ex. 12345678";
            txtID.Size = new Size(200, 23);
            txtID.TabIndex = 0;
            txtID.Tag = "";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(150, 56);
            txtNama.Name = "txtNama";
            txtNama.PlaceholderText = "ex. Budi Santoso";
            txtNama.Size = new Size(200, 23);
            txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 85);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "ex. email@gmail.com";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtGaji
            // 
            txtGaji.Location = new Point(150, 114);
            txtGaji.Name = "txtGaji";
            txtGaji.PlaceholderText = "ex. 7.500.000,00";
            txtGaji.Size = new Size(200, 23);
            txtGaji.TabIndex = 3;
            // 
            // cbDepartemen
            // 
            cbDepartemen.DisplayMember = "3";
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "IT", "HR", "Finance" });
            cbDepartemen.Location = new Point(150, 143);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(200, 23);
            cbDepartemen.TabIndex = 4;
            cbDepartemen.SelectedIndexChanged += cbDepartemen_SelectedIndexChanged;
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Staff", "Manager", "Director" });
            cbJabatan.Location = new Point(150, 172);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(200, 23);
            cbJabatan.TabIndex = 5;
            // 
            // dtpTglLahir
            // 
            dtpTglLahir.Location = new Point(150, 201);
            dtpTglLahir.Name = "dtpTglLahir";
            dtpTglLahir.Size = new Size(200, 23);
            dtpTglLahir.TabIndex = 6;
            // 
            // dtpTglGabung
            // 
            dtpTglGabung.Location = new Point(150, 230);
            dtpTglGabung.Name = "dtpTglGabung";
            dtpTglGabung.Size = new Size(200, 23);
            dtpTglGabung.TabIndex = 7;
            // 
            // chkStatusTetap
            // 
            chkStatusTetap.AutoSize = true;
            chkStatusTetap.Location = new Point(150, 259);
            chkStatusTetap.Name = "chkStatusTetap";
            chkStatusTetap.Size = new Size(90, 19);
            chkStatusTetap.TabIndex = 8;
            chkStatusTetap.Text = "Status Tetap";
            chkStatusTetap.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.Chartreuse;
            btnSimpan.Location = new Point(184, 284);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 9;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Coral;
            btnBatal.Location = new Point(275, 284);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 10;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 11;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 12;
            label2.Text = "Nama Lengkap";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 88);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 13;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 117);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Gaji / Salary";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 146);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 15;
            label5.Text = "Departemen";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 175);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 16;
            label6.Text = "Jabatan";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 201);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 17;
            label7.Text = "Tanggal Lahir";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 230);
            label8.Name = "label8";
            label8.Size = new Size(110, 15);
            label8.TabIndex = 18;
            label8.Text = "Tanggal Bergabung";
            // 
            // FormEntriKaryawan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 330);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(chkStatusTetap);
            Controls.Add(dtpTglGabung);
            Controls.Add(dtpTglLahir);
            Controls.Add(cbJabatan);
            Controls.Add(cbDepartemen);
            Controls.Add(txtGaji);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(txtID);
            Name = "FormEntriKaryawan";
            Text = "FormEntriKaryawan";
            Load += FormEntriKaryawan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGaji;
        private System.Windows.Forms.ComboBox cbDepartemen;
        private System.Windows.Forms.ComboBox cbJabatan;
        private System.Windows.Forms.DateTimePicker dtpTglLahir;
        private System.Windows.Forms.DateTimePicker dtpTglGabung;
        private System.Windows.Forms.CheckBox chkStatusTetap;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}