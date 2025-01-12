namespace Bromo_Airlines_entitiy_framework
{
    partial class UbahStatusPenerbangan
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.perubahanStatusJadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalPenerbanganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalPenerbanganDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            namaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // statusPenerbanganBindingSource
            // 
            this.statusPenerbanganBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.StatusPenerbangan);
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(67, 453);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 5;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusPenerbanganBindingSource, "Nama", true));
            this.namaTextBox.Location = new System.Drawing.Point(120, 450);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(100, 22);
            this.namaTextBox.TabIndex = 6;
            // 
            // perubahanStatusJadwalPenerbanganBindingSource
            // 
            this.perubahanStatusJadwalPenerbanganBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.PerubahanStatusJadwalPenerbangan);
            // 
            // jadwalPenerbanganBindingSource
            // 
            this.jadwalPenerbanganBindingSource.DataSource = typeof(Bromo_Airlines_entitiy_framework.JadwalPenerbangan);
            // 
            // jadwalPenerbanganDataGridView
            // 
            this.jadwalPenerbanganDataGridView.AutoGenerateColumns = false;
            this.jadwalPenerbanganDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jadwalPenerbanganDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.jadwalPenerbanganDataGridView.DataSource = this.jadwalPenerbanganBindingSource;
            this.jadwalPenerbanganDataGridView.Location = new System.Drawing.Point(47, 100);
            this.jadwalPenerbanganDataGridView.Name = "jadwalPenerbanganDataGridView";
            this.jadwalPenerbanganDataGridView.RowHeadersWidth = 51;
            this.jadwalPenerbanganDataGridView.RowTemplate.Height = 24;
            this.jadwalPenerbanganDataGridView.Size = new System.Drawing.Size(773, 320);
            this.jadwalPenerbanganDataGridView.TabIndex = 6;
            this.jadwalPenerbanganDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.jadwalPenerbanganDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KodePenerbangan";
            this.dataGridViewTextBoxColumn2.HeaderText = "KodePenerbangan";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BandaraKeberangkatanID";
            this.dataGridViewTextBoxColumn3.HeaderText = "BandaraKeberangkatanID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BandaraTujuanID";
            this.dataGridViewTextBoxColumn4.HeaderText = "BandaraTujuanID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaskapaiID";
            this.dataGridViewTextBoxColumn5.HeaderText = "MaskapaiID";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TanggalWaktuKeberangkatan";
            this.dataGridViewTextBoxColumn6.HeaderText = "TanggalWaktuKeberangkatan";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DurasiPenerbangan";
            this.dataGridViewTextBoxColumn7.HeaderText = "DurasiPenerbangan";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "HargaPerTiket";
            this.dataGridViewTextBoxColumn8.HeaderText = "HargaPerTiket";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Bandara";
            this.dataGridViewTextBoxColumn9.HeaderText = "Bandara";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Bandara1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Bandara1";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PerubahanStatusJadwalPenerbangan";
            this.dataGridViewTextBoxColumn11.HeaderText = "PerubahanStatusJadwalPenerbangan";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TransaksiHeader";
            this.dataGridViewTextBoxColumn12.HeaderText = "TransaksiHeader";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Maskapai";
            this.dataGridViewTextBoxColumn13.HeaderText = "Maskapai";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // UbahStatusPenerbangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jadwalPenerbanganDataGridView);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UbahStatusPenerbangan";
            this.Size = new System.Drawing.Size(917, 554);
            this.Load += new System.EventHandler(this.UbahStatusPenerbangan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perubahanStatusJadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalPenerbanganDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource statusPenerbanganBindingSource;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.BindingSource perubahanStatusJadwalPenerbanganBindingSource;
        private System.Windows.Forms.BindingSource jadwalPenerbanganBindingSource;
        private System.Windows.Forms.DataGridView jadwalPenerbanganDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}
