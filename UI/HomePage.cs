using RaskhodApp.business;
using RaskhodApp.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaskhodApp.UI
{
    public partial class HomePage : Form
    {
        private readonly MyDbContext2 _dbContext;
        private readonly ExpenseManager expenseManager;
        private readonly ExpensesTypeManager expensesTypeManager;
        public User user;

        public HomePage(MyDbContext2 dbContext, User user)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            _dbContext = dbContext;
            expenseManager = new ExpenseManager(dbContext);

            timer1.Interval = 1000;
            timer1.Start();
            lbl_name.Text = user.Name;

            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.CustomFormat = "dd/MM/yyyy";

            this.user = user;

            timer2.Interval = 60000; // 1 dəqiqə
            timer2.Tick += CheckAndSendDailyExpenseReport;
            timer2.Start();

            dgv_expenses.DataSource = expenseManager.GetAll();

        }

        private void CheckAndSendDailyExpenseReport(object? sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour == 0 && currentTime.Minute == 0)
            {
                SendDailyExpenseReport();
            }
        }

        private void SendDailyExpenseReport()
        {
          
                var expenses = expenseManager.GetAll().ToString();

                string subject = $"Daily Expense Report: {DateTime.Today.ToShortDateString()}";
                string body = string.Join(Environment.NewLine, expenses);

                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("randomislerucun123@gmail.com", "adimadim123");
                    smtp.EnableSsl = true;

                    var mail = new MailMessage("randomislerucun123@gmail.com", user.Email, subject, body);
                    smtp.Send(mail);
                }
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ExpenseTypePage dialog = new ExpenseTypePage();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                cb_types.DataSource = expensesTypeManager.GetAll();
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense(user.Id, dtp_date.Value, cb_types.SelectedIndex, Double.Parse(tb_amount.Text));
            expenseManager.Add(exp);

        }
    }
}
