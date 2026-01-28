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

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterdayIncome.Text = yesterdayCost.ToString("C");
                    }
                    else
                    {
                        income_yesterdayIncome.Text = "0.00 zl";
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
