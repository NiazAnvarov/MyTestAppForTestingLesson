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

namespace MyTestApp
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            PasswordCheck check = new PasswordCheck();
            string login = ULogin.Text;
            string password = UPassword.Text;
            if (check.ValidatePassword(password, login) != "Успех")
            {
                MessageBox.Show(check.ValidatePassword(password, login));
                return;
            }
            else
            {
                Employee user = SupermarketForTestingEntities.GetContext().Employee.ToList().Find(p => p.Employee_Login == login && p.Employee_Password == password);

                if (user != null)
                {
                    Manager.MainFrame.Navigate(new ProductPage());
                    ULogin.Text = "";
                    UPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Такого сотрудника нет в базе данных!");
                    return;
                }
            }
            
        }
    }
}
