
namespace ÜrünStok.Formlar
{
    partial class frmDecrease
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
            this.cbxRaf = new System.Windows.Forms.ComboBox();
            this.cbxDolap = new System.Windows.Forms.ComboBox();
            this.lblRaf = new System.Windows.Forms.Label();
            this.lblDolap = new System.Windows.Forms.Label();
            this.gbxUrunAd = new System.Windows.Forms.GroupBox();
            this.tbxUrunAd = new ÜrünStok.CustomTools.cTextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.gbxAdetAzalt = new System.Windows.Forms.GroupBox();
            this.tbxUrunAdet = new ÜrünStok.CustomTools.cTextBox();
            this.btnAdetAzalt = new ÜrünStok.CustomTools.cButton();
            this.gbxStokAzalt = new System.Windows.Forms.GroupBox();
            this.tbxStokAdet = new ÜrünStok.CustomTools.cTextBox();
            this.btnStokAzalt = new ÜrünStok.CustomTools.cButton();
            this.lblKutu = new System.Windows.Forms.Label();
            this.lblBolme = new System.Windows.Forms.Label();
            this.gbxKutuBolme = new System.Windows.Forms.GroupBox();
            this.btnDelete = new ÜrünStok.CustomTools.cButton();
            this.cButton1 = new ÜrünStok.CustomTools.cButton();
            this.cbxBolme = new System.Windows.Forms.ComboBox();
            this.cbxKutu = new System.Windows.Forms.ComboBox();
            this.gbxDolapRaf.SuspendLayout();
            this.gbxUrunAd.SuspendLayout();
            this.gbxAdetAzalt.SuspendLayout();
            this.gbxStokAzalt.SuspendLayout();
            this.gbxKutuBolme.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 254);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbxDolapRaf
            // 
            this.gbxDolapRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxDolapRaf.Controls.Add(this.cbxRaf);
            this.gbxDolapRaf.Controls.Add(this.cbxDolap);
            this.gbxDolapRaf.Controls.Add(this.lblRaf);
            this.gbxDolapRaf.Controls.Add(this.lblDolap);
            this.gbxDolapRaf.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxDolapRaf.Location = new System.Drawing.Point(12, 12);
            this.gbxDolapRaf.Name = "gbxDolapRaf";
            this.gbxDolapRaf.Size = new System.Drawing.Size(390, 79);
            this.gbxDolapRaf.TabIndex = 13;
            this.gbxDolapRaf.TabStop = false;
            this.gbxDolapRaf.Text = "Dolap Ve Raf\'a Göre Listele";
            // 
            // cbxRaf
            // 
            this.cbxRaf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaf.FormattingEnabled = true;
            this.cbxRaf.Location = new System.Drawing.Point(90, 47);
            this.cbxRaf.Name = "cbxRaf";
            this.cbxRaf.Size = new System.Drawing.Size(194, 21);
            this.cbxRaf.TabIndex = 5;
            this.cbxRaf.SelectedIndexChanged += new System.EventHandler(this.cbxRaf_SelectedIndexChanged);
            // 
            // cbxDolap
            // 
            this.cbxDolap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxDolap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDolap.FormattingEnabled = true;
            this.cbxDolap.Location = new System.Drawing.Point(90, 24);
            this.cbxDolap.Name = "cbxDolap";
            this.cbxDolap.Size = new System.Drawing.Size(194, 21);
            this.cbxDolap.TabIndex = 4;
            this.cbxDolap.SelectedIndexChanged += new System.EventHandler(this.cbxDolap_SelectedIndexChanged);
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
            // gbxUrunAd
            // 
            this.gbxUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxUrunAd.Controls.Add(this.tbxUrunAd);
            this.gbxUrunAd.Controls.Add(this.lblUrunAd);
            this.gbxUrunAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxUrunAd.Location = new System.Drawing.Point(804, 12);
            this.gbxUrunAd.Name = "gbxUrunAd";
            this.gbxUrunAd.Size = new System.Drawing.Size(390, 79);
            this.gbxUrunAd.TabIndex = 15;
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
            // gbxAdetAzalt
            // 
            this.gbxAdetAzalt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxAdetAzalt.Controls.Add(this.tbxUrunAdet);
            this.gbxAdetAzalt.Controls.Add(this.btnAdetAzalt);
            this.gbxAdetAzalt.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxAdetAzalt.Location = new System.Drawing.Point(12, 357);
            this.gbxAdetAzalt.Name = "gbxAdetAzalt";
            this.gbxAdetAzalt.Size = new System.Drawing.Size(528, 101);
            this.gbxAdetAzalt.TabIndex = 19;
            this.gbxAdetAzalt.TabStop = false;
            this.gbxAdetAzalt.Text = "Ürün Adet Azalt";
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
            this.tbxUrunAdet.Location = new System.Drawing.Point(147, 18);
            this.tbxUrunAdet.Multiline = false;
            this.tbxUrunAdet.Name = "tbxUrunAdet";
            this.tbxUrunAdet.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUrunAdet.PasswordChar = false;
            this.tbxUrunAdet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUrunAdet.PlaceholderText = "Azaltılacak Miktar";
            this.tbxUrunAdet.Size = new System.Drawing.Size(194, 31);
            this.tbxUrunAdet.TabIndex = 4;
            this.tbxUrunAdet.Texts = "";
            this.tbxUrunAdet.UnderlinedStyle = false;
            // 
            // btnAdetAzalt
            // 
            this.btnAdetAzalt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdetAzalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetAzalt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnAdetAzalt.BorderColor = System.Drawing.SystemColors.Window;
            this.btnAdetAzalt.BorderRadius = 20;
            this.btnAdetAzalt.BorderSize = 2;
            this.btnAdetAzalt.FlatAppearance.BorderSize = 0;
            this.btnAdetAzalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdetAzalt.ForeColor = System.Drawing.Color.White;
            this.btnAdetAzalt.Location = new System.Drawing.Point(147, 55);
            this.btnAdetAzalt.Name = "btnAdetAzalt";
            this.btnAdetAzalt.Size = new System.Drawing.Size(194, 40);
            this.btnAdetAzalt.TabIndex = 18;
            this.btnAdetAzalt.Text = "Adet Azalt";
            this.btnAdetAzalt.TextColor = System.Drawing.Color.White;
            this.btnAdetAzalt.UseVisualStyleBackColor = false;
            this.btnAdetAzalt.Click += new System.EventHandler(this.btnAdetAzalt_Click);
            // 
            // gbxStokAzalt
            // 
            this.gbxStokAzalt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxStokAzalt.Controls.Add(this.tbxStokAdet);
            this.gbxStokAzalt.Controls.Add(this.btnStokAzalt);
            this.gbxStokAzalt.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxStokAzalt.Location = new System.Drawing.Point(666, 357);
            this.gbxStokAzalt.Name = "gbxStokAzalt";
            this.gbxStokAzalt.Size = new System.Drawing.Size(528, 101);
            this.gbxStokAzalt.TabIndex = 16;
            this.gbxStokAzalt.TabStop = false;
            this.gbxStokAzalt.Text = "Ürün Stok Azalt";
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
            this.tbxStokAdet.Location = new System.Drawing.Point(147, 18);
            this.tbxStokAdet.Multiline = false;
            this.tbxStokAdet.Name = "tbxStokAdet";
            this.tbxStokAdet.Padding = new System.Windows.Forms.Padding(7);
            this.tbxStokAdet.PasswordChar = false;
            this.tbxStokAdet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxStokAdet.PlaceholderText = "Azaltılacak Miktar";
            this.tbxStokAdet.Size = new System.Drawing.Size(194, 31);
            this.tbxStokAdet.TabIndex = 4;
            this.tbxStokAdet.Texts = "";
            this.tbxStokAdet.UnderlinedStyle = false;
            // 
            // btnStokAzalt
            // 
            this.btnStokAzalt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStokAzalt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnStokAzalt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnStokAzalt.BorderColor = System.Drawing.SystemColors.Window;
            this.btnStokAzalt.BorderRadius = 20;
            this.btnStokAzalt.BorderSize = 2;
            this.btnStokAzalt.FlatAppearance.BorderSize = 0;
            this.btnStokAzalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStokAzalt.ForeColor = System.Drawing.Color.White;
            this.btnStokAzalt.Location = new System.Drawing.Point(147, 55);
            this.btnStokAzalt.Name = "btnStokAzalt";
            this.btnStokAzalt.Size = new System.Drawing.Size(194, 40);
            this.btnStokAzalt.TabIndex = 17;
            this.btnStokAzalt.Text = "Stok Azalt";
            this.btnStokAzalt.TextColor = System.Drawing.Color.White;
            this.btnStokAzalt.UseVisualStyleBackColor = false;
            this.btnStokAzalt.Click += new System.EventHandler(this.btnStokAzalt_Click);
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
            // gbxKutuBolme
            // 
            this.gbxKutuBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxKutuBolme.Controls.Add(this.cbxBolme);
            this.gbxKutuBolme.Controls.Add(this.cbxKutu);
            this.gbxKutuBolme.Controls.Add(this.lblBolme);
            this.gbxKutuBolme.Controls.Add(this.lblKutu);
            this.gbxKutuBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxKutuBolme.Location = new System.Drawing.Point(408, 12);
            this.gbxKutuBolme.Name = "gbxKutuBolme";
            this.gbxKutuBolme.Size = new System.Drawing.Size(390, 79);
            this.gbxKutuBolme.TabIndex = 14;
            this.gbxKutuBolme.TabStop = false;
            this.gbxKutuBolme.Text = "Kutu Ve Bölmeye Göre Listele";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDelete.BorderColor = System.Drawing.SystemColors.Window;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(557, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 40);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Ürünü Sil";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cButton1
            // 
            this.cButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.cButton1.BorderColor = System.Drawing.SystemColors.Window;
            this.cButton1.BorderRadius = 20;
            this.cButton1.BorderSize = 2;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.Location = new System.Drawing.Point(557, 406);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(95, 40);
            this.cButton1.TabIndex = 20;
            this.cButton1.Text = "Tümünü Listele";
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // cbxBolme
            // 
            this.cbxBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxBolme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolme.FormattingEnabled = true;
            this.cbxBolme.Location = new System.Drawing.Point(85, 47);
            this.cbxBolme.Name = "cbxBolme";
            this.cbxBolme.Size = new System.Drawing.Size(194, 21);
            this.cbxBolme.TabIndex = 7;
            this.cbxBolme.SelectedIndexChanged += new System.EventHandler(this.cbxBolme_SelectedIndexChanged);
            // 
            // cbxKutu
            // 
            this.cbxKutu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxKutu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKutu.FormattingEnabled = true;
            this.cbxKutu.Location = new System.Drawing.Point(85, 24);
            this.cbxKutu.Name = "cbxKutu";
            this.cbxKutu.Size = new System.Drawing.Size(194, 21);
            this.cbxKutu.TabIndex = 6;
            this.cbxKutu.SelectedIndexChanged += new System.EventHandler(this.cbxKutu_SelectedIndexChanged);
            // 
            // frmDecrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxStokAzalt);
            this.Controls.Add(this.gbxAdetAzalt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbxDolapRaf);
            this.Controls.Add(this.gbxKutuBolme);
            this.Controls.Add(this.gbxUrunAd);
            this.Name = "frmDecrease";
            this.Text = "frmDecrease";
            this.Load += new System.EventHandler(this.frmDecrease_Load);
            this.gbxDolapRaf.ResumeLayout(false);
            this.gbxDolapRaf.PerformLayout();
            this.gbxUrunAd.ResumeLayout(false);
            this.gbxUrunAd.PerformLayout();
            this.gbxAdetAzalt.ResumeLayout(false);
            this.gbxStokAzalt.ResumeLayout(false);
            this.gbxKutuBolme.ResumeLayout(false);
            this.gbxKutuBolme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbxDolapRaf;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.Label lblDolap;
        private System.Windows.Forms.GroupBox gbxUrunAd;
        private CustomTools.cTextBox tbxUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private CustomTools.cButton btnAdetAzalt;
        private CustomTools.cButton btnStokAzalt;
        private System.Windows.Forms.GroupBox gbxAdetAzalt;
        private CustomTools.cTextBox tbxUrunAdet;
        private System.Windows.Forms.GroupBox gbxStokAzalt;
        private CustomTools.cTextBox tbxStokAdet;
        private System.Windows.Forms.ComboBox cbxRaf;
        private System.Windows.Forms.ComboBox cbxDolap;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.GroupBox gbxKutuBolme;
        private CustomTools.cButton btnDelete;
        private CustomTools.cButton cButton1;
        private System.Windows.Forms.ComboBox cbxBolme;
        private System.Windows.Forms.ComboBox cbxKutu;
    }
}