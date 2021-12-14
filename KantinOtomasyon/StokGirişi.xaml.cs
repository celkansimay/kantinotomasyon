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
    /// StokGirişi.xaml etkileşim mantığı
    /// </summary>
    public partial class StokGirişi : Window
    {
        public List<cUsers> UserItem;
        public List<cProducts> ProductsList;
        public StokGirişi(List<cUsers> LoginControlItem)
        {
            InitializeComponent();
            UserItem = LoginControlItem;
            ProductsList = cProducts.GetProductsByAll(UserItem[0].FrenchiseId);
            cbProducts.DataContext= ProductsList;
            cbProducts.DisplayMemberPath = "Name";
            cbProducts.DisplayMemberPath = "Id";
            //cbProducts.DataSource = ProductsList;
            //cbProducts.DisplayMember = "Name";
            //cbProducts.ValueMember = "Id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrEmpty(txtTotalPrice.Text))
            {
                int quantity = int.Parse(txtQuantity.Text);
                double totalPrice = double.Parse(txtTotalPrice.Text);
                double unitPrice = totalPrice / double.Parse(quantity.ToString());


                cStockMovements.InsertStockMovements(UserItem[0].FrenchiseId, 1, int.Parse(cbProducts.SelectedValue.ToString()), quantity, unitPrice, totalPrice, UserItem[0].Id);

                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }
    }
}
