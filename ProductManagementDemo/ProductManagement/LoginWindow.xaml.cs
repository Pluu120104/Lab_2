using Services;
using System.Windows;
using BusinessObjects_;


namespace ProductManagement
{
    public partial class LoginWindow : Window
    {
        private readonly IAccountService iAccountService;
        public LoginWindow()
        {
            InitializeComponent();
            iAccountService = new AccountService();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountMember account = iAccountService.GetAccountByID(txtUser.Text);
            if (account != null && account.MemberPassword.Equals(txtPass.Password) 
                && account.MemberRole == 1)
{
                this.Hide();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("You are not permission !");
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
