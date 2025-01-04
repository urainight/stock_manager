using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using NpgsqlTypes;
using System.Windows.Forms;

namespace stock_manager
{
    internal class warehouse_productdb
    {
        public static void AddProduct(Product std)
        {
            string querry = "INSERT INTO warehouse_stock.products (product_id ,product_name, quantity, unit, date) VALUES (@id, @name, @quantity, @unit, @date)";
            NpgsqlConnection conn = Connect.GetConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(querry, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Integer).Value = std.id;
            cmd.Parameters.AddWithValue("@name", NpgsqlDbType.Varchar).Value = std.name;
            cmd.Parameters.AddWithValue("@quantity", NpgsqlDbType.Integer).Value = std.quantity;
            cmd.Parameters.AddWithValue("@unit", NpgsqlDbType.Varchar).Value = std.unit;
            cmd.Parameters.AddWithValue("@date", NpgsqlDbType.Timestamp).Value = std.date_added;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Product not insert. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void EditProduct(Product std, int id)
        {
            string querry = "UPDATE warehouse_stock.products SET product_name = @name, quantity = @quantity, unit = @unit, date_update = @date_update WHERE product_id = @id";
            NpgsqlConnection conn = Connect.GetConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(querry, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Integer).Value = id;
            cmd.Parameters.AddWithValue("@name", NpgsqlDbType.Varchar).Value = std.name;
            cmd.Parameters.AddWithValue("@quantity", NpgsqlDbType.Integer).Value = std.quantity;
            cmd.Parameters.AddWithValue("@unit", NpgsqlDbType.Varchar).Value = std.unit;
            cmd.Parameters.AddWithValue("@date_update", NpgsqlDbType.Timestamp).Value = std.date_updated;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Product not Updated. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteProduct(int id)
        {
            string querry = "DELETE FROM warehouse_stock.products WHERE product_id = @id";
            NpgsqlConnection conn = Connect.GetConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(querry, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", NpgsqlDbType.Integer).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Product not Deleted. \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DisplayAndSearchProduct(string querry, DataGridView dgv)
        {
            string sql = querry;
            NpgsqlConnection conn = Connect.GetConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }
    }
}
