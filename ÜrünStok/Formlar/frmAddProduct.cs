using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÜrünStok.Business;
using ÜrünStok.Entities;

namespace ÜrünStok.Formlar
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        SqlConnection _baglanti = new SqlConnection("Data Source=DESKTOP-OTMDOAG\\SQLEXPRESS;Initial Catalog=UrunStokTakip;Integrated Security=True");
        DolapManager _dolapManager = new DolapManager();
        RafManager _rafManager = new RafManager();
        KategoriManager _kategoriManager = new KategoriManager();
        DurumManager _durumManager = new DurumManager();
        UrunManager _urunManager = new UrunManager();
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
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadKonum();
            LoadKaregori();
            LoadDurum();
        }
        private void LoadKonum()
        {
            cbxKonum.Items.Clear();
            if (_baglanti.State == ConnectionState.Open)
                _baglanti.Close();
            SqlDataReader reader;
            SqlCommand komut = new SqlCommand();
            komut.Connection = _baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select *from Konum";
            _baglanti.Open();
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                cbxKonum.Items.Add(reader["KonumAd"].ToString());
            }
            reader.Close();
            _baglanti.Close();
        }
        public void LoadKaregori()
        {
            cbxKategori.Items.Clear();            
            _kategoris = _kategoriManager.GetAll();
            foreach(Kategori kategori in _kategoris)
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
        private void LoadRaf(int dolapId)
        {
            cbxRaf.Items.Clear();
            _rafs = _rafManager.GetAll("DolapId=" + dolapId.ToString());
            foreach(Raf raf in _rafs)
            {
                cbxRaf.Items.Add(raf.RafAd);
            }
        }
        private void LoadDurum()
        {
            cbxDurum.Items.Clear();
            _durums = _durumManager.GetAll();
            foreach(Durum durum in _durums)
            {
                cbxDurum.Items.Add(durum.DurumAd);
            }
        }
        private void LoadKutu()
        {
            cbxKutu.Items.Clear();
            _kutus.Clear();
            _kutus = _kutuManager.GetAll("RafId=" + _rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId).RafId.ToString());
            foreach (Kutu kutu in _kutus)
            {
                cbxKutu.Items.Add(kutu.KutuAd);
            }
        }
        private void LoadBolme()
        {
            cbxBolme.Items.Clear();
            _bolmes.Clear();
            _bolmes = _bolmeManager.GetAll("KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu.Text + "'").KutuId);
            foreach (Bolme bolme in _bolmes)
            {
                cbxBolme.Items.Add(bolme.BolmeAd);
            }
        }
        private void cbxKonum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKonum.Text == "Ofis")
            {
                cbxDolap.Visible = true;
                lblDolap.Visible = true;
                LoadDolap();
            }
                
            if (cbxKonum.Text == "Hangar"|| cbxKonum.Text == "Saha")
            {
                cbxDolap.Visible = false;
                lblDolap.Visible = false;
            }
                
        }

        private void cbxDolap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxDolap.Text))
            {
                lblRaf.Visible = true;
                cbxRaf.Visible = true;
            }            
            Dolap dolap = new Dolap();
            dolap = _dolapManager.Get("DolapAd='"+cbxDolap.Text+"'");
            LoadRaf(dolap.DolapId);
        }
        private void temizle()
        {
            cbxDolap.Items.Clear();
            cbxDurum.Items.Clear();
            cbxKategori.Items.Clear();
            cbxKonum.Items.Clear();
            cbxRaf.Items.Clear();
            LoadKonum();
            LoadKaregori();
            LoadDurum();
            LoadDolap();
            tbxUrunAd.Texts = "";
            tbxUrunAdet.Texts = "";
            tbxUrunStok.Texts = "";
            lblKutu.Visible = false;
            cbxKutu.Visible = false;
            lblBolme.Visible = false;
            cbxBolme.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbxKutu.Text) || cbxKutu.Visible == false)
            {
                var dolapId = _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId;
                Urun urun = new Urun
                {
                    KategoriId = _kategoriManager.Get("KategoriAd='" + cbxKategori.Text + "'").KategoriId,
                    KonumId = 1,
                    DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                    RafId = _rafManager.Get("DolapId=" + dolapId.ToString() + "and RafAd='" + cbxRaf.Text + "'").RafId,
                    UrunAd = tbxUrunAd.Texts,
                    UrunAdet = Convert.ToInt32(tbxUrunAdet.Texts),
                    StokMiktari = Convert.ToInt32(tbxUrunStok.Texts)
                };
                _urunManager.Add(urun);
                Timer timer = new Timer();
                timer.Start();
                Log log = new Log
                {
                    UrunId = _urunManager.Get("KategoriId=" + urun.KategoriId.ToString() + "and KonumId=" + urun.KonumId.ToString() + "and DurumId=" + urun.DurumId.ToString() +
                    "and RafId=" + urun.RafId.ToString() + "and UrunAd='" + urun.UrunAd + "' and UrunAdet=" + urun.UrunAdet.ToString() + "and StokMiktari=" + urun.StokMiktari.ToString()).UrunId,
                    UrunAd = urun.UrunAd,
                    Islem = "Ürün eklendi.",
                    Tarih = DateTime.Now.ToString()
                };
                timer.Stop();
                _logManager.Add(log);
                MessageBox.Show(urun.UrunAd + " Adlı ürün eklendi.");
            }
            else
            {
                var dolapId = _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId;
                UrunKutu urunKutu = new UrunKutu() 
                {
                    KategoriId = _kategoriManager.Get("KategoriAd='" + cbxKategori.Text + "'").KategoriId,
                    KonumId = 1,
                    DurumId = _durumManager.Get("DurumAd='" + cbxDurum.Text + "'").DurumId,
                    BolmeId = _kutuManager.Get("KutuAd='"+cbxKutu.Text+"'").KutuId,
                    UrunAd = tbxUrunAd.Texts,
                    UrunAdet = Convert.ToInt32(tbxUrunAdet.Texts),
                    StokMiktari = Convert.ToInt32(tbxUrunStok.Texts)
                };
                bool deger =_urunKutuManager.Add(urunKutu);
                if(deger == true)
                {
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = _urunKutuManager.Get("KategoriId=" + urunKutu.KategoriId.ToString() + "and KonumId=" + urunKutu.KonumId.ToString() + "and DurumId=" + urunKutu.DurumId.ToString() +
                        "and KutuId=" + urunKutu.BolmeId.ToString() + "and UrunAd='" + urunKutu.UrunAd + "' and UrunAdet=" + urunKutu.UrunAdet.ToString() + "and StokMiktari=" + urunKutu.StokMiktari.ToString()).UrunId,
                        UrunAd = urunKutu.UrunAd,
                        Islem = "Ürün eklendi.",
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                    MessageBox.Show(urunKutu.UrunAd + " Adlı ürün eklendi.");
                }//kullanıcıya yetki mesağı business katmanında değil bu bloğun else kısmında verilebilir 
            }   
            temizle();
        }

        private void cbxRaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            _kutus.Clear();
            _kutus = _kutuManager.GetAll("RafId=" + _rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId).RafId.ToString()); 
            if (_kutus.Count != 0)
            {
                lblKutu.Visible = true;
                cbxKutu.Visible = true;
                lblBolme.Visible = true;
                cbxBolme.Visible = true;
                LoadKutu();
            }
            else
            {
                lblKutu.Visible = false;
                cbxKutu.Visible = false;
                lblBolme.Visible = false;
                cbxBolme.Visible = false;
            }
        }

        private void cbxKutu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBolme();
        }
    }
}
