using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMan
{
    public class DataAccess
    {
        private string connectionString;

        private void StringConnBuider()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = "DP-03\\SQLEXPRESS",
                UserID = "bigotes",
                Password = "1234",
                InitialCatalog = "pm"
            };

            connectionString = builder.ConnectionString;
        }

        public bool InsertUser(User user)
        {
            StringConnBuider();
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryString = string.Format("INSERT INTO user_account (user_name, user_email, user_pass, user_master) VALUES ('{0}', '{1}', '{2}', '{3}')", user.Name, user.Email, user.Password, user.MasterPass);

                using (SqlCommand _cmd = new SqlCommand(queryString, _con))
                {
                    _con.Open();

                    return _cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public User ValidateUser(string user)
        {
            User user1 = new User();
            StringConnBuider();
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryString = string.Format("SELECT * FROM user_account WHERE user_name = '{0}'", user);

                using (SqlCommand _cmd = new SqlCommand(queryString, _con))
                {
                    _con.Open();
                    SqlDataReader reader = _cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user1 = new User();
                        user1.Id = reader.GetInt32(0);
                        user1.Name = reader.GetString(1);
                        user1.Email = reader.GetString(2);
                        user1.Password = reader.GetString(3);
                        user1.MasterPass = reader.GetString(4);
                    }
                }
            }
            return user1;
        }

        public void updateUser()
        {
            StringConnBuider();
        }
    }
}
