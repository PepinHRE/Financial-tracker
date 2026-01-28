namespace Financial_Tracker_System
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.expenses_btn = new System.Windows.Forms.Button();
            this.income_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greetUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new Financial_Tracker_System.DashboardForm();
            this.expensesForm1 = new Financial_Tracker_System.ExpensesForm();
            this.incomeForm1 = new Financial_Tracker_System.IncomeForm();
            this.categoryForm1 = new Financial_Tracker_System.CategoryForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 69);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Financial_Tracker_System.Properties.Resources.person1;
            this.pictureBox1.Location = new System.Drawing.Point(36, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income and Expenses Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(842, 24);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(12, 12);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.logout_btn);
            this.panel3.Controls.Add(this.expenses_btn);
            this.panel3.Controls.Add(this.income_btn);
            this.panel3.Controls.Add(this.addCategory_btn);
            this.panel3.Controls.Add(this.dashboard_btn);
            this.panel3.Controls.Add(this.greetUser);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 419);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout_btn.Image = global::Financial_Tracker_System.Properties.Resources.logout_icone;
            this.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_btn.Location = new System.Drawing.Point(0, 357);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(196, 40);
            this.logout_btn.TabIndex = 8;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // expenses_btn
            // 
            this.expenses_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.expenses_btn.FlatAppearance.BorderSize = 0;
            this.expenses_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.expenses_btn.Image = global::Financial_Tracker_System.Properties.Resources.expense_icon;
            this.expenses_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses_btn.Location = new System.Drawing.Point(0, 287);
            this.expenses_btn.Name = "expenses_btn";
            this.expenses_btn.Size = new System.Drawing.Size(196, 40);
            this.expenses_btn.TabIndex = 7;
            this.expenses_btn.Text = "Expenses";
            this.expenses_btn.UseVisualStyleBackColor = false;
            this.expenses_btn.Click += new System.EventHandler(this.expenses_btn_Click);
            // 
            // income_btn
            // 
            this.income_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.income_btn.FlatAppearance.BorderSize = 0;
            this.income_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.income_btn.Image = global::Financial_Tracker_System.Properties.Resources.income_icon;
            this.income_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income_btn.Location = new System.Drawing.Point(3, 241);
            this.income_btn.Name = "income_btn";
            this.income_btn.Size = new System.Drawing.Size(193, 40);
            this.income_btn.TabIndex = 6;
            this.income_btn.Text = "Income";
            this.income_btn.UseVisualStyleBackColor = false;
            this.income_btn.Click += new System.EventHandler(this.income_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.addCategory_btn.FlatAppearance.BorderSize = 0;
            this.addCategory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCategory_btn.Image = global::Financial_Tracker_System.Properties.Resources.category_icon;
            this.addCategory_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCategory_btn.Location = new System.Drawing.Point(0, 195);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(196, 40);
            this.addCategory_btn.TabIndex = 5;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = false;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dashboard_btn.Image = global::Financial_Tracker_System.Properties.Resources.dashboard_icon_3;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(3, 139);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(193, 50);
            this.dashboard_btn.TabIndex = 4;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // greetUser
            // 
            this.greetUser.AutoSize = true;
            this.greetUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.greetUser.Location = new System.Drawing.Point(12, 110);
            this.greetUser.Name = "greetUser";
            this.greetUser.Size = new System.Drawing.Size(62, 14);
            this.greetUser.TabIndex = 3;
            this.greetUser.Text = "Welcome,";
            this.greetUser.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Financial_Tracker_System.Properties.Resources.person1;
            this.pictureBox2.Location = new System.Drawing.Point(59, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dashboardForm1);
            this.panel2.Controls.Add(this.expensesForm1);
            this.panel2.Controls.Add(this.incomeForm1);
            this.panel2.Controls.Add(this.categoryForm1);
            this.panel2.Location = new System.Drawing.Point(274, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 397);
            this.panel2.TabIndex = 3;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(550, 357);
            this.dashboardForm1.TabIndex = 7;
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(0, 0);
            this.expensesForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(557, 397);
            this.expensesForm1.TabIndex = 6;
            // 
            // incomeForm1
            // 
            this.incomeForm1.Location = new System.Drawing.Point(0, 0);
            this.incomeForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incomeForm1.Name = "incomeForm1";
            this.incomeForm1.Size = new System.Drawing.Size(569, 397);
            this.incomeForm1.TabIndex = 5;
            // 
            // categoryForm1
            // 
            this.categoryForm1.Location = new System.Drawing.Point(0, 0);
            this.categoryForm1.Margin = new System.Windows.Forms.Padding(2);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(626, 397);
            this.categoryForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(877, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label greetUser;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button expenses_btn;
        private System.Windows.Forms.Button income_btn;
        private System.Windows.Forms.Button addCategory_btn;
        private System.Windows.Forms.Panel panel2;
        private CategoryForm categoryForm1;
        private IncomeForm incomeForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
    }
}