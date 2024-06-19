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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.DataFilesApp;
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// авторизация пользователей
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            var userObj = OdbConnectHelper.entObj.User.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == psbPassword.Password);
            if (userObj != null)
            {
                switch (userObj.Role)
                {
                    case 1:
                        FrameApp.frmObj.Navigate(new PageAdmin());
                        break;

                        case 2:
                        FrameApp.frmObj.Navigate(new PageUser());
                        break;

                }
            }
            else
            {
                MessageBox.Show("Неправильный пароль или логин, попробуйте ещё раз", "Ошибка",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
 