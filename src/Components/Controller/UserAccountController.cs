using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG.src.Components.DBConnection;
using WarehouseMG.src.Components.Models;

namespace WarehouseMG.src.Components.Controller
{
    public class UserAccountController
    {
        private SqlConnection Conn = null;
        public UserAccountController(DBuser user)
        {
            DBServerConnection dbCon = new DBServerConnection();
            Conn = dbCon.conn(user.loginName, user.password);
        }

        public List<DBUserAccount> getAllUserAccount()
        {

            List<DBUserAccount> userList = new List<DBUserAccount>();

            try
            {
                Conn.Open();

                string query = "SELECT * FROM user_account";

                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userList.Add(new DBUserAccount(
                        reader["Id"].ToString(),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["userId"].ToString()
                        ));
                }

                Conn.Close();
                return userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBUserAccount> getUserAccountFilter(string txtSearch)
        {

            List<DBUserAccount> userList = new List<DBUserAccount>();

            try
            {
                Conn.Open();

                string query = "SELECT * FROM user_account WHERE Id LIKE '%" + txtSearch + "%' OR username LIKE '%"+ txtSearch + "%'";

                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userList.Add(new DBUserAccount(
                        reader["Id"].ToString(),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["userId"].ToString()
                        ));
                }

                Conn.Close();
                return userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
        public List<DBUserAccount> getUserAccountByUserId(string id)
        {

            List<DBUserAccount> userList = new List<DBUserAccount>();

            try
            {
                Conn.Open();

                string query = "SELECT * FROM user_account WHERE userId = "+id;

                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userList.Add(new DBUserAccount(
                        reader["Id"].ToString(),
                        reader["username"].ToString(),
                        reader["password"].ToString(),
                        reader["userId"].ToString()
                        ));
                }

                Conn.Close();
                return userList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
    }
}
