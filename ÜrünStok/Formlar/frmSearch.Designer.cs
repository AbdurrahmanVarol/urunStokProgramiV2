
namespace ÜrünStok.Formlar
{
    partial class frmSearch
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
            this.btnListAll = new ÜrünStok.CustomTools.cButton();
            this.gbxUrunAd = new System.Windows.Forms.GroupBox();
            this.tbxUrunAd = new ÜrünStok.CustomTools.cTextBox();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.gbxKutuBolme = new System.Windows.Forms.GroupBox();
            this.cbxBolme = new System.Windows.Forms.ComboBox();
            this.cbxKutu = new System.Windows.Forms.ComboBox();
            this.lblBolme = new System.Windows.Forms.Label();
            this.lblKutu = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbxDolapRaf = new System.Windows.Forms.GroupBox();
            this.lblRaf = new System.Windows.Forms.Label();
            this.lblDolap = new System.Windows.Forms.Label();
            this.cbxRaf = new System.Windows.Forms.ComboBox();
            this.cbxDolap = new System.Windows.Forms.ComboBox();
            this.gbxUrunAd.SuspendLayout();
            this.gbxKutuBolme.SuspendLayout();
            this.gbxDolapRaf.SuspendLayout();
            this.SuspendLayout();
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
            this.btnListAll.Location = new System.Drawing.Point(1101, 423);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(104, 40);
            this.btnListAll.TabIndex = 31;
            this.btnListAll.Text = "Tümünü Listele";
            this.btnListAll.TextColor = System.Drawing.Color.White;
            this.btnListAll.UseVisualStyleBackColor = false;
            this.btnListAll.Click += new System.EventHandler(this.btnListAll_Click);
            // 
            // gbxUrunAd
            // 
            this.gbxUrunAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxUrunAd.Controls.Add(this.tbxUrunAd);
            this.gbxUrunAd.Controls.Add(this.lblUrunAd);
            this.gbxUrunAd.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxUrunAd.Location = new System.Drawing.Point(815, 12);
            this.gbxUrunAd.Name = "gbxUrunAd";
            this.gbxUrunAd.Size = new System.Drawing.Size(390, 79);
            this.gbxUrunAd.TabIndex = 29;
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
            // gbxKutuBolme
            // 
            this.gbxKutuBolme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxKutuBolme.Controls.Add(this.cbxBolme);
            this.gbxKutuBolme.Controls.Add(this.cbxKutu);
            this.gbxKutuBolme.Controls.Add(this.lblBolme);
            this.gbxKutuBolme.Controls.Add(this.lblKutu);
            this.gbxKutuBolme.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxKutuBolme.Location = new System.Drawing.Point(419, 12);
            this.gbxKutuBolme.Name = "gbxKutuBolme";
            this.gbxKutuBolme.Size = new System.Drawing.Size(390, 79);
            this.gbxKutuBolme.TabIndex = 28;
            this.gbxKutuBolme.TabStop = false;
            this.gbxKutuBolme.Text = "Kutu Ve Bölmeye Göre Listele";
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
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 320);
            this.listView1.TabIndex = 30;
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
            this.gbxDolapRaf.Location = new System.Drawing.Point(23, 12);
            this.gbxDolapRaf.Name = "gbxDolapRaf";
            this.gbxDolapRaf.Size = new System.Drawing.Size(390, 79);
            this.gbxDolapRaf.TabIndex = 27;
            this.gbxDolapRaf.TabStop = false;
            this.gbxDolapRaf.Text = "Dolap Ve Raf\'a Göre Listele";
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
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1224, 475);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.gbxUrunAd);
            this.Controls.Add(this.gbxKutuBolme);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbxDolapRaf);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.gbxUrunAd.ResumeLayout(false);
            this.gbxUrunAd.PerformLayout();
            this.gbxKutuBolme.ResumeLayout(false);
            this.gbxKutuBolme.PerformLayout();
            this.gbxDolapRaf.ResumeLayout(false);
            this.gbxDolapRaf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTools.cButton btnListAll;
        private System.Windows.Forms.GroupBox gbxUrunAd;
        private CustomTools.cTextBox tbxUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.GroupBox gbxKutuBolme;
        private System.Windows.Forms.ComboBox cbxBolme;
        private System.Windows.Forms.ComboBox cbxKutu;
        private System.Windows.Forms.Label lblBolme;
        private System.Windows.Forms.Label lblKutu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox gbxDolapRaf;
        private System.Windows.Forms.Label lblRaf;
        private System.Windows.Forms.Label lblDolap;
        private System.Windows.Forms.ComboBox cbxRaf;
        private System.Windows.Forms.ComboBox cbxDolap;
    }
}