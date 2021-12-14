using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KantinOtomasyon
{
    /// <summary>
    /// ÜrünGüncelle.xaml etkileşim mantığı
    /// </summary>
    public partial class ÜrünGüncelle : Window
    {
        public List<cProducts> ProductsItem;
        public List<cUsers> UserItem;
        public int productId;
        public ÜrünGüncelle(List<cUsers> LoginControlItem, int vProductId)
        {
            productId = vProductId;
            UserItem = LoginControlItem;
            InitializeComponent();
        }
        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            ProductsItem = cProducts.GetProductsById(productId);
            txtProductName.Text = ProductsItem[0].Name;
            txtManufacturer.Text = ProductsItem[0].Manufacturer;
            txtBarcode.Text = ProductsItem[0].Barcode;
            txtPrice.Text = ProductsItem[0].Price.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtManufacturer.Text) && !string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                cProducts.UpdateProducts(productId, txtProductName.Text, txtManufacturer.Text, txtBarcode.Text, double.Parse(txtPrice.Text), UserItem[0].Id);

                Ürünler urunler = new Ürünler(UserItem);
                urunler.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }
    }
}
