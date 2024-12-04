using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PassMan
{
    public class DataAccess
    {
        private string connectionString;
        private readonly string _dataSource = Environment.GetEnvironmentVariable("datasource");
        private readonly string _userId = Environment.GetEnvironmentVariable("userDB");
        private readonly string _password = Environment.GetEnvironmentVariable("passDB");
        private readonly string _initialCatalog = Environment.GetEnvironmentVariable("database");

        private void StringConnBuider()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = this._dataSource,
                UserID = this._userId,
                Password = this._password,
                InitialCatalog = this._initialCatalog
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

        public void DeleteUser()
        {
            StringConnBuider();
        }

        public List<Account> GetAccounts(int id_user)
        {
            List<Account> accounts = new List<Account>();
            StringConnBuider();

            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryString = string.Format("SELECT * FROM password_account WHERE user_id = '{0}'", id_user);

                using (SqlCommand _cmd = new SqlCommand(queryString, _con))
                {
                    _con.Open();
                    SqlDataReader reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        accounts.Add(new Account()
                        {
                            Id = reader.GetInt32(0),
                            IdUser = reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Password = reader.GetString(3),
                            Note = reader.GetString(4)
                        });

                    }
                }
            }
            return accounts;
        }

        public bool InsertAccount(Account account)
        {
            StringConnBuider();
            using (SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryString = string.Format("INSERT INTO password_account (user_id, name, password, note) VALUES ('{0}', '{1}', '{2}', '{3}')", account.IdUser, account.Name, account.Password, account.Note);

                using (SqlCommand _cmd = new SqlCommand(queryString, _con))
                {
                    _con.Open();
                    return _cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
