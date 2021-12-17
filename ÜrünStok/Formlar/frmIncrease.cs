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
    public partial class frmIncrease : Form
    {
        public frmIncrease()
        {
            InitializeComponent();
        }
        UrunManager _urunManager = new UrunManager();
        UrunKutuManager _urunKutuManager = new UrunKutuManager();
        KategoriManager _KategoriManager = new KategoriManager();
        DolapManager _dolapManager = new DolapManager();
        RafManager _rafManager = new RafManager();
        KutuManager _kutuManager = new KutuManager();
        BolmeManager _bolmeManager = new BolmeManager();
        DurumManager _durumManager = new DurumManager();
        UrunListeManager _urunListeManager = new UrunListeManager();
        LogManager _logManager = new LogManager();
        List<Dolap> _dolaps = new List<Dolap>();
        List<Raf> _rafs = new List<Raf>();
        List<Kutu> _kutus = new List<Kutu>();
        List<Bolme> _bolmes = new List<Bolme>();

        private void frmIncrease_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Ürün Id", 50);
            listView1.Columns.Add("Kategori", 100);
            listView1.Columns.Add("Konum", 50);
            listView1.Columns.Add("Ürün Ad", 150);
            listView1.Columns.Add("Dolap", 100);
            listView1.Columns.Add("Raf", 100);
            listView1.Columns.Add("Kutu", 100);
            listView1.Columns.Add("Bölme", 100);
            listView1.Columns.Add("Durum", 100);
            listView1.Columns.Add("Ürün Adet", 50);
            listView1.Columns.Add("Stok", 50);
            Listele();
            LoadDolap();
            LoadKutu();


        }
        private void LoadDolap()
        {
            cbxDolap.Items.Clear();
            _dolaps = _dolapManager.GetAll();
            foreach (Dolap dolap in _dolaps)
            {
                cbxDolap.Items.Add(dolap.DolapAd);
            }
        }
        private void LoadRaf(int dolapId)
        {
            cbxRaf.Items.Clear();
            _rafs = _rafManager.GetAll("DolapId=" + dolapId.ToString());
            foreach (Raf raf in _rafs)
            {
                cbxRaf.Items.Add(raf.RafAd);
            }
        }
        private void LoadKutu()
        {
            cbxKutu.Items.Clear();
            _kutus = _kutuManager.GetAll();
            foreach(Kutu kutu in _kutus)
            {
                cbxKutu.Items.Add(kutu.KutuAd);
            }
        }
        private void LoadBolme(int kutuId)
        {
            cbxBolme.Items.Clear();
            _bolmes = _bolmeManager.GetAll("KutuId=" + kutuId.ToString());
            foreach (Bolme bolme in _bolmes)
            {
                cbxBolme.Items.Add(bolme.BolmeAd);
            }
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
        private void ListByDolapName()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("Urun","DolapAd='" + cbxDolap.Text + "'");
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
            uruns = _urunListeManager.GetAll("UrunKutu","DolapAd='"+ cbxDolap.Text +"'");
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
        private void ListByRafName()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("Urun","DolapAd='" + cbxDolap.Text + "' and RafAd='" + cbxRaf.Text + "'");
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
            uruns = _urunListeManager.GetAll("UrunKutu", "DolapAd='" + cbxDolap.Text + "' and RafAd='" + cbxRaf.Text + "'");
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
        private void ListByKutuName()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("UrunKutu", "KutuAd='" + cbxKutu.Text + "'");
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
        private void ListByBolmeName()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("Urun", "KutuAd='" + cbxKutu.Text + "' and BolmeAd='" + cbxBolme.Text + "'");            
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
        private void ListByUrunName()
        {
            listView1.Items.Clear();
            List<UrunListe> uruns = new List<UrunListe>();
            uruns = _urunListeManager.GetAll("Urun","UrunAd like '%" + tbxUrunAd.Texts + "%'");
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
            uruns = _urunListeManager.GetAll("UrunKutu","UrunAd like '%" + tbxUrunAd.Texts + "%'");
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
        private void cbxDolap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRaf.Items.Clear();
            LoadRaf(_dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId);
            ListByDolapName();
        }
        private void cbxRaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListByRafName();
        }
        private void cbxKutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBolme.Items.Clear();
            LoadBolme(_kutuManager.Get("KutuAd='" + cbxKutu.Text + "'").KutuId);
            ListByKutuName();
        }
        private void cbxBolme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListByBolmeName();
        }
        private void tbxUrunAd__TextChanged(object sender, EventArgs e)
        {
            ListByUrunName();
        }

        private void btnAdetArttır_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (listView1.SelectedItems[0].SubItems[6].Text == "-")
                {
                    Urun urun = new Urun
                    {
                        UrunId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                        KategoriId = _KategoriManager.Get("KategoriAd='" + listView1.SelectedItems[0].SubItems[1].Text + "'").KategoriId,
                        KonumId = 1,
                        UrunAd = listView1.SelectedItems[0].SubItems[3].Text,
                        RafId = _rafManager.Get("RafAd='" + listView1.SelectedItems[0].SubItems[5].Text + "'").RafId,
                        DurumId = _durumManager.Get("DurumAd='" + listView1.SelectedItems[0].SubItems[8].Text + "'").DurumId,
                        UrunAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[9].Text) + Convert.ToInt32(tbxUrunAdet.Texts),
                        StokMiktari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[10].Text)
                    };
                    _urunManager.Update(urun);
                    MessageBox.Show(urun.UrunAd + " Adlı ürünün adet miktartı " + tbxUrunAdet.Texts + " kadar arttırıldı.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = urun.UrunId,
                        UrunAd = urun.UrunAd,
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = "Adet miktarı arttırıldı: " + tbxUrunAdet.Texts,
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
                else
                {
                    UrunKutu urun = new UrunKutu
                    {
                        UrunId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                        KategoriId = _KategoriManager.Get("KategoriAd='" + listView1.SelectedItems[0].SubItems[1].Text + "'").KategoriId,
                        KonumId = 1,
                        UrunAd = listView1.SelectedItems[0].SubItems[3].Text,
                        BolmeId = _bolmeManager.Get("BolmeAd ='" + listView1.SelectedItems[0].SubItems[7].Text + "' and KutuId = "
                        + _kutuManager.Get("KutuAd='" + listView1.SelectedItems[0].SubItems[6].Text + "'").KutuId.ToString()).BolmeId,
                        DurumId = _durumManager.Get("DurumAd='" + listView1.SelectedItems[0].SubItems[8].Text + "'").DurumId,
                        UrunAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[9].Text) + Convert.ToInt32(tbxUrunAdet.Texts),
                        StokMiktari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[10].Text)
                    };
                    _urunKutuManager.Update(urun);
                    MessageBox.Show(urun.UrunAd + " Adlı ürünün adet miktartı " + tbxUrunAdet.Texts + " kadar arttırıldı.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = urun.UrunId,
                        UrunAd = urun.UrunAd,
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = "Adet miktarı arttırıldı: " + tbxUrunAdet.Texts,
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
                Listele();
            }
        }

        private void btnStokArttır_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                if (listView1.SelectedItems[0].SubItems[6].Text == "-")
                {
                    Urun urun = new Urun
                    {
                        UrunId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                        KategoriId = _KategoriManager.Get("KategoriAd='" + listView1.SelectedItems[0].SubItems[1].Text + "'").KategoriId,
                        KonumId = 1,
                        UrunAd = listView1.SelectedItems[0].SubItems[3].Text,
                        RafId = _rafManager.Get("RafAd='" + listView1.SelectedItems[0].SubItems[5].Text + "'").RafId,
                        DurumId = _durumManager.Get("DurumAd='" + listView1.SelectedItems[0].SubItems[8].Text + "'").DurumId,
                        UrunAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[9].Text),
                        StokMiktari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[10].Text) + Convert.ToInt32(tbxUrunAdet.Texts)
                    };
                    _urunManager.Update(urun);
                    MessageBox.Show(urun.UrunAd + " Adlı ürünün adet miktartı " + tbxUrunAdet.Texts + " kadar arttırıldı.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = urun.UrunId,
                        UrunAd = urun.UrunAd,
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = "Adet miktarı arttırıldı: " + tbxUrunAdet.Texts,
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
                else
                {
                    UrunKutu urun = new UrunKutu
                    {
                        UrunId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text),
                        KategoriId = _KategoriManager.Get("KategoriAd='" + listView1.SelectedItems[0].SubItems[1].Text + "'").KategoriId,
                        KonumId = 1,
                        UrunAd = listView1.SelectedItems[0].SubItems[3].Text,
                        BolmeId = _bolmeManager.Get("BolmeAd ='" + listView1.SelectedItems[0].SubItems[7].Text + "' and KutuId = "
                        + _kutuManager.Get("KutuAd='" + listView1.SelectedItems[0].SubItems[6].Text + "'").KutuId.ToString()).BolmeId,
                        DurumId = _durumManager.Get("DurumAd='" + listView1.SelectedItems[0].SubItems[8].Text + "'").DurumId,
                        UrunAdet = Convert.ToInt32(listView1.SelectedItems[0].SubItems[9].Text),
                        StokMiktari = Convert.ToInt32(listView1.SelectedItems[0].SubItems[10].Text) + Convert.ToInt32(tbxUrunAdet.Texts)
                    };
                    _urunKutuManager.Update(urun);
                    MessageBox.Show(urun.UrunAd + " Adlı ürünün adet miktartı " + tbxUrunAdet.Texts + " kadar arttırıldı.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = urun.UrunId,
                        UrunAd = urun.UrunAd,
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = "Adet miktarı arttırıldı: " + tbxUrunAdet.Texts,
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                    Listele();
                }
            }
        }
        private void btnListAll_Click(object sender, EventArgs e)
        {
            Listele();
        }       
    }
}
