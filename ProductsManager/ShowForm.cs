using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsManager
{
    public partial class ShowForm : Form
    {
        public ShowForm(DataTable dtable)
        {
            InitializeComponent();
            PopulateDataGrid(dtable);
        }

        public void PopulateDataGrid(DataTable dtable)
        {
            dataGridView1.DataSource = dtable;
            //Added
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

    }
}
