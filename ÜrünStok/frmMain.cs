using FontAwesome.Sharp;
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
using ÜrünStok.Formlar;

namespace ÜrünStok
{
    public partial class frmMain : Form
    {
        
        private IconButton currentBtn;
        private IconButton currentSubBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private bool isShow=false;
        LogManager _logManager = new LogManager();

        public frmMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                hideSubMenu();
                leftBorderBtn.Visible = false;
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void ActivateButton(object senderBtn, Color color, Panel subMenu)
        {
            if (senderBtn != null)
            {

                if (subMenu.Visible == true)
                {
                    DisableButton();
                    hideSubMenu();
                    leftBorderBtn.Visible = false;
                }
                else
                {
                    //Button
                    DisableButton();
                    hideSubMenu();
                    leftBorderBtn.Visible = false;
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                    showSubMenu(subMenu);
                    //DisableButton();

                }
            }
        }
        private void ActivateSubButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //Button
                DisableSubButton();
                currentSubBtn = (IconButton)senderBtn;
                currentSubBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentSubBtn.ForeColor = color;
                //DisableButton();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                leftBorderBtn.Visible = false;
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                DisableSubButton();
                //hideSubMenu();
            }
        }
        private void DisableSubButton()
        {
            if (currentSubBtn != null)
            {
                currentSubBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentSubBtn.ForeColor = Color.Gainsboro;
                currentSubBtn.TextAlign = ContentAlignment.MiddleLeft;
                //hideSubMenu();
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Reset()
        {
            DisableButton();

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            leftBorderBtn.Visible = false;  
        }
        private void hideSubMenu()
        {
            List<Panel> panels = new List<Panel>();
            //panels.Add(ListeleSubMenu);
            panels.Add(EkleSubMenu);
            panels.Add(SilSubMenu);
            foreach (Panel panel in panels)
            {
                if (panel.Visible == true)
                    panel.Visible = false;
            }

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;

            }
            else
                subMenu.Visible = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = FormBorderStyle.None;
            }
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableSubButton();         
            DisableButton();
            if (panelMenu.Visible)
            {
                isShow = false;                
                timer.Start();
            }
            else
            {
                panelMenu.Show();
                isShow = true;
                timer.Start();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (isShow)
            {
                if (panelMenu.Width >= 200)
                    timer.Stop();
                else
                    panelMenu.Width += 100;
            }
            else
            {
                if (panelMenu.Width <= 0)
                {
                    timer.Stop();
                    panelMenu.Hide();
                }
                else
                    panelMenu.Width -= 100;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color1, EkleSubMenu);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color2, SilSubMenu);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Formlar.frmUpdateProduct());
        }
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Formlar.frmPrintDocument());
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateSubButton(sender, RGBColors.color1);
            OpenChildForm(new Formlar.frmIncrease());
        }

        private void StokAzalt_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateSubButton(sender, RGBColors.color2);
            OpenChildForm(new Formlar.frmDecrease());
        }

        private void DolapEkle_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateSubButton(sender, RGBColors.color1);
            OpenChildForm(new Formlar.frmAdd());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateSubButton(sender, RGBColors.color2);
            OpenChildForm(new Formlar.frmDelete());
        }
        private void brnUrunEkle_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateSubButton(sender, RGBColors.color1);
            OpenChildForm(new Formlar.frmAddProduct());
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableSubButton();
            DisableButton();
            OpenChildForm(new Formlar.frmLog());
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Formlar.frmSearch());
        }
        private void btnKullanicii_Click(object sender, EventArgs e)
        {
            DisableSubButton();
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Formlar.frmUser());
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableSubButton();
            Reset();
            Timer timer = new Timer();
            timer.Start();
            Log log = new Log
            {
                UrunId = 0,
                UrunAd = "-",
                KullaniciAd = frmLogin._kullanici.KullaniciAdi,
                YetkiId = frmLogin._kullanici.KullaniciYetki,
                Islem = " Çıkış yapıldı..",
                Tarih = DateTime.Now.ToString()
            };
            timer.Stop();
            _logManager.Add(log);      
            this.Hide();
            MessageBox.Show("Çıkış Yapıldı.");
            frmLoad._frmLogin.Show(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            DisableSubButton();
            Reset();
        }

       
    }
}
