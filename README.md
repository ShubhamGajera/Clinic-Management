
# 🏥 Clinic360 – Smart Clinic Management System (Windows Forms)

![Made with C#](https://img.shields.io/badge/Made%20with-C%23-blue?logo=csharp)
![Desktop App](https://img.shields.io/badge/Platform-Windows-lightgrey?logo=windows)
![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)

**Clinic360** is a comprehensive and modern **Clinic Management System** built using **C# and Windows Forms (.NET Framework)**. It provides an efficient solution to manage patients, doctors, appointments, and billing records with a user-friendly interface, ideal for small to mid-sized clinics.

---

## ✨ Features

- 🔐 Secure Login System (Admin/Receptionist)
- 👨‍⚕️ Doctor Management (Add, Update, Delete)
- 🧑‍🤝‍🧑 Patient Management (Add, Update, Delete)
- 📅 Appointment Booking & Viewing
- 🧾 Bill Generation & Record Maintenance
- 📊 Dashboard with Real-Time Data
- 🔍 Search & Filter Functionality
- 💻 Modern & Clean UI

---


> ✅ Inspired by this YouTube base project with UI enhancements:  
[Watch on YouTube](https://www.youtube.com/watch?v=wPUBtU15nVI)

---

## 📦 Tech Stack

| Technology                  | Purpose                                  |
|-----------------------------|------------------------------------------|
| **C# (.NET Framework)**     | Core application logic                   |
| **Windows Forms (WinForms)**| Desktop UI framework                     |
| **SQL Server / MS Access**  | Relational Database                      |
| **ADO.NET / OleDB**         | Database connectivity                    |
| **Visual Studio 2019+**     | Development IDE                          |
| **Custom Icons & UI Assets**| Improved visual appearance               |

---

## 🔧 Setup Instructions

### 1️⃣ Prerequisites

- Visual Studio 2019 or later
- .NET Framework (4.6.1+)
- SQL Server or MS Access installed

### 2️⃣ Clone the Repository

```bash
git clone https://github.com/your-username/Clinic360.git
cd Clinic360
````

### 3️⃣ Open in Visual Studio

* Open the `.sln` file in Visual Studio.
* Restore any missing NuGet packages (if needed).
* Set the main form (e.g., `LoginForm.cs`) as the startup form.

### 4️⃣ Configure the Database


* Use the provided `clinik.dacpac` file to deploy the database:

  1. Open **SQL Server Management Studio (SSMS)**.
  2. Right-click on **Databases** → choose **Deploy Data-tier Application**.
  3. Browse and select the `clinik.dacpac` file.
  4. Complete the wizard to deploy it as a new database.
  5. Update the connection string in `App.config` with your SQL Server instance and database name.

### 5️⃣ Run the App

* Press `F5` to build and run the project.

---
## 🗃️ Database

A prebuilt database is included as a `.dacpac` file:

* 📁 `clinik.dacpac` – SQL Server data-tier application file in DATABASE Folder
* Use this file to deploy the database quickly without creating tables manually.
---

## 🔐 Auth & Roles

* **Admin Role**: Full access to all features
* **Receptionist/User Role**: Limited to appointments & patient management
* Simple role-based UI control for functionality access

---
