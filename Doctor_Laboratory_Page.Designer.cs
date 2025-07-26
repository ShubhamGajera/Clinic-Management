namespace Clinic_Management
{
    partial class Doctor_Laboratory_Page
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
            this.View_Laboratory = new System.Windows.Forms.Button();
            this.Delete_Laboratory = new System.Windows.Forms.Button();
            this.Edit_Laboratory = new System.Windows.Forms.Button();
            this.Add_Laboratory = new System.Windows.Forms.Button();
            this.Test_Name_Box = new System.Windows.Forms.TextBox();
            this.Test_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Laboratory = new System.Windows.Forms.DataGridView();
            this.Cost_Box = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Logout_page_pic = new System.Windows.Forms.PictureBox();
            this.Laboratory_page_pic = new System.Windows.Forms.PictureBox();
            this.Patients_page_pic = new System.Windows.Forms.PictureBox();
            this.Logout_page = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Patients_page = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.PictureBox();
            this.Laboratory_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Laboratory)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laboratory_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Patients_page_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Laboratory
            // 
            this.View_Laboratory.Location = new System.Drawing.Point(778, 359);
            this.View_Laboratory.Name = "View_Laboratory";
            this.View_Laboratory.Size = new System.Drawing.Size(107, 39);
            this.View_Laboratory.TabIndex = 77;
            this.View_Laboratory.Text = "View";
            this.View_Laboratory.UseVisualStyleBackColor = true;
            this.View_Laboratory.Click += new System.EventHandler(this.View_Laboratory_Click);
            // 
            // Delete_Laboratory
            // 
            this.Delete_Laboratory.Location = new System.Drawing.Point(903, 314);
            this.Delete_Laboratory.Name = "Delete_Laboratory";
            this.Delete_Laboratory.Size = new System.Drawing.Size(107, 39);
            this.Delete_Laboratory.TabIndex = 72;
            this.Delete_Laboratory.Text = "Delete";
            this.Delete_Laboratory.UseVisualStyleBackColor = true;
            this.Delete_Laboratory.Click += new System.EventHandler(this.Delete_Laboratory_Click);
            // 
            // Edit_Laboratory
            // 
            this.Edit_Laboratory.Location = new System.Drawing.Point(778, 314);
            this.Edit_Laboratory.Name = "Edit_Laboratory";
            this.Edit_Laboratory.Size = new System.Drawing.Size(107, 39);
            this.Edit_Laboratory.TabIndex = 71;
            this.Edit_Laboratory.Text = "Edit";
            this.Edit_Laboratory.UseVisualStyleBackColor = true;
            this.Edit_Laboratory.Click += new System.EventHandler(this.Edit_Laboratory_Click);
            // 
            // Add_Laboratory
            // 
            this.Add_Laboratory.Location = new System.Drawing.Point(656, 314);
            this.Add_Laboratory.Name = "Add_Laboratory";
            this.Add_Laboratory.Size = new System.Drawing.Size(107, 39);
            this.Add_Laboratory.TabIndex = 70;
            this.Add_Laboratory.Text = "Add";
            this.Add_Laboratory.UseVisualStyleBackColor = true;
            this.Add_Laboratory.Click += new System.EventHandler(this.Add_Laboratory_Click);
            // 
            // Test_Name_Box
            // 
            this.Test_Name_Box.Location = new System.Drawing.Point(509, 243);
            this.Test_Name_Box.Multiline = true;
            this.Test_Name_Box.Name = "Test_Name_Box";
            this.Test_Name_Box.Size = new System.Drawing.Size(248, 29);
            this.Test_Name_Box.TabIndex = 69;
            // 
            // Test_Name
            // 
            this.Test_Name.AutoSize = true;
            this.Test_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Name.Location = new System.Drawing.Point(510, 218);
            this.Test_Name.Name = "Test_Name";
            this.Test_Name.Size = new System.Drawing.Size(107, 22);
            this.Test_Name.TabIndex = 68;
            this.Test_Name.Text = "Test Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(739, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 46);
            this.label1.TabIndex = 58;
            this.label1.Text = "Laboratory";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(890, 223);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(51, 22);
            this.Cost.TabIndex = 57;
            this.Cost.Text = "Cost";
            // 
            // Laboratory
            // 
            this.Laboratory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Laboratory.Location = new System.Drawing.Point(301, 427);
            this.Laboratory.Name = "Laboratory";
            this.Laboratory.RowHeadersWidth = 51;
            this.Laboratory.RowTemplate.Height = 24;
            this.Laboratory.Size = new System.Drawing.Size(1106, 290);
            this.Laboratory.TabIndex = 56;
            // 
            // Cost_Box
            // 
            this.Cost_Box.Location = new System.Drawing.Point(894, 248);
            this.Cost_Box.Multiline = true;
            this.Cost_Box.Name = "Cost_Box";
            this.Cost_Box.Size = new System.Drawing.Size(248, 24);
            this.Cost_Box.TabIndex = 59;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel6.Controls.Add(this.Logout_page_pic);
            this.panel6.Controls.Add(this.Laboratory_page_pic);
            this.panel6.Controls.Add(this.Patients_page_pic);
            this.panel6.Controls.Add(this.Logout_page);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.Patients_page);
            this.panel6.Controls.Add(this.Home);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 720);
            this.panel6.TabIndex = 78;
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
            this.Laboratory_page_pic.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Laboratory_page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Laboratory_page_pic.Image = global::Clinic_Management.Properties.Resources.Laboratory_Icon;
            this.Laboratory_page_pic.Location = new System.Drawing.Point(51, 295);
            this.Laboratory_page_pic.Name = "Laboratory_page_pic";
            this.Laboratory_page_pic.Size = new System.Drawing.Size(64, 58);
            this.Laboratory_page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Laboratory_page_pic.TabIndex = 12;
            this.Laboratory_page_pic.TabStop = false;
            // 
            // Patients_page_pic
            // 
            this.Patients_page_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patients_page_pic.Image = global::Clinic_Management.Properties.Resources.Patients_icon;
            this.Patients_page_pic.Location = new System.Drawing.Point(51, 218);
            this.Patients_page_pic.Name = "Patients_page_pic";
            this.Patients_page_pic.Size = new System.Drawing.Size(64, 58);
            this.Patients_page_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Patients_page_pic.TabIndex = 10;
            this.Patients_page_pic.TabStop = false;
            this.Patients_page_pic.Click += new System.EventHandler(this.Patients_page_pic_Click_1);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Laboratory ";
            // 
            // Patients_page
            // 
            this.Patients_page.AutoSize = true;
            this.Patients_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patients_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patients_page.Location = new System.Drawing.Point(134, 235);
            this.Patients_page.Name = "Patients_page";
            this.Patients_page.Size = new System.Drawing.Size(90, 25);
            this.Patients_page.TabIndex = 6;
            this.Patients_page.Text = "Patients";
            this.Patients_page.Click += new System.EventHandler(this.Patients_page_Click);
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
            // Laboratory_ID
            // 
            this.Laboratory_ID.Location = new System.Drawing.Point(510, 169);
            this.Laboratory_ID.Multiline = true;
            this.Laboratory_ID.Name = "Laboratory_ID";
            this.Laboratory_ID.Size = new System.Drawing.Size(248, 29);
            this.Laboratory_ID.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 81;
            this.label3.Text = "Test ID";
            // 
            // Doctor_Laboratory_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 720);
            this.Controls.Add(this.Laboratory_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.View_Laboratory);
            this.Controls.Add(this.Delete_Laboratory);
            this.Controls.Add(this.Edit_Laboratory);
            this.Controls.Add(this.Add_Laboratory);
            this.Controls.Add(this.Test_Name_Box);
            this.Controls.Add(this.Test_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Laboratory);
            this.Controls.Add(this.Cost_Box);
            this.Name = "Doctor_Laboratory_Page";
            this.Text = "Laboratory_Page";
            ((System.ComponentModel.ISupportInitialize)(this.Laboratory)).EndInit();
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

        private System.Windows.Forms.Button View_Laboratory;
        private System.Windows.Forms.Button Delete_Laboratory;
        private System.Windows.Forms.Button Edit_Laboratory;
        private System.Windows.Forms.Button Add_Laboratory;
        private System.Windows.Forms.TextBox Test_Name_Box;
        private System.Windows.Forms.Label Test_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.DataGridView Laboratory;
        private System.Windows.Forms.TextBox Cost_Box;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox Logout_page_pic;
        private System.Windows.Forms.PictureBox Laboratory_page_pic;
        private System.Windows.Forms.PictureBox Patients_page_pic;
        private System.Windows.Forms.Label Logout_page;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Patients_page;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.TextBox Laboratory_ID;
        private System.Windows.Forms.Label label3;
    }
}