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
    public class AuthController : DBServerConnection
    {
        SqlConnection MyCon = null;

        private DBuser user;

        public DBuser User
        {
            get { return user; }
            set { user = value; }
        }
        public AuthController()
        {
            this.MyCon = this.conn();
        }

        public bool login(string username,string password)
        {
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM user_account WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Dispose();
                while (reader.Read())
                {
                    if (password.Equals(reader["password"].ToString()))
                    {
                        query = "SELECT * FROM tbl_user WHERE id = @id";
                        SqlCommand cmd1 = new SqlCommand(query, MyCon);
                        cmd1.Parameters.AddWithValue("@id", reader["userId"].ToString());
                        reader.Close();
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        while (reader1.Read())
                        {
                            this.user = new DBuser(
                                    reader1["id"].ToString(),
                                    reader1["userName"].ToString(),
                                    reader1["loginName"].ToString(),
                                    reader1["password"].ToString()
                                );
                        }
                        return true;
                        
                    }
                }

                MyCon.Close();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }
    }
}
