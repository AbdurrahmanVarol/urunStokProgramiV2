
namespace ÜrünStok.Formlar
{
    partial class frmUser
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
            this.tbxPassword = new ÜrünStok.CustomTools.cTextBox();
            this.tbxUserName = new ÜrünStok.CustomTools.cTextBox();
            this.btnUserAdd = new ÜrünStok.CustomTools.cButton();
            this.tbxPassword2 = new ÜrünStok.CustomTools.cTextBox();
            this.gbxUserAdd = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.gbxChangePassword = new System.Windows.Forms.GroupBox();
            this.tbxPasswordc2 = new ÜrünStok.CustomTools.cTextBox();
            this.tbxPasswordc = new ÜrünStok.CustomTools.cTextBox();
            this.btnChangePassword = new ÜrünStok.CustomTools.cButton();
            this.btnDeleteUser = new ÜrünStok.CustomTools.cButton();
            this.gbxUserAdd.SuspendLayout();
            this.gbxChangePassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(198, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 200);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxPassword.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxPassword.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPassword.BorderRadius = 15;
            this.tbxPassword.BorderSize = 2;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxPassword.Location = new System.Drawing.Point(50, 88);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPassword.PasswordChar = true;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.PlaceholderText = "Şifre";
            this.tbxPassword.Size = new System.Drawing.Size(271, 31);
            this.tbxPassword.TabIndex = 38;
            this.tbxPassword.Texts = "";
            this.tbxPassword.UnderlinedStyle = false;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxUserName.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxUserName.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxUserName.BorderRadius = 15;
            this.tbxUserName.BorderSize = 2;
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxUserName.Location = new System.Drawing.Point(50, 52);
            this.tbxUserName.Multiline = false;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUserName.PasswordChar = false;
            this.tbxUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUserName.PlaceholderText = "Kullanıcı Adı";
            this.tbxUserName.Size = new System.Drawing.Size(271, 31);
            this.tbxUserName.TabIndex = 37;
            this.tbxUserName.Texts = "";
            this.tbxUserName.UnderlinedStyle = false;
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnUserAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnUserAdd.BorderColor = System.Drawing.SystemColors.Window;
            this.btnUserAdd.BorderRadius = 20;
            this.btnUserAdd.BorderSize = 2;
            this.btnUserAdd.FlatAppearance.BorderSize = 0;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Location = new System.Drawing.Point(127, 192);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(194, 40);
            this.btnUserAdd.TabIndex = 39;
            this.btnUserAdd.Text = "Kullanıcı Ekle";
            this.btnUserAdd.TextColor = System.Drawing.Color.White;
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // tbxPassword2
            // 
            this.tbxPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPassword2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxPassword2.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxPassword2.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPassword2.BorderRadius = 15;
            this.tbxPassword2.BorderSize = 2;
            this.tbxPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPassword2.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxPassword2.Location = new System.Drawing.Point(50, 125);
            this.tbxPassword2.Multiline = false;
            this.tbxPassword2.Name = "tbxPassword2";
            this.tbxPassword2.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPassword2.PasswordChar = true;
            this.tbxPassword2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPassword2.PlaceholderText = "Şifre Tekrar";
            this.tbxPassword2.Size = new System.Drawing.Size(271, 31);
            this.tbxPassword2.TabIndex = 40;
            this.tbxPassword2.Texts = "";
            this.tbxPassword2.UnderlinedStyle = false;
            // 
            // gbxUserAdd
            // 
            this.gbxUserAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxUserAdd.Controls.Add(this.lblUser);
            this.gbxUserAdd.Controls.Add(this.cbxUser);
            this.gbxUserAdd.Controls.Add(this.tbxUserName);
            this.gbxUserAdd.Controls.Add(this.tbxPassword2);
            this.gbxUserAdd.Controls.Add(this.tbxPassword);
            this.gbxUserAdd.Controls.Add(this.btnUserAdd);
            this.gbxUserAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUserAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxUserAdd.Location = new System.Drawing.Point(198, 218);
            this.gbxUserAdd.Name = "gbxUserAdd";
            this.gbxUserAdd.Size = new System.Drawing.Size(381, 245);
            this.gbxUserAdd.TabIndex = 41;
            this.gbxUserAdd.TabStop = false;
            this.gbxUserAdd.Text = "Yeni Kullanıcı Ekle";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(56, 165);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(85, 16);
            this.lblUser.TabIndex = 42;
            this.lblUser.Text = "Yetki Düzeyi:";
            // 
            // cbxUser
            // 
            this.cbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(147, 162);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(174, 24);
            this.cbxUser.TabIndex = 41;
            // 
            // gbxChangePassword
            // 
            this.gbxChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbxChangePassword.Controls.Add(this.tbxPasswordc2);
            this.gbxChangePassword.Controls.Add(this.tbxPasswordc);
            this.gbxChangePassword.Controls.Add(this.btnChangePassword);
            this.gbxChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxChangePassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.gbxChangePassword.Location = new System.Drawing.Point(585, 218);
            this.gbxChangePassword.Name = "gbxChangePassword";
            this.gbxChangePassword.Size = new System.Drawing.Size(381, 245);
            this.gbxChangePassword.TabIndex = 42;
            this.gbxChangePassword.TabStop = false;
            this.gbxChangePassword.Text = "Şifre Değiştir";
            // 
            // tbxPasswordc2
            // 
            this.tbxPasswordc2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPasswordc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxPasswordc2.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxPasswordc2.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPasswordc2.BorderRadius = 15;
            this.tbxPasswordc2.BorderSize = 2;
            this.tbxPasswordc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPasswordc2.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxPasswordc2.Location = new System.Drawing.Point(54, 109);
            this.tbxPasswordc2.Multiline = false;
            this.tbxPasswordc2.Name = "tbxPasswordc2";
            this.tbxPasswordc2.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPasswordc2.PasswordChar = true;
            this.tbxPasswordc2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPasswordc2.PlaceholderText = "Şifre Tekrar";
            this.tbxPasswordc2.Size = new System.Drawing.Size(271, 31);
            this.tbxPasswordc2.TabIndex = 40;
            this.tbxPasswordc2.Texts = "";
            this.tbxPasswordc2.UnderlinedStyle = false;
            // 
            // tbxPasswordc
            // 
            this.tbxPasswordc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxPasswordc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.tbxPasswordc.BorderColor = System.Drawing.SystemColors.Window;
            this.tbxPasswordc.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPasswordc.BorderRadius = 15;
            this.tbxPasswordc.BorderSize = 2;
            this.tbxPasswordc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPasswordc.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbxPasswordc.Location = new System.Drawing.Point(54, 72);
            this.tbxPasswordc.Multiline = false;
            this.tbxPasswordc.Name = "tbxPasswordc";
            this.tbxPasswordc.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPasswordc.PasswordChar = true;
            this.tbxPasswordc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPasswordc.PlaceholderText = "Şifre";
            this.tbxPasswordc.Size = new System.Drawing.Size(271, 31);
            this.tbxPasswordc.TabIndex = 38;
            this.tbxPasswordc.Texts = "";
            this.tbxPasswordc.UnderlinedStyle = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnChangePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnChangePassword.BorderColor = System.Drawing.SystemColors.Window;
            this.btnChangePassword.BorderRadius = 20;
            this.btnChangePassword.BorderSize = 2;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(131, 146);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(194, 40);
            this.btnChangePassword.TabIndex = 39;
            this.btnChangePassword.Text = "Şifre Değiştir";
            this.btnChangePassword.TextColor = System.Drawing.Color.White;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDeleteUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnDeleteUser.BorderColor = System.Drawing.SystemColors.Window;
            this.btnDeleteUser.BorderRadius = 20;
            this.btnDeleteUser.BorderSize = 2;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(972, 172);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(70, 40);
            this.btnDeleteUser.TabIndex = 43;
            this.btnDeleteUser.Text = "Kullanıcı Sil";
            this.btnDeleteUser.TextColor = System.Drawing.Color.White;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1208, 475);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.gbxChangePassword);
            this.Controls.Add(this.gbxUserAdd);
            this.Controls.Add(this.listView1);
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.gbxUserAdd.ResumeLayout(false);
            this.gbxUserAdd.PerformLayout();
            this.gbxChangePassword.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private CustomTools.cTextBox tbxPassword;
        private CustomTools.cTextBox tbxUserName;
        private CustomTools.cButton btnUserAdd;
        private CustomTools.cTextBox tbxPassword2;
        private System.Windows.Forms.GroupBox gbxUserAdd;
        private System.Windows.Forms.GroupBox gbxChangePassword;
        private CustomTools.cTextBox tbxPasswordc2;
        private CustomTools.cTextBox tbxPasswordc;
        private CustomTools.cButton btnChangePassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cbxUser;
        private CustomTools.cButton btnDeleteUser;
    }
}