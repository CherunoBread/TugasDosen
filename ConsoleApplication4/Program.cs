using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            Console.WriteLine("Default Dosen Pengampu:");
            dosen.display();

            Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru:");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukkan Mata Kuliah Baru");
            dosen.AddCOurse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();
        }
    }
}