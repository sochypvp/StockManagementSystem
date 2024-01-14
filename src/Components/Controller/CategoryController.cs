using System;
using System.CodeDom.Compiler;
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
    public class CategoryController
    {
        private SqlConnection MyCon = null;

        public CategoryController(DBuser user)
        {
            DBServerConnection dbCon = new DBServerConnection();
            this.MyCon = dbCon.conn(user.loginName, user.password);

            UpdateTotalGroups();
        }

        public void UpdateTotalGroups()
        {
            foreach(var s in getAllCategory())
            {
                try
                {
                    MyCon.Open();

                    string query = "execute updateTotalGroupsAndGoods @categId = "+s.categId;

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

        public List<DBCategory> getAllCategory()
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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

        public List<DBCategory> getCategoryById(string id)
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category WHERE categId = "+id;

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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

        public List<DBCategory> getAllCategoryInnerJoinGroups()
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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
        public List<DBCategory> categoryIdFilter(string id)
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category WHERE categId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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
        public List<DBCategory> categoryNameFilter(string name)
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category WHERE categName = @name";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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
        public List<DBCategory> categoryFinder(string finderTxt)
        {
            List<DBCategory> listDb = new List<DBCategory>();
            try
            {
                MyCon.Open();

                string query = "SELECT * FROM tbl_category WHERE categId LIKE %@id% OR categName LIKE %@name%";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@id", finderTxt);
                cmd.Parameters.AddWithValue("@name", finderTxt);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listDb.Add(new DBCategory(
                            reader["categId"].ToString(),
                            reader["categName"].ToString(),
                            reader["totalGroups"].ToString(),
                            reader["totalGoods"].ToString()
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
        public bool addCategory(DBCategory category)
        {
            try
            {
                MyCon.Open();

                string query = "INSERT INTO tbl_category(categName) VALUES(@name)";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", category.categName);
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

        public bool modifyCategory(DBCategory category)
        {
            try
            {
                MyCon.Open();

                string query = "UPDATE tbl_category SET categName = @name WHERE categId = @id";

                SqlCommand cmd = new SqlCommand(query, MyCon);
                cmd.Parameters.AddWithValue("@name", category.categName);
                cmd.Parameters.AddWithValue("@id", category.categId);
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

        public bool removeCategory(string id)
        {
            try
            {
                MyCon.Open();

                string query = "DELETE tbl_category WHERE categId = @id";

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
