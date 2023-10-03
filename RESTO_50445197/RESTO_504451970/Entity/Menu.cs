using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTO_504451970.Entity
{
    class Menu
    {
        string nama, deskripsi;
        double harga;
        int kategori;

        public Menu(string nama, string deskripsi, double harga, int kategori)
        {
            this.nama = nama;
            this.kategori = kategori;
            this.harga = harga;
            this.kategori = kategori;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Deskrirpsi
        {
            get { return deskripsi; }
            set { deskripsi = value; }
        }
        
        public double Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int Kategori
        {
            get { return kategori; }
            set { kategori = value; }
        }
    }

}
