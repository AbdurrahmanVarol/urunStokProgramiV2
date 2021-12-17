
namespace ÜrünStok.Formlar
{
    partial class frmLog
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
            this.btnPrint = new ÜrünStok.CustomTools.cButton();
            this.btnLogDelete = new ÜrünStok.CustomTools.cButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1182, 405);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnPrint.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnPrint.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.BorderSize = 2;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1002, 423);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(194, 40);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextColor = System.Drawing.Color.White;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLogDelete
            // 
            this.btnLogDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnLogDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnLogDelete.BorderColor = System.Drawing.SystemColors.Window;
            this.btnLogDelete.BorderRadius = 20;
            this.btnLogDelete.BorderSize = 2;
            this.btnLogDelete.FlatAppearance.BorderSize = 0;
            this.btnLogDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogDelete.ForeColor = System.Drawing.Color.White;
            this.btnLogDelete.Location = new System.Drawing.Point(802, 423);
            this.btnLogDelete.Name = "btnLogDelete";
            this.btnLogDelete.Size = new System.Drawing.Size(194, 40);
            this.btnLogDelete.TabIndex = 27;
            this.btnLogDelete.Text = "Sil";
            this.btnLogDelete.TextColor = System.Drawing.Color.White;
            this.btnLogDelete.UseVisualStyleBackColor = false;
            this.btnLogDelete.Click += new System.EventHandler(this.btnLogDelete_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.btnLogDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.listView1);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private CustomTools.cButton btnPrint;
        private CustomTools.cButton btnLogDelete;
    }
}