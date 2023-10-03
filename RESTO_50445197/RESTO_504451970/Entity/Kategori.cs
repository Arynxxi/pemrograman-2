using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTO_504451970.Entity
{
    class Kategori
    {
        string nama, deskripsi;

        public Kategori(string nama, string deskripsi )
        {
            this.nama = nama;
            this.deskripsi = deskripsi;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Deskripsi
        {
            get { return deskripsi; }
            set { deskripsi = value; }
        }
    }
}
