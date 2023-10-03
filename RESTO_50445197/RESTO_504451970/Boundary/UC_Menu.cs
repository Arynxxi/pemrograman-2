using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTO_504451970.Control;

namespace RESTO_504451970
{
    public partial class UC_Menu : UserControl
    {

        MenuControl MC = new MenuControl();

        int flagperintah = 0;
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            Form1 myParent = (Form1)this.Parent;
            myParent.Enable();

        }

        public void setFlag(int flag)
        {
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            cmbKategori.DataSource = MC.getKategori();
            cmbKategori.DisplayMember = "nama_kategori";
        }

        private bool cektxt()
        {
            bool temp = true;

            if(txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan Isi Nama Barang");
                txtNama.Focus();
                temp = false;
            }

            if (txtDeskripsi.Text == "")
            {
                errorProvider1.SetError(txtDeskripsi, "Silahkan Isi Nama Deskripsi");
                txtDeskripsi.Focus();
                temp = false;
            }

            if (txtHarga.Text == "")
            {
                errorProvider1.SetError(txtHarga, "Silahkan Isi Nama Barang");
                txtHarga.Focus();
                temp = false;
            }

            if (cmbKategori.Text == "")
            {
                errorProvider1.SetError(cmbKategori, "Silahkan Isi Nama Barang");
                cmbKategori.Focus();
                temp = false;
            }

            return temp;
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cleartxt()
        {
            txtNama.Clear();
            txtHarga.Clear();
            txtDeskripsi.Clear();
            cmbKategori.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (flagperintah == 1)
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();

                    int IDKategori = MC.getIdKategori(cmbKategori.Text);
                    RESTO_504451970.Entity.Menu M = new Entity.Menu(txtNama.Text, txtDeskripsi.Text, double.Parse(txtHarga.Text), IDKategori);
                    MC.addMenu(M);
                    cleartxt();
                    this.Hide();
                    Form1 myParent = (Form1)this.Parent;
                    myParent.Enable();
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
