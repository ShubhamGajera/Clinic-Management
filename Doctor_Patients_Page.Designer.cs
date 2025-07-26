namespace Clinic_Management
{
    partial class Doctor_Patients_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Patient_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Patient_Name_Box = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.Label();
            this.Patient_DOB = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.Label();
            this.Patient_Gender_Box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Disease_box = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Patient_Phone_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Patient_Address_Box = new System.Windows.Forms.TextBox();
            this.Medicine_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Patient_Id_Box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Patients = new System.Windows.Forms.Button();
            this.Edit_Patient = new System.Windows.Forms.Button();
            this.Delete_Patient = new System.Windows.Forms.Button();
            this.View_Patients = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Logout_page_pic = new System.Windows.Forms.PictureBox();
            this.Laboratory_page_pic = new System.Windows.Forms.PictureBox();
            this.Patients_page_pic = new System.Windows.Forms.PictureBox();
            this.Logout_page = new System.Windows.Forms.Label();
            this.Laboratory_page = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laboratory_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 274);
            this.dataGridView1.TabIndex = 7;
            // 
            // Patient_Name
            // 
            this.Patient_Name.AutoSize = true;
            this.Patient_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Name.Location = new System.Drawing.Point(312, 115);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Size = new System.Drawing.Size(130, 22);
            this.Patient_Name.TabIndex = 8;
            this.Patient_Name.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(744, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Patients";
            // 
            // Patient_Name_Box
            // 
            this.Patient_Name_Box.Location = new System.Drawing.Point(316, 140);
            this.Patient_Name_Box.Multiline = true;
            this.Patient_Name_Box.Name = "Patient_Name_Box";
            this.Patient_Name_Box.Size = new System.Drawing.Size(248, 24);
            this.Patient_Name_Box.TabIndex = 10;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(312, 182);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(52, 22);
            this.DOB.TabIndex = 11;
            this.DOB.Text = "DOB";
            // 
            // Patient_DOB
            // 
            this.Patient_DOB.Location = new System.Drawing.Point(316, 207);
            this.Patient_DOB.Name = "Patient_DOB";
            this.Patient_DOB.Size = new System.Drawing.Size(243, 22);
            this.Patient_DOB.TabIndex = 12;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.Location = new System.Drawing.Point(312, 250);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(76, 22);
            this.Gender.TabIndex = 13;
            this.Gender.Text = "Gender";
            // 
            // Patient_Gender_Box
            // 
            this.Patient_Gender_Box.FormattingEnabled = true;
            this.Patient_Gender_Box.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Patient_Gender_Box.Location = new System.Drawing.Point(316, 275);
            this.Patient_Gender_Box.Name = "Patient_Gender_Box";
            this.Patient_Gender_Box.Size = new System.Drawing.Size(248, 24);
            this.Patient_Gender_Box.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(904, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Disease ";
            // 
            // Disease_box
            // 
            this.Disease_box.Location = new System.Drawing.Point(908, 151);
            this.Disease_box.Multiline = true;
            this.Disease_box.Name = "Disease_box";
            this.Disease_box.Size = new System.Drawing.Size(248, 148);
            this.Disease_box.TabIndex = 16;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(607, 115);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(67, 22);
            this.Phone.TabIndex = 17;
            this.Phone.Text = "Phone";
            // 
            // Patient_Phone_Box
            // 
            this.Patient_Phone_Box.Location = new System.Drawing.Point(610, 140);
            this.Patient_Phone_Box.Multiline = true;
            this.Patient_Phone_Box.Name = "Patient_Phone_Box";
            this.Patient_Phone_Box.Size = new System.Drawing.Size(248, 24);
            this.Patient_Phone_Box.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(610, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // Patient_Address_Box
            // 
            this.Patient_Address_Box.Location = new System.Drawing.Point(610, 209);
            this.Patient_Address_Box.Multiline = true;
            this.Patient_Address_Box.Name = "Patient_Address_Box";
            this.Patient_Address_Box.Size = new System.Drawing.Size(248, 90);
            this.Patient_Address_Box.TabIndex = 20;
            // 
            // Medicine_Box
            // 
            this.Medicine_Box.Location = new System.Drawing.Point(1169, 151);
            this.Medicine_Box.Multiline = true;
            this.Medicine_Box.Name = "Medicine_Box";
            this.Medicine_Box.Size = new System.Drawing.Size(248, 148);
            this.Medicine_Box.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1165, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Medicine";
            // 
            // Patient_Id_Box
            // 
            this.Patient_Id_Box.Location = new System.Drawing.Point(316, 72);
            this.Patient_Id_Box.Multiline = true;
            this.Patient_Id_Box.Name = "Patient_Id_Box";
            this.Patient_Id_Box.Size = new System.Drawing.Size(248, 29);
            this.Patient_Id_Box.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Patient Id";
            // 
            // Add_Patients
            // 
            this.Add_Patients.Location = new System.Drawing.Point(664, 333);
            this.Add_Patients.Name = "Add_Patients";
            this.Add_Patients.Size = new System.Drawing.Size(107, 39);
            this.Add_Patients.TabIndex = 25;
            this.Add_Patients.Text = "Add";
            this.Add_Patients.UseVisualStyleBackColor = true;
            this.Add_Patients.Click += new System.EventHandler(this.Add_Patients_Click);
            // 
            // Edit_Patient
            // 
            this.Edit_Patient.Location = new System.Drawing.Point(786, 333);
            this.Edit_Patient.Name = "Edit_Patient";
            this.Edit_Patient.Size = new System.Drawing.Size(107, 39);
            this.Edit_Patient.TabIndex = 26;
            this.Edit_Patient.Text = "Edit";
            this.Edit_Patient.UseVisualStyleBackColor = true;
            this.Edit_Patient.Click += new System.EventHandler(this.Edit_Patient_Click);
            // 
            // Delete_Patient
            // 
            this.Delete_Patient.Location = new System.Drawing.Point(911, 333);
            this.Delete_Patient.Name = "Delete_Patient";
            this.Delete_Patient.Size = new System.Drawing.Size(107, 39);
            this.Delete_Patient.TabIndex = 27;
            this.Delete_Patient.Text = "Delete";
            this.Delete_Patient.UseVisualStyleBackColor = true;
            this.Delete_Patient.Click += new System.EventHandler(this.Delete_Patient_Click);
            // 
            // View_Patients
            // 
            this.View_Patients.Location = new System.Drawing.Point(786, 389);
            this.View_Patients.Name = "View_Patients";
            this.View_Patients.Size = new System.Drawing.Size(107, 39);
            this.View_Patients.TabIndex = 55;
            this.View_Patients.Text = "View";
            this.View_Patients.UseVisualStyleBackColor = true;
            this.View_Patients.Click += new System.EventHandler(this.View_Patients_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.Logout_page_pic);
            this.panel6.Controls.Add(this.Laboratory_page_pic);
            this.panel6.Controls.Add(this.Patients_page_pic);
            this.panel6.Controls.Add(this.Logout_page);
            this.panel6.Controls.Add(this.Laboratory_page);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.Home);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 723);
            this.panel6.TabIndex = 56;
            // 
            // Logout_page_pic
            // 
            this.Logout_page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_page_pic.Image = global::Clinic_Management.Properties.Resources.LogOut_Icon;
            this.Logout_page_pic.Location = new System.Drawing.Point(51, 638);
            this.Logout_page_pic.Name = "Logout_page_pic";
            this.Logout_page_pic.Size = new System.Drawing.Size(64, 58);
            this.Logout_page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logout_page_pic.TabIndex = 14;
            this.Logout_page_pic.TabStop = false;
            this.Logout_page_pic.Click += new System.EventHandler(this.Logout_page_pic_Click_1);
            // 
            // Laboratory_page_pic
            // 
            this.Laboratory_page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Laboratory_page_pic.Image = global::Clinic_Management.Properties.Resources.Laboratory_Icon;
            this.Laboratory_page_pic.Location = new System.Drawing.Point(51, 296);
            this.Laboratory_page_pic.Name = "Laboratory_page_pic";
            this.Laboratory_page_pic.Size = new System.Drawing.Size(64, 58);
            this.Laboratory_page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Laboratory_page_pic.TabIndex = 12;
            this.Laboratory_page_pic.TabStop = false;
            this.Laboratory_page_pic.Click += new System.EventHandler(this.Laboratory_page_pic_Click_1);
            // 
            // Patients_page_pic
            // 
            this.Patients_page_pic.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Patients_page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patients_page_pic.Image = global::Clinic_Management.Properties.Resources.Patients_icon;
            this.Patients_page_pic.Location = new System.Drawing.Point(51, 218);
            this.Patients_page_pic.Name = "Patients_page_pic";
            this.Patients_page_pic.Size = new System.Drawing.Size(64, 58);
            this.Patients_page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Patients_page_pic.TabIndex = 10;
            this.Patients_page_pic.TabStop = false;
            // 
            // Logout_page
            // 
            this.Logout_page.AutoSize = true;
            this.Logout_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_page.Location = new System.Drawing.Point(138, 654);
            this.Logout_page.Name = "Logout_page";
            this.Logout_page.Size = new System.Drawing.Size(89, 25);
            this.Logout_page.TabIndex = 9;
            this.Logout_page.Text = "Log Out";
            this.Logout_page.Click += new System.EventHandler(this.Logout_page_Click_1);
            // 
            // Laboratory_page
            // 
            this.Laboratory_page.AutoSize = true;
            this.Laboratory_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Laboratory_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laboratory_page.Location = new System.Drawing.Point(138, 311);
            this.Laboratory_page.Name = "Laboratory_page";
            this.Laboratory_page.Size = new System.Drawing.Size(121, 25);
            this.Laboratory_page.TabIndex = 8;
            this.Laboratory_page.Text = "Laboratory ";
            this.Laboratory_page.Click += new System.EventHandler(this.Laboratory_page_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Patients";
            // 
            // Home
            // 
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.Image = global::Clinic_Management.Properties.Resources.Clinic_Icon;
            this.Home.Location = new System.Drawing.Point(86, 72);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(98, 77);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 5;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Doctor_Patients_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 723);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.View_Patients);
            this.Controls.Add(this.Delete_Patient);
            this.Controls.Add(this.Edit_Patient);
            this.Controls.Add(this.Add_Patients);
            this.Controls.Add(this.Patient_Id_Box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Medicine_Box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Patient_Address_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Patient_Phone_Box);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Disease_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Patient_Gender_Box);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Patient_DOB);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Patient_Name_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Patient_Name);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor_Patients_Page";
            this.Text = "Patients_Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_page_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laboratory_page_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_page_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Patient_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Patient_Name_Box;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.DateTimePicker Patient_DOB;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox Patient_Gender_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Disease_box;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox Patient_Phone_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Patient_Address_Box;
        private System.Windows.Forms.TextBox Medicine_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Patient_Id_Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_Patients;
        private System.Windows.Forms.Button Edit_Patient;
        private System.Windows.Forms.Button Delete_Patient;
        private System.Windows.Forms.Button View_Patients;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Logout_page_pic;
        private System.Windows.Forms.PictureBox Laboratory_page_pic;
        private System.Windows.Forms.PictureBox Patients_page_pic;
        private System.Windows.Forms.Label Logout_page;
        private System.Windows.Forms.Label Laboratory_page;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Home;
    }
}