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
    /// BakiyeEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class BakiyeEkle : Window
    {
        List<cUsers> UserItem = new List<cUsers>();
        public List<cSavedUsersCredit> SavedUsersCreditItem;
        public BakiyeEkle(List<cUsers> LoginControlItem)
        {
            //UserItem = UserControl;
            //Burada bir sorun var
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //List<cUsers> UserItem=new List<cUsers>();
            List<cSavedUsersCredit> SavedUsersCreditItem=new List<cSavedUsersCredit>();

            if (!string.IsNullOrEmpty(txtCardNo.Text) && !string.IsNullOrEmpty(txtAmount.Text))
            {
                List<cSavedUsers> savedUserItem = cSavedUsers.GetSavedUserByCardNumber(11, txtCardNo.Text);

                cSavedUsersCredit.InsertAmount(savedUserItem[0].AboutId, double.Parse(txtAmount.Text), UserItem[0].Id);
                //int pId, int pSavedUserId, float pAmount, string pCardNumber, int pInsertBy
                BakiyeEkle bakiyeekle = new BakiyeEkle(UserItem);
                bakiyeekle.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }
    }
}
