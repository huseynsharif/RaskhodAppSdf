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

namespace RaskhodApp.UI
{
    public partial class ExpenseTypePage : Form
    {
        ExpensesTypeManager expensesTypeManager;
        public ExpenseTypePage()
        {
            InitializeComponent();
            expensesTypeManager = new ExpensesTypeManager(new MyDbContext2);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            expensesTypeManager.Add(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
