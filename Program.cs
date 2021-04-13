using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3386
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan mufti = new Karyawan();
            Karyawan paijo = new Karyawan();

            mufti.Nik = 20113386;
            mufti.Nama = "Mufti";
            mufti.GajiBulanan = 3000000;

            paijo.Nik = 20123456;
            paijo.Nama = "Paijo";
            paijo.GajiBulanan = 2000000;

            Console.WriteLine("Nik Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            mufti.gajiawal();
            paijo.gajiawal();

            Console.WriteLine("\n\nAlhamdulillah dapat kenaikan gaji 10%\n\n");

            Console.WriteLine("Nik Nama\t\tGaji Bulanan");
            Console.WriteLine("-------------------------------------");
            mufti.gajiakhir();
            paijo.gajiakhir();

            Console.ReadKey();
        }
    }
}
