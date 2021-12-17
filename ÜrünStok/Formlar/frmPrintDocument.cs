using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÜrünStok.Business;
using ÜrünStok.Entities;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using GemBox.Spreadsheet;

namespace ÜrünStok.Formlar
{
    public partial class frmPrintDocument : Form
    {
        public frmPrintDocument()
        {
            InitializeComponent();
        }
        UrunListeManager _urunListeManager = new UrunListeManager();    
        
        private void frmPrintDocument_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Ürün Id", 150);
            listView1.Columns.Add("Kategori Id", 150);
            listView1.Columns.Add("Konum", 150);
            listView1.Columns.Add("Ürün Ad", 150);
            listView1.Columns.Add("Dolap", 150);
            listView1.Columns.Add("Raf Id", 150);
            listView1.Columns.Add("Durum Id", 150);
            listView1.Columns.Add("Ürün Adet", 50);
            listView1.Columns.Add("Stok", 50);
            Listele();

        }
        private void Listele()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("Urun");
            foreach (UrunListe urun in uruns)
            {
                string[] bilgiler =
                    {
                        urun.UrunId.ToString(),
                        urun.KategoriAd,
                        urun.KonumAd,
                        urun.UrunAd,
                        urun.DolapAd,
                        urun.RafAd,
                        "-",
                        "-",
                        urun.DurumAd,
                        urun.UrunAdet.ToString(),
                        urun.StokMiktari.ToString()
                    };
                ListViewItem item = new ListViewItem(bilgiler);
                listView1.Items.Add(item);
                if (urun.UrunAdet > urun.StokMiktari)
                {
                    item.BackColor = Color.FromArgb(68, 189, 50);
                    item.ForeColor = Color.White;
                }

                if (urun.UrunAdet < urun.StokMiktari)
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
            }

            uruns.Clear();
            uruns = _urunListeManager.GetAll("UrunKutu");
            foreach (UrunListe urun in uruns)
            {
                string[] bilgiler =
                    {
                        urun.UrunId.ToString(),
                        urun.KategoriAd,
                        urun.KonumAd,
                        urun.UrunAd,
                        urun.DolapAd,
                        urun.RafAd,
                        urun.Kutu,
                        urun.Bolme,
                        urun.DurumAd,
                        urun.UrunAdet.ToString(),
                        urun.StokMiktari.ToString()
                    };
                ListViewItem item = new ListViewItem(bilgiler);
                listView1.Items.Add(item);
                if (urun.UrunAdet > urun.StokMiktari)
                {
                    item.BackColor = Color.FromArgb(68, 189, 50);
                    item.ForeColor = Color.White;
                }

                if (urun.UrunAdet < urun.StokMiktari)
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void PrintToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
                
                Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;
                int i = 2;
                int j = 1;
                ws.Cells[1, 1] = "Ürün Id";
                ws.Cells[1, 2] = "Kategori";
                ws.Cells[1, 3] = "Konum";
                ws.Cells[1, 4] = "Ürün Ad";
                ws.Cells[1, 5] = "Dolap";
                ws.Cells[1, 6] = "Raf";
                ws.Cells[1, 7] = "Durum";
                ws.Cells[1, 8] = "Adet";
                ws.Cells[1, 9] = "Stok";
                foreach (ListViewItem item in listView1.Items)
                {
                    ws.Cells[i, j] = item.Text.ToString();
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {
                        ws.Cells[i, j] = subitem.Text.ToString();
                        j++;
                    }
                    j = 1;
                    i++;
                }
                xla.Visible = true;
                
                ws.PrintPreview();
                
               

            }
            catch (System.Runtime.InteropServices.COMException e)
            {

            }
           
        }   

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintToExcel();
        }
    }
}
