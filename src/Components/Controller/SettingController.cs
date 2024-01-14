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
    public class SettingController
    {
        private SqlConnection MyCon;
        public SettingController(DBuser user)
        {
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(user.loginName, user.password);
        }

        public string getAllSetting()
        {
            return "";
        }
        public string getSttStatus(string sttCode)
        {
            try
            {
                MyCon.Open();

                string sttStatus = "";
                string query = "SELECT SettingStatus FROM Setting WHERE SettingCode = '" + sttCode+"'";
                SqlCommand cmd = new SqlCommand(query,MyCon);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sttStatus = reader["SettingStatus"].ToString();
                }

                MyCon.Close();
                return sttStatus;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public Boolean updateSttStatus(string sttCode,string value)
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE Setting SET SettingStatus = '"+ value + "' WHERE SettingCode = '" + sttCode+"'";
                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.ExecuteNonQuery();

                MyCon.Close();
                return true;
            }
            catch (Exception ex)
            {
                MyCon.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
