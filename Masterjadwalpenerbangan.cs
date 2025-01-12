using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class Masterjadwalpenerbangan : UserControl
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public Masterjadwalpenerbangan()
        {
            InitializeComponent();
        }

        private void Masterjadwalpenerbangan_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();

            comboBox1.DataSource = database.Bandara.ToList();
            comboBox2.DataSource = database.Bandara.ToList();
            comboBox3.DataSource = database.Maskapai.ToList();

            comboBox1.DisplayMember = "Nama"; 
            comboBox1.ValueMember = "ID";    

            comboBox2.DisplayMember = "Nama";
            comboBox2.ValueMember = "ID";

            comboBox3.DisplayMember = "Nama"; 
            comboBox3.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            textBox1.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (bindingSource1.Current is JadwalPenerbangan datajadwal)
            {

                database.JadwalPenerbangan.AddOrUpdate(datajadwal);
                datajadwal.BandaraKeberangkatanID = (int)comboBox1.SelectedValue;
                datajadwal.BandaraTujuanID = (int)comboBox2.SelectedValue;
                datajadwal.MaskapaiID = (int)comboBox3.SelectedValue;
                datajadwal.HargaPerTiket = (int)numericUpDown1.Value;
                datajadwal.TanggalWaktuKeberangkatan = datajadwal.TanggalWaktuKeberangkatan.Date.Add(tanggalWaktuKeberangkatanDateTimePicker.Value.TimeOfDay);
                database.SaveChanges();
                bindingSource1.Clear();
                tanggalWaktuKeberangkatanDateTimePicker.Value = DateTime.Now;
                textBox1.Clear();
                numericUpDown1.Value = 0;
                MessageBox.Show("Data berhasil disimpan", "Master Jadwal Penerbangan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();
            }
        }

        private void jadwalPenerbanganDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (jadwalPenerbanganDataGridView.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan datajadwal)
            {
                if (e.ColumnIndex == dataGridViewTextBoxColumn9.Index) e.Value = datajadwal.Bandara.Nama;
                if (e.ColumnIndex == dataGridViewTextBoxColumn10.Index) e.Value = datajadwal.Bandara.Nama;
                if (e.ColumnIndex == dataGridViewTextBoxColumn13.Index) e.Value = datajadwal.Maskapai.Nama;

                if (e.RowIndex >= 0)
                {
                    var data = jadwalPenerbanganDataGridView.Rows[e.RowIndex].DataBoundItem as JadwalPenerbangan;

                    if (data != null)
                    {
                        if (jadwalPenerbanganDataGridView.Columns[e.ColumnIndex].Name == "TanggalWaktuKeberangkatan")
                        {
                            e.Value = data.TanggalWaktuKeberangkatan.ToString("HH:mm"); 
                        }
                    }
                }
            }
        }

        private void jadwalPenerbanganDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (jadwalPenerbanganBindingSource.Current is JadwalPenerbangan datajadwal)
            {
                if (e.ColumnIndex == Ubah.Index)
                {
                    var data = database.JadwalPenerbangan.AsNoTracking().FirstOrDefault(f => f.KodePenerbangan == datajadwal.KodePenerbangan);
                    bindingSource1.Clear();
                    bindingSource1.Add(data);
                    comboBox1.Text = datajadwal.Bandara.Nama;
                    comboBox2.Text = datajadwal.Bandara.Nama;
                    comboBox3.Text = datajadwal.Maskapai.Nama;

                    numericUpDown1.Value = (int)datajadwal.HargaPerTiket;
                }
                else if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult res = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Master jadwal penerbangan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        database.JadwalPenerbangan.Remove(datajadwal);
                        database.SaveChanges();
                        OnLoad(null);
                        MessageBox.Show("Data berhasil dihapus", "Master Jadwal Penerbangan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
