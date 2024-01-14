using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.DBConnection;

namespace WarehouseMG.src.Components.Controller
{
    public class OrderController
    {
        private DBuser user;
        private SqlConnection MyCon;
        public OrderController(DBuser user)
        {
            this.user = user;
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(this.user.loginName,this.user.password);
        }

        public List<DBorder> getAllReport()
        {
            try
            {
                MyCon.Open();
                List<DBorder> listReport = new List<DBorder>();

                string query = "SELECT * FROM tbl_order ORDER BY orderId DESC";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listReport.Add(new DBorder(
                            reader.GetInt32(0).ToString(),
                            reader.GetDateTime(1).ToString(),
                            reader.GetInt32(2).ToString(),
                            reader.GetInt32(3).ToString()
                        ));
                }

                MyCon.Close();
                return listReport;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<DBorder> fillReportByCustomerId(string id)
        {
            try
            {
                MyCon.Open();
                List<DBorder> listReport = new List<DBorder>();

                string query = "SELECT * FROM tbl_order WHERE customerId = "+id+" ORDER BY orderId DESC";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listReport.Add(new DBorder(
                            reader.GetInt32(0).ToString(),
                            reader.GetDateTime(1).ToString(),
                            reader.GetInt32(2).ToString(),
                            reader.GetInt32(3).ToString()
                        ));
                }

                MyCon.Close();
                return listReport;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<DBorder> fillReportByUserId(string id)
        {
            try
            {
                MyCon.Open();
                List<DBorder> listReport = new List<DBorder>();

                string query = "SELECT * FROM tbl_order WHERE userId = " + id + " ORDER BY userId DESC";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listReport.Add(new DBorder(
                            reader.GetInt32(0).ToString(),
                            reader.GetDateTime(1).ToString(),
                            reader.GetInt32(2).ToString(),
                            reader.GetInt32(3).ToString()
                        ));
                }

                MyCon.Close();
                return listReport;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<DBorder> fillReportByUserIdAndCusId(string cusid, string userid)
        {
            try
            {
                MyCon.Open();
                List<DBorder> listReport = new List<DBorder>();

                string query = "SELECT * FROM tbl_order WHERE  customerId = "+cusid+" AND userId = " + userid + " ORDER BY userId DESC";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listReport.Add(new DBorder(
                            reader.GetInt32(0).ToString(),
                            reader.GetDateTime(1).ToString(),
                            reader.GetInt32(2).ToString(),
                            reader.GetInt32(3).ToString()
                        ));
                }

                MyCon.Close();
                return listReport;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool orderGoods(DBorder dbOrder)
        {
            try
            {
                int newId = getOrderId()+1;
                if(newId == 1)
                {
                    newId = 1000;
                }

                string query = "INSERT INTO tbl_order(orderId,customerId,userId) VALUES(@orderId,@cusId,@userId)";
                SqlCommand cmd = new SqlCommand(query,MyCon);
                MyCon.Open();

                cmd.Parameters.AddWithValue("@orderId",newId.ToString());
                cmd.Parameters.AddWithValue("@cusId", dbOrder.customerId);
                cmd.Parameters.AddWithValue("@userId", dbOrder.userId);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public int getOrderId()
        {
            try
            {
                MyCon.Open();

                string query = "SELECT orderId FROM tbl_order";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();
                int lastId = 0;
                while (reader.Read())
                {
                    lastId = Convert.ToInt32(reader["orderId"].ToString());
                }

                MyCon.Close();
                return lastId;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }
        public bool removeReport(string id)
        {
            try
            {
                MyCon.Open();

                string query = "DELETE FROM tbl_order WHERE orderId = "+id;
                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
