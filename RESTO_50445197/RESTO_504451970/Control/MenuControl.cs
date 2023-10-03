using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTO_504451970.dsRestoTableAdapters;
using System.Data;
using RESTO_504451970.Entity;

namespace RESTO_504451970.Control
{
    class MenuControl
    {
        private TBL_MENUTableAdapter TM = new TBL_MENUTableAdapter();
        private TBL_KATEGORITableAdapter TK = new TBL_KATEGORITableAdapter();

        public DataTable showMenu()
        {
            return TM.GetData();
        }

        public DataTable searchMenu(string keyword)
        {
            return TM.GetDataBy(keyword);
        }

        public void addMenu(Menu M)
        {
            TM.InsetMenu(M.Nama, M.Harga, M.Deskrirpsi, M.Kategori);
        }

        public DataTable getKategori()
        {
            return TK.GetData();

        }

        public int getIdKategori(string ketegori)
        {
            return TK.GetIdkategori(ketegori).Value;
        }

        public void editMenu(Menu M, int idMenu)
        {
            TM.UpdateMenu(M.Nama, M.Harga, M.Deskrirpsi, M.Kategori, idMenu);
        }
    }
}
