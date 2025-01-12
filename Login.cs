using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class Login : Form
    {
        BromoAirlinesEntities database = new BromoAirlinesEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkun daftar = new DaftarAkun();
            daftar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text; 

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua input harus terisi", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var akun = database.Akun.FirstOrDefault(f => f.Username == username && f.Password == password);

            if (akun != null)
            {
                if (akun.MerupakanAdmin)
                {
                    AdminMain admin = new AdminMain();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    customermain customer = new customermain(username);
                    customer.Show();
                    this.Hide();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            akunBindingSource.DataSource = database.Akun.Select(f => new { f.Username, f.Password, f.MerupakanAdmin}).FirstOrDefault();
            akunBindingSource.Clear();
        }
    }
}
