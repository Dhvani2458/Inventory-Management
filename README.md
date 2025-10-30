## 🏢 360 Inventory Management System

A **.NET Core MVC web application** designed to efficiently manage inventory, employees, and product tracking in a business environment.  
This system provides modules for managing employees, leave requests, leave types, and other administrative operations with a simple, user-friendly interface.

---

## 📋 Project Description

The **360 Inventory Management System** helps organizations streamline their inventory and employee leave management processes.  
It allows administrators to manage products, track quantities, handle employee data, define leave types, and process leave requests — all in one central dashboard.

**Key Features:**
- 👩‍💼 Employee Management (Add, Edit, Delete)
- 📦 Inventory / Leave Type Management
- 🗓️ Leave Request and Approval
- 📊 Dashboard for quick overview
- 💾 Database integration (MySQL or SQL Server)
- 🎨 Clean and responsive UI (Bootstrap-based)

---

## ⚙️ Technologies Used

- **ASP.NET Core MVC (v9.0)**  
- **Entity Framework Core**  
- **C#**  
- **MySQL / XAMPP** for database  
- **Bootstrap 5** for UI  
- **Localhost** for hosting  

---

## 🚀 Installation Steps

Follow these steps to set up the project locally:

1. Clone the Repository
   - git clone https://github.com/<your-username>/360_InventoryApp.git
   - cd 360_InventoryApp

2. Install .NET SDK
-Download and install the latest .NET SDK from:
   - https://dotnet.microsoft.com/download
     
-Verify installation:
bash:
dotnet --version

3. Set Up Database (MySQL via XAMPP)
- Open XAMPP Control Panel → Start Apache and MySQL
- Open phpMyAdmin → Create a new database (example: inventorydb)
- Update the connection string in appsettings.json:
json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=inventorydb;user=root;password=;"
}

4. Install Entity Framework Core Tools
dotnet tool install --global dotnet-ef

5. Apply Database Migration
dotnet ef database update

6. Build the Project
dotnet build

7. Run the Project
dotnet run
