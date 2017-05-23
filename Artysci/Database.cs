﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artysci.ObjectsClass;
using System.Diagnostics;
using System.Data;

namespace Artysci
{
    class Database
    {
        public static SqlConnection cnn;

        #region ConnectDatabase
        public static void ConnectDatabase()
        {
            cnn = new SqlConnection(GlobalVariables.connetionString);
            try
            {
                cnn.Open();
                // MessageBox.Show("Connection Open ! ");
                //cnn.Close();
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }


        #endregion

        #region Database method sond
        public static List<sond> GetSond(string statement = "")
        {
            List<sond> sonds = new List<sond>();
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();

                string querry = "SELECT * FROM sond " + statement;
                using (SqlCommand command = new SqlCommand(querry, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idIn = reader.GetInt32(0);
                        string creator_loginIn = reader.GetString(1);
                        string questionIn = reader.GetString(2);
                        string date_startIn = reader.GetString(3);
                        string date_endIn = reader.GetString(4);

                        sonds.Add(new sond()
                        {
                            id = idIn,
                            creator_login = creator_loginIn,
                            question = questionIn,
                            date_start = date_startIn,
                            date_end = date_endIn
                        });
                    }
                }
                con.Close();

            }

            return sonds;
        }


        public static void AddSond(sond sond)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();
                try
                {
                    int nextId;
                    List<sond> sonds = GetSond();
                    try
                    {
                        nextId = sonds.OrderByDescending(u => u.id).FirstOrDefault().id + 1;
                    }
                    catch
                    {
                        nextId = 1;
                    }
                    //int nextId = sonds.OrderByDescending(u => u.id).FirstOrDefault().id + 1;

                    using (SqlCommand command = new SqlCommand(
                        "INSERT INTO sond VALUES(@id, @creator_login, @question, @date_start, @date_end)", con))
                    {
                        command.Parameters.Add(new SqlParameter("id", nextId));
                        command.Parameters.Add(new SqlParameter("creator_login", sond.creator_login));
                        command.Parameters.Add(new SqlParameter("question", sond.question));
                        command.Parameters.Add(new SqlParameter("date_start", sond.date_start));
                        command.Parameters.Add(new SqlParameter("date_end", sond.date_end));
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    Console.WriteLine("Count not insert.");
                }
            }
        }


        public static void UpdateSond(sond sond)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(
                        "UPDATE sond SET creator_login = @creator_login, question = @question, date_start = @date_start, date_end = @date_end  Where id = @id", con))
                    {
                        command.Parameters.Add(new SqlParameter("id", sond.id));
                        command.Parameters.Add(new SqlParameter("creator_login", sond.creator_login));
                        command.Parameters.Add(new SqlParameter("question", sond.question));
                        command.Parameters.Add(new SqlParameter("date_start", sond.date_start));
                        command.Parameters.Add(new SqlParameter("date_end", sond.date_end));
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    Console.WriteLine("Count not update.");
                }
            }
        }

        public static void DeleteSond(sond sond)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(
                        "DELETE FROM sond WHERE id = @id", con))
                    {
                        command.Parameters.Add(new SqlParameter("id", sond.id));
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {
                    Console.WriteLine("Count not delete.");
                }
            }
        }


        #endregion


        #region Database method userTab

        public static List<usersTab> GetUsers(string statement = "")
        {
            List<usersTab> users = new List<usersTab>();
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();

                string querry = "SELECT * FROM usersTab " + statement;
                using (SqlCommand command = new SqlCommand(querry, con))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string loginIn = reader.GetString(0);
                        string passwordIn = reader.GetString(1);
                        string emailIn = reader.GetString(2);
                        string nameIn = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        string surnameIn = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string townIn = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        int ageIn = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                        string stateIn = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        string groupsIn = reader.GetString(9);

                        users.Add(new usersTab()
                        {
                            login = loginIn,
                            password = passwordIn,
                            email = emailIn,
                            name = nameIn,
                            surname = surnameIn,
                            town = townIn,
                            age = ageIn,
                            state = stateIn,
                            groups = groupsIn
                        });
                    }
                }
                con.Close();
            }
            return users;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static usersTab getUserInfo(string login)
        {
            usersTab user = new usersTab();
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();

                string querry = "SELECT * FROM usersTab where login = @login ";
                using (SqlCommand command = new SqlCommand(querry, con))
                {
                    command.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string loginIn = reader.GetString(0);
                        string passwordIn = reader.GetString(1);
                        string emailIn = reader.GetString(2);
                        string nameIn = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        string surnameIn = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        string townIn = reader.IsDBNull(5) ? "" : reader.GetString(5);
                        int ageIn = reader.IsDBNull(6) ? 0 : reader.GetInt32(6);
                        string stateIn = reader.IsDBNull(8) ? "" : reader.GetString(8);
                        string groupsIn = reader.GetString(9);

                        user = new usersTab()
                        {
                            login = loginIn,
                            password = passwordIn,
                            email = emailIn,
                            name = nameIn,
                            surname = surnameIn,
                            town = townIn,
                            age = ageIn,
                            state = stateIn,
                            groups = groupsIn
                        };
                    }
                }
                con.Close();
            }
            return user;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public static bool isLoginAvaible(string login)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();

                string querry = "SELECT login FROM usersTab where login = @login ";
                using (SqlCommand command = new SqlCommand(querry, con))
                {
                    command.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        con.Close();
                        return false;
                    }
                    con.Close();
                    return true;
                }

            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pass"></param>
        /// <param name="email"></param>
        public static bool addUser(string login, string pass, string email)
        {
            using (SqlConnection con = new SqlConnection(GlobalVariables.connetionString))
            {
                con.Open();
                try
                {

                    using (SqlCommand command = new SqlCommand
                        ("INSERT INTO usersTab (login, password, email, groups) VALUES (@login, @pass, @email, @user) ", con))
                    {
                        command.Parameters.Add(new SqlParameter("@login", login));
                        command.Parameters.Add(new SqlParameter("@pass", pass));
                        command.Parameters.Add(new SqlParameter("@email", email));
                        command.Parameters.Add(new SqlParameter("@user", "user"));
                        command.ExecuteNonQuery();
                        con.Close();
                       
                        return true;
                    }
                }
                catch (Exception e)
                {
                    con.Close();
                    Console.WriteLine("Blad " + e);
                    return false;
                }
            }

        }
            #endregion
        
    }
}
