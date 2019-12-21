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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ShowForm showAll = new ShowForm(Operating.ProductsTable);
            showAll.Show();
        }

        private void buttonAmend_Click(object sender, EventArgs e)
        {
            EditDeleteAddForm myAmend = new EditDeleteAddForm();
            myAmend.Show();
        }

        private void MainForm_Closing(object sender, EventArgs e)
        {
           Operating.SaveData();
        }
    }
}
