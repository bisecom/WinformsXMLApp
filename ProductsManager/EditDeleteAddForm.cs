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
    public partial class EditDeleteAddForm : Form
    {
        public EditDeleteAddForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = Operating.ProductsTable;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditForm myAdd = new AddEditForm();
            myAdd.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           var selectedRow = dataGridView1.SelectedRows[0].Index;
           Operating.ProductsTable.Rows[selectedRow].Delete();
           Operating.ProductsTable.AcceptChanges();
           dataGridView1.DataSource = Operating.ProductsTable;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            Product product = new Product();
            product.SkuNumber = Convert.ToString(selectedRow.Cells[0].Value); 
            product.Category = Convert.ToString(selectedRow.Cells[1].Value);
            product.TradeMark = Convert.ToString(selectedRow.Cells[2].Value);
            product.ProductName = Convert.ToString(selectedRow.Cells[3].Value);
            product.ProductDetails = Convert.ToString(selectedRow.Cells[4].Value);
            product.Supplier = Convert.ToString(selectedRow.Cells[5].Value);
            try
            {
                string str = Convert.ToString(selectedRow.Cells[6].Value);
                if (str.Contains('.'))
                {
                    str = str.Remove(str.IndexOf('.'));
                    product.Price = Convert.ToDecimal(str);
                }
                else product.Price = Convert.ToDecimal(str);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please, put price in correct format! \n");
            }
            product.StorageUnit = Convert.ToString(selectedRow.Cells[7].Value);
                       
            AddEditForm myEditing = new AddEditForm("Product Editing:", product, dataGridView1.SelectedRows[0].Index);
            myEditing.ShowDialog();
        }
    }
}
