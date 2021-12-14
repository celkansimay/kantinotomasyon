using System;
using System.Collections.Generic;
using System.Data;
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
    /// SatışEkranı.xaml etkileşim mantığı
    /// </summary>
    public partial class SatışEkranı : Window
    {
        public List<cUsers> UserItem;
        public List<cProducts> ProductsList;
        public List<cStockMovements> StockList;
        public List<cProductSales> ProductSalesList;
        public List<cSavedUsers> SavedUserItem;
        double toplamFiyat = 0;
        public SatışEkranı(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public DataTable dt = new DataTable();
        private void SatisEkrani_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("Barcode", typeof(String));
            dt.Columns.Add("Manufacturer", typeof(String));
            dt.Columns.Add("ProductName", typeof(String));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Price", typeof(double));
            dt.Columns.Add("TotalPrice", typeof(double));
            dt.Columns.Add("InsertBy", typeof(int));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    AddCard(txtBarcode.Text);
            //    //listBox1.Items.Add(txtBarcode.Text);
            //}
        }
        List<cProducts> productItem = new List<cProducts>();
        private void AddCard(string text)
        {
            //if (!string.IsNullOrEmpty(txtBarcode.Text))
            //{
            //    int controlCount = 0;
            //    double totalAmount = 0;
            //    if (dt.Rows.Count > 0)
            //    {
            //        foreach (DataRow item in dt.Rows)
            //        {
            //            if (item["Barcode"].ToString() == txtBarcode.Text)
            //            {
            //                controlCount = 1;

            //                item["Quantity"] = int.Parse(item["Quantity"].ToString()) + 1;
            //                item["TotalPrice"] = double.Parse(item["Price"].ToString()) * double.Parse(item["Quantity"].ToString());
            //            }
            //            totalAmount += double.Parse(item["Price"].ToString()) * double.Parse(item["Quantity"].ToString());
            //        }
            //    }
            //    lblTotalPrice.Text = totalAmount.ToString("N2");

            //    if (controlCount == 0)
            //    {
            //        // burda ürünü sorgulayıp sepete ekleyecez

            //        productItem = cProducts.GetProductsByBarcode(txtBarcode.Text); // Burası Tamam

            //        if (productItem.Count > 0)
            //        {
            //            DataRow dr = dt.NewRow();

            //            dr["ProductId"] = productItem[0].Id;
            //            dr["Barcode"] = productItem[0].Barcode;
            //            dr["Manufacturer"] = productItem[0].Manufacturer;
            //            dr["ProductName"] = productItem[0].Name;
            //            dr["Quantity"] = 1;
            //            dr["Price"] = productItem[0].Price;
            //            dr["TotalPrice"] = productItem[0].Price * int.Parse(dr["Quantity"].ToString());
            //            dr["InsertBy"] = UserItem[0].FrenchiseId;


            //            dt.Rows.Add(dr);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Aradığınız ürün bulunamadı", "Ürün Bulunamadı");
            //        }
            //    }

            //    //Gride veri aktarılacak
            //    dgCard.DataSource = dt;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtCardNumber.Text))
            //{
            //    SavedUserItem = cSavedUsers.GetSavedUserCreditByCardNumber(savedUserItem[0].AboutId);

            //    try
            //    {
            //        if (productItem[0].Price < SavedUserItem[0].KalanBakiye)
            //        {
            //            foreach (DataRow dr in dt.Rows)
            //            {
            //                cProductSales.InsertProductSales(int.Parse(dr["ProductId"].ToString()), savedUserItem[0].AboutId, int.Parse(dr["Quantity"].ToString()), double.Parse(dr["Price"].ToString()), UserItem[0].Id);
            //                cStockMovements.InsertStockMovements(UserItem[0].FrenchiseId, 2, int.Parse(dr["ProductId"].ToString()), int.Parse(dr["Quantity"].ToString()), double.Parse(dr["Price"].ToString()),
            //                    double.Parse(dr["TotalPrice"].ToString()), UserItem[0].Id);
            //                ppdDialog.ShowDialog();

            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Yetersiz Bakiye ", "HATA");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("İşlem yapılamadı. Hata kodu: " + ex.ToString(), "HATA");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Lütfen öğrenci kartını okutunuz", "Kart Bulunamadı");
            //    //Lütfen öğrenci kartını okutunuz mesajı
            //}
        }
        List<cSavedUsers> savedUserItem = new List<cSavedUsers>();

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (!string.IsNullOrEmpty(txtCardNumber.Text))
            //    {
            //        savedUserItem = cSavedUsers.GetSavedUserByCardNumber(11, txtCardNumber.Text);

            //        if (savedUserItem.Count > 0)
            //        {
            //            lblStudentInformation.Text = "Öğrenci Adı: " + savedUserItem[0].StudentName + " " + savedUserItem[0].StudentSurname;
            //        }
            //        else
            //        {
            //            //Kart bilgisi bulunamadı hatası
            //            MessageBox.Show("Kart bilgisi bulunamadı.", "Kart Bulunamadı");
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Lütfen öğrenci kartını okutunuz", "Kart Bulunamadı");
            //        //Lütfen öğrenci kartını okutunuz mesajı
            //    }
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //if (dgCard.SelectedRows.Count > 0)
            //{
            //    //seçili satırı siliyoruz.
            //    dgCard.Rows.RemoveAt(dgCard.SelectedRows[0].Index);
            //}
            //else
            //{
            //    MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            //}
        }

        //private void PdYazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    //    float x = 10.0F;
        //    //    float y = 15.0F;

        //    //    Font drawFont = new Font("Arial", 9);
        //    //    StringFormat sFormat = new StringFormat();
        //    //    sFormat.Alignment = StringAlignment.Near;
        //    //    SolidBrush drawBrush = new SolidBrush(Color.Black);
        //    //    e.Graphics.DrawString("Adı: " + savedUserItem[0].StudentName + " " + savedUserItem[0].StudentSurname, drawFont, drawBrush, x, y);
        //    //    y += 20;
        //    //    double genelToplam = 0;
        //    //    foreach (DataRow row in dt.Rows)
        //    //    {
        //    //        string productText1 = "Ürün Adı: " + row["ProductName"];
        //    //        e.Graphics.DrawString(productText1, drawFont, drawBrush, x, y);
        //    //        y += 15;
        //    //        string productText2 = "Adet: " + row["Quantity"];
        //    //        e.Graphics.DrawString(productText2, drawFont, drawBrush, x, y);
        //    //        y += 15;
        //    //        string productText3 = "Toplam: ₺" + row["TotalPrice"];
        //    //        e.Graphics.DrawString(productText3, drawFont, drawBrush, x, y);
        //    //        genelToplam += double.Parse(row["TotalPrice"].ToString());
        //    //        y += 10;
        //    //        e.Graphics.DrawString("---", drawFont, drawBrush, x, y);
        //    //        y += 20;
        //    //    }

        //    //    e.Graphics.DrawString("Toplam Harcanan: ₺" + genelToplam, drawFont, drawBrush, x, y);
        //    //    y += 20;
        //    //    double kalanbakiye = SavedUserItem[0].KalanBakiye - genelToplam;
        //    //    e.Graphics.DrawString("Kalan Bakiye: ₺" + kalanbakiye.ToString("N2"), drawFont, drawBrush, x, y);

        //}
    }
}
