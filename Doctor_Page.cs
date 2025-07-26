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
    public partial class Doctor_Page : Form
    {
        public Doctor_Page()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Clinic_Management;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True";


        private void Home_Click_1(object sender, EventArgs e)
        {
            Home_page HomePage = new Home_page();
            HomePage.Show();
            this.Hide();
        }

        private void Patients_page_Click(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }

        private void Patients_page_pic_Click(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }

        private void Laboratory_page_pic_Click(object sender, EventArgs e)
        {
            Laboratory_Page LaboratoryPage = new Laboratory_Page();
            LaboratoryPage.Show();
            this.Hide();
        }

        private void Laboratory_page_Click(object sender, EventArgs e)
        {
            Laboratory_Page LaboratoryPage = new Laboratory_Page();
            LaboratoryPage.Show();
            this.Hide();
        }

        private void Receptionists_page_Click(object sender, EventArgs e)
        {
            Receptionists_Page ReceptionistsPage = new Receptionists_Page();
            ReceptionistsPage.Show();
            this.Hide();
        }

        private void Receptionists_page_pic_Click(object sender, EventArgs e)
        {
            Receptionists_Page ReceptionistsPage = new Receptionists_Page();
            ReceptionistsPage.Show();
            this.Hide();
        }

        private void Logout_page_Click(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
            LoginPage.Show();
            this.Hide();
        }

        private void Logout_page_pic_Click(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
            LoginPage.Show();
            this.Hide();
        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Doctors (DoctorID,DoctorName, DateOfBirth, Gender, Phone, Address, Password, Specialization) VALUES (@DoctorID,@DoctorName, @DateOfBirth, @Gender, @Phone, @Address, @Password, @Specialization)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DoctorID", Doctor_Id_Box.Text);
                command.Parameters.AddWithValue("@DoctorName", Patient_Name_Box.Text);
                command.Parameters.AddWithValue("@DateOfBirth", Doctor_DOB.Value);
                command.Parameters.AddWithValue("@Gender", Doctor_Gender_Box.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Phone", Doctor_Phone_Box.Text);
                command.Parameters.AddWithValue("@Address", Doctor_Address_Box.Text);
                command.Parameters.AddWithValue("@Password", Doctor_Password.Text);
                command.Parameters.AddWithValue("@Specialization", Specialitasion_Box.SelectedItem.ToString());

                command.ExecuteNonQuery();

                MessageBox.Show("Doctor added successfully!");
            }

        }

        private void Edit_Doctor_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

            string query = "UPDATE Doctors SET DoctorName = @DoctorName, DateOfBirth = @DateOfBirth, Gender = @Gender, Phone = @Phone, Address = @Address, Password = @Password, Specialization = @Specialization WHERE DoctorID = @DoctorID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DoctorName", Patient_Name_Box.Text);
                command.Parameters.AddWithValue("@DateOfBirth", Doctor_DOB.Value);
                command.Parameters.AddWithValue("@Gender", Doctor_Gender_Box.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Phone", Doctor_Phone_Box.Text);
                command.Parameters.AddWithValue("@Address", Doctor_Address_Box.Text);
                command.Parameters.AddWithValue("@Password", Doctor_Password.Text);
                command.Parameters.AddWithValue("@Specialization", Specialitasion_Box.SelectedItem.ToString());
                command.Parameters.AddWithValue("@DoctorID", Doctor_Id_Box.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Doctor updated successfully!");
            }

        }

        private void Delete_Doctor_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DoctorID", Doctor_Id_Box.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Doctor deleted successfully!");
            }


        }

        private void View_Doctor_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Doctors";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    DataTable doctorsTable = new DataTable();
                    doctorsTable.Load(reader);

                    dataGridView1.DataSource = doctorsTable;
                }
            }

        }
    }
}
