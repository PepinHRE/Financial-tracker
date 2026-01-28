namespace Financial_Tracker_System
{
    partial class ExpensesForm
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expense_clearBtn = new System.Windows.Forms.Button();
            this.expense_deleteBtn = new System.Windows.Forms.Button();
            this.expense_updateBtn = new System.Windows.Forms.Button();
            this.expense_addBtn = new System.Windows.Forms.Button();
            this.expense_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expense_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.expense_cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.expense_item = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expense_category = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.income_category = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.income_category.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(30, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 228);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // expense_clearBtn
            // 
            this.expense_clearBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.expense_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_clearBtn.Location = new System.Drawing.Point(674, 292);
            this.expense_clearBtn.Name = "expense_clearBtn";
            this.expense_clearBtn.Size = new System.Drawing.Size(95, 48);
            this.expense_clearBtn.TabIndex = 14;
            this.expense_clearBtn.Text = "Clear";
            this.expense_clearBtn.UseVisualStyleBackColor = false;
            this.expense_clearBtn.Click += new System.EventHandler(this.expense_clearBtn_Click);
            // 
            // expense_deleteBtn
            // 
            this.expense_deleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.expense_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_deleteBtn.Location = new System.Drawing.Point(537, 292);
            this.expense_deleteBtn.Name = "expense_deleteBtn";
            this.expense_deleteBtn.Size = new System.Drawing.Size(95, 48);
            this.expense_deleteBtn.TabIndex = 13;
            this.expense_deleteBtn.Text = "Delete";
            this.expense_deleteBtn.UseVisualStyleBackColor = false;
            this.expense_deleteBtn.Click += new System.EventHandler(this.expense_deleteBtn_Click);
            // 
            // expense_updateBtn
            // 
            this.expense_updateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.expense_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_updateBtn.Location = new System.Drawing.Point(391, 292);
            this.expense_updateBtn.Name = "expense_updateBtn";
            this.expense_updateBtn.Size = new System.Drawing.Size(95, 48);
            this.expense_updateBtn.TabIndex = 12;
            this.expense_updateBtn.Text = "Update";
            this.expense_updateBtn.UseVisualStyleBackColor = false;
            this.expense_updateBtn.Click += new System.EventHandler(this.expense_updateBtn_Click);
            // 
            // expense_addBtn
            // 
            this.expense_addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.expense_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expense_addBtn.Location = new System.Drawing.Point(254, 292);
            this.expense_addBtn.Name = "expense_addBtn";
            this.expense_addBtn.Size = new System.Drawing.Size(95, 48);
            this.expense_addBtn.TabIndex = 11;
            this.expense_addBtn.Text = "Add";
            this.expense_addBtn.UseVisualStyleBackColor = false;
            this.expense_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // expense_date
            // 
            this.expense_date.Location = new System.Drawing.Point(536, 203);
            this.expense_date.Name = "expense_date";
            this.expense_date.Size = new System.Drawing.Size(381, 31);
            this.expense_date.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(467, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses List";
            // 
            // expense_description
            // 
            this.expense_description.Location = new System.Drawing.Point(536, 66);
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            this.expense_description.Size = new System.Drawing.Size(517, 98);
            this.expense_description.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(410, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description:";
            // 
            // expense_cost
            // 
            this.expense_cost.Location = new System.Drawing.Point(125, 197);
            this.expense_cost.Name = "expense_cost";
            this.expense_cost.Size = new System.Drawing.Size(205, 31);
            this.expense_cost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(57, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cost:";
            // 
            // expense_item
            // 
            this.expense_item.Location = new System.Drawing.Point(125, 133);
            this.expense_item.Name = "expense_item";
            this.expense_item.Size = new System.Drawing.Size(205, 31);
            this.expense_item.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // expense_category
            // 
            this.expense_category.FormattingEnabled = true;
            this.expense_category.Location = new System.Drawing.Point(125, 69);
            this.expense_category.Name = "expense_category";
            this.expense_category.Size = new System.Drawing.Size(205, 33);
            this.expense_category.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // income_category
            // 
            this.income_category.BackColor = System.Drawing.Color.White;
            this.income_category.Controls.Add(this.expense_clearBtn);
            this.income_category.Controls.Add(this.expense_deleteBtn);
            this.income_category.Controls.Add(this.expense_updateBtn);
            this.income_category.Controls.Add(this.expense_addBtn);
            this.income_category.Controls.Add(this.expense_date);
            this.income_category.Controls.Add(this.label6);
            this.income_category.Controls.Add(this.expense_description);
            this.income_category.Controls.Add(this.label5);
            this.income_category.Controls.Add(this.expense_cost);
            this.income_category.Controls.Add(this.label4);
            this.income_category.Controls.Add(this.expense_item);
            this.income_category.Controls.Add(this.label3);
            this.income_category.Controls.Add(this.expense_category);
            this.income_category.Controls.Add(this.label2);
            this.income_category.Location = new System.Drawing.Point(14, 318);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(1073, 351);
            this.income_category.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 295);
            this.panel1.TabIndex = 11;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.income_category);
            this.Controls.Add(this.panel1);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(1101, 687);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.income_category.ResumeLayout(false);
            this.income_category.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button expense_clearBtn;
        private System.Windows.Forms.Button expense_deleteBtn;
        private System.Windows.Forms.Button expense_updateBtn;
        private System.Windows.Forms.Button expense_addBtn;
        private System.Windows.Forms.DateTimePicker expense_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox expense_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox expense_cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox expense_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox expense_category;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel income_category;
        private System.Windows.Forms.Panel panel1;
    }
}
