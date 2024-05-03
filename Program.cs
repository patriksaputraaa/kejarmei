using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KejarMei
{
    class Program
    {
        static void Main(string[] args)
        {
            DaftarPemain lineup = new DaftarPemain(3);

            lineup.tambahPemain();
            lineup.tampilkanDaftarPemain();
            lineup.insertionSortNomorPunggung();
            lineup.tampilkanDaftarPemain();
            Console.ReadKey();
        }
    }
}
