using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Dosen
    {
        private int id;
        private string Nama { get; set; }
        private int NIK { get; set; }
        private string gender { get; set; }
        private string course { get; set; }

        public Dosen()
        {
            this.id = 1;
            this.Nama = "Dosen Pengampu";
            this.NIK = 123456789;
            this.gender = "Male";
            this.course = "Pemrograman berorientasi Objek";  

        }

        public void attDosen(string nama, int nik)
        {
            this.Nama = nama;
            this.NIK = nik;
        }

        public void AddCOurse(string course)
        {
            this.course +=  ", " + course;
        }

        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nama: " + Nama);
            Console.WriteLine("NIK: " + NIK);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Course: " + course);
        }
    }
}
