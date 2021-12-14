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
    /// Login.xaml etkileşim mantığı
    /// </summary>
    public partial class Login : Window
    {
        List<cUsers> LoginControlItem;
        public Login()
        {
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            List<cUsers> usersControl = new List<cUsers>();
            usersControl = cUsers.LoginUsers(txtUserName.Text, GeneralSettings.MD5Olustur(txtPassword.Text));

            if (usersControl.Count > 0)
            {
                GeneralSettings.loginUsers = usersControl[0];

                MainWindow mw = new MainWindow(LoginControlItem);
                mw.Show();
            }
            else
            {
                //hata mesajı
            }
        }
    }

}
