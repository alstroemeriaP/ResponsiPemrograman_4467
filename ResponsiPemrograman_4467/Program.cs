using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsiPemrograman_4467
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        public static List <Mahasiswa> list = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Mata kuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                Console.Write("Nomor Menu [1..3] : ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();    
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.Write("1. Tambah Mahasiswa\n");
            Console.Write("2. Tampilkan Mahasiswa\n");
            Console.Write("3. Keluar\n\n");
        }

        static void TambahMahasiswa()
        {
            Mahasiswa mhs = new Mahasiswa();

            Console.Clear();
            Console.WriteLine("Tambah Data Mahasiswa\n");

            Console.Write("NIM : ");
            mhs.NIM =  Console.ReadLine();

            Console.Write("Nama : ");
            mhs.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P] : ");
            mhs.Gender = Console.ReadLine() == "L" ? "Laki-Laki" : "Perempuan";

            Console.Write("IPK  : ");
            mhs.IPK = Console.ReadLine();

            list.Add(mhs);
            

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            int no = 0;

            foreach(Mahasiswa mhs in list)
            {
                Console.WriteLine($"{++no}.{mhs.NIM},{mhs.Nama}, {mhs.Gender}, {mhs.IPK}");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
