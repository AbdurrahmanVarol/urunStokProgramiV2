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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }
        DolapManager _dolapManager = new DolapManager();
        RafManager _rafManager = new RafManager();
        KutuManager _kutuManager = new KutuManager();
        BolmeManager _bolmeManager = new BolmeManager();
        KategoriManager _kategoriManager = new KategoriManager();
        UrunManager _urunManager = new UrunManager();
        UrunKutuManager _urunKutuManager = new UrunKutuManager();
        List<Raf> _rafs = new List<Raf>();
        List<Urun> _uruns = new List<Urun>();
        List<UrunKutu> _urunKutus = new List<UrunKutu>();
        List<Bolme> _bolmes = new List<Bolme>();
        List<Kutu> _kutus = new List<Kutu>();

        private void frmDelete_Load(object sender, EventArgs e)
        {
            LoadDolap();
            LoadKutu();            
        }
        private void LoadDolap()
        {
            cbxDolap.Items.Clear();
            List<Dolap> dolaps = new List<Dolap>();
            dolaps = _dolapManager.GetAll();
            foreach (Dolap dolap in dolaps)
            {
                cbxDolap.Items.Add(dolap.DolapAd);
                cbxDolap2.Items.Add(dolap.DolapAd);
            }
        }
        private void LoadRaf()
        {
            cbxRaf.Items.Clear();
            List<Raf> rafs = new List<Raf>();
            rafs = _rafManager.GetAll("DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap2.Text + "'").DolapId);
            foreach (Raf raf in rafs)
            {               
                    cbxRaf.Items.Add(raf.RafAd);
            }
        }
        private void LoadBolme()
        {
            cbxBolme.Items.Clear();
            List<Bolme> bolmes = new List<Bolme>();
            bolmes = _bolmeManager.GetAll("KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu2.Text + "'").KutuId.ToString());
            foreach (Bolme bolme in bolmes)
            {
                cbxBolme.Items.Add(bolme.BolmeAd);
            }
        }
        private void LoadKutu()
        {
            cbxKutu2.Items.Clear();
            List<Kutu> kutus = new List<Kutu>();
            kutus = _kutuManager.GetAll();
            foreach (Kutu kutu in kutus)
            {
                cbxKutu.Items.Add(kutu.KutuAd);
                cbxKutu2.Items.Add(kutu.KutuAd);
            }
        }

        private void cbxDolap2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRaf();
        }

        private void cbxKutu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBolme();
        }

        private void btnDolapSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dolap silme işleminde dolabın içerisindeki raflar, kutular, ve ürünler de silinir.\n Emin misiniz ?", "Dolap Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _rafs.Clear();
                _rafs = _rafManager.GetAll("DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId.ToString());
                foreach (Raf raf in _rafs)
                {
                    _uruns.Clear();
                    _uruns = _urunManager.GetAll("RafId=" + raf.RafId.ToString());
                    foreach (Urun urun in _uruns)
                    {
                        _urunManager.Delete(urun.UrunId);
                    }
                    _kutus.Clear();
                    _kutus = _kutuManager.GetAll("RafId=" + raf.RafId.ToString());
                    foreach (Kutu kutu in _kutus)
                    {
                        _bolmes.Clear();
                        _bolmes = _bolmeManager.GetAll("KutuId=" + kutu.KutuId.ToString());
                        foreach (Bolme bolme in _bolmes)
                        {
                            _urunKutus.Clear();
                            _urunKutus = _urunKutuManager.GetAll("BolmeId=" + bolme.BolmeId.ToString());
                            foreach (UrunKutu urunKutu in _urunKutus)
                            {
                                _urunKutuManager.Delete(urunKutu.UrunId);
                            }
                            _bolmeManager.Delete(bolme.BolmeId);
                        }
                        _kutuManager.Delete(kutu.KutuId);
                    }
                    _rafManager.Delete(raf.RafId);
                }
                _dolapManager.Delete(_dolapManager.Get("DolapAd='" + cbxDolap.Text + "'").DolapId);
            }
        }

        private void btnRafSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Raf silme işleminde rafın içerisindeki kutular, ve ürünler de silinir.\n Emin misiniz ?", "Raf Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _uruns.Clear();
                _uruns = _urunManager.GetAll("RafId=" + _rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap2.Text + "'").DolapId.ToString()).RafId.ToString());
                foreach (Urun urun in _uruns)
                {
                    _urunManager.Delete(urun.UrunId);
                }
                _kutus.Clear();
                _kutus = _kutuManager.GetAll("RafId=" + _rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap2.Text + "'").DolapId.ToString()).RafId.ToString());
                foreach (Kutu kutu in _kutus)
                {
                    _bolmes.Clear();
                    _bolmes = _bolmeManager.GetAll("KutuId=" + kutu.KutuId.ToString());
                    foreach (Bolme bolme in _bolmes)
                    {
                        _urunKutus.Clear();
                        _urunKutus = _urunKutuManager.GetAll("BolmeId=" + bolme.BolmeId.ToString());
                        foreach (UrunKutu urunKutu in _urunKutus)
                        {
                            _urunKutuManager.Delete(urunKutu.UrunId);
                        }
                        _bolmeManager.Delete(bolme.BolmeId);
                    }
                    _kutuManager.Delete(kutu.KutuId);
                }
                _rafManager.Delete(_rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap2.Text + "'").DolapId.ToString()).RafId);
            }               
        }

        private void btnKutuSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kutu silme işleminde kutunun içerisindeki ürünler de silinir.\n Emin misiniz ?", "Kutu Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _bolmes.Clear();
                _bolmes = _bolmeManager.GetAll("KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu2.Text + "'").KutuId.ToString());
                foreach (Bolme bolme in _bolmes)
                {
                    _urunKutus.Clear();
                    _urunKutus = _urunKutuManager.GetAll("BolmeId=" + bolme.BolmeId.ToString());
                    foreach (UrunKutu urunKutu in _urunKutus)
                    {
                        _urunKutuManager.Delete(urunKutu.UrunId);
                    }
                    _bolmeManager.Delete(bolme.BolmeId);
                }
                _kutuManager.Delete(_kutuManager.Get("KutuAd='" + cbxKutu.Text + "'").KutuId);
            }                
        }

        private void btnBolmeSil_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bölme silme işleminde bölmenin içerisindeki ürünler de silinir.\n Emin misiniz ?", "Bölme Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _urunKutus.Clear();
                _urunKutus = _urunKutuManager.GetAll("BolmeId="
                    + _bolmeManager.Get("BolmeAd='" + cbxBolme.Text + "' and KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu2.Text + "'").KutuId.ToString()).BolmeId.ToString());
                foreach (UrunKutu urunKutu in _urunKutus)
                {
                    _urunKutuManager.Delete(urunKutu.UrunId);
                }
                _bolmeManager.Delete(_bolmeManager.Get("BolmeAd='" + cbxBolme.Text + "' and KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutu2.Text + "'").KutuId.ToString()).BolmeId);
            }
              
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {

        }
    }
}
