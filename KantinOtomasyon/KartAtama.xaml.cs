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
    /// KartAtama.xaml etkileşim mantığı
    /// </summary>
    public partial class KartAtama : Window
    {
        public List<cUsers> UserItem;
        public List<cUserTypes> UserTypeList;
        public List<cSavedInformation> SavedInformationList;
        public List<cSavedUsers> SavedUsersList;
        public List<cSavedUsers> KartItem;
        public int productId;

        public KartAtama(List<cUsers> LoginControlItem, int vProductId)
        {
            productId = vProductId;
            UserItem = LoginControlItem;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCardNumber.Text))
            {
                List<cSavedUsers> cardNumberControl = new List<cSavedUsers>();
                cardNumberControl = cSavedUsers.GetSavedUserByCardNumber(11, txtCardNumber.Text);
                if (cardNumberControl.Count == 0)
                {
                    cSavedUsers.InsertSavedUsers(UserItem[0].FrenchiseId, 1, SavedInformationList[0].Id, txtCardNumber.Text, UserItem[0].Id);

                    MessageBox.Show("Kayit Basarili !", "Kaydedildi");
                }
                else
                    MessageBox.Show("Seçili kart numarası başka bir kullanıcıya kayıtlı.", "Hatalı Kart Numarası");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurduğunuzdan emin olup tekrar deneyiniz.", "Eksik Bilgi");
            }
        }
        private void KartAtama_Load(object sender, EventArgs e)
        {
            SavedInformationList = cSavedInformation.GetSavedInformationByFrenchiseId(11);
            txtName.Text = SavedInformationList[0].Name;
            txtSurname.Text = SavedInformationList[0].Surname;
            txtParentName.Text = SavedInformationList[0].ParentName;
            txtClassName.Text = SavedInformationList[0].EducationPlanName;
            txtSchoolName.Text = SavedInformationList[0].SchoolName;
        }

    }
}
