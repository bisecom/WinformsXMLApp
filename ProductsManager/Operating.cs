using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProductsManager
{
    [Serializable]
    public static class Operating
    {
        public static XmlSerializer myserialize;
        static DataSet ProductDirDataSet;
        public static DataTable ProductsTable { get; set; }
        static BindingSource SBind;
       
       static Operating()
        {
            myserialize = new XmlSerializer(typeof(List<Product>));
            ProductDirDataSet = new DataSet("Products");
            ProductsTable = new DataTable();
            SBind = new BindingSource();
            SBind.DataSource = ProductsTable;
            GetFromXml();
            //ProductsList = new List<Product>()
            //{
            //    new Product { SkuNumber = "QHRUD", Category = "TV", TradeMark   = "Samsung", ProductName    = "UE55NU7172",
            //    ProductDetails = "Модель позиционируется как оптимальное решение для того, чтобы возглавить в качестве"+
            //    "дисплея домашнее мультимедийное пространство.", Supplier = "Roga & Kopyta", Price  = 14500.0m, StorageUnit  = "pcs"},
            //     new Product { SkuNumber = "43UK6", Category = "TV", TradeMark   = "LG", ProductName    = "43UK6300PLB",
            //    ProductDetails = "Бюджетный 4К-телевизор, оптимально сочетающий в себе современную функциональность и производительное техническое оснащение."+
            //    "IPS-панель разрешением 3840x2160 пикселей имеет диагональ 43 дюйма, широкие углы обзора и поддержку технологии HDR.",
            //    Supplier = "Roga & Kopyta", Price  = 13500.0m, StorageUnit  = "pcs"},
            //     new Product { SkuNumber = "NU719", Category = "TV", TradeMark   = "Samsung", ProductName    = "UE43NU7192",
            //    ProductDetails = "Доступный 4К-телевизор с актуальной «умной» функциональностью, представленный в распространённой компактной диагонали."+
            //    "Модель имеет в своём распоряжении минимальный набор беспроводных коммуникаций в виде Wi-Fi, Miracast, DLNA",
            //    Supplier = "TV Best LTD", Price  = 12500.0m, StorageUnit  = "pcs"},
            //      new Product { SkuNumber = "EF-SIS", Category = "Camera", TradeMark   = "Canon", ProductName    = "EOS 200D kit",
            //    ProductDetails = "Canon EOS 200D kit (18-55mm) EF-S IS STM black – бюджетный зеркальный фотоаппарат для начинающих фотолюбителей."+
            //    "Примечательной особенностью модели стоит определить компактность и простоту в управлении. Первое обусловлено применением 24-мегапиксельной"+
            //    "CMOS-матрицы з физическим размером 22,3x14,9 мм",
            //    Supplier = "Camera LTD", Price  = 15700.0m, StorageUnit  = "pcs"}
            //};

        }
        public static void SaveData()
        {
            ProductDirDataSet.WriteXml("ProductsDirectory.xml");
        }

 
        public static void GetFromXml()
        {
            ProductDirDataSet.ReadXml("ProductsDirectory.xml");
            ProductsTable = ProductDirDataSet.Tables[0];
            
        }

    }
}
