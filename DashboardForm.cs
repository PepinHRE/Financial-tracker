using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Financial_Tracker_System
{
    public partial class DashboardForm : UserControl
    {
        string stringConnection = @"Data Source=OLI-WORKPLACE;Initial Catalog=ExpensesApp;Integrated Security=True;TrustServerCertificate=True;";

        public DashboardForm()
        {
            InitializeComponent();

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();

            expensesToday();
            expensesYesterday();
            expensesThisMonth();
            expensesThisYear();
        }

        // Income
        public void incomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        income_totalIncome.Text = todayCost.ToString("C");
                        //income_totalIncome.Text = todayCost.ToString("0.00") + " zl";
                    } else
                    {
                        income_totalIncome.Text = "0.00 zl";
                    }
                }
            }
        }
        public void incomeYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection)) { 
            
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using (SqlCommand cmd = new SqlCommand(query, connect)) {
                    
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                    } else
                    {
                        income_yesterdayIncome.Text = "0.00 zl";
                    }
                }
            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime starMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = starMonth.AddMonths(1).AddDays(-1);
                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", starMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        income_thisMonthIncome.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        income_thisMonthIncome.Text = "0.00 zl";
                    }
                }
            }
        }

        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        income_thisYearIncome.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        income_thisYearIncome.Text = "0.00 zl";
                    }
                }
            }

        }

        // expenses
        public void expensesToday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        expense_today.Text = todayCost.ToString("C");
                        //income_totalIncome.Text = todayCost.ToString("0.00") + " zl";
                    }
                    else
                    {
                        expense_today.Text = "0.00 zl";
                    }
                }
            }
        }
        public void expensesYesterday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        expense_yesterday.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        expense_yesterday.Text = "0.00 zl";
                    }
                }
            }
        }

        public void expensesThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime starMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = starMonth.AddMonths(1).AddDays(-1);
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", starMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);

                        expense_thisMonth.Text = monthCost.ToString("C");
                    }
                    else
                    {
                        expense_thisMonth.Text = "0.00 zl";
                    }
                }
            }
        }

        public void expensesThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {

                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);
                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        expense_thisYear.Text = yearCost.ToString("C");
                    }
                    else
                    {
                        expense_thisYear.Text = "0.00 zl";
                    }
                }
            }

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
