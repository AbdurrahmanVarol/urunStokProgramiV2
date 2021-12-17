
namespace ÜrünStok.Formlar
{
    partial class frmAddProduct
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxKonum = new System.Windows.Forms.ComboBox();
            this.lblKutu = new System.Windows.Forms.Label();
            this.lblBolme = new System.Windows.Forms.Label();
            this.lblDolap = new System.Windows.Forms.Label();
            this.lblRaf = new System.Windows.Forms.Label();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.cbxDurum = new System.Windows.Forms.ComboBox();
            this.cbxKutu = new System.Windows.Forms.ComboBox();
            this.cbxDolap = new System.Windows.Forms.ComboBox();
            this.cbxBolme = new System.Windows.Forms.ComboBox();
            this.cbxRaf = new System.Windows.Forms.ComboBox();
            this.tbxUrunStok = new ÜrünStok.CustomTools.cTextBox();
            this.tbxUrunAdet = new ÜrünStok.CustomTools.cTextBox();
            this.cButton2 = new ÜrünStok.CustomTools.cButton();
            this.btnAddProduct = new ÜrünStok.CustomTools.cButton();
            this.tbxUrunAd = new ÜrünStok.CustomTools.cTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(384, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Durum:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(383, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(383, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ürün Konumu";
            // 
            // cbxKonum
            // 
            this.cbxKonum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKonum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxKonum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKonum.FormattingEnabled = true;
            this.cbxKonum.Location = new System.Drawing.Point(524, 40);
            this.cbxKonum.Name = "cbxKonum";
            this.cbxKonum.Size = new System.Drawing.Size(121, 21);
            this.cbxKonum.TabIndex = 38;
            this.cbxKonum.SelectedIndexChanged += new System.EventHandler(this.cbxKonum_SelectedIndexChanged);
            // 
            // lblKutu
            // 
            this.lblKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKutu.AutoSize = true;
            this.lblKutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKutu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblKutu.Location = new System.Drawing.Point(382, 157);
            this.lblKutu.Name = "lblKutu";
            this.lblKutu.Size = new System.Drawing.Size(36, 16);
            this.lblKutu.TabIndex = 47;
            this.lblKutu.Text = "Kutu:";
            this.lblKutu.Visible = false;
            // 
            // lblBolme
            // 
            this.lblBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBolme.AutoSize = true;
            this.lblBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBolme.Location = new System.Drawing.Point(660, 152);
            this.lblBolme.Name = "lblBolme";
            this.lblBolme.Size = new System.Drawing.Size(78, 16);
            this.lblBolme.TabIndex = 51;
            this.lblBolme.Text = "Kutu Bölme:";
            this.lblBolme.Visible = false;
            // 
            // lblDolap
            // 
            this.lblDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDolap.AutoSize = true;
            this.lblDolap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolap.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDolap.Location = new System.Drawing.Point(383, 127);
            this.lblDolap.Name = "lblDolap";
            this.lblDolap.Size = new System.Drawing.Size(48, 16);
            this.lblDolap.TabIndex = 53;
            this.lblDolap.Text = "Dolap:";
            // 
            // lblRaf
            // 
            this.lblRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRaf.AutoSize = true;
            this.lblRaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRaf.Location = new System.Drawing.Point(660, 127);
            this.lblRaf.Name = "lblRaf";
            this.lblRaf.Size = new System.Drawing.Size(32, 16);
            this.lblRaf.TabIndex = 55;
            this.lblRaf.Text = "Raf:";
            this.lblRaf.Visible = false;
            // 
            // cbxKategori
            // 
            this.cbxKategori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKategori.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(524, 68);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxKategori.TabIndex = 56;
            // 
            // cbxDurum
            // 
            this.cbxDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDurum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDurum.FormattingEnabled = true;
            this.cbxDurum.Location = new System.Drawing.Point(524, 96);
            this.cbxDurum.Name = "cbxDurum";
            this.cbxDurum.Size = new System.Drawing.Size(121, 21);
            this.cbxDurum.TabIndex = 57;
            // 
            // cbxKutu
            // 
            this.cbxKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKutu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKutu.FormattingEnabled = true;
            this.cbxKutu.Location = new System.Drawing.Point(524, 152);
            this.cbxKutu.Name = "cbxKutu";
            this.cbxKutu.Size = new System.Drawing.Size(121, 21);
            this.cbxKutu.TabIndex = 59;
            this.cbxKutu.Visible = false;
            this.cbxKutu.SelectedIndexChanged += new System.EventHandler(this.cbxKutu_SelectedIndexChanged);
            // 
            // cbxDolap
            // 
            this.cbxDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDolap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxDolap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDolap.FormattingEnabled = true;
            this.cbxDolap.Location = new System.Drawing.Point(524, 124);
            this.cbxDolap.Name = "cbxDolap";
            this.cbxDolap.Size = new System.Drawing.Size(121, 21);
            this.cbxDolap.TabIndex = 60;
            this.cbxDolap.SelectedIndexChanged += new System.EventHandler(this.cbxDolap_SelectedIndexChanged);
            // 
            // cbxBolme
            // 
            this.cbxBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBolme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxBolme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolme.FormattingEnabled = true;
            this.cbxBolme.Location = new System.Drawing.Point(744, 154);
            this.cbxBolme.Name = "cbxBolme";
            this.cbxBolme.Size = new System.Drawing.Size(121, 21);
            this.cbxBolme.TabIndex = 62;
            this.cbxBolme.Visible = false;
            // 
            // cbxRaf
            // 
            this.cbxRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRaf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxRaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaf.FormattingEnabled = true;
            this.cbxRaf.Location = new System.Drawing.Point(744, 126);
            this.cbxRaf.Name = "cbxRaf";
            this.cbxRaf.Size = new System.Drawing.Size(121, 21);
            this.cbxRaf.TabIndex = 63;
            this.cbxRaf.Visible = false;
            this.cbxRaf.SelectedIndexChanged += new System.EventHandler(this.cbxRaf_SelectedIndexChanged);
            // 
            // tbxUrunStok
            // 
            this.tbxUrunStok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUrunStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxUrunStok.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxUrunStok.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxUrunStok.BorderRadius = 15;
            this.tbxUrunStok.BorderSize = 2;
            this.tbxUrunStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunStok.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxUrunStok.Location = new System.Drawing.Point(385, 269);
            this.tbxUrunStok.Multiline = false;
            this.tbxUrunStok.Name = "tbxUrunStok";
            this.tbxUrunStok.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunStok.PasswordChar = false;
            this.tbxUrunStok.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunStok.PlaceholderText = "Ürün Stok Bilgisi";
            this.tbxUrunStok.Size = new System.Drawing.Size(271, 31);
            this.tbxUrunStok.TabIndex = 37;
            this.tbxUrunStok.Texts = "";
            this.tbxUrunStok.UnderlinedStyle = false;
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
            this.tbxUrunAdet.Location = new System.Drawing.Point(385, 232);
            this.tbxUrunAdet.Multiline = false;
            this.tbxUrunAdet.Name = "tbxUrunAdet";
            this.tbxUrunAdet.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAdet.PasswordChar = false;
            this.tbxUrunAdet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAdet.PlaceholderText = "Ürün Adeti";
            this.tbxUrunAdet.Size = new System.Drawing.Size(271, 31);
            this.tbxUrunAdet.TabIndex = 36;
            this.tbxUrunAdet.Texts = "";
            this.tbxUrunAdet.UnderlinedStyle = false;
            // 
            // cButton2
            // 
            this.cButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cButton2.BorderColor = System.Drawing.SystemColors.Window;
            this.cButton2.BorderRadius = 20;
            this.cButton2.BorderSize = 2;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.Location = new System.Drawing.Point(526, 306);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(130, 40);
            this.cButton2.TabIndex = 35;
            this.cButton2.Text = "İptal";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAddProduct.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAddProduct.BorderRadius = 20;
            this.btnAddProduct.BorderSize = 2;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(385, 306);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(130, 40);
            this.btnAddProduct.TabIndex = 34;
            this.btnAddProduct.Text = "Ürünü Ekle";
            this.btnAddProduct.TextColor = System.Drawing.Color.White;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
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
            this.tbxUrunAd.Location = new System.Drawing.Point(385, 196);
            this.tbxUrunAd.Multiline = false;
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAd.PasswordChar = false;
            this.tbxUrunAd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAd.PlaceholderText = "Ürün Adı";
            this.tbxUrunAd.Size = new System.Drawing.Size(271, 31);
            this.tbxUrunAd.TabIndex = 33;
            this.tbxUrunAd.Texts = "";
            this.tbxUrunAd.UnderlinedStyle = false;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.cbxRaf);
            this.Controls.Add(this.cbxBolme);
            this.Controls.Add(this.cbxDolap);
            this.Controls.Add(this.cbxKutu);
            this.Controls.Add(this.cbxDurum);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.lblRaf);
            this.Controls.Add(this.lblDolap);
            this.Controls.Add(this.lblBolme);
            this.Controls.Add(this.lblKutu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxKonum);
            this.Controls.Add(this.tbxUrunStok);
            this.Controls.Add(this.tbxUrunAdet);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbxUrunAd);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProduct";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxKonum;
        private CustomTools.cTextBox tbxUrunStok;
        private CustomTools.cTextBox tbxUrunAdet;
        private CustomTools.cButton cButton2;
        private CustomTools.cButton btnAddProduct;
        private CustomTools.cTextBox tbxUrunAd;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.Label lblDolap;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.ComboBox cbxDurum;
        private System.Windows.Forms.ComboBox cbxKutu;
        private System.Windows.Forms.ComboBox cbxDolap;
        private System.Windows.Forms.ComboBox cbxBolme;
        private System.Windows.Forms.ComboBox cbxRaf;
    }
}