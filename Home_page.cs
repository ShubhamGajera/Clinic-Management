using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management
{
    public partial class Home_page : Form
    {
        public Home_page()
        {
            InitializeComponent();
        }
       
        
        private void Patients_page_pic_Click(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }
        private void Patients_page_Click_1(object sender, EventArgs e)
        {
            Patients_Page patientsPage = new Patients_Page();
            patientsPage.Show();
            this.Hide();
        }

        private void Doctor_page_pic_Click_1(object sender, EventArgs e)
        {
            Doctor_Page DoctorPage = new Doctor_Page();
            DoctorPage.Show();
            this.Hide();
        }

        private void Doctor_page_Click_1(object sender, EventArgs e)
        {
            Doctor_Page DoctorPage = new Doctor_Page();
            DoctorPage.Show();
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

        private void Receptionists_page_pic_Click(object sender, EventArgs e)
        {
            Receptionists_Page ReceptionistsPage = new Receptionists_Page();
                ReceptionistsPage.Show();
                this.Hide();
        }

        private void Receptionists_page_Click(object sender, EventArgs e)
        {
            Receptionists_Page ReceptionistsPage = new Receptionists_Page();
            ReceptionistsPage.Show();
            this.Hide();
        }

        private void Logout_page_pic_Click(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
                LoginPage.Show();
                this.Hide();
        }

        private void Logout_page_Click(object sender, EventArgs e)
        {
            Login_page LoginPage = new Login_page();
                   LoginPage.Show();
                   this.Hide();
        }
    }
}
