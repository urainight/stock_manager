using Npgsql;
using DotNetEnv;
using Npgsql.Replication;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.IO;
using DotNetEnv.Configuration;
using System.Web.Caching;

namespace stock_manager
{
    internal class warehousedb_user
    {
        public static void AddUser(User std)
        {
            string querry = "INSERT INTO warehouse_stock.users(username, email, password, is_admin, date_joined) VALUES (@Username, @Useremail, @Userpassword, @Isadmin, @Datejoined)";
            NpgsqlConnection con = Connect.GetConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(querry, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Username", NpgsqlDbType.Varchar).Value = std.username;
            cmd.Parameters.Add("@Useremail", NpgsqlDbType.Varchar).Value = std.email;
            cmd.Parameters.Add("@Userpassword", NpgsqlDbType.Varchar).Value = std.password;
            cmd.Parameters.Add("@Isadmin", NpgsqlDbType.Boolean).Value = std.is_admin;
            cmd.Parameters.Add("@Datejoined", NpgsqlDbType.Timestamp).Value = std.date_joined;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("User not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static bool LoginUser(string username, string password)
        {
            string query = "SELECT password FROM warehouse_stock.users WHERE username = @Username";
            NpgsqlConnection con = Connect.GetConnection();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                string Hashpass = cmd.ExecuteScalar()?.ToString();
                Console.WriteLine(Hashpass);

                if (Hashpass != null)
                {
                    if (Backend_user.VertifyPassword(password, Hashpass))
                    {
                        return true;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            con.Close();
            return false;
        }
    }
}
