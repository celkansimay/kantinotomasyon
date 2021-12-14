using KantinOtomasyon.App_Code;
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
    /// Ürünler.xaml etkileşim mantığı
    /// </summary>
    public partial class Ürünler : Window
    {
        public List<cUsers> UserItem;
        public List<cProducts> ProductsList;
        public Ürünler(List<cUsers> LoginControlItem)
        {
            //Urunler_Load();
            UserItem = LoginControlItem;
            InitializeComponent();


            ProductsList = cProducts.GetProductsByAll(GeneralSettings.franchiseId);
            dgProducts.AutoGenerateColumns = false;
            dgProducts.ItemsSource = ProductsList;

            //double totalAmount = 0;

            //foreach (var item in ProductsList)
            //{
            //    totalAmount += item.Price;
            //}

            //lbl.tex

        }

        private void Urunler_Load()
        {
            ProductsList = new List<cProducts>();
            ProductsList = cProducts.GetProductsByAll(GeneralSettings.franchiseId);
            //dgProducts.AutoGenerateColumns = false;
            dgProducts.ItemsSource = ProductsList;
        }

      
        //private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (dgProducts.   .Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    //ataGrid.Items.IndexOf(cell.Item)
        //    {
        //        int productId = ProductsList[e.RowIndex].Id;
        //        ÜrünGüncelle urunGuncelle = new ÜrünGüncelle(UserItem, productId);
        //        urunGuncelle.Show();
        //        this.Close();
        //    }
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ÜrünEkle urunEkle = new ÜrünEkle(UserItem);
            urunEkle.Show();
        }
    }
}
