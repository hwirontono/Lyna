using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using DollarXpressDataModel;

namespace DollarXpressDataAccessServices
{
    public class CustomerDataAccessService
    {
        public List<Customer> GetCustomers(string FieldName, string KeyWord)
        {
            MySqlConnection conn = new MySqlConnection(Database.DollarExpressDB());
            List<Customer> customerList = new List<Customer>();
            Customer c = null;

            try
            {
                conn.Open();

                string sql = "SELECT * FROM Customer WHERE " + FieldName + " like '%" + KeyWord + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    c = new Customer(rdr.GetInt32(0),rdr.GetString(1),rdr.GetString(2),rdr.GetString(3),rdr.GetString(4));
                    customerList.Add(c);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return customerList;
        }



    }
}
