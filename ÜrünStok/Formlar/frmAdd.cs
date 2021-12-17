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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }
        DolapManager _dolapManager = new DolapManager();
        RafManager _rafManager = new RafManager();
        KutuManager _kutuManager = new KutuManager();
        BolmeManager _bolmeManager = new BolmeManager();
        KategoriManager _kategoriManager = new KategoriManager();
        private void frmAdd_Load(object sender, EventArgs e)
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
        private void LoadKutu()
        {
            cbxKutuAd.Items.Clear();
            List<Kutu> kutus = new List<Kutu>();
            kutus = _kutuManager.GetAll();
            foreach (Kutu kutu in kutus)
            {
                cbxKutuAd.Items.Add(kutu.KutuAd);
            }
        }


        private void btnDolapEkle_Click(object sender, EventArgs e)
        {
            Dolap dolap = new Dolap
            {
                DolapAd = tbxDolapAd.Texts
            };
            _dolapManager.Add(dolap);
            MessageBox.Show(tbxDolapAd.Texts + " Eklendi.");
            tbxDolapAd.Texts = "";
            LoadDolap();
        }

        private void btnRafEkle_Click(object sender, EventArgs e)
        {
            Dolap dolap = new Dolap();
            dolap = _dolapManager.Get("DolapAd='" + cbxDolap.Text + "'");
            List<Raf> rafs = new List<Raf>();
            rafs = _rafManager.GetAll("DolapId=" + dolap.DolapId.ToString());
            for (int i = rafs.Count + 1; i <= rafs.Count + Convert.ToInt32(tbxRaf.Texts); i++)
            {
                Raf raf = new Raf
                {
                    DolapId = dolap.DolapId,
                    RafAd = "Raf " + i.ToString()
                };
                _rafManager.Add(raf);
            }
            MessageBox.Show(dolap.DolapAd + " Adlı dolaba " + tbxRaf.Texts + " tane raf eklendi.");
            tbxRaf.Texts = "";
            LoadDolap();

        }

        private void btnKutuEkle_Click(object sender, EventArgs e)
        {
            Kutu kutu = new Kutu
            {
                RafId = _rafManager.Get("RafAd='" + cbxRaf.Text + "' and DolapId=" + _dolapManager.Get("DolapAd='" + cbxDolap2.Text + "'").DolapId).RafId,
                KutuAd = tbxKutuAd.Texts
            };
            _kutuManager.Add(kutu);
            MessageBox.Show(kutu.KutuAd + " Adlı kutu eklendi.");
            LoadKutu();
        }
        private void btnBolmeEkle_Click(object sender, EventArgs e)
        {
            List<Bolme> bolmes = new List<Bolme>();
            bolmes = _bolmeManager.GetAll("KutuId=" + _kutuManager.Get("KutuAd='" + cbxKutuAd.Text + "'").KutuId.ToString());
            for (int i = bolmes.Count + 1; i <= bolmes.Count + Convert.ToInt32(tbxBolme.Texts); i++)
            {
                Bolme bolme = new Bolme
                {
                    KutuId = _kutuManager.Get("KutuAd='" + cbxKutuAd.Text + "'").KutuId,
                    BolmeAd = "Bölme " + i.ToString()
                };
                _bolmeManager.Add(bolme);
            }
            MessageBox.Show(cbxKutuAd.Text + " Adlı dolaba " + tbxBolme.Texts + " tane raf eklendi.");
            tbxRaf.Texts = "";
            LoadKutu();
        }

        private void cbxDolap2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRaf();
        }

        private void btnAddKategori_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori
            {
                KategoriAd = tbxKategori.Texts
            };
            _kategoriManager.Add(kategori);
        }        
    }
}

