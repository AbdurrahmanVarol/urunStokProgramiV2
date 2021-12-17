using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ÜrünStok.Business;
using ÜrünStok.Entities;

namespace ÜrünStok.Formlar
{
    public partial class frmLogin : Form
    {
        public static Kullanici _kullanici = new Kullanici();
        public static frmMain _mainForm = new frmMain();
        LogManager _logManager = new LogManager();
        public frmLogin()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _kullaniciManager = new KullaniciManager();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmLogin_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        KullaniciManager _kullaniciManager;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool login = false;
            List<Kullanici> kullanicis = new List<Kullanici>();
            kullanicis=_kullaniciManager.GetAll();
            foreach(Kullanici kullanici in kullanicis)
            {
                if(kullanici.KullaniciAdi == tbxUsername.Text && kullanici.KullaniciSifre == tbxPassword.Text)
                {
                    login = true;
                    MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                    _kullanici.KullaniciId = kullanici.KullaniciId;
                    _kullanici.KullaniciAdi = kullanici.KullaniciAdi;
                    _kullanici.KullaniciSifre = kullanici.KullaniciSifre;
                    _kullanici.KullaniciYetki = kullanici.KullaniciYetki;
                    
                    Timer timer = new Timer();
                    timer.Start();
                    Log log = new Log
                    {
                        UrunId = 0,
                        UrunAd = "-",
                        KullaniciAd = _kullanici.KullaniciAdi,
                        YetkiId = _kullanici.KullaniciYetki,
                        Islem = "Giriş yapıldı.",
                        Tarih = DateTime.Now.ToString()
                    };
                    timer.Stop();
                    _logManager.Add(log);

                    tbxUsername.Text = string.Empty;
                    tbxPassword.Text = string.Empty;
                    
                    _mainForm.Show();
                    this.Hide();
                }
            }
            if(login == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.\nLütfen tekrar deneyiniz.");
                tbxUsername.Text = "";
                tbxPassword.Text = "";
            }                
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
