using RaskhodApp.business;
using RaskhodApp.Models2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RaskhodApp.UI
{
    public partial class HomePage : Form
    {
        private readonly MyDbContext2 _dbContext;
        private readonly ExpenseManager expenseManager;
        private readonly ExpensesTypeManager expensesTypeManager;

        public HomePage(MyDbContext2 dbContext, string name)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            _dbContext = dbContext;
            expenseManager = new ExpenseManager(dbContext);

            timer1.Interval = 1000;
            timer1.Start();
            lbl_name.Text = name;

            dtp_date.Format = DateTimePickerFormat.Custom;
            dtp_date.CustomFormat = "dd/MM/yyyy";

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
                cb_types.DataSource = ex.GetAll();
            }

        }
    }
}
