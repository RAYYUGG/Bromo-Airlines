namespace Bromo_Airlines_entitiy_framework
{
    partial class MasterKodePromo
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
            System.Windows.Forms.Label berlakuSampaiLabel;
            System.Windows.Forms.Label deskripsiLabel;
            System.Windows.Forms.Label kodeLabel;
            System.Windows.Forms.Label maksimumDiskonLabel;
            System.Windows.Forms.Label persentaseDiskonLabel;
            this.kodePromoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.berlakuSampaiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kodeTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kodePromoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubah = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Hapus = new System.Windows.Forms.DataGridViewButtonColumn();
            berlakuSampaiLabel = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            kodeLabel = new System.Windows.Forms.Label();
            maksimumDiskonLabel = new System.Windows.Forms.Label();
            persentaseDiskonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // berlakuSampaiLabel
            // 
            berlakuSampaiLabel.AutoSize = true;
            berlakuSampaiLabel.Location = new System.Drawing.Point(57, 415);
            berlakuSampaiLabel.Name = "berlakuSampaiLabel";
            berlakuSampaiLabel.Size = new System.Drawing.Size(106, 16);
            berlakuSampaiLabel.TabIndex = 17;
            berlakuSampaiLabel.Text = "Berlaku Sampai:";
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(536, 386);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 19;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(57, 386);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(42, 16);
            kodeLabel.TabIndex = 23;
            kodeLabel.Text = "Kode:";
            // 
            // maksimumDiskonLabel
            // 
            maksimumDiskonLabel.AutoSize = true;
            maksimumDiskonLabel.Location = new System.Drawing.Point(57, 470);
            maksimumDiskonLabel.Name = "maksimumDiskonLabel";
            maksimumDiskonLabel.Size = new System.Drawing.Size(120, 16);
            maksimumDiskonLabel.TabIndex = 25;
            maksimumDiskonLabel.Text = "Maksimum Diskon:";
            // 
            // persentaseDiskonLabel
            // 
            persentaseDiskonLabel.AutoSize = true;
            persentaseDiskonLabel.Location = new System.Drawing.Point(57, 442);
            persentaseDiskonLabel.Name = "persentaseDiskonLabel";
            persentaseDiskonLabel.Size = new System.Drawing.Size(124, 16);
            persentaseDiskonLabel.TabIndex = 27;
            persentaseDiskonLabel.Text = "Persentase Diskon:";
            // 
            // kodePromoDataGridView
            // 
            this.kodePromoDataGridView.AutoGenerateColumns = false;
            this.kodePromoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kodePromoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kodePromoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Ubah,
            this.Hapus});
            this.kodePromoDataGridView.DataSource = this.kodePromoBindingSource;
            this.kodePromoDataGridView.Location = new System.Drawing.Point(62, 79);
            this.kodePromoDataGridView.Name = "kodePromoDataGridView";
            this.kodePromoDataGridView.RowHeadersWidth = 51;
            this.kodePromoDataGridView.RowTemplate.Height = 24;
            this.kodePromoDataGridView.Size = new System.Drawing.Size(784, 286);
            this.kodePromoDataGridView.TabIndex = 1;
            this.kodePromoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kodePromoDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Master Kode Promo";
            // 
            // berlakuSampaiDateTimePicker
            // 
            this.berlakuSampaiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindingSource1, "BerlakuSampai", true));
            this.berlakuSampaiDateTimePicker.Location = new System.Drawing.Point(187, 411);
            this.berlakuSampaiDateTimePicker.Name = "berlakuSampaiDateTimePicker";
            this.berlakuSampaiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.berlakuSampaiDateTimePicker.TabIndex = 18;
            // 
            // kodeTextBox
            // 
            this.kodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Kode", true));
            this.kodeTextBox.Location = new System.Drawing.Point(187, 383);
            this.kodeTextBox.Name = "kodeTextBox";
            this.kodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.kodeTextBox.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(187, 442);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 28;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(187, 470);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown2.TabIndex = 29;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(617, 394);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(216, 97);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(695, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 29);
            this.button1.TabIndex = 31;
            this.button1.Text = "Batal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 29);
            this.button2.TabIndex = 32;
            this.button2.Text = "Simpan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Bromo_Airlines_entitiy_framework.KodePromo);
            // 
            // kodePromoBindingSource
            // 
            this.kodePromoBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.KodePromo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kode";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersentaseDiskon";
            this.dataGridViewTextBoxColumn3.HeaderText = "PersentaseDiskon";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaksimumDiskon";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaksimumDiskon";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BerlakuSampai";
            this.dataGridViewTextBoxColumn5.HeaderText = "BerlakuSampai";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Deskripsi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Deskripsi";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransaksiHeader";
            this.dataGridViewTextBoxColumn7.HeaderText = "TransaksiHeader";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
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
            // MasterKodePromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(berlakuSampaiLabel);
            this.Controls.Add(this.berlakuSampaiDateTimePicker);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(kodeLabel);
            this.Controls.Add(this.kodeTextBox);
            this.Controls.Add(maksimumDiskonLabel);
            this.Controls.Add(persentaseDiskonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodePromoDataGridView);
            this.Name = "MasterKodePromo";
            this.Size = new System.Drawing.Size(935, 579);
            this.Load += new System.EventHandler(this.MasterKodePromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodePromoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource kodePromoBindingSource;
        private System.Windows.Forms.DataGridView kodePromoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker berlakuSampaiDateTimePicker;
        private System.Windows.Forms.TextBox kodeTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Ubah;
        private System.Windows.Forms.DataGridViewButtonColumn Hapus;
    }
}
