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
    /// Kullanıcı.xaml etkileşim mantığı
    /// </summary>
    public partial class Kullanıcı : Window
    {
        public List<cUsers> UserItem;
        public List<cUsers> UsersList;
        public Kullanıcı(List<cUsers> LoginControlItem)
        {
            UserItem = LoginControlItem;
            InitializeComponent();

            UsersList = cUsers.GetListByUsers(GeneralSettings.franchiseId);
            grdusers.AutoGenerateColumns = false;
            grdusers.ItemsSource = UsersList;
            //grdusers.ItemBindingGroup();

        }
    }
}
