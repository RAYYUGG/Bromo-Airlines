using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bromo_Airlines_entitiy_framework
{
    public partial class UbahStatusPenerbangan : UserControl
    {
            BromoAirlinesEntities database = new BromoAirlinesEntities();
            public UbahStatusPenerbangan()
            {
                InitializeComponent();
            }

            private void UbahStatusPenerbangan_Load(object sender, EventArgs e)
            {
                jadwalPenerbanganBindingSource.DataSource = database.JadwalPenerbangan.ToList();
            }

        private void jadwalPenerbanganDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (jadwalPenerbanganDataGridView.Rows[e.RowIndex].DataBoundItem is JadwalPenerbangan datajadwal)
            {
                if (e.ColumnIndex == dataGridViewTextBoxColumn9.Index) e.Value = datajadwal.Bandara.Nama;
                if (e.ColumnIndex == dataGridViewTextBoxColumn10.Index) e.Value = datajadwal.Bandara.Nama;
                if (e.ColumnIndex == dataGridViewTextBoxColumn13.Index) e.Value = datajadwal.Maskapai.Nama;
            }
        }
    }
    }

