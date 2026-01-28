namespace Financial_Tracker_System
{
    partial class IncomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.income_category = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.income_categories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.income_item = new System.Windows.Forms.TextBox();
            this.income_income = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.income_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.income_date = new System.Windows.Forms.DateTimePicker();
            this.income_addBtn = new System.Windows.Forms.Button();
            this.income_updateBtn = new System.Windows.Forms.Button();
            this.income_clearBtn = new System.Windows.Forms.Button();
            this.income_deleteBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.income_category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 295);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            // 
            // income_category
            // 
            this.income_category.BackColor = System.Drawing.Color.White;
            this.income_category.Controls.Add(this.income_clearBtn);
            this.income_category.Controls.Add(this.income_deleteBtn);
            this.income_category.Controls.Add(this.income_updateBtn);
            this.income_category.Controls.Add(this.income_addBtn);
            this.income_category.Controls.Add(this.income_date);
            this.income_category.Controls.Add(this.label6);
            this.income_category.Controls.Add(this.income_description);
            this.income_category.Controls.Add(this.label5);
            this.income_category.Controls.Add(this.income_income);
            this.income_category.Controls.Add(this.label4);
            this.income_category.Controls.Add(this.income_item);
            this.income_category.Controls.Add(this.label3);
            this.income_category.Controls.Add(this.income_categories);
            this.income_category.Controls.Add(this.label2);
            this.income_category.Location = new System.Drawing.Point(13, 315);
            this.income_category.Name = "income_category";
            this.income_category.Size = new System.Drawing.Size(1073, 351);
            this.income_category.TabIndex = 2;
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
            // income_categories
            // 
            this.income_categories.FormattingEnabled = true;
            this.income_categories.Location = new System.Drawing.Point(125, 69);
            this.income_categories.Name = "income_categories";
            this.income_categories.Size = new System.Drawing.Size(205, 33);
            this.income_categories.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item:";
            // 
            // income_item
            // 
            this.income_item.Location = new System.Drawing.Point(125, 133);
            this.income_item.Name = "income_item";
            this.income_item.Size = new System.Drawing.Size(205, 31);
            this.income_item.TabIndex = 4;
            // 
            // income_income
            // 
            this.income_income.Location = new System.Drawing.Point(125, 197);
            this.income_income.Name = "income_income";
            this.income_income.Size = new System.Drawing.Size(205, 31);
            this.income_income.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Income:";
            // 
            // income_description
            // 
            this.income_description.Location = new System.Drawing.Point(536, 66);
            this.income_description.Multiline = true;
            this.income_description.Name = "income_description";
            this.income_description.Size = new System.Drawing.Size(517, 98);
            this.income_description.TabIndex = 8;
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
            // income_date
            // 
            this.income_date.Location = new System.Drawing.Point(536, 203);
            this.income_date.Name = "income_date";
            this.income_date.Size = new System.Drawing.Size(381, 31);
            this.income_date.TabIndex = 10;
            // 
            // income_addBtn
            // 
            this.income_addBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.income_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_addBtn.Location = new System.Drawing.Point(254, 292);
            this.income_addBtn.Name = "income_addBtn";
            this.income_addBtn.Size = new System.Drawing.Size(95, 48);
            this.income_addBtn.TabIndex = 11;
            this.income_addBtn.Text = "Add";
            this.income_addBtn.UseVisualStyleBackColor = false;
            this.income_addBtn.Click += new System.EventHandler(this.income_addBtn_Click);
            // 
            // income_updateBtn
            // 
            this.income_updateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.income_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_updateBtn.Location = new System.Drawing.Point(391, 292);
            this.income_updateBtn.Name = "income_updateBtn";
            this.income_updateBtn.Size = new System.Drawing.Size(95, 48);
            this.income_updateBtn.TabIndex = 12;
            this.income_updateBtn.Text = "Update";
            this.income_updateBtn.UseVisualStyleBackColor = false;
            this.income_updateBtn.Click += new System.EventHandler(this.income_updateBtn_Click);
            // 
            // income_clearBtn
            // 
            this.income_clearBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.income_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_clearBtn.Location = new System.Drawing.Point(674, 292);
            this.income_clearBtn.Name = "income_clearBtn";
            this.income_clearBtn.Size = new System.Drawing.Size(95, 48);
            this.income_clearBtn.TabIndex = 14;
            this.income_clearBtn.Text = "Clear";
            this.income_clearBtn.UseVisualStyleBackColor = false;
            this.income_clearBtn.Click += new System.EventHandler(this.income_clearBtn_Click);
            // 
            // income_deleteBtn
            // 
            this.income_deleteBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.income_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income_deleteBtn.Location = new System.Drawing.Point(537, 292);
            this.income_deleteBtn.Name = "income_deleteBtn";
            this.income_deleteBtn.Size = new System.Drawing.Size(95, 48);
            this.income_deleteBtn.TabIndex = 13;
            this.income_deleteBtn.Text = "Delete";
            this.income_deleteBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(29, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 228);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.income_category);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Size = new System.Drawing.Size(1101, 687);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.income_category.ResumeLayout(false);
            this.income_category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel income_category;
        private System.Windows.Forms.TextBox income_income;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox income_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox income_categories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker income_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox income_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button income_clearBtn;
        private System.Windows.Forms.Button income_deleteBtn;
        private System.Windows.Forms.Button income_updateBtn;
        private System.Windows.Forms.Button income_addBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
