using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Financial_Tracker_System
{
    internal class IncomeData
    {
        string stringConnection = @"Data Source=OLI-WORKPLACE;Initial Catalog=ExpensesApp;Integrated Security=True;TrustServerCertificate=True;";

        public int ID { set; get; } // 0
        public string Category { set; get; } // 1
        public string Item { set; get; } // 2
        public string Cost { set; get; } // 3
        public string Description { set; get; } // 4
        public string DateIncome { set; get; } 

        public List<IncomeData> incomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM income";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Cost = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("dd-MM-yyyy");

                        listData.Add(iData);
                    }
                }
            }
            return listData;
        }
    }
}
