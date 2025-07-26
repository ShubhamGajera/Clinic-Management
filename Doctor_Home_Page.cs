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
    public partial class Doctor_Home_Page : Form
    {
        public Doctor_Home_Page()
        {
            InitializeComponent();
        }


        private void Patients_page_pic_Click(object sender, EventArgs e)
        {
            Doctor_Patients_Page DoctorpatientsPage = new Doctor_Patients_Page();
            DoctorpatientsPage.Show();
            this.Hide();
        }
        private void Patients_page_Click_1(object sender, EventArgs e)
        {
            Doctor_Patients_Page DoctorpatientsPage = new Doctor_Patients_Page();
            DoctorpatientsPage.Show();
            this.Hide();
        }



        private void Laboratory_page_pic_Click(object sender, EventArgs e)
        {
            Doctor_Laboratory_Page DoctorLaboratoryPage = new Doctor_Laboratory_Page();
            DoctorLaboratoryPage.Show();
            this.Hide();
        }

        private void Laboratory_page_Click(object sender, EventArgs e)
        {
            Doctor_Laboratory_Page DoctorLaboratoryPage = new Doctor_Laboratory_Page();
            DoctorLaboratoryPage.Show();
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
