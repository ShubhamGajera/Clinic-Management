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
    public partial class Receptionists_Page : Form
    {
        public Receptionists_Page()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Clinic_Management;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True";

        private void Home_Click(object sender, EventArgs e)
        {
            Home_page HomePage = new Home_page();
            HomePage.Show();
            this.Hide();
        }

        private void Patients_page_pic_Click_1(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }

        private void Patients_page_Click(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }

        private void Doctor_page_Click(object sender, EventArgs e)
        {
            Doctor_Page DoctorPage = new Doctor_Page();
            DoctorPage.Show();
            this.Hide();
        }

        private void Doctor_page_pic_Click(object sender, EventArgs e)
        {
            Doctor_Page DoctorPage = new Doctor_Page();
            DoctorPage.Show();
            this.Hide();
        }

        private void Laboratory_page_Click_1(object sender, EventArgs e)
        {
            Laboratory_Page LaboratoryPage = new Laboratory_Page();
            LaboratoryPage.Show();
            this.Hide();
        }

        private void Laboratory_page_pic_Click_1(object sender, EventArgs e)
        {
            Laboratory_Page LaboratoryPage = new Laboratory_Page();
            LaboratoryPage.Show();
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

        private void Add_Receptionist_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "INSERT INTO Receptionists (ReceptionistId,ReceptionistName, Phone, Address) VALUES (@ReceptionistId,@ReceptionistName, @Phone, @Address)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReceptionistId", Receptionists_Id_Box.Text.Trim());
            command.Parameters.AddWithValue("@ReceptionistName", Receptionist_Name_Box.Text.Trim());
            command.Parameters.AddWithValue("@Phone", Receptionist_Phone_Box.Text.Trim());
            command.Parameters.AddWithValue("@Address", Receptionist_Address_Box.Text.Trim());
            command.ExecuteNonQuery();
            MessageBox.Show("Receptionist added successfully!");
        }

        private void Edit_Receptionist_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "UPDATE Receptionists SET ReceptionistName = @ReceptionistName, Phone = @Phone, Address = @Address WHERE ReceptionistId = @ReceptionistId";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReceptionistId", Receptionists_Id_Box.Text.Trim());
            command.Parameters.AddWithValue("@ReceptionistName", Receptionist_Name_Box.Text.Trim());
            command.Parameters.AddWithValue("@Phone", Receptionist_Phone_Box.Text.Trim());
            command.Parameters.AddWithValue("@Address", Receptionist_Address_Box.Text.Trim());
            command.ExecuteNonQuery();
            MessageBox.Show("Receptionist updated successfully!");


        }

        private void Delete_Receptionist_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "DELETE FROM Receptionists WHERE ReceptionistId = @ReceptionistId";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReceptionistId", Receptionists_Id_Box.Text.Trim());
            command.ExecuteNonQuery();
            MessageBox.Show("Receptionist deleted successfully!");

        }

        private void View_Receptionist_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Receptionists", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}
