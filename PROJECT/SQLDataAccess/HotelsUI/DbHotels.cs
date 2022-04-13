using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsUI
{
    class DbHotels
    {
        public static SqlConnection GetConnection()
        {
            string sql = "ADD HERE YOUR DATA PATH";
            SqlConnection con = new SqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Connection error" + ex.Message);
            }
            return con;        
        }

        public static void UpdateHotelOne(HotelOne std, string id)
        {

            string sql = "UPDATE TableOne SET RoomNumber = @RoomNumber, RoomDescription = @RoomDescription, RoomVacancy = @RoomVacancy WHERE ID = @Id";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = std.RoomNumber;
            cmd.Parameters.Add("@RoomDescription", SqlDbType.VarChar).Value = std.RoomDescription;
            cmd.Parameters.Add("@RoomVacancy", SqlDbType.VarChar).Value = std.RoomVacancy;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error, not updated\n" +ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();            
        }

        public static void UpdateHotelTwo(HotelTwo std, string id2)
        {

            string sql = "UPDATE TableTwo SET RoomNumber2 = @RoomNumber2, RoomDescription2 = @RoomDescription2, RoomVacancy2 = @RoomVacancy2 WHERE ROOMID = @RoomId";
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@RoomId", SqlDbType.VarChar).Value = id2;
            cmd.Parameters.Add("@RoomNumber2", SqlDbType.VarChar).Value = std.RoomNumber2;
            cmd.Parameters.Add("@RoomDescription2", SqlDbType.VarChar).Value = std.RoomDescription2;
            cmd.Parameters.Add("@RoomVacancy2", SqlDbType.VarChar).Value = std.RoomVacancy2;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error, not updated\n" + ex.Message, "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }
    }
}
