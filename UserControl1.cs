using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class UserControl1 : UserControl
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
            var bandaraList = database.Bandara.OrderBy(b => b.Nama).ToList();

            bandaraBindingSource.DataSource = bandaraList;

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(database.Negara.Select(F => F.Nama).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Bandara databandara)
            {
                if (string.IsNullOrEmpty(richTextBox2.Text))
                {
                    MessageBox.Show("Alamat tidak boleh kosong");
                    return;
                }

                databandara.Alamat = richTextBox2.Text;
                databandara.NegaraID = comboBox1.SelectedIndex;
                databandara.JumlahTerminal = (int)numericUpDown1.Value;

                try
                {
                   
                    var existingbandara = database.Bandara.FirstOrDefault(b => b.ID == databandara.ID);
                    if (existingbandara != null)
                    {
                        existingbandara.Nama = databandara.Nama;
                        existingbandara.Alamat = databandara.Alamat;
                        existingbandara.Kota = databandara.Kota;
                        existingbandara.KodeIATA = databandara.KodeIATA;
                        existingbandara.JumlahTerminal = databandara.JumlahTerminal;
                        existingbandara.NegaraID = databandara.NegaraID;
                        database.Entry(existingbandara).State = EntityState.Modified;
                    }
                    else
                    {
                        database.Bandara.AddOrUpdate(databandara);
                    }
              
                    
                    database.SaveChanges();

                    OnLoad(null);
                    bindingSource1.Clear();
                    comboBox1.Items.Clear();
                    numericUpDown1.Value = 0;
                    richTextBox2.Clear();
                    MessageBox.Show("Data berhasil disimpan", "Bandara", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bandaraBindingSource.DataSource = database.Bandara.OrderBy(f => f.Nama).ToList();
                }
                catch (Exception ex)
                {
              
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bandaraDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (bandaraDataGridView.Rows[e.RowIndex].DataBoundItem is Bandara databandara)
            {
                if (e.ColumnIndex == dataGridViewTextBoxColumn10.Index) e.Value = databandara.Negara.Nama;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            comboBox1.Items.Clear();
            numericUpDown1.Value = 0;
            richTextBox2.Clear();
        }

        private void bandaraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bandaraBindingSource.Current is Bandara databandara)
            {
                if (e.ColumnIndex == Ubah.Index)
                {
                    var data = database.Bandara.AsNoTracking().FirstOrDefault(f => f.Nama == databandara.Nama);
                    bindingSource1.Clear();
                    bindingSource1.Add(data);
                    comboBox1.Text = databandara.Negara.Nama;
                    numericUpDown1.Value = databandara.JumlahTerminal;
                    richTextBox2.Text = databandara.Alamat;
                }
                if (e.ColumnIndex == Hapus.Index)
                {
                    DialogResult res = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Master jadwal penerbangan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        database.Bandara.Remove(databandara);
                        database.SaveChanges();
                        OnLoad(null);
                        bindingSource1.Clear();
                        comboBox1.Items.Clear();
                        numericUpDown1.Value = 0;
                        richTextBox2.Clear();
                        MessageBox.Show("Berhasil dihapus", "Bandara", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }
    }
}
