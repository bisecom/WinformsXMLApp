using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManager
{
    [Serializable]
    public class Product
    {
        public string SkuNumber { get; set; }
        public string Category { get; set; }
        public string TradeMark { get; set; }
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public string StorageUnit { get; set; }

        public Product() { }

        public override string ToString()
        {
            return  $"SKU Number = {SkuNumber}, Category = {Category}, Trade Mark = {TradeMark},"+
                    $"Product Name = {ProductName}, Product Details = {ProductDetails}, Supplier = {Supplier},"+
                    $"Price = {Price}, Storage Unit = {StorageUnit}";
        }

    }
}
