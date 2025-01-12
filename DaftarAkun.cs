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
    public partial class DaftarAkun : Form
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public DaftarAkun()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            akunBindingSource.AddNew();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (akunBindingSource.Current is Akun dataakun)
                {
                    dataakun.MerupakanAdmin = merupakanAdminCheckBox.Checked;
                    database.Akun.Add(dataakun);
                    database.SaveChanges();
                    akunBindingSource.Clear();
                    MessageBox.Show("Akun berhasil ditambahkan");  
                }
                else
                {
                    MessageBox.Show("Wajib diisi");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
