using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class MasterKodePromo : UserControl
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public MasterKodePromo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            berlakuSampaiDateTimePicker.Value = DateTime.Now;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            richTextBox1.Clear();
        }

        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            var kode = database.KodePromo.OrderBy(f => f.Kode).ToList();
            kodePromoBindingSource.DataSource = kode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is KodePromo datakode)
            {
                try
                {
                    datakode.PersentaseDiskon = (int)numericUpDown1.Value;
                    datakode.MaksimumDiskon = (int)numericUpDown2.Value;
                    datakode.Deskripsi = richTextBox1.Text;

                    var existkode = database.KodePromo.FirstOrDefault(f => f.ID == datakode.ID);
                    if (existkode != null)
                    {
                        existkode.Kode = datakode.Kode;
                        existkode.PersentaseDiskon = datakode.PersentaseDiskon;
                        existkode.MaksimumDiskon = datakode.MaksimumDiskon;
                        existkode.BerlakuSampai = datakode.BerlakuSampai;
                        existkode.Deskripsi = datakode.Deskripsi;
                        database.Entry(existkode).State = EntityState.Modified;
                    }
                    else
                    {
                        database.KodePromo.AddOrUpdate(datakode);
                    }
                    database.SaveChanges();
                    OnLoad(null);
                    berlakuSampaiDateTimePicker.Value = DateTime.Now;
                    numericUpDown1.Value = 0;
                    numericUpDown2.Value = 0;
                    richTextBox1.Clear();
                    MessageBox.Show("Data disimpan", "Master Kode Promo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kodePromoBindingSource.DataSource = database.KodePromo.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void kodePromoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (kodePromoBindingSource.Current is KodePromo datakode)
            {
                if (e.ColumnIndex == Ubah.Index)
                {
                    var data = database.KodePromo.AsNoTracking().FirstOrDefault (f => f.Kode == datakode.Kode);
                    bindingSource1.Clear();
                    bindingSource1.Add(data);
                    numericUpDown1.Value = (int)datakode.PersentaseDiskon;
                    numericUpDown2.Value = (int)datakode.PersentaseDiskon;
                    richTextBox1.Text = datakode.Deskripsi;
                }
                else if (e.ColumnIndex == Hapus.Index)
                {
                    database.KodePromo.Remove(datakode);
                    database.SaveChanges();
                    OnLoad(null);
                    MessageBox.Show("Data berhasil dihapus", "Master Kode Promo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
