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
    /// ÜrünEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class ÜrünEkle : Window
    {
        public List<cUsers> UserItem;
        public ÜrünEkle(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtManufacturer.Text) && !string.IsNullOrEmpty(txtBarcode.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                cProducts.InsertProducts(UserItem[0].FrenchiseId, txtProductName.Text, txtManufacturer.Text, txtBarcode.Text, double.Parse(txtPrice.Text), UserItem[0].Id);

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
