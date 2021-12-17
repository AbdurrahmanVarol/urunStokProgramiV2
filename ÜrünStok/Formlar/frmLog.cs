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

namespace ÜrünStok.Formlar
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
        LogManager _logManager = new LogManager();
        private void frmLog_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Log Id", 50);
            listView1.Columns.Add("Kullanıcı", 100);
            listView1.Columns.Add("Yetki", 150);
            listView1.Columns.Add("Ürün Id", 50);
            listView1.Columns.Add("Ürün Ad", 300);
            listView1.Columns.Add("İşlem", 300);
            listView1.Columns.Add("Tarih", 150);
            Listele();
        }
        private void Listele()
        {
            listView1.Items.Clear();
            List<Log> logs = new List<Log>();
            logs = _logManager.GetAll();
            foreach (Log log in logs)
            {
                string yetki = string.Empty;
                if (log.YetkiId == 1)
                    yetki = "Yönetici";
                else if (log.YetkiId == 2)
                    yetki = "Kullanıcı";
                else
                    yetki = "Misafir";
                string[] bilgiler =
                    {
                        log.LogId.ToString(),
                        log.KullaniciAd,
                        yetki,
                        log.UrunId.ToString(),
                        log.UrunAd,
                        log.Islem,
                        log.Tarih
                    };
                ListViewItem item = new ListViewItem(bilgiler);
                listView1.Items.Add(item);               
            }
        }

        private void btnLogDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Kayıt Silinecek.\n Emin misiniz ?", "Kayıt Silme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _logManager.Delete(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                    Listele();
                }                    
            }
            catch (Exception)
            {

            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintToExcel();
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
                ws.Cells[1, 1] = "Log Id";
                ws.Cells[1, 2] = "Kullanıcı";
                ws.Cells[1, 3] = "Yetki";
                ws.Cells[1, 4] = "Ürün Id";
                ws.Cells[1, 5] = "Ürün Ad";
                ws.Cells[1, 6] = "İşlem";
                ws.Cells[1, 7] = "Tarih";
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
    }
}
