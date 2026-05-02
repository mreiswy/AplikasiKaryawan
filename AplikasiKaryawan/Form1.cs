using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AplikasiKaryawan
{
    public partial class Form1 : Form
    {
        BindingList<Karyawan> listKaryawan = new BindingList<Karyawan>();

        public Form1()
        {
            InitializeComponent();

            dgvKaryawan.DataSource = listKaryawan;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nothing special for now
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            using (FormEntriKaryawan frmEntri = new FormEntriKaryawan())
            {
                if (frmEntri.ShowDialog() == DialogResult.OK)
                {
                    Karyawan karyawanBaru = frmEntri.GetKaryawan();

                    listKaryawan.Add(karyawanBaru);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvKaryawan.CurrentRow != null && dgvKaryawan.CurrentRow.Index >= 0)
            {
                int index = dgvKaryawan.CurrentRow.Index;
                Karyawan karyawanDipilih = listKaryawan[index];

                using (FormEntriKaryawan frmEntri = new FormEntriKaryawan(karyawanDipilih))
                {
                    if (frmEntri.ShowDialog() == DialogResult.OK)
                    {
                        // 4. Timpa data lama, tabel juga akan OTOMATIS berubah mengikuti editanmu!
                        listKaryawan[index] = frmEntri.GetKaryawan();
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan klik/pilih salah satu baris data terlebih dahulu!");
            }
        }
    }
}