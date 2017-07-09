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

namespace loginSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void logIn_click(object sender, RoutedEventArgs e)
        {
            if (userNameLogIn.Text != "" && passwordLogIn.Text != "")
            {
                MessageBox.Show(userNameLogIn.Text);
            }
            else
            {
                MessageBox.Show("all fields must be filled in");
            }
        }
        private void signUp_click(object sender, RoutedEventArgs e)
        {
            if (userNameSignUp.Text != "" && passwordSignUp.Text != "" && confirmPasswordSignUp.Text != "")
            {
                if (passwordSignUp.Text == confirmPasswordSignUp.Text)
                {
                    MessageBox.Show("Signed Up!");
                }
                else
                {
                    MessageBox.Show("passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("all fields must be filled in");
            }
        }
    }
}
