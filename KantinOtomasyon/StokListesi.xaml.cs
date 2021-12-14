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
    /// StokHareketleri.xaml etkileşim mantığı
    /// </summary>
    public partial class StokListesi : Window
    {
        public List<cUsers> UserItem;
        public List<cProducts> ProductsList;
        public List<cStockMovements> StockList;
        double genelToplamMaliyet = 0;
        double toplamGelir = 0;
        double rafUrunToplam = 0;
        double ongorulenKar = 0;
        public StokListesi(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();

            //txtToplamMaliyet.Content = "Çok Pahalı";

            ProductsList = cProducts.GetProductsByStockCount(GeneralSettings.franchiseId);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ItemsSource = ProductsList;


            foreach (var item in ProductsList)
            {
                genelToplamMaliyet += item.TotalMaliyet;
                toplamGelir += item.TotalGelir;
                rafUrunToplam += item.RafUrunToplam;
                ongorulenKar += item.ToplamOngorulenKar;
            }

            txtToplamMaliyet.Content = genelToplamMaliyet.ToString();
            txtToplamGelir.Content = toplamGelir.ToString();
            txtRaftakiUrunTop.Content = rafUrunToplam.ToString();
            txtToplamKar.Content = ongorulenKar.ToString();
        }
        private void StokListesi_Load(object sender, EventArgs e)
        {
            ProductsList = cProducts.GetProductsByStockCount(UserItem[0].FrenchiseId);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataContext = ProductsList;
            //dataGridView1.DataSource = ProductsList;
            foreach (var item in ProductsList)
            {
                genelToplamMaliyet += item.TotalMaliyet;
                toplamGelir += item.TotalGelir;
                rafUrunToplam += item.RafUrunToplam;
                ongorulenKar += item.ToplamOngorulenKar;
            }


            //txtToplamMaliyet.Text = genelToplamMaliyet.ToString();
            //txtToplamGelir.Text = toplamGelir.ToString();
            //txtRaftakiUrunTop.Text = rafUrunToplam.ToString();
            //txtToplamKar.Text = ongorulenKar.ToString();
        }
        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    int stockId = StockList[e.RowIndex].Id;
            //}
        }
    }
}
