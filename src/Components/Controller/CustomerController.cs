using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.DBConnection;

namespace WarehouseMG.src.Components.Controller
{
    public class CustomerController
    {
        private SqlConnection MyCon;
        private DBuser user;

        public CustomerController(DBuser user)
        {
            this.user = user;
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(this.user.loginName, this.user.password);
        }

        public string getCustomerLastId() //======== Get all Customers
        {
            try
            {
                MyCon.Open();

                string lastId = "";

                string query = "SELECT TOP 1 customerId FROM tbl_customers ORDER BY customerId DESC";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lastId = reader["customerId"].ToString();
                }

                MyCon.Close();

                return lastId;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return "";
            }
        }

        public List<DBcustomers> getAllCustomers() //======== Get all Customers
        {
            List<DBcustomers> listDb = new List<DBcustomers>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_customers";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBcustomers(
                            reader["customerId"].ToString(),
                            reader["customerName"].ToString(),
                            reader["customerAddress"].ToString(),
                            reader["customerPosition"].ToString(),
                            reader["customerPhoneNumber"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        public List<DBcustomers> customerIdFilter(string id) //============= Get customer by ID filter
        {
            List<DBcustomers> listDb = new List<DBcustomers>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_customers WHERE customerId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBcustomers(
                            reader["customerId"].ToString(),
                            reader["customerName"].ToString(),
                            reader["customerAddress"].ToString(),
                            reader["customerPosition"].ToString(),
                            reader["customerPhoneNumber"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBcustomers> customerNameFilter(string name) //============= Get customer by Name filter
        {
            List<DBcustomers> listDb = new List<DBcustomers>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_customers WHERE customerName = @name";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBcustomers(
                            reader["customerId"].ToString(),
                            reader["customerName"].ToString(),
                            reader["customerAddress"].ToString(),
                            reader["customerPosition"].ToString(),
                            reader["customerPhoneNumber"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBcustomers> customerFinder(string finderTxt) //============= Find customer
        {
            List<DBcustomers> listDb = new List<DBcustomers>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_customers WHERE customerId LIKE '%"+finderTxt+ "%' OR customerName LIKE '%"+finderTxt+"%'";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBcustomers(
                            reader["customerId"].ToString(),
                            reader["customerName"].ToString(),
                            reader["customerAddress"].ToString(),
                            reader["customerPosition"].ToString(),
                            reader["customerPhoneNumber"].ToString()
                        ));
                }

                MyCon.Close();
                return listDb;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public bool addCustomers(DBcustomers customers) //============== Add customers
        {
            try
            {
                MyCon.Open();

                string query = "INSERT INTO " +
                    "tbl_customers(customerId,customerName,customerAddress,customerPosition,customerPhoneNumber) " +
                    "VALUES(@id,@name,@address,@position,@phone)";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                Random rand = new Random();
                string newId = rand.Next(20000,30000).ToString();

                cmd.Parameters.AddWithValue("@id", newId);
                cmd.Parameters.AddWithValue("@name", customers.cusName);
                cmd.Parameters.AddWithValue("@address", customers.cusAddress);
                cmd.Parameters.AddWithValue("@position", customers.cusPosition);
                cmd.Parameters.AddWithValue("@phone", customers.cusPhoneNumber);

                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public bool modifyCustomer(DBcustomers customers) //=========== Update customers
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE tbl_customers " +
                    "SET customerName = @name," +
                    " customerAddress = @address," +
                    " customerPosition = @position, " +
                    "customerPhoneNumber = @phone " +
                    "WHERE customerId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@name", customers.cusName);
                cmd.Parameters.AddWithValue("@address", customers.cusAddress);
                cmd.Parameters.AddWithValue("@position", customers.cusPosition);
                cmd.Parameters.AddWithValue("@phone", customers.cusPhoneNumber);
                cmd.Parameters.AddWithValue("@id", customers.cusId);

                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public bool removeCustomer(string id) //========== Delete customer
        {
            try
            {
                MyCon.Open();

                string query = "DELETE tbl_customers WHERE customerId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
