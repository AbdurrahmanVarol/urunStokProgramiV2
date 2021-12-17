
namespace ÜrünStok.Formlar
{
    partial class frmUpdateProduct
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbxDolapRaf = new System.Windows.Forms.GroupBox();
            this.cbxBolme = new System.Windows.Forms.ComboBox();
            this.cbxKutu = new System.Windows.Forms.ComboBox();
            this.lblBolme = new System.Windows.Forms.Label();
            this.lblKutu = new System.Windows.Forms.Label();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblRaf = new System.Windows.Forms.Label();
            this.lblDolap = new System.Windows.Forms.Label();
            this.cbxDolap = new System.Windows.Forms.ComboBox();
            this.cbxRaf = new System.Windows.Forms.ComboBox();
            this.tbxUrunAd = new ÜrünStok.CustomTools.cTextBox();
            this.btnAdetArttır = new ÜrünStok.CustomTools.cButton();
            this.gbxDolapRaf.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 302);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // gbxDolapRaf
            // 
            this.gbxDolapRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDolapRaf.Controls.Add(this.cbxBolme);
            this.gbxDolapRaf.Controls.Add(this.cbxKutu);
            this.gbxDolapRaf.Controls.Add(this.lblBolme);
            this.gbxDolapRaf.Controls.Add(this.lblKutu);
            this.gbxDolapRaf.Controls.Add(this.tbxUrunAd);
            this.gbxDolapRaf.Controls.Add(this.cbxDurum);
            this.gbxDolapRaf.Controls.Add(this.cbxKategori);
            this.gbxDolapRaf.Controls.Add(this.btnAdetArttır);
            this.gbxDolapRaf.Controls.Add(this.lblDurum);
            this.gbxDolapRaf.Controls.Add(this.lblKategori);
            this.gbxDolapRaf.Controls.Add(this.lblRaf);
            this.gbxDolapRaf.Controls.Add(this.lblDolap);
            this.gbxDolapRaf.Controls.Add(this.cbxDolap);
            this.gbxDolapRaf.Controls.Add(this.cbxRaf);
            this.gbxDolapRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxDolapRaf.Location = new System.Drawing.Point(13, 320);
            this.gbxDolapRaf.Name = "gbxDolapRaf";
            this.gbxDolapRaf.Size = new System.Drawing.Size(1182, 151);
            this.gbxDolapRaf.TabIndex = 26;
            this.gbxDolapRaf.TabStop = false;
            this.gbxDolapRaf.Text = "Ürün Güncelle";
            // 
            // cbxBolme
            // 
            this.cbxBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBolme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolme.FormattingEnabled = true;
            this.cbxBolme.Location = new System.Drawing.Point(773, 45);
            this.cbxBolme.Name = "cbxBolme";
            this.cbxBolme.Size = new System.Drawing.Size(194, 21);
            this.cbxBolme.TabIndex = 59;
            // 
            // cbxKutu
            // 
            this.cbxKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKutu.FormattingEnabled = true;
            this.cbxKutu.Location = new System.Drawing.Point(773, 18);
            this.cbxKutu.Name = "cbxKutu";
            this.cbxKutu.Size = new System.Drawing.Size(194, 21);
            this.cbxKutu.TabIndex = 58;
            this.cbxKutu.SelectedIndexChanged += new System.EventHandler(this.cbxKutu_SelectedIndexChanged);
            // 
            // lblBolme
            // 
            this.lblBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBolme.AutoSize = true;
            this.lblBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBolme.Location = new System.Drawing.Point(717, 43);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(39, 13);
            this.lblBolme.TabIndex = 57;
            this.lblBolme.Text = "Bölme:";
            // 
            // lblKutu
            // 
            this.lblKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKutu.AutoSize = true;
            this.lblKutu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKutu.Location = new System.Drawing.Point(717, 20);
            this.lblKutu.Name = "lblKutu";
            this.lblKutu.Size = new System.Drawing.Size(32, 13);
            this.lblKutu.TabIndex = 56;
            this.lblKutu.Text = "Kutu:";
            // 
            // cbxDurum
            // 
            this.cbxDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Location = new System.Drawing.Point(495, 48);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(194, 21);
            this.cbxDurum.TabIndex = 54;
            // 
            // cbxKategori
            // 
            this.cbxKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(495, 21);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(194, 21);
            this.cbxKategori.TabIndex = 53;
            // 
            // lblDurum
            // 
            this.lblDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDurum.Location = new System.Drawing.Point(439, 46);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(44, 13);
            this.lblDurum.TabIndex = 49;
            this.lblDurum.Text = "Durum: ";
            // 
            // lblKategori
            // 
            this.lblKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKategori.AutoSize = true;
            this.lblKategori.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKategori.Location = new System.Drawing.Point(439, 23);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(52, 13);
            this.lblKategori.TabIndex = 47;
            this.lblKategori.Text = "Kategori: ";
            // 
            // lblRaf
            // 
            this.lblRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaf.AutoSize = true;
            this.lblRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRaf.Location = new System.Drawing.Point(183, 46);
            this.lblRaf.Name = "lblRaf";
            this.lblRaf.Size = new System.Drawing.Size(30, 13);
            this.lblRaf.TabIndex = 50;
            this.lblRaf.Text = "Raf: ";
            // 
            // lblDolap
            // 
            this.lblDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDolap.AutoSize = true;
            this.lblDolap.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDolap.Location = new System.Drawing.Point(183, 23);
            this.lblDolap.Name = "lblDolap";
            this.lblDolap.Size = new System.Drawing.Size(41, 13);
            this.lblDolap.TabIndex = 48;
            this.lblDolap.Text = "Dolap: ";
            // 
            // cbxDolap
            // 
            this.cbxDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDolap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDolap.FormattingEnabled = true;
            this.cbxDolap.Location = new System.Drawing.Point(239, 20);
            this.cbxDolap.Name = "cbxDolap";
            this.cbxDolap.Size = new System.Drawing.Size(194, 21);
            this.cbxDolap.TabIndex = 44;
            this.cbxDolap.SelectedIndexChanged += new System.EventHandler(this.cbxDolap_SelectedIndexChanged);
            // 
            // cbxRaf
            // 
            this.cbxRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaf.FormattingEnabled = true;
            this.cbxRaf.Location = new System.Drawing.Point(239, 46);
            this.cbxRaf.Name = "cbxRaf";
            this.cbxRaf.Size = new System.Drawing.Size(194, 21);
            this.cbxRaf.TabIndex = 46;
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
            this.tbxUrunAd.Location = new System.Drawing.Point(495, 75);
            this.tbxUrunAd.Multiline = false;
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAd.PasswordChar = false;
            this.tbxUrunAd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAd.PlaceholderText = "";
            this.tbxUrunAd.Size = new System.Drawing.Size(194, 31);
            this.tbxUrunAd.TabIndex = 55;
            this.tbxUrunAd.Texts = "";
            this.tbxUrunAd.UnderlinedStyle = false;
            // 
            // btnAdetArttır
            // 
            this.btnAdetArttır.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdetArttır.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetArttır.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetArttır.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAdetArttır.BorderRadius = 12;
            this.btnAdetArttır.BorderSize = 2;
            this.btnAdetArttır.FlatAppearance.BorderSize = 0;
            this.btnAdetArttır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdetArttır.ForeColor = System.Drawing.Color.White;
            this.btnAdetArttır.Location = new System.Drawing.Point(495, 112);
            this.btnAdetArttır.Name = "btnAdetArttır";
            this.btnAdetArttır.Size = new System.Drawing.Size(194, 31);
            this.btnAdetArttır.TabIndex = 52;
            this.btnAdetArttır.Text = "Güncelle";
            this.btnAdetArttır.TextColor = System.Drawing.Color.White;
            this.btnAdetArttır.UseVisualStyleBackColor = false;
            this.btnAdetArttır.Click += new System.EventHandler(this.btnAdetArttır_Click);
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.gbxDolapRaf);
            this.Controls.Add(this.listView1);
            this.Name = "frmUpdateProduct";
            this.Text = "frmUpdateProduct";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
            this.gbxDolapRaf.ResumeLayout(false);
            this.gbxDolapRaf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbxDolapRaf;
        private CustomTools.cButton btnAdetArttır;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.Label lblDolap;
        private System.Windows.Forms.ComboBox cbxDolap;
        private System.Windows.Forms.ComboBox cbxRaf;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.ComboBox cbxKategori;
        private CustomTools.cTextBox tbxUrunAd;
        private System.Windows.Forms.ComboBox cbxBolme;
        private System.Windows.Forms.ComboBox cbxKutu;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.Label lblKutu;
    }
}