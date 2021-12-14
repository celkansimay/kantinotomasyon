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
    public partial class StokHareketleri : Window
    {
        public List<cUsers> UserItem;
        public List<cProducts> ProductsList;
        public List<cStockMovements> StockList;
        public StokHareketleri(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();

            StockList = cStockMovements.GetStockByAll(GeneralSettings.franchiseId);
            dgStockMov.AutoGenerateColumns = false;
            dgStockMov.ItemsSource = StockList;
        }

        private void dgStockMov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (dgStockMov.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
                //int stockId = StockList[e.Index].Id;
                //StockList=cStockMovements.GetStockByAll(UserItem.)
                //stokhareketleri.Show();
                //this.Close();


                StockList = cStockMovements.GetStockByAll(UserItem[0].FrenchiseId);
                dgStockMov.ItemsSource = StockList;
                //grdusers.ItemBindingGroup();

            //}
        }
    }
}
