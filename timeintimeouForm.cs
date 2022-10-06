using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeInTimeOutwithMSSQL
{
    public partial class timeintimeouForm : Form
    {
        string connectionString;
        SqlConnection con;

        public timeintimeouForm()
        {
            InitializeComponent();
        }
        void clearTxt()
        {
            nameTxt.Clear();
            timeinTxt.Clear();
            timeoutTxt.Clear();
            totaltimeTxt.Clear();
        }

        private void timeintimeouForm_Load(object sender, EventArgs e)
        {

        }

        private void timeinBtn_Click(object sender, EventArgs e)
        {
            timeinTxt.Text = Convert.ToString(DateTime.Now);
        }

        private void timeoutBtn_Click(object sender, EventArgs e)
        {
            timeoutTxt.Text = Convert.ToString(DateTime.Now);            
            DateTime dtStart = Convert.ToDateTime(timeinTxt.Text);
            DateTime dtEnd = Convert.ToDateTime(timeoutTxt.Text);
            TimeSpan DtTimeSpan = dtEnd.Subtract(dtStart);
            totaltimeTxt.Text = Convert.ToString(DtTimeSpan);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=TimeInOutDB;Integrated Security=True";
                con = new SqlConnection(connectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into TimeInOutTB values (@Employee_No,@Employee_Name,@Employee_TimeIn,@Employee_TimeOut,@Total_Time)", con);
                cmd.Parameters.AddWithValue("@Employee_No", int.Parse(employeenoTxt.Text));
                cmd.Parameters.AddWithValue("@Employee_Name", (nameTxt.Text));
                cmd.Parameters.AddWithValue("@Employee_TimeIn", (timeinTxt.Text));
                cmd.Parameters.AddWithValue("@Employee_TimeOut", (timeoutTxt.Text));
                cmd.Parameters.AddWithValue("@Total_Time", (totaltimeTxt.Text));
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Succcessfully Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearTxt();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=TimeInOutDB;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update TimeInOutTB set Employee_Name = @Employee_Name,Employee_TimeIn = @Employee_TimeIn,Employee_TimeOut = @Employee_TimeOut,Total_Time = @Total_Time where Employee_No = @Employee_No", con);
            cmd.Parameters.AddWithValue("@Employee_No", int.Parse(employeenoTxt.Text));
            cmd.Parameters.AddWithValue("@Employee_Name", (nameTxt.Text));
            cmd.Parameters.AddWithValue("@Employee_TimeIn", (timeinTxt.Text));
            cmd.Parameters.AddWithValue("@Employee_TimeOut", (timeoutTxt.Text));
            cmd.Parameters.AddWithValue("@Total_Time", (totaltimeTxt.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Succcessfully Saved");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=TimeInOutDB;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete TimeInOutTB where Employee_No = @Employee_No", con);
            cmd.Parameters.AddWithValue("@Employee_No", int.Parse(employeenoTxt.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succcessfully Deleted");
        }

        private void employeenoTxt_TextChanged(object sender, EventArgs e)
        {
            connectionString = @"Data Source=WIN-U412I9LKOT5\SQLEXPRESS;Initial Catalog=TimeInOutDB;Integrated Security=True";
            con = new SqlConnection(connectionString);
            con.Open();
            if (employeenoTxt.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Select Employee_Name,Employee_TimeIn,Employee_TimeOut,Total_Time from TimeInOutTB where Employee_No = @Employee_No", con);
                cmd.Parameters.AddWithValue("@Employee_No", long.Parse(employeenoTxt.Text));
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    nameTxt.Text = da.GetValue(0).ToString();
                    timeinTxt.Text = da.GetValue(1).ToString();
                    timeoutTxt.Text = da.GetValue(2).ToString();
                    totaltimeTxt.Text = da.GetValue(3).ToString();
                }
            }
            else if (employeenoTxt.Text == "")
            {
                clearTxt();
            }
                con.Close();                     
        }

        private void employeenoTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
