namespace Bromo_Airlines_entitiy_framework
{
    partial class MasterMaskpai
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
            System.Windows.Forms.Label namaLabel;
            System.Windows.Forms.Label perusahaanLabel;
            System.Windows.Forms.Label jumlahKruLabel;
            System.Windows.Forms.Label deskripsiLabel;
            this.maskapaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maskapaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perusahaanTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            namaLabel = new System.Windows.Forms.Label();
            perusahaanLabel = new System.Windows.Forms.Label();
            jumlahKruLabel = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(87, 408);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 21;
            namaLabel.Text = "Nama:";
            // 
            // perusahaanLabel
            // 
            perusahaanLabel.AutoSize = true;
            perusahaanLabel.Location = new System.Drawing.Point(87, 453);
            perusahaanLabel.Name = "perusahaanLabel";
            perusahaanLabel.Size = new System.Drawing.Size(83, 16);
            perusahaanLabel.TabIndex = 23;
            perusahaanLabel.Text = "Perusahaan:";
            // 
            // jumlahKruLabel
            // 
            jumlahKruLabel.AutoSize = true;
            jumlahKruLabel.Location = new System.Drawing.Point(78, 502);
            jumlahKruLabel.Name = "jumlahKruLabel";
            jumlahKruLabel.Size = new System.Drawing.Size(75, 16);
            jumlahKruLabel.TabIndex = 28;
            jumlahKruLabel.Text = "Jumlah Kru:";
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(489, 407);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 29;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // maskapaiDataGridView
            // 
            this.maskapaiDataGridView.AutoGenerateColumns = false;
            this.maskapaiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.maskapaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maskapaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Ubah,
            this.Hapus});
            this.maskapaiDataGridView.DataSource = this.maskapaiBindingSource;
            this.maskapaiDataGridView.Location = new System.Drawing.Point(66, 66);
            this.maskapaiDataGridView.Name = "maskapaiDataGridView";
            this.maskapaiDataGridView.RowHeadersWidth = 51;
            this.maskapaiDataGridView.RowTemplate.Height = 24;
            this.maskapaiDataGridView.Size = new System.Drawing.Size(738, 290);
            this.maskapaiDataGridView.TabIndex = 1;
            this.maskapaiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maskapaiDataGridView_CellContentClick);
            this.maskapaiDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.maskapaiDataGridView_CellFormatting);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Perusahaan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Perusahaan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JumlahKru";
            this.dataGridViewTextBoxColumn4.HeaderText = "JumlahKru";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Deskripsi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Deskripsi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Ubah
            // 
            this.Ubah.HeaderText = "";
            this.Ubah.MinimumWidth = 6;
            this.Ubah.Name = "Ubah";
            this.Ubah.Text = "Ubah";
            this.Ubah.UseColumnTextForButtonValue = true;
            // 
            // Hapus
            // 
            this.Hapus.HeaderText = "";
            this.Hapus.MinimumWidth = 6;
            this.Hapus.Name = "Hapus";
            this.Hapus.Text = "Hapus";
            this.Hapus.UseColumnTextForButtonValue = true;
            // 
            // maskapaiBindingSource
            // 
            this.maskapaiBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.Maskapai);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Master Maskapai";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(176, 405);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(149, 22);
            this.namaTextBox.TabIndex = 22;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo_Airlines_entitiy_framework.Maskapai);
            // 
            // perusahaanTextBox
            // 
            this.perusahaanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Perusahaan", true));
            this.perusahaanTextBox.Location = new System.Drawing.Point(176, 450);
            this.perusahaanTextBox.Name = "perusahaanTextBox";
            this.perusahaanTextBox.Size = new System.Drawing.Size(149, 22);
            this.perusahaanTextBox.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 27;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(699, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(176, 500);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(149, 22);
            this.numericUpDown1.TabIndex = 30;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(568, 407);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 93);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // MasterMaskpai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(jumlahKruLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(perusahaanLabel);
            this.Controls.Add(this.perusahaanTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskapaiDataGridView);
            this.Name = "MasterMaskpai";
            this.Size = new System.Drawing.Size(935, 579);
            this.Load += new System.EventHandler(this.MasterMaskpai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskapaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource maskapaiBindingSource;
        private System.Windows.Forms.DataGridView maskapaiDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.TextBox perusahaanTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
