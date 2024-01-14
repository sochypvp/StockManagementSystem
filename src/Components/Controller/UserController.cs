using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.DBClasses;
using WarehouseMG;
using WarehouseMG.src.Components.DBConnection;

namespace WarehouseMG.src.Components.Contoller
{

    public class UserController
    {
        private SqlConnection Conn = null;

        public UserController(DBuser user)
        {
            DBServerConnection dbCon = new DBServerConnection();
            Conn = dbCon.conn(user.loginName, user.password);
        }

        public bool AddUser(DBuser user)
        {
            try
            {
                Conn.Open();

                string query = "INSERT INTO tbl_user(userName,loginName,password) VALUES(@username,@loginname,@password)";
                
                SqlCommand cmd = new SqlCommand(query,Conn);
                cmd.Parameters.AddWithValue("@username",user.userName);
                cmd.Parameters.AddWithValue("@loginname", user.loginName);
                cmd.Parameters.AddWithValue("@password", user.password);

                cmd.ExecuteNonQuery();

                Conn.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public List<DBuser> getAllUser()
        {

            List<DBuser> userList = new List<DBuser>();

            try
            {
                Conn.Open();

                string query = "SELECT * FROM tbl_user";

                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userList.Add(new DBuser(
                        reader["Id"].ToString(),
                        reader["userName"].ToString(),
                        reader["loginName"].ToString(),
                        reader["password"].ToString()
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

        public DBuser getUserById(string id)
        {

            DBuser userData = new DBuser();

            try
            {
                Conn.Open();

                string query = "SELECT * FROM tbl_user WHERE Id = "+id;

                SqlCommand cmd = new SqlCommand(query, Conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    userData = new DBuser(
                        reader["Id"].ToString(),
                        reader["userName"].ToString(),
                        reader["loginName"].ToString(),
                        reader["password"].ToString()
                        );
                }

                Conn.Close();
                return userData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }
    }
}
