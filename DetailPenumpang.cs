using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class DetailPenumpang : Form
    {
        public DetailPenumpang(string bandarakeberangkatan, string bandaratujuan, string date, string penumpang, string maskapai, string tanggalpenerbangan)
        {
            InitializeComponent();
            label7.Text = bandarakeberangkatan.ToString();
            label8.Text = bandaratujuan.ToString();
            label9.Text = maskapai.ToString();
            label13.Text = penumpang.ToString();
            label12.Text = date.ToString();
            label11.Text = tanggalpenerbangan.ToString();
        }

        private void DetailPenumpang_Load(object sender, EventArgs e)
        {
            var list = new List<string>()
            {
                "Tuan",
                "Nyonya"
            };

            foreach (var item in list)
            {
                comboBox1.Items.Add(item.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string bandarakeberangkatan = "";
            string bandaratujuan = "";
            DateTime date = DateTime.UtcNow;
            int penumpang = 0;
            listpenerbangan penerbangan = new listpenerbangan(bandarakeberangkatan, bandaratujuan, date, penumpang);
            penerbangan.Show();
            this.Hide();
        }
    }
}
