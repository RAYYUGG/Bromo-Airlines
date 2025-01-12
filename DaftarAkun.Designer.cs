namespace Bromo_Airlines_entitiy_framework
{
    partial class DaftarAkun
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label merupakanAdminLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label nomorTeleponLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label tanggalLahirLabel;
            System.Windows.Forms.Label usernameLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.merupakanAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.nomorTeleponTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tanggalLahirDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.akunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            merupakanAdminLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            nomorTeleponLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            tanggalLahirLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 16;
            this.label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Daftar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sudah punya akun? ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(174, 475);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bromo_Airlines_entitiy_framework.Properties.Resources.Logo_Rect;
            this.pictureBox1.Location = new System.Drawing.Point(498, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // merupakanAdminLabel
            // 
            merupakanAdminLabel.AutoSize = true;
            merupakanAdminLabel.Location = new System.Drawing.Point(50, 137);
            merupakanAdminLabel.Name = "merupakanAdminLabel";
            merupakanAdminLabel.Size = new System.Drawing.Size(119, 16);
            merupakanAdminLabel.TabIndex = 22;
            merupakanAdminLabel.Text = "Merupakan Admin:";
            merupakanAdminLabel.Visible = false;
            // 
            // merupakanAdminCheckBox
            // 
            this.merupakanAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.akunBindingSource, "MerupakanAdmin", true));
            this.merupakanAdminCheckBox.Location = new System.Drawing.Point(175, 132);
            this.merupakanAdminCheckBox.Name = "merupakanAdminCheckBox";
            this.merupakanAdminCheckBox.Size = new System.Drawing.Size(200, 24);
            this.merupakanAdminCheckBox.TabIndex = 23;
            this.merupakanAdminCheckBox.Text = "Admin";
            this.merupakanAdminCheckBox.UseVisualStyleBackColor = true;
            this.merupakanAdminCheckBox.Visible = false;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(50, 202);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 24;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.akunBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(175, 199);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(200, 22);
            this.namaTextBox.TabIndex = 25;
            // 
            // nomorTeleponLabel
            // 
            nomorTeleponLabel.AutoSize = true;
            nomorTeleponLabel.Location = new System.Drawing.Point(50, 292);
            nomorTeleponLabel.Name = "nomorTeleponLabel";
            nomorTeleponLabel.Size = new System.Drawing.Size(105, 16);
            nomorTeleponLabel.TabIndex = 26;
            nomorTeleponLabel.Text = "Nomor Telepon:";
            // 
            // nomorTeleponTextBox
            // 
            this.nomorTeleponTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.akunBindingSource, "NomorTelepon", true));
            this.nomorTeleponTextBox.Location = new System.Drawing.Point(175, 289);
            this.nomorTeleponTextBox.Name = "nomorTeleponTextBox";
            this.nomorTeleponTextBox.Size = new System.Drawing.Size(200, 22);
            this.nomorTeleponTextBox.TabIndex = 27;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(50, 332);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 16);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.akunBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(175, 329);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '.';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 26);
            this.passwordTextBox.TabIndex = 29;
            // 
            // tanggalLahirLabel
            // 
            tanggalLahirLabel.AutoSize = true;
            tanggalLahirLabel.Location = new System.Drawing.Point(50, 248);
            tanggalLahirLabel.Name = "tanggalLahirLabel";
            tanggalLahirLabel.Size = new System.Drawing.Size(93, 16);
            tanggalLahirLabel.TabIndex = 30;
            tanggalLahirLabel.Text = "Tanggal Lahir:";
            // 
            // tanggalLahirDateTimePicker
            // 
            this.tanggalLahirDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.akunBindingSource, "TanggalLahir", true));
            this.tanggalLahirDateTimePicker.Location = new System.Drawing.Point(175, 244);
            this.tanggalLahirDateTimePicker.Name = "tanggalLahirDateTimePicker";
            this.tanggalLahirDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.tanggalLahirDateTimePicker.TabIndex = 31;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(50, 165);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 32;
            usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.akunBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(175, 162);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 22);
            this.usernameTextBox.TabIndex = 33;
            // 
            // akunBindingSource
            // 
            this.akunBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.Akun);
            // 
            // DaftarAkun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 546);
            this.Controls.Add(merupakanAdminLabel);
            this.Controls.Add(this.merupakanAdminCheckBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(nomorTeleponLabel);
            this.Controls.Add(this.nomorTeleponTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(tanggalLahirLabel);
            this.Controls.Add(this.tanggalLahirDateTimePicker);
            this.Controls.Add(usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DaftarAkun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource akunBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox merupakanAdminCheckBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox nomorTeleponTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.DateTimePicker tanggalLahirDateTimePicker;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

