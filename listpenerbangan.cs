using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class listpenerbangan : Form
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public listpenerbangan(string bandarakeberangkatan, string bandaratujuan, DateTime date, int penumpang)
        {
            InitializeComponent();
            label2.Text = bandarakeberangkatan.ToString();
            label3.Text = bandaratujuan.ToString();
            label4.Text = date.ToString();
            label5.Text = penumpang.ToString() + " Penumpang";
        }

        private void listpenerbangan_Load(object sender, EventArgs e)
        {
            jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();
            var list = new List<string>()
            {
                "Harga Terendah",
                "Keberangkatan Paling Awal",
                "Keberangkatan Paling Akhir",
                "Kedatangan Paling Awal",
                "Kedatangan Paling Akhir",
                "Durasi Tercepat"
            };
            foreach (var item in list)
            {
                comboBox1.Items.Add(item.ToString());
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
                        if (jadwalPenerbanganDataGridView.Columns[e.ColumnIndex].Name == "WaktuKeberangkatan")
                        {
                            e.Value = data.TanggalWaktuKeberangkatan.ToString("HH:mm");
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string username = "";
            customermain customer = new customermain(username);
            customer.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jadwalPenerbanganBindingSource.Current is  JadwalPenerbangan datajadwal)
            {
                if (comboBox1.Text == "Harga Terendah")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderBy(f => f.HargaPerTiket).ToList();
                }
                if (comboBox1.Text == "Keberangkatan Paling Awal")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderBy(f => f.TanggalWaktuKeberangkatan).ToList();
                }
                if (comboBox1.Text == "Keberangkatan Paling Akhir")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderByDescending(f => f.TanggalWaktuKeberangkatan).ToList();
                }
                if (comboBox1.Text == "Kedatangan Paling Awal")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderBy(f => f.DurasiPenerbangan).ToList();
                }
                if (comboBox1.Text == "Kedatangan Paling Akhir")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderByDescending(f => f.DurasiPenerbangan).ToList();
                }
                if (comboBox1.Text == "Durasi Tercepat")
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.OrderBy(f => f.DurasiPenerbangan).ToList();
                }
            }
        }

        private void jadwalPenerbanganDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (jadwalPenerbanganBindingSource.Current is JadwalPenerbangan datajadwal)
            {

                if (e.ColumnIndex == BeliTiket.Index)
                {
                    string bandarakeberangkatan = label2.Text;
                    string bandaratujuan = label3.Text;
                    string maskapai = datajadwal.Maskapai.Nama;
                    string penumpang = label5.Text;
                    string date = label4.Text;
                    string tanggalpenerbangan = datajadwal.TanggalWaktuKeberangkatan.ToString();
                    DetailPenumpang detail = new DetailPenumpang(bandarakeberangkatan, bandaratujuan, maskapai, penumpang, date, tanggalpenerbangan);
                    detail.Show();
                    this.Hide();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var startTime = DateTime.Today.AddHours(0);
                var endTime = DateTime.Today.AddHours(6);

                var filteredData = database.JadwalPenerbangan
                    .Where(f => f.TanggalWaktuKeberangkatan >= startTime && f.TanggalWaktuKeberangkatan <= endTime)
                    .OrderBy(f => f.TanggalWaktuKeberangkatan)
                    .ToList();

                jadwalPenerbanganBindingSource.DataSource = filteredData;
                if (!checkBox1.Checked)
                {
                    jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            var starttime = DateTime.Today.AddHours(6);
            var endtime = DateTime.Today.AddHours(12);

            var filtered = database.JadwalPenerbangan.Where(f => f.TanggalWaktuKeberangkatan >= starttime && f.TanggalWaktuKeberangkatan <= endtime).OrderBy(f => f.TanggalWaktuKeberangkatan).ToList();
            jadwalPenerbanganBindingSource.DataSource = filtered;
            if (!checkBox2.Checked)
            {
                jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();
            }

        }
    }
}
