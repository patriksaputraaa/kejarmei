using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMei
{
    class Pemain
    {
        public string Nama { get; set; }
        public int NomorPunggung { get; set; }

        public Pemain(string nama, int nomor_punggung)
        {
            this.Nama = nama;
            this.NomorPunggung = nomor_punggung;
        }
    }
}
