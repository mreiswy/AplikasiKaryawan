using System;
using System.Windows.Forms;
using System.Text.RegularExpressions; // WAJIB DITAMBAHKAN UNTUK VALIDASI FORMAT

namespace AplikasiKaryawan
{
    public partial class FormEntriKaryawan : Form
    {
        // Constructor 1: Digunakan untuk TAMBAH DATA (Form Kosong)
        public FormEntriKaryawan()
        {
            InitializeComponent();
        }

        // Constructor 2: Digunakan untuk UPDATE DATA (Mengisi form dengan data yang dipilih)
        public FormEntriKaryawan(Karyawan dataEdit)
        {
            InitializeComponent();
            // Memasukkan data lama ke dalam input form
            txtID.Text = dataEdit.IDKaryawan;
            txtID.Enabled = false; // ID tidak boleh diedit
            txtNama.Text = dataEdit.NamaLengkap;
            cbDepartemen.SelectedItem = dataEdit.Departemen;
            cbJabatan.SelectedItem = dataEdit.Jabatan;
            dtpTglLahir.Value = dataEdit.TanggalLahir;
            dtpTglGabung.Value = dataEdit.TanggalBergabung;
            txtEmail.Text = dataEdit.Email;
            txtGaji.Text = dataEdit.GajiPokok.ToString();
            chkStatusTetap.Checked = dataEdit.StatusTetap;
            dtpTglLahir.MaxDate = DateTime.Today.AddYears(-18);
        }

        // Action saat tombol Simpan diklik
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi Input Kosong (Contoh untuk ID dan Nama)
            if (string.IsNullOrWhiteSpace(txtID.Text) || txtID.Text.StartsWith("ex."))
            {
                MessageBox.Show("ID Karyawan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus(); // Arahkan kursor kembali ke kotak ID
                return; // Hentikan proses simpan
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text) || txtNama.Text.StartsWith("ex."))
            {
                MessageBox.Show("Nama Lengkap wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            string email = txtEmail.Text;
            if (string.IsNullOrWhiteSpace(email) || email.StartsWith("ex."))
            {
                MessageBox.Show("Email wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            string polaEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(email, polaEmail))
            {
                MessageBox.Show("Format email tidak valid!\nContoh yang benar: nama@perusahaan.com", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            // 2. Validasi Angka untuk Gaji menggunakan TryParse
            // (Akan gagal jika user mengosongkan atau memasukkan huruf)
            if (!decimal.TryParse(txtGaji.Text, out decimal hasilGaji))
            {
                MessageBox.Show("Gaji Pokok harus berupa angka yang valid! (Jangan pakai tulisan 'ex.')", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGaji.Focus();
                return;
            }

            string Departemen = cbDepartemen.Text;
            if (string.IsNullOrWhiteSpace(Departemen) || Departemen.StartsWith("ex."))
            {
                MessageBox.Show("Departemen wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbDepartemen.Focus();
                return;
            }

            string Jabatan = cbJabatan.Text;
            if (string.IsNullOrWhiteSpace(Jabatan) || Jabatan.StartsWith("ex."))
            {
                MessageBox.Show("Jabatan wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbJabatan.Focus();
                return;
            }

            DateTime batasUmur18 = DateTime.Today.AddYears(-18);

            // Jika tanggal lahir yang diinput LEBIH BESAR (lebih muda) dari tanggal batas
            if (dtpTglLahir.Value > batasUmur18)
            {
                MessageBox.Show("Usia karyawan minimal harus 18 tahun!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpTglLahir.Focus();
                return; // Hentikan proses simpan
            }

            // Jika semua pengecekan di atas aman, baru kita tutup form dengan status OK
            this.DialogResult = DialogResult.OK;
        }

        // Event handler untuk tombol Batal (tutup form tanpa menyimpan)
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Form load handler expected by designer
        private void FormEntriKaryawan_Load(object sender, EventArgs e)
        {
            // initialize combo boxes or defaults if needed
        }

        // Method publik agar Form1 bisa mengambil data dari Form Entri ini
        public Karyawan GetKaryawan()
        {
            // Coba ubah teks menjadi desimal. Jika gagal (misal kosong), otomatis jadi 0.
            decimal.TryParse(txtGaji.Text, out decimal gajiAman);

            return new Karyawan()
            {
                IDKaryawan = txtID.Text,
                NamaLengkap = txtNama.Text,
                Departemen = cbDepartemen.Text,
                Jabatan = cbJabatan.Text,
                TanggalLahir = dtpTglLahir.Value,
                TanggalBergabung = dtpTglGabung.Value,
                Email = txtEmail.Text,
                GajiPokok = gajiAman, // Gunakan variabel gaji yang sudah aman dari crash
                StatusTetap = chkStatusTetap.Checked
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDepartemen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}