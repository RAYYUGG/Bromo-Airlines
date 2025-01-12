using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class MasterMaskpai : UserControl
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public MasterMaskpai()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Maskapai maskapai)
            {
                try
                {
                    maskapai.JumlahKru = (int)numericUpDown1.Value;
                    maskapai.Deskripsi = richTextBox1.Text;

                    var exismaskapai = database.Maskapai.FirstOrDefault(m => m.ID == maskapai.ID);

                    if (exismaskapai != null)
                    {
                        exismaskapai.Nama = maskapai.Nama;
                        exismaskapai.Perusahaan = maskapai.Perusahaan;
                        exismaskapai.JumlahKru = maskapai.JumlahKru;
                        exismaskapai.Deskripsi = maskapai.Deskripsi;
                        database.Entry(exismaskapai).State = EntityState.Modified;
                    }
                    else
                    {
                        database.Maskapai.AddOrUpdate(maskapai);
                    }
                    database.SaveChanges();
                    OnLoad(null);
                    bindingSource1.Clear();
                    numericUpDown1.Value = 0;
                    richTextBox1.Clear();
                    MessageBox.Show("Data berhasil disimpan", "Master Maskapai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    maskapaiBindingSource.DataSource = database.Maskapai.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MasterMaskpai_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            maskapaiBindingSource.DataSource = database.Maskapai.OrderBy( f=> f.Nama).ToList();
        }


        private void maskapaiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void maskapaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (maskapaiBindingSource.Current is Maskapai datamaskapai)
            {
                if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult res = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Master jadwal penerbangan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        database.Maskapai.Remove(datamaskapai);
                        database.SaveChanges();
                        OnLoad(null);
                        MessageBox.Show("Data berhasil dihapus", "Maskapai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (e.ColumnIndex == Ubah.Index)
                {
                        var data = database.Maskapai.AsNoTracking().FirstOrDefault(f => f.Nama == datamaskapai.Nama);
                        bindingSource1.Clear();
                        bindingSource1.Add(data);
                        richTextBox1.Text = datamaskapai.Deskripsi;
                        numericUpDown1.Value = datamaskapai.JumlahKru;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            numericUpDown1.Value = 0;
            richTextBox1.Clear();
        }
    }
}
