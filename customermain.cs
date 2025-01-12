using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class customermain : Form
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public customermain(string username)
        {
            InitializeComponent();
            label3.Text = username;
        }

        private void SetUpAutoComplete()
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var bandaranames = database.Bandara.Select(f => new { f.Nama, f.Kota, f.KodeIATA }).ToList();

            AutoCompleteStringCollection autoCompleteData = new AutoCompleteStringCollection();
            foreach (var bandara in bandaranames)
            {
                string bandaraDisplayText = $"{bandara.Nama} - {bandara.Kota} ({bandara.KodeIATA})";
                autoCompleteData.Add(bandaraDisplayText);
            }

            textBox1.AutoCompleteCustomSource = autoCompleteData;

            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBox2.AutoCompleteCustomSource = autoCompleteData;
        }

        private void customermain_Load(object sender, EventArgs e)
        {
            SetUpAutoComplete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bandarakeberangkatan = textBox1.Text;
            string bandaratujuan = textBox2.Text;
            DateTime date = dateTimePicker1.Value;
            int penumpang = (int)numericUpDown1.Value;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Semua data harus terisi", "Customer Main", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Bandara keberangkatan dan Bandara tujuan harus berbeda", "Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                listpenerbangan penerbangan = new listpenerbangan(bandarakeberangkatan, bandaratujuan, date, penumpang);
                penerbangan.Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }
    }
}
