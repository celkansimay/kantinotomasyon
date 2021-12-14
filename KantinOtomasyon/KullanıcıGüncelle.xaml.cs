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
    /// KullanıcıGüncelle.xaml etkileşim mantığı
    /// </summary>
    public partial class KullanıcıGüncelle : Window
    {
        public List<cUsers> UserItem;
        public int userId;
        public KullanıcıGüncelle(List<cUsers> LoginControlItem, int vuserId)
        {
            userId = vuserId;
            UserItem = LoginControlItem;
            InitializeComponent();
        }
        private void KullanıcıGuncelle_Load(object sender, EventArgs e)
        {
            UserItem = cUsers.GetUsersById(userId);
            txtName.Text = UserItem[0].Name;
            txtSurname.Text = UserItem[0].Surname;
            txtUserName.Text = UserItem[0].UserName;
            txtCardNumber.Text = UserItem[0].CardNumber;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtCardNumber.Text))
            {
                cUsers.UpdateUsers(userId, txtName.Text, txtSurname.Text, txtUserName.Text, txtCardNumber.Text);
                //UserItem[0].Id
                Kullanıcı kullanıcı = new Kullanıcı(UserItem);
                kullanıcı.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }
    }
}
