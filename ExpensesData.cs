using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Financial_Tracker_System
{
    class ExpensesData
    {
        string stringConnection = @"Data Source=OLI-WORKPLACE;Initial Catalog=ExpensesApp;Integrated Security=True;TrustServerCertificate=True;";

        public int ID { set; get; } // 0
        public string Category { set; get; } // 1
        public string Item { set; get; } // 2
        public string Cost { set; get; } // 3
        public string Description { set; get; } // 4
        public string DateIncome { set; get; }

        public List<ExpensesData> expensesListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM expenses";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateIncome = ((DateTime)reader["date_expense"]).ToString("dd-MM-yyyy");

                        listData.Add(eData);
                    }
                }
            }
            return listData;
        }
    }
}
