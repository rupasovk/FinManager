using FinManagerService.Logic;
using System.Diagnostics.Metrics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinManagerService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _counter;

        UserService _userService;

        public MainWindow()
        {
            _counter = 0;
            _userService = new UserService();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBlok1.Text = $"Name:{TextBoxName.Text}, Email:{TextBoxEmail.Text}, Password:{TextBoxPassword.Text}";

            var _user = _userService.CreateUser(TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text);

            //User _user = new User()
            //{
            //    Name = TextBoxName.Text,
            //    Email = TextBoxEmail.Text,
            //    Password = TextBoxPassword.Text,
            //};
        }
    }
}