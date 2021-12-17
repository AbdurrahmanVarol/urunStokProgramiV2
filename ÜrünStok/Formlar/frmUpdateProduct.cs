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
    public partial class frmUpdateProduct : Form
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
        }
        DolapManager _dolapManager = new DolapManager();
        RafManager _rafManager = new RafManager();
        KategoriManager _kategoriManager = new KategoriManager();
        DurumManager _durumManager = new DurumManager();
        UrunManager _urunManager = new UrunManager();
        UrunListeManager _urunListeManager = new UrunListeManager();
        UrunKutuManager _urunKutuManager = new UrunKutuManager();
        LogManager _logManager = new LogManager();
        KutuManager _kutuManager = new KutuManager();
        BolmeManager _bolmeManager = new BolmeManager();
        List<Kategori> _kategoris = new List<Kategori>();
        List<Dolap> _dolaps = new List<Dolap>();
        List<Raf> _rafs = new List<Raf>();
        List<Durum> _durums = new List<Durum>();
        List<Kutu> _kutus = new List<Kutu>();
        List<Bolme> _bolmes = new List<Bolme>();
        int i = 0;

        private void frmUpdateProduct_Load(object sender, EventArgs e)
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
            LoadDurum();
            LoadKategori();
        }
        private void LoadKutu()
        {
            cbxKutu.Items.Clear();
            cbxKutu.Items.Add("-");
            _kutus = _kutuManager.GetAll();
            foreach (Kutu kutu in _kutus)
            {
                cbxKutu.Items.Add(kutu.KutuAd);
            }
        }
        private void LoadBolme()
        {
            cbxBolme.Items.Clear();
            cbxBolme.Items.Add("-");
            if(cbxKutu.Text != "-")
            _bolmes = _bolmeManager.GetAll("KutuId=" + _kutuManager.Get("KutuAd='"+ cbxKutu.Text + "'").KutuId.ToString());
            foreach(Bolme bolme in _bolmes)
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
        public void LoadKategori()
        {
            cbxKategori.Items.Clear();
            _kategoris = _kategoriManager.GetAll();
            foreach (Kategori kategori in _kategoris)
            {
                cbxKategori.Items.Add(kategori.KategoriAd);
            }
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
        private void LoadRaf()
        {
            cbxRaf.Items.Clear();
            _rafs = _rafManager.GetAll("DolapId=" +_dolapManager.Get("DolapAd='" +cbxDolap.Text+ "'").DolapId.ToString()) ;
            foreach (Raf raf in _rafs)
            {
                cbxRaf.Items.Add(raf.RafAd);
            }
        }
        private void LoadDurum()
        {
            cbxDurum.Items.Clear();
            _durums = _durumManager.GetAll();
            foreach (Durum durum in _durums)
            {
                cbxDurum.Items.Add(durum.DurumAd);
            }
        }
        private void cbxDolap_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRaf();
        }        
        private void cbxKutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBolme();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                LoadKategori();
                LoadDurum();
                LoadDolap();
                LoadKutu();
                cbxKategori.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbxUrunAd.Texts = string.Empty;
                tbxUrunAd.Texts = listView1.SelectedItems[0].SubItems[3].Text;
                cbxDolap.Text = listView1.SelectedItems[0].SubItems[4].Text;
                cbxRaf.Text = listView1.SelectedItems[0].SubItems[5].Text;
                cbxKutu.Text = listView1.SelectedItems[0].SubItems[6].Text;
                cbxBolme.Text = listView1.SelectedItems[0].SubItems[7].Text;
                cbxDurum.Text = listView1.SelectedItems[0].SubItems[8].Text;
            }        
        }
        private void btnAdetArttır_Click(object sender, EventArgs e)
        {
            try
            {
                if(listView1.SelectedItems.Count == 1)
                {
                    i = 0;
                    var row = listView1.SelectedItems[0].SubItems;
                    if (string.IsNullOrEmpty(cbxBolme.Text) || string.IsNullOrEmpty(cbxKutu.Text) || cbxKutu.Text == "-")
                    {
                        if(listView1.SelectedItems[0].SubItems[5].Text == "-")
                        {
                            Urun urun = new Urun
                            {
                                UrunId = Convert.ToInt32(row[0].Text),
                                KategoriId = _kategoriManager.Get("KategoriAd='" + cbxKategori.Text + "'").KategoriId,
                                KonumId = 1,
                                UrunAd = tbxUrunAd.Texts,
                                DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                                RafId = _rafManager.Get("DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId.ToString() + " and RafAd='" + cbxRaf.Text + "'").RafId,
                                UrunAdet = Convert.ToInt32(row[9].Text),
                                StokMiktari = Convert.ToInt32(row[10].Text)
                            };
                            _urunManager.Update(urun);
                            Timer timer = new Timer();
                            timer.Start();
                            Log log = new Log
                            {
                                UrunId = urun.UrunId,
                                UrunAd = urun.UrunAd,
                                KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                                YetkiId = frmLogin._kullanici.KullaniciYetki,
                                Islem = "Ürün bilgileri değiştirildi.",
                                Tarih = DateTime.Now.ToString()
                            };
                            timer.Stop();
                            _logManager.Add(log);
                            MessageBox.Show("Ürün güncellendi.");
                        }
                        else
                        {
                            Urun urun = new Urun
                            {                               
                                KategoriId = _kategoriManager.Get("KategoriAd='" + cbxKategori.Text + "'").KategoriId,
                                KonumId = 1,
                                UrunAd = tbxUrunAd.Texts,
                                DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                                RafId = _rafManager.Get("DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId.ToString() + " and RafAd='" + cbxRaf.Text + "'").RafId,
                                UrunAdet = Convert.ToInt32(row[9].Text),
                                StokMiktari = Convert.ToInt32(row[10].Text)
                            };
                            _urunKutuManager.Delete(Convert.ToInt32(row[0].Text));
                            _urunManager.Add(urun);
                            Timer timer = new Timer();
                            timer.Start();
                            Log log = new Log
                            {
                                UrunId = urun.UrunId,
                                UrunAd = urun.UrunAd,
                                KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                                YetkiId = frmLogin._kullanici.KullaniciYetki,
                                Islem = "Ürün bilgileri değiştirildi.",
                                Tarih = DateTime.Now.ToString()
                            };
                            timer.Stop();
                            _logManager.Add(log);
                            MessageBox.Show("Ürün güncellendi.");
                        }                        
                    }
                    else
                    {
                        if (listView1.SelectedItems[0].SubItems[5].Text == "-")
                        {
                            UrunKutu urun = new UrunKutu
                            {
                                KategoriId = _kategoriManager.Get("KategoriAd='" + cbxKategori.Text + "'").KategoriId,
                                KonumId = 1,
                                UrunAd = tbxUrunAd.Texts,
                                DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                                BolmeId = _bolmeManager.Get("BolmeAd='" + cbxBolme.Text + "' and KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu.Text + "'").KutuId.ToString()).BolmeId,
                                UrunAdet = Convert.ToInt32(row[9].Text),
                                StokMiktari = Convert.ToInt32(row[10].Text)
                            };
                            _urunManager.Delete(Convert.ToInt32(row[0].Text));
                            _urunKutuManager.Add(urun);

                            Timer timer = new Timer();
                            timer.Start();
                            Log log = new Log
                            {
                                UrunId = urun.UrunId,
                                UrunAd = urun.UrunAd,
                                KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                                YetkiId = frmLogin._kullanici.KullaniciYetki,
                                Islem = "Ürün bilgileri değiştirildi.",
                                Tarih = DateTime.Now.ToString()
                            };
                            timer.Stop();
                            _logManager.Add(log);
                            MessageBox.Show("Ürün güncellendi.");
                        }
                        else
                        {
                            UrunKutu urun = new UrunKutu
                            {
                                UrunId = Convert.ToInt32(row[0].Text),
                                KonumId = 1,
                                UrunAd = tbxUrunAd.Texts,
                                DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                                BolmeId = _bolmeManager.Get("BolmeAd='" + cbxBolme.Text + "' and KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu.Text + "'").KutuId.ToString()).BolmeId,
                                UrunAdet = Convert.ToInt32(row[9].Text),
                                StokMiktari = Convert.ToInt32(row[10].Text)
                            };
                            _urunKutuManager.Update(urun);
                            Timer timer = new Timer();
                            timer.Start();
                            Log log = new Log
                            {
                                UrunId = urun.UrunId,
                                UrunAd = urun.UrunAd,
                                KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                                YetkiId = frmLogin._kullanici.KullaniciYetki,
                                Islem = "Ürün bilgileri değiştirildi.",
                                Tarih = DateTime.Now.ToString()
                            };
                            timer.Stop();
                            _logManager.Add(log);
                            MessageBox.Show("Ürün güncellendi.");
                        }                           
                    }
                    listView1.SelectedItems[0].Selected = false;
                    LoadDolap();
                    cbxRaf.Items.Clear();
                    LoadDurum();
                    LoadKategori();
                    LoadKutu();
                    tbxUrunAd.Texts = string.Empty;
                    Listele();
                }
            }
            catch (Exception)
            {              
            }
        }       
    }   
}