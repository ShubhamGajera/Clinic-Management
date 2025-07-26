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
    public partial class Doctor_Patients_Page : Form
    {
        public Doctor_Patients_Page()
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

    

        private void Laboratory_page_Click_1(object sender, EventArgs e)
        {
            Doctor_Laboratory_Page DoctorLaboratoryPage = new Doctor_Laboratory_Page();
                DoctorLaboratoryPage.Show();
                this.Hide();
        }

        private void Laboratory_page_pic_Click_1(object sender, EventArgs e)
        {
            Doctor_Laboratory_Page DoctorLaboratoryPage = new Doctor_Laboratory_Page();
                DoctorLaboratoryPage.Show();
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
        private void Add_Patients_Click(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Patients (PatientId,PatientName, DateOfBirth, Gender, Phone, Address, Disease, Medicine) VALUES (@PatientId,@PatientName, @DateOfBirth, @Gender, @Phone, @Address, @Disease, @Medicine)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@PatientName", Patient_Name_Box.Text);
                command.Parameters.AddWithValue("@DateOfBirth", Patient_DOB.Value);
                command.Parameters.AddWithValue("@Gender", Patient_Gender_Box.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Phone", Patient_Phone_Box.Text);
                command.Parameters.AddWithValue("@Address", Patient_Address_Box.Text);
                command.Parameters.AddWithValue("@Disease", Disease_box.Text);
                command.Parameters.AddWithValue("@Medicine", Medicine_Box.Text);
                command.Parameters.AddWithValue("@PatientId", Patient_Id_Box.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Patient added successfully!");
            }

        }

        private void Edit_Patient_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Patients SET PatientName = @PatientName, DateOfBirth = @DateOfBirth, Gender = @Gender, Phone = @Phone, Address = @Address, Disease = @Disease, Medicine = @Medicine WHERE PatientId = @PatientId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientName", Patient_Name_Box.Text);
                command.Parameters.AddWithValue("@DateOfBirth", Patient_DOB.Value);
                command.Parameters.AddWithValue("@Gender", Patient_Gender_Box.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Phone", Patient_Phone_Box.Text);
                command.Parameters.AddWithValue("@Address", Patient_Address_Box.Text);
                command.Parameters.AddWithValue("@Disease", Disease_box.Text);
                command.Parameters.AddWithValue("@Medicine", Medicine_Box.Text);
                command.Parameters.AddWithValue("@PatientId", Patient_Id_Box.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Patient updated successfully!");
            }

        }

        private void Delete_Patient_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM Patients WHERE PatientId = @PatientId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PatientID", Patient_Id_Box.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Patient deleted successfully!");
            }

        }

        private void View_Patients_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Patients";
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Clinic_Management;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trusted_Connection=True";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
