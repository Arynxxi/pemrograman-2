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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MenuControl MC = new MenuControl();

        public void setDatagridview(DataGridView DG)
        {
            DG.DataSource = MC.showMenu();

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Harga";
            DG.Columns[3].HeaderText = "Deskripsi";
            DG.Columns[4].HeaderText = "Kategori";

            DG.Columns[0].Width = 50;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 75;
            DG.Columns[3].Width = 150;
            DG.Columns[4].Width = 80;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setDatagridview(this.dataGridView1);
            uC_Menu1.Visible = false;
        }

        private void TxtCari_TextChanged(object sender, EventArgs e)
        {
            searchDatagridView(dataGridView1, TxtCari.Text);
        }

        public void searchDatagridView(DataGridView DG, string keyword)
        {
            DG.DataSource = MC.searchMenu(keyword);

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Harga";
            DG.Columns[3].HeaderText = "Deskripsi";
            DG.Columns[4].HeaderText = "Kategori";


            DG.Columns[0].Width = 50;
            DG.Columns[1].Width = 100;
            DG.Columns[2].Width = 75;
            DG.Columns[3].Width = 150;
            DG.Columns[4].Width = 80;
        }

        private void disable()
        {
            TxtCari.Enabled = false;
            dataGridView1.Enabled = false;
            btnTambah.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            btnBatal.Enabled = false;
        }

        public void Enable()
        {
            TxtCari.Enabled = true;
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;

            setDatagridview(this.dataGridView1);
            dataGridView1.Rows[0].Selected = true;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Menu1.setFlag(1);
            uC_Menu1.Visible = true;
            disable();
        }

        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void Pencarian_Enter(object sender, EventArgs e)
        {

        }

        public void EnableEdit()
        {
            TxtCari.Enabled = true;
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            btnBatal.Enabled = true;

            setDatagridview(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }
    }
}
