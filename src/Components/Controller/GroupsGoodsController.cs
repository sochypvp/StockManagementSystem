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
    public class GroupsGoodsController
    {
        private SqlConnection MyCon = null;
        private DBuser user = null;

        public GroupsGoodsController(DBuser user)
        {
            this.user = user;
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(this.user.loginName, this.user.password);

            UpdateTotalGoods();
        }

        public void UpdateTotalGoods()
        {
            foreach (var s in getAllGroupsGoods())
            {
                try
                {
                    MyCon.Open();

                    string query = "UPDATE tbl_groupsGoods SET " +
                        "totalGoods = (select count(*) from tbl_groupsGoods inner join tbl_goods ON tbl_groupsGoods.groupsId = tbl_goods.goodsGroupsId where tbl_groupsGoods.groupsId = " + s.groupsId + ") " +
                        "WHERE groupsId = " + s.groupsId;

                    SqlCommand cmd = new SqlCommand(query, MyCon);
                    cmd.ExecuteNonQuery();

                    MyCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    break;
                }
            }
        }

        public List<DBgroupsGoods> getAllGroupsGoods()
        {
            List<DBgroupsGoods> listDb = new List<DBgroupsGoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_groupsGoods";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgroupsGoods(
                            reader["groupsId"].ToString(),
                            reader["groupsName"].ToString(),
                            reader["totalGoods"].ToString(),
                            reader["categId"].ToString()
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
        public List<DBgroupsGoods> groupsGoodsIdFilter(string id)
        {
            List<DBgroupsGoods> listDb = new List<DBgroupsGoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_groupsGoods WHERE groupsId = @groupsId";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@groupsId", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgroupsGoods(
                            reader["groupsId"].ToString(),
                            reader["groupsName"].ToString(),
                             reader["totalGoods"].ToString(),
                            reader["categId"].ToString()
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
        public List<DBgroupsGoods> groupsGoodsCategoryIdFilter(string id)
        {
            List<DBgroupsGoods> listDb = new List<DBgroupsGoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_groupsGoods WHERE categId = @Id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgroupsGoods(
                            reader["groupsId"].ToString(),
                            reader["groupsName"].ToString(),
                             reader["totalGoods"].ToString(),
                            reader["categId"].ToString()
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
        public List<DBgroupsGoods> groupsGoodsNameFilter(string name)
        {
            List<DBgroupsGoods> listDb = new List<DBgroupsGoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_groupsGoods WHERE groupsName = @name";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgroupsGoods(
                            reader["groupId"].ToString(),
                            reader["groupsName"].ToString(),
                             reader["totalGoods"].ToString(),
                            reader["categId"].ToString()
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
        public List<DBgroupsGoods> groupsGoodsFinder(string finderTxt)
        {
            List<DBgroupsGoods> listDb = new List<DBgroupsGoods>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_groupsGoods WHERE groupsid LIKE %@id% OR groupsName LIKE %@name%";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", finderTxt);
                cmd.Parameters.AddWithValue("@name", finderTxt);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBgroupsGoods(
                            reader["groupId"].ToString(),
                            reader["groupsName"].ToString(),
                             reader["totalGoods"].ToString(),
                            reader["categId"].ToString()
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
        public bool addGroupsGoods(DBgroupsGoods groupsGoods)
        {
            try
            {
                MyCon.Open();

                string query = "INSERT INTO tbl_groupsGoods(groupsName,categId) " +
                    "VALUES(@name,@categId)";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@name", groupsGoods.groupsName);
                cmd.Parameters.AddWithValue("@categId", groupsGoods.categId);
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

        public bool modifyGroupsGoods(DBgroupsGoods groupsGoods)
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE tbl_groupsGoods SET " +
                    "groupsName=@name," +
                    "categId=@categId WHERE groupsId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);

                cmd.Parameters.AddWithValue("@name", groupsGoods.groupsName);
                cmd.Parameters.AddWithValue("@categId", groupsGoods.categId);
                cmd.Parameters.AddWithValue("@id", groupsGoods.groupsId);

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

        public bool removeGroupsGoods(string id)
        {
            try
            {
                MyCon.Open();

                string query = "DELETE tbl_groupsGoods WHERE groupsId = @id";

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
