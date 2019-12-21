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
    public partial class AddEditForm : Form
    {
        private int rowIndex;
        public AddEditForm()
        {
            InitializeComponent();
        }
        public AddEditForm(string str, Product obj, int index)
        {
            InitializeComponent();
            this.Text = str;
            this.label1.Text = str;
            this.buttonSave.Tag = "Editing";
            textBoxSku.Text = obj.SkuNumber;
            textBoxCategory.Text = obj.Category;
            textBoxTM.Text = obj.TradeMark;
            textBoxPrName.Text = obj.ProductName;
            textBoxProductDetails.Text = obj.ProductDetails;
            textBoxSupplier.Text = obj.Supplier;
            textBoxStoreUn.Text = obj.StorageUnit;
            textBoxPrice.Text = obj.Price.ToString();
            rowIndex = index;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            decimal testPrice = 0.0m;
            bool numberIsDecimal = true;
            if (this.buttonSave.Tag == "Editing")
            {
                Operating.ProductsTable.Rows[rowIndex].SetField(0, textBoxSku.Text);
                Operating.ProductsTable.Rows[rowIndex].SetField(1, textBoxCategory.Text);
                Operating.ProductsTable.Rows[rowIndex].SetField(2, textBoxTM.Text);
                Operating.ProductsTable.Rows[rowIndex].SetField(3, textBoxPrName.Text);
                Operating.ProductsTable.Rows[rowIndex].SetField(4, textBoxProductDetails.Text);
                Operating.ProductsTable.Rows[rowIndex].SetField(5, textBoxSupplier.Text);
                try
                {
                    testPrice = Convert.ToDecimal(textBoxPrice.Text);
                }
                catch (Exception ex)
                { MessageBox.Show("Please, put price in correct format! \n"); numberIsDecimal = false;
                }
                               
                Operating.ProductsTable.Rows[rowIndex].SetField(7, textBoxStoreUn.Text);
                if (numberIsDecimal)
                {
                    Operating.ProductsTable.Rows[rowIndex].SetField(6, textBoxPrice.Text);
                    this.Close();
                }

            }
            else {
                
                try
                {
                    testPrice = Convert.ToDecimal(textBoxPrice.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please, put price in correct format! \n");
                    numberIsDecimal = false;
                }

                if (textBoxCategory.Text != "" && textBoxTM.Text != "" && textBoxPrName.Text != "" &&
                    textBoxProductDetails.Text != "" && textBoxSupplier.Text != "" && textBoxPrice.Text != "" && textBoxStoreUn.Text != "" && numberIsDecimal)
                {
                    Operating.ProductsTable.Rows.Add(new object[] {textBoxSku.Text, textBoxCategory.Text, textBoxTM.Text, textBoxPrName.Text,
                textBoxProductDetails.Text, textBoxSupplier.Text, textBoxPrice.Text, textBoxStoreUn.Text});
                    this.Close();
                }
                else MessageBox.Show("Please, fill in all fields!!!");
            }

        }
    }
}
