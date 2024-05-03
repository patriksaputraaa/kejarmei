using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMei
{
    class DaftarPemain
    {
        private Pemain[] daftar_pemain;//array dengan tipe data pemain
        int data = 0;

        public DaftarPemain(int jumlah)
        {
            daftar_pemain = new Pemain[jumlah];
        }

        public void tambahPemain()
        {
            string nama;
            int nomor_punggung;

            //perulangan untuk menambahkan pemain hingga array terisi penuh
            while (true)
            {
                if (data < daftar_pemain.Length)
                {
                    //input nama pemain
                    Console.Write("Masukkan nama pemain: ");
                    nama = Console.ReadLine();

                    //input nomor punggung pemain
                    Console.Write("Masukkan nomor punggung pemain: ");
                    nomor_punggung = Convert.ToInt32(Console.ReadLine());

                    daftar_pemain[data] = new Pemain(nama, nomor_punggung);
                    data++;
                }
                else
                {
                    Console.WriteLine("Lineup sudah penuh!");
                    break;
                }
            }
        }

        public void tampilkanDaftarPemain()
        {
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < daftar_pemain.Length; i++)
            {
                Console.Write("| " + daftar_pemain[i].NomorPunggung + " (" + daftar_pemain[i].Nama + ")\n");
            }
            Console.WriteLine("---------------------------------");
        }

        public void insertionSortNomorPunggung()
        {
            int ukuran = daftar_pemain.Length;
            int index, putaran = 1;

            while (putaran <= ukuran - 1)
            {
                index = putaran;
                Pemain pemain_temp = daftar_pemain[index];

                while ((index >= 1) && (daftar_pemain[index - 1].NomorPunggung < pemain_temp.NomorPunggung))
                {
                    daftar_pemain[index] = daftar_pemain[index - 1];
                    index--;
                }

                daftar_pemain[index] = pemain_temp;
                putaran++;
            }
        }
    }
}
