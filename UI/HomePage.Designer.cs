namespace RaskhodApp.UI
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_time = new Label();
            label1 = new Label();
            lbl_name = new Label();
            dgv_expenses = new DataGridView();
            cb_types = new ComboBox();
            dtp_date = new DateTimePicker();
            btn_add = new Button();
            tb_amount = new TextBox();
            btn_save = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgv_expenses).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Location = new Point(722, 33);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(0, 15);
            lbl_time.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Xoş Gəldin";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(92, 33);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 15);
            lbl_name.TabIndex = 2;
            // 
            // dgv_expenses
            // 
            dgv_expenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_expenses.Location = new Point(402, 84);
            dgv_expenses.Name = "dgv_expenses";
            dgv_expenses.Size = new Size(357, 326);
            dgv_expenses.TabIndex = 3;
            // 
            // cb_types
            // 
            cb_types.FormattingEnabled = true;
            cb_types.Location = new Point(23, 165);
            cb_types.Name = "cb_types";
            cb_types.Size = new Size(121, 23);
            cb_types.TabIndex = 4;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(23, 114);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(200, 23);
            dtp_date.TabIndex = 5;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(150, 165);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(35, 23);
            btn_add.TabIndex = 6;
            btn_add.Text = "...";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // tb_amount
            // 
            tb_amount.Location = new Point(23, 240);
            tb_amount.Name = "tb_amount";
            tb_amount.Size = new Size(146, 23);
            tb_amount.TabIndex = 7;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(23, 303);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_save);
            Controls.Add(tb_amount);
            Controls.Add(btn_add);
            Controls.Add(dtp_date);
            Controls.Add(cb_types);
            Controls.Add(dgv_expenses);
            Controls.Add(lbl_name);
            Controls.Add(label1);
            Controls.Add(lbl_time);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)dgv_expenses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lbl_time;
        private Label label1;
        private Label lbl_name;
        private DataGridView dgv_expenses;
        private ComboBox cb_types;
        private DateTimePicker dtp_date;
        private Button btn_add;
        private TextBox tb_amount;
        private Button btn_save;
        private System.Windows.Forms.Timer timer2;
    }
}