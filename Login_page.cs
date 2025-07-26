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
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void Role_Click(object sender, EventArgs e)
        {
        }
        private void Login_Click_1(object sender, EventArgs e)
        {
            string selectedRole = Role_Box_Login.SelectedItem.ToString();
            string username = Username_textbox.Text;
            string password = Password_textbox.Text;

            if (selectedRole == "Admin" && username == "shubham" && password == "123")
            {
                Home_page adminPage = new Home_page();
                adminPage.Show();
                this.Hide(); 
            }
            else if (selectedRole == "Doctor" && username == "atmin" && password == "123")
            {
                Doctor_Home_Page doctorPage = new Doctor_Home_Page();
                doctorPage.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }
}
