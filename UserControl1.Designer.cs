namespace Bromo_Airlines_entitiy_framework
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label jumlahTerminalLabel;
            System.Windows.Forms.Label kodeIATALabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label negaraIDLabel;
            this.bandaraDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kodeIATATextBox = new System.Windows.Forms.TextBox();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandaraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            negaraIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bandaraDataGridView
            // 
            this.bandaraDataGridView.AutoGenerateColumns = false;
            this.bandaraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bandaraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bandaraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Ubah,
            this.Hapus});
            this.bandaraDataGridView.DataSource = this.bandaraBindingSource;
            this.bandaraDataGridView.Location = new System.Drawing.Point(78, 92);
            this.bandaraDataGridView.Name = "bandaraDataGridView";
            this.bandaraDataGridView.RowHeadersWidth = 51;
            this.bandaraDataGridView.RowTemplate.Height = 24;
            this.bandaraDataGridView.Size = new System.Drawing.Size(701, 220);
            this.bandaraDataGridView.TabIndex = 18;
            this.bandaraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bandaraDataGridView_CellContentClick);
            this.bandaraDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.bandaraDataGridView_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Master Bandara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(457, 391);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(52, 16);
            alamatLabel.TabIndex = 20;
            alamatLabel.Text = "Alamat:";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(457, 340);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(109, 16);
            jumlahTerminalLabel.TabIndex = 24;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(74, 394);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(75, 16);
            kodeIATALabel.TabIndex = 26;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // kodeIATATextBox
            // 
            this.kodeIATATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "KodeIATA", true));
            this.kodeIATATextBox.Location = new System.Drawing.Point(176, 388);
            this.kodeIATATextBox.Name = "kodeIATATextBox";
            this.kodeIATATextBox.Size = new System.Drawing.Size(149, 22);
            this.kodeIATATextBox.TabIndex = 27;
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(74, 450);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(37, 16);
            kotaLabel.TabIndex = 28;
            kotaLabel.Text = "Kota:";
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Kota", true));
            this.kotaTextBox.Location = new System.Drawing.Point(176, 444);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(149, 22);
            this.kotaTextBox.TabIndex = 29;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(74, 340);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 30;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(176, 340);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(149, 22);
            this.namaTextBox.TabIndex = 31;
            // 
            // negaraIDLabel
            // 
            negaraIDLabel.AutoSize = true;
            negaraIDLabel.Location = new System.Drawing.Point(74, 507);
            negaraIDLabel.Name = "negaraIDLabel";
            negaraIDLabel.Size = new System.Drawing.Size(72, 16);
            negaraIDLabel.TabIndex = 32;
            negaraIDLabel.Text = "Negara ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 33;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(583, 338);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(196, 22);
            this.numericUpDown1.TabIndex = 34;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(589, 395);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 109);
            this.richTextBox2.TabIndex = 36;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ubah
            // 
            this.Ubah.DataPropertyName = "ID";
            this.Ubah.HeaderText = "";
            this.Ubah.MinimumWidth = 6;
            this.Ubah.Name = "Ubah";
            this.Ubah.Text = "Ubah";
            this.Ubah.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            this.Hapus.DataPropertyName = "ID";
            this.Hapus.HeaderText = "";
            this.Hapus.MinimumWidth = 6;
            this.Hapus.Name = "Hapus";
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo_Airlines_entitiy_framework.Bandara);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nama";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "KodeIATA";
            this.dataGridViewTextBoxColumn3.HeaderText = "KodeIATA";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Kota";
            this.dataGridViewTextBoxColumn4.HeaderText = "Kota";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Negara";
            this.dataGridViewTextBoxColumn10.HeaderText = "Negara";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.HeaderText = "JumlahTerminal";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Alamat";
            this.dataGridViewTextBoxColumn7.HeaderText = "Alamat";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bandaraBindingSource
            // 
            this.bandaraBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.Bandara);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(jumlahTerminalLabel);
            this.Controls.Add(kodeIATALabel);
            this.Controls.Add(this.kodeIATATextBox);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(negaraIDLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bandaraDataGridView);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(935, 703);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bandaraDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandaraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bandaraBindingSource;
        private System.Windows.Forms.DataGridView bandaraDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox kodeIATATextBox;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}
