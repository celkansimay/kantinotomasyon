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
    /// KullanıcıEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class KullanıcıEkle : Window
    {
        public List<cUsers> UserItem;
        public List<cUserTypes> UserTypeList;
        public List<cSavedInformation> SavedInformationList;
        public KullanıcıEkle(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();

            UserTypeList = cUserTypes.GetUserTypesByAll();
            cbUserType.DataContext = UserTypeList;
            cbUserType.DisplayMemberPath = "Text";
            cbUserType.DisplayMemberPath = "Id";

            SavedInformationList = cSavedInformation.GetSavedInformationActiveByFrenchiseId(GeneralSettings.franchiseId);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataContext = SavedInformationList;

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
        private void KullanıcıEkle_Load(object sender, EventArgs e)
        {
            UserTypeList = cUserTypes.GetUserTypesByAll();
            cbUserType.DataContext = UserTypeList;
            cbUserType.DisplayMemberPath = "Text";
            cbUserType.DisplayMemberPath = "Id";

            //cbUserType.DataSource = UserTypeList;
            //cbUserType.DisplayMember = "Text";
            //cbUserType.ValueMember = "Id";

            SavedInformationList = cSavedInformation.GetSavedInformationActiveByFrenchiseId(UserItem[0].FrenchiseId);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataContext = SavedInformationList;
           // dataGridView1.DataSource = SavedInformationList;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtSurname.Text) && !string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtCardNumber.Text))
            {
                cUsers.InsertUsers(GeneralSettings.franchiseId, txtName.Text, txtSurname.Text, txtUserName.Text, txtCardNumber.Text, txtPassword.Text, int.Parse(cbUserType.SelectedValue.ToString()), UserItem[0].Id);

                Kullanıcı kullanıcı = new Kullanıcı(UserItem);
                kullanıcı.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
