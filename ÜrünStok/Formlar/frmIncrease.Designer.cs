
namespace ÜrünStok.Formlar
{
    partial class frmIncrease
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAdetArttır = new System.Windows.Forms.GroupBox();
            this.tbxUrunAdet = new ÜrünStok.CustomTools.cTextBox();
            this.btnAdetArttır = new ÜrünStok.CustomTools.cButton();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblBolme = new System.Windows.Forms.Label();
            this.lblKutu = new System.Windows.Forms.Label();
            this.gbxUrunAd = new System.Windows.Forms.GroupBox();
            this.tbxUrunAd = new ÜrünStok.CustomTools.cTextBox();
            this.gbxStokArttır = new System.Windows.Forms.GroupBox();
            this.tbxStokAdet = new ÜrünStok.CustomTools.cTextBox();
            this.btnStokArttır = new ÜrünStok.CustomTools.cButton();
            this.gbxKutuBolme = new System.Windows.Forms.GroupBox();
            this.lblRaf = new System.Windows.Forms.Label();
            this.lblDolap = new System.Windows.Forms.Label();
            this.cbxRaf = new System.Windows.Forms.ComboBox();
            this.cbxDolap = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbxDolapRaf = new System.Windows.Forms.GroupBox();
            this.btnListAll = new ÜrünStok.CustomTools.cButton();
            this.cbxBolme = new System.Windows.Forms.ComboBox();
            this.cbxKutu = new System.Windows.Forms.ComboBox();
            this.gbxAdetArttır.SuspendLayout();
            this.gbxUrunAd.SuspendLayout();
            this.gbxStokArttır.SuspendLayout();
            this.gbxKutuBolme.SuspendLayout();
            this.gbxDolapRaf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAdetArttır
            // 
            this.gbxAdetArttır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAdetArttır.Controls.Add(this.tbxUrunAdet);
            this.gbxAdetArttır.Controls.Add(this.btnAdetArttır);
            this.gbxAdetArttır.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxAdetArttır.Location = new System.Drawing.Point(26, 357);
            this.gbxAdetArttır.Name = "gbxAdetArttır";
            this.gbxAdetArttır.Size = new System.Drawing.Size(533, 101);
            this.gbxAdetArttır.TabIndex = 25;
            this.gbxAdetArttır.TabStop = false;
            this.gbxAdetArttır.Text = "Ürün Adet Arttır";
            // 
            // tbxUrunAdet
            // 
            this.tbxUrunAdet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUrunAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxUrunAdet.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxUrunAdet.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxUrunAdet.BorderRadius = 15;
            this.tbxUrunAdet.BorderSize = 2;
            this.tbxUrunAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAdet.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxUrunAdet.Location = new System.Drawing.Point(149, 18);
            this.tbxUrunAdet.Multiline = false;
            this.tbxUrunAdet.Name = "tbxUrunAdet";
            this.tbxUrunAdet.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAdet.PasswordChar = false;
            this.tbxUrunAdet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAdet.PlaceholderText = "Arttırılacak Miktar";
            this.tbxUrunAdet.Size = new System.Drawing.Size(194, 31);
            this.tbxUrunAdet.TabIndex = 4;
            this.tbxUrunAdet.Texts = "";
            this.tbxUrunAdet.UnderlinedStyle = false;
            // 
            // btnAdetArttır
            // 
            this.btnAdetArttır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdetArttır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetArttır.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetArttır.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAdetArttır.BorderRadius = 20;
            this.btnAdetArttır.BorderSize = 2;
            this.btnAdetArttır.FlatAppearance.BorderSize = 0;
            this.btnAdetArttır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdetArttır.ForeColor = System.Drawing.Color.White;
            this.btnAdetArttır.Location = new System.Drawing.Point(149, 55);
            this.btnAdetArttır.Name = "btnAdetArttır";
            this.btnAdetArttır.Size = new System.Drawing.Size(194, 40);
            this.btnAdetArttır.TabIndex = 18;
            this.btnAdetArttır.Text = "Adet Arttır";
            this.btnAdetArttır.TextColor = System.Drawing.Color.White;
            this.btnAdetArttır.UseVisualStyleBackColor = false;
            this.btnAdetArttır.Click += new System.EventHandler(this.btnAdetArttır_Click);
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUrunAd.Location = new System.Drawing.Point(58, 35);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAd.TabIndex = 3;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // lblBolme
            // 
            this.lblBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBolme.AutoSize = true;
            this.lblBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBolme.Location = new System.Drawing.Point(6, 50);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(42, 13);
            this.lblBolme.TabIndex = 3;
            this.lblBolme.Text = "Bölme: ";
            // 
            // lblKutu
            // 
            this.lblKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKutu.AutoSize = true;
            this.lblKutu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKutu.Location = new System.Drawing.Point(6, 27);
            this.lblKutu.Name = "lblKutu";
            this.lblKutu.Size = new System.Drawing.Size(35, 13);
            this.lblKutu.TabIndex = 2;
            this.lblKutu.Text = "Kutu: ";
            // 
            // gbxUrunAd
            // 
            this.gbxUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxUrunAd.Controls.Add(this.tbxUrunAd);
            this.gbxUrunAd.Controls.Add(this.lblUrunAd);
            this.gbxUrunAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxUrunAd.Location = new System.Drawing.Point(818, 12);
            this.gbxUrunAd.Name = "gbxUrunAd";
            this.gbxUrunAd.Size = new System.Drawing.Size(390, 79);
            this.gbxUrunAd.TabIndex = 22;
            this.gbxUrunAd.TabStop = false;
            this.gbxUrunAd.Text = "Ürün Adına Göre Listele";
            // 
            // tbxUrunAd
            // 
            this.tbxUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUrunAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxUrunAd.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxUrunAd.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxUrunAd.BorderRadius = 15;
            this.tbxUrunAd.BorderSize = 2;
            this.tbxUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxUrunAd.Location = new System.Drawing.Point(150, 27);
            this.tbxUrunAd.Multiline = false;
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAd.PasswordChar = false;
            this.tbxUrunAd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAd.PlaceholderText = "Ürün Adı";
            this.tbxUrunAd.Size = new System.Drawing.Size(194, 31);
            this.tbxUrunAd.TabIndex = 4;
            this.tbxUrunAd.Texts = "";
            this.tbxUrunAd.UnderlinedStyle = false;
            this.tbxUrunAd._TextChanged += new System.EventHandler(this.tbxUrunAd__TextChanged);
            // 
            // gbxStokArttır
            // 
            this.gbxStokArttır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxStokArttır.Controls.Add(this.tbxStokAdet);
            this.gbxStokArttır.Controls.Add(this.btnStokArttır);
            this.gbxStokArttır.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxStokArttır.Location = new System.Drawing.Point(675, 357);
            this.gbxStokArttır.Name = "gbxStokArttır";
            this.gbxStokArttır.Size = new System.Drawing.Size(533, 101);
            this.gbxStokArttır.TabIndex = 23;
            this.gbxStokArttır.TabStop = false;
            this.gbxStokArttır.Text = "Ürün Stok Arttır";
            // 
            // tbxStokAdet
            // 
            this.tbxStokAdet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxStokAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxStokAdet.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxStokAdet.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxStokAdet.BorderRadius = 15;
            this.tbxStokAdet.BorderSize = 2;
            this.tbxStokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxStokAdet.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxStokAdet.Location = new System.Drawing.Point(149, 18);
            this.tbxStokAdet.Multiline = false;
            this.tbxStokAdet.Name = "tbxStokAdet";
            this.tbxStokAdet.Padding = new System.Windows.Forms.Padding(7);
            this.tbxStokAdet.PasswordChar = false;
            this.tbxStokAdet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxStokAdet.PlaceholderText = "Arttırılacak Miktar";
            this.tbxStokAdet.Size = new System.Drawing.Size(194, 31);
            this.tbxStokAdet.TabIndex = 4;
            this.tbxStokAdet.Texts = "";
            this.tbxStokAdet.UnderlinedStyle = false;
            // 
            // btnStokArttır
            // 
            this.btnStokArttır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStokArttır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnStokArttır.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnStokArttır.BorderColor = System.Drawing.SystemColors.Window;
            this.btnStokArttır.BorderRadius = 20;
            this.btnStokArttır.BorderSize = 2;
            this.btnStokArttır.FlatAppearance.BorderSize = 0;
            this.btnStokArttır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokArttır.ForeColor = System.Drawing.Color.White;
            this.btnStokArttır.Location = new System.Drawing.Point(149, 55);
            this.btnStokArttır.Name = "btnStokArttır";
            this.btnStokArttır.Size = new System.Drawing.Size(194, 40);
            this.btnStokArttır.TabIndex = 17;
            this.btnStokArttır.Text = "Stok Arttır";
            this.btnStokArttır.TextColor = System.Drawing.Color.White;
            this.btnStokArttır.UseVisualStyleBackColor = false;
            this.btnStokArttır.Click += new System.EventHandler(this.btnStokArttır_Click);
            // 
            // gbxKutuBolme
            // 
            this.gbxKutuBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxKutuBolme.Controls.Add(this.cbxBolme);
            this.gbxKutuBolme.Controls.Add(this.cbxKutu);
            this.gbxKutuBolme.Controls.Add(this.lblBolme);
            this.gbxKutuBolme.Controls.Add(this.lblKutu);
            this.gbxKutuBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxKutuBolme.Location = new System.Drawing.Point(422, 12);
            this.gbxKutuBolme.Name = "gbxKutuBolme";
            this.gbxKutuBolme.Size = new System.Drawing.Size(390, 79);
            this.gbxKutuBolme.TabIndex = 21;
            this.gbxKutuBolme.TabStop = false;
            this.gbxKutuBolme.Text = "Kutu Ve Bölmeye Göre Listele";
            // 
            // lblRaf
            // 
            this.lblRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaf.AutoSize = true;
            this.lblRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRaf.Location = new System.Drawing.Point(6, 53);
            this.lblRaf.Name = "lblRaf";
            this.lblRaf.Size = new System.Drawing.Size(30, 13);
            this.lblRaf.TabIndex = 3;
            this.lblRaf.Text = "Raf: ";
            // 
            // lblDolap
            // 
            this.lblDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDolap.AutoSize = true;
            this.lblDolap.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDolap.Location = new System.Drawing.Point(6, 30);
            this.lblDolap.Name = "lblDolap";
            this.lblDolap.Size = new System.Drawing.Size(41, 13);
            this.lblDolap.TabIndex = 2;
            this.lblDolap.Text = "Dolap: ";
            // 
            // cbxRaf
            // 
            this.cbxRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaf.FormattingEnabled = true;
            this.cbxRaf.Location = new System.Drawing.Point(53, 50);
            this.cbxRaf.Name = "cbxRaf";
            this.cbxRaf.Size = new System.Drawing.Size(194, 21);
            this.cbxRaf.TabIndex = 1;
            this.cbxRaf.SelectedIndexChanged += new System.EventHandler(this.cbxRaf_SelectedIndexChanged);
            // 
            // cbxDolap
            // 
            this.cbxDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDolap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDolap.FormattingEnabled = true;
            this.cbxDolap.Location = new System.Drawing.Point(53, 27);
            this.cbxDolap.Name = "cbxDolap";
            this.cbxDolap.Size = new System.Drawing.Size(194, 21);
            this.cbxDolap.TabIndex = 0;
            this.cbxDolap.SelectedIndexChanged += new System.EventHandler(this.cbxDolap_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 254);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbxDolapRaf
            // 
            this.gbxDolapRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDolapRaf.Controls.Add(this.lblRaf);
            this.gbxDolapRaf.Controls.Add(this.lblDolap);
            this.gbxDolapRaf.Controls.Add(this.cbxRaf);
            this.gbxDolapRaf.Controls.Add(this.cbxDolap);
            this.gbxDolapRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxDolapRaf.Location = new System.Drawing.Point(26, 12);
            this.gbxDolapRaf.Name = "gbxDolapRaf";
            this.gbxDolapRaf.Size = new System.Drawing.Size(390, 79);
            this.gbxDolapRaf.TabIndex = 20;
            this.gbxDolapRaf.TabStop = false;
            this.gbxDolapRaf.Text = "Dolap Ve Raf\'a Göre Listele";
            // 
            // btnListAll
            // 
            this.btnListAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnListAll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnListAll.BorderColor = System.Drawing.SystemColors.Window;
            this.btnListAll.BorderRadius = 20;
            this.btnListAll.BorderSize = 2;
            this.btnListAll.FlatAppearance.BorderSize = 0;
            this.btnListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListAll.ForeColor = System.Drawing.Color.White;
            this.btnListAll.Location = new System.Drawing.Point(565, 376);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(104, 40);
            this.btnListAll.TabIndex = 26;
            this.btnListAll.Text = "Tümünü Listele";
            this.btnListAll.TextColor = System.Drawing.Color.White;
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // cbxBolme
            // 
            this.cbxBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBolme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolme.FormattingEnabled = true;
            this.cbxBolme.Location = new System.Drawing.Point(75, 50);
            this.cbxBolme.Name = "cbxBolme";
            this.cbxBolme.Size = new System.Drawing.Size(194, 21);
            this.cbxBolme.TabIndex = 5;
            this.cbxBolme.SelectedIndexChanged += new System.EventHandler(this.cbxBolme_SelectedIndexChanged);
            // 
            // cbxKutu
            // 
            this.cbxKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKutu.FormattingEnabled = true;
            this.cbxKutu.Location = new System.Drawing.Point(75, 27);
            this.cbxKutu.Name = "cbxKutu";
            this.cbxKutu.Size = new System.Drawing.Size(194, 21);
            this.cbxKutu.TabIndex = 4;
            this.cbxKutu.SelectedIndexChanged += new System.EventHandler(this.cbxKutu_SelectedIndexChanged);
            // 
            // frmIncrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1224, 475);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.gbxAdetArttır);
            this.Controls.Add(this.gbxUrunAd);
            this.Controls.Add(this.gbxStokArttır);
            this.Controls.Add(this.gbxKutuBolme);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbxDolapRaf);
            this.Name = "frmIncrease";
            this.Text = "frmIncrease";
            this.Load += new System.EventHandler(this.frmIncrease_Load);
            this.gbxAdetArttır.ResumeLayout(false);
            this.gbxUrunAd.ResumeLayout(false);
            this.gbxUrunAd.PerformLayout();
            this.gbxStokArttır.ResumeLayout(false);
            this.gbxKutuBolme.ResumeLayout(false);
            this.gbxKutuBolme.PerformLayout();
            this.gbxDolapRaf.ResumeLayout(false);
            this.gbxDolapRaf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTools.cTextBox tbxStokAdet;
        private CustomTools.cTextBox tbxUrunAdet;
        private System.Windows.Forms.GroupBox gbxAdetArttır;
        private CustomTools.cButton btnAdetArttır;
        private CustomTools.cButton btnStokArttır;
        private CustomTools.cTextBox tbxUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.GroupBox gbxUrunAd;
        private System.Windows.Forms.GroupBox gbxStokArttır;
        private System.Windows.Forms.GroupBox gbxKutuBolme;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.Label lblDolap;
        private System.Windows.Forms.ComboBox cbxRaf;
        private System.Windows.Forms.ComboBox cbxDolap;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbxDolapRaf;
        private CustomTools.cButton btnListAll;
        private System.Windows.Forms.ComboBox cbxBolme;
        private System.Windows.Forms.ComboBox cbxKutu;
    }
}