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

namespace Clinic_Management
{
    public partial class Doctor_Laboratory_Page : Form
    {
        public Doctor_Laboratory_Page()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Clinic_Management;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True";

        private void Home_Click(object sender, EventArgs e)
        {
            Doctor_Home_Page DoctorHomePage = new Doctor_Home_Page();
            DoctorHomePage.Show();
            this.Hide();
        }

        private void Patients_page_pic_Click_1(object sender, EventArgs e)
        {
            Doctor_Patients_Page DoctorpatientsPage = new Doctor_Patients_Page();
            DoctorpatientsPage.Show();
            this.Hide();
        }

        private void Patients_page_Click(object sender, EventArgs e)
        {
            Doctor_Patients_Page DoctorpatientsPage = new Doctor_Patients_Page();
            DoctorpatientsPage.Show();
            this.Hide();
        }


        private void Logout_page_Click_1(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
            LoginPage.Show();
            this.Hide();
        }

        private void Logout_page_pic_Click_1(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
            LoginPage.Show();
            this.Hide();
        }

        private void Add_Laboratory_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Laboratory (Laboratory_ID,Test_Name, Cost) VALUES (@Laboratory_ID,@Test_Name, @Cost)", connection);
            command.Parameters.AddWithValue("@Laboratory_ID", Laboratory_ID.Text);
            command.Parameters.AddWithValue("@Test_Name", Test_Name_Box.Text);
            command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(Cost_Box.Text));
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Laboratory Added successfully!");
        }

        private void Edit_Laboratory_Click(object sender, EventArgs e)
        {

            int rowIndex = Laboratory.SelectedCells[0].RowIndex;
            int laboratoryID = Convert.ToInt32(Laboratory.Rows[rowIndex].Cells[0].Value);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Laboratory SET Test_Name = @Test_Name, Cost = @Cost WHERE Laboratory_ID = @Laboratory_ID", connection);
            command.Parameters.AddWithValue("@Test_Name", Test_Name_Box.Text);
            command.Parameters.AddWithValue("@Cost", Convert.ToDecimal(Cost_Box.Text));
            command.Parameters.AddWithValue("@Laboratory_ID", laboratoryID);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Laboratory Updated successfully!");

        }

        private void Delete_Laboratory_Click(object sender, EventArgs e)
        {

            int rowIndex = Laboratory.SelectedCells[0].RowIndex;
            int laboratoryID = Convert.ToInt32(Laboratory.Rows[rowIndex].Cells[0].Value);
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Laboratory WHERE Laboratory_ID = @Laboratory_ID", connection);
            command.Parameters.AddWithValue("@Laboratory_ID", laboratoryID);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Laboratory deleted successfully!");


        }

        private void View_Laboratory_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Laboratory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Laboratory.DataSource = table;
            connection.Close();
        }
    }
}
