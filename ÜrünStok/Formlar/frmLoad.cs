using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÜrünStok.Formlar
{
    public partial class frmLoad : Form
    {
        public frmLoad()
        {
            InitializeComponent();
        }
        public static frmLogin _frmLogin = new frmLogin();
        private void frmLoad_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Width +=75;

            if (panel2.Width >= 750)
            {
                timer2.Stop();                
                
                _frmLogin.Show();
                this.Hide();
            }
        }

        
    }
}
