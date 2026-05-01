using System;
using System.Collections.Generic;
using System.Text;

namespace AplikasiKaryawan
{
    public class Karyawan
    {
        public string IDKaryawan { get; set; }
        public string NamaLengkap { get; set; }
        public string Departemen { get; set; }
        public string Jabatan { get; set; }
        public DateTime TanggalLahir { get; set; }
        public DateTime TanggalBergabung { get; set; }
        public string Email { get; set; }
        public decimal GajiPokok { get; set; }
        public bool StatusTetap { get; set; }
    }
}