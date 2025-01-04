using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using DotNetEnv;
using System.Windows.Forms;

namespace stock_manager
{
    internal class Connect
    {
        public static NpgsqlConnection GetConnection()
        {
            Env.Load();
            string querry = Environment.GetEnvironmentVariable("DATABASE_URL");
            Console.WriteLine($"Connection string: {querry}");
            NpgsqlConnection conn = new NpgsqlConnection(querry);
            try
            {
                conn.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("SQL Connection! \n" +ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}
