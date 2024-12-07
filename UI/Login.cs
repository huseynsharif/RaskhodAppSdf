using Microsoft.IdentityModel.Tokens;
using RaskhodApp.business;
using RaskhodApp.Models2;



namespace RaskhodApp.UI
{
    public partial class Login : Form
    {
        private readonly MyDbContext2 _dbContext;
        private readonly UserManager userManager;

        public User loggedInUser;
        public Login(MyDbContext2 dbContext)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _dbContext = dbContext;
            userManager = new UserManager(dbContext);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (CheckInputs() && CheckEmailAndPassword())
            {
                loggedInUser = userManager.GetByEmail(tb_email.Text);
                NavigateToHome();
            }
            
        }

        private bool CheckEmailAndPassword()
        {
            User? user = userManager.GetByEmail(tb_email.Text);
            if (user != null && user.Password.Equals(tb_password.Text))
            {
                return true;
            }
            MessageBox.Show("Email or password is incorrect");

            return false;
        }

        private void NavigateToHome()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool CheckInputs()
        {
            if (
                    tb_email.Text.IsNullOrEmpty() ||
                    tb_password.Text.IsNullOrEmpty()
                )
            {

                MessageBox.Show("Please, fill all fields.");
                return false;
            }
            return true;

        }
    }
}
