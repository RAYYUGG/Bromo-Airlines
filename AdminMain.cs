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
    public partial class AdminMain : Form
    {
        bool klik = false;
       
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (klik)
            {
                klik = false;
                panel5.Visible = false;
            }
            else
            {
                klik = true;
                panel5.Visible = true;
            }
        }

        public void OpenUC(UserControl uc, Panel p)
        {
        
            if (!p.Controls.Contains(uc))
            {
                p.Controls.Add(uc);  
                uc.Dock = DockStyle.Fill; 
            }

            uc.BringToFront();
            uc.Visible = true; 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UserControl1 user = new UserControl1();
            OpenUC(user, panel6);
            color();
            label2.ForeColor = Color.Black;
        }

        private void color()
        {
            label2.ForeColor = Color.Gray;
            label3.ForeColor = Color.Gray;
            label4.ForeColor = Color.Gray;
            label5.ForeColor = Color.Gray;
            label6.ForeColor = Color.Gray;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MasterMaskpai maskapai = new MasterMaskpai();
            OpenUC(maskapai, panel6);
            color();
            label3.ForeColor = Color.Black;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Masterjadwalpenerbangan jadwal = new Masterjadwalpenerbangan();
            OpenUC(jadwal, panel6);
            color();
            label4.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MasterKodePromo promo = new MasterKodePromo();
            OpenUC(promo, panel6);
            color();
            label5.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UbahStatusPenerbangan ubah = new UbahStatusPenerbangan();
            OpenUC(ubah, panel6);
            color();
            label6.ForeColor = Color.Black;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
