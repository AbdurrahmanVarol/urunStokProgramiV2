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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        KullaniciManager _kullaniciManager = new KullaniciManager();
        LogManager _logManager = new LogManager();
        List<Kullanici> _kullanicis = new List<Kullanici>();
        private void frmUser_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Kullanıcı Id", 150);
            listView1.Columns.Add("Kullanıcı Adı", 150);
            listView1.Columns.Add("Kullanıcı Yetki", 150);
            Listele();
        }

        private void Listele()
        {
            listView1.Items.Clear();
            _kullanicis.Clear();
            _kullanicis = _kullaniciManager.GetAll();
            foreach (Kullanici kullanici in _kullanicis)
            {
                string[] bilgiler =
                    {
                        kullanici.KullaniciId.ToString(),
                        kullanici.KullaniciAdi,
                        kullanici.KullaniciYetki.ToString()
                    };
                ListViewItem item = new ListViewItem(bilgiler);
                listView1.Items.Add(item);
            }
            cbxUser.Items.Clear();
            cbxUser.Items.Add("Yönetici");
            cbxUser.Items.Add("Kullanıcı");
        }
        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUserName.Texts))
            {
                bool val = true;
                _kullanicis.Clear();
                _kullanicis = _kullaniciManager.GetAll();
                foreach (Kullanici kullanici1 in _kullanicis)
                {
                    if (kullanici1.KullaniciAdi == tbxUserName.Texts)
                        val = false;
                }
                if (val)
                {
                    Kullanici kullanici = new Kullanici
                    {
                        KullaniciAdi = tbxUserName.Texts,

                    };
                    if ((!string.IsNullOrEmpty(tbxPasswordc.Texts) && string.IsNullOrEmpty(tbxPasswordc2.Texts)) && tbxPassword.Texts == tbxPassword2.Texts)
                        kullanici.KullaniciSifre = tbxPassword.Texts;
                    if (cbxUser.Text == "Yönetici")
                        kullanici.KullaniciYetki = 1;
                    else
                        kullanici.KullaniciYetki = 2;
                    _kullaniciManager.Add(kullanici);
                    MessageBox.Show("Kullanıcı EKlendi.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = 0,
                        UrunAd = "-",
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = kullanici.KullaniciAdi + " Adlı kullanıcı Eklendi.",
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
                else
                    MessageBox.Show(tbxUserName.Texts + " Adında bir kullanıcı var.");

            }

            temizle();
            Listele();
        }

        private void temizle()
        {
            tbxPassword.Texts = string.Empty;
            tbxPassword2.Texts = string.Empty;
            tbxUserName.Texts = string.Empty;
            tbxPasswordc.Texts = string.Empty;
            tbxPasswordc2.Texts = string.Empty;
            cbxUser.Items.Clear();
            cbxUser.Items.Add("Yönetici");
            cbxUser.Items.Add("Kullanıcı");
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(tbxPasswordc.Texts) && !string.IsNullOrEmpty(tbxPasswordc2.Texts)) && tbxPasswordc.Texts == tbxPasswordc2.Texts)
            {
                if (frmLogin._kullanici.KullaniciSifre != tbxPassword.Texts)
                {
                    Kullanici kullanici = new Kullanici
                    {
                        KullaniciId = frmLogin._kullanici.KullaniciId,
                        KullaniciAdi = frmLogin._kullanici.KullaniciAdi,
                        KullaniciSifre = tbxPasswordc.Texts,
                        KullaniciYetki = (frmLogin._kullanici.KullaniciYetki)
                    };
                    _kullaniciManager.Update(kullanici);
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = 0,
                        UrunAd = "-",
                        KullaniciAd = kullanici.KullaniciAdi,
                        YetkiId = kullanici.KullaniciYetki,
                        Islem = "Şifre değiştirildi..",
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
                else
                    MessageBox.Show("Önceki şifreyle aynı olamaz.");
            }
            else
                MessageBox.Show("Lütfen şifreyi tekrar giriniz.");
            temizle();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (frmLogin._kullanici.KullaniciAdi != listView1.SelectedItems[0].SubItems[1].Text)
            {
                DialogResult dialogResult = MessageBox.Show("Kullanıcı Silinecek.\n Emin misiniz ?", "Kullanıcı Silme", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _kullaniciManager.Delete(Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Kullanıcı Silindi.");
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = 0,
                        UrunAd = "-",
                        KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                        YetkiId = frmLogin._kullanici.KullaniciYetki,
                        Islem = listView1.SelectedItems[0].SubItems[1].Text + " Adlı kullanıcı Eklendi.",
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);
                }
            }
            else
                MessageBox.Show("Giriş yaptığıınz kullanıcıyı silemezsiniz.");
            temizle();
            Listele();


        }
    }
}
