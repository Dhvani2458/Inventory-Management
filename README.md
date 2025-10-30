# 🏷️ Inventory Management System (ASP.NET Core MVC)

## 📘 Project Title
**Inventory Management System**

---

## 📖 Description
The **Inventory Management System** is a full-featured web application built using **ASP.NET Core MVC** that helps organizations manage their stock, products, suppliers, and orders in one centralized platform.

It eliminates the hassle of manual record-keeping and makes inventory management faster, smarter, and more accurate.  
The app is designed for small to medium-sized businesses looking to digitize their stock and order processes.

### 🎯 Key Objectives:
- Streamline the process of **tracking stock levels**
- Automate **order management**
- Maintain accurate **supplier and product data**
- Generate **inventory and order reports**
- Provide a **user-friendly interface** for quick operations

---

## 💻 Features

| Module | Description |
|:-------|:-------------|
| **Product Management** | Add, edit, view, or delete product details (name, SKU, quantity, price, supplier). |
| **Supplier Management** | Manage supplier information including contact and email. |
| **Order Management** | Create new orders, update status, view order details, and manage items. |
| **Inventory Tracking** | Track real-time stock levels and restocking needs. |
| **Reports** | View total stock, low-stock alerts, and sales summaries. |
| **Responsive UI** | Clean and mobile-friendly interface built using Bootstrap. |

---

## ⚙️ Installation Steps

### Prerequisites
Make sure you have the following installed:
- [.NET SDK 9.0 or higher](https://dotnet.microsoft.com/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- Optional: [SQLite](https://www.sqlite.org/) or [MySQL](https://www.mysql.com/) for database

---

### 🪜 Step 1: Clone the Repository
- bash:
- git clone https://github.com/yourusername/InventoryManagementSystem.git

### 🪜 Step 2: Navigate into the Project Folder
- cd InventoryManagementSystem

### 🪜 Step 3: Restore Dependencies
- dotnet restore

### 🪜 Step 4: Build the Project
- dotnet build

### 🪜 Step 5: Apply Database Migrations (if using EF Core)
dotnet ef database update

---

### 🚀 How to Run the Project
- Using Command Line
Run the project:
  - dotnet run

- Then open your browser and visit:
   - http://localhost:5000
or
   - https://localhost:5001

---

### 📊 Sample Features Preview
🧾 Product List
  - Displays all products with stock level, SKU, and supplier details.
  - Buttons for edit, delete, and add new product.

📦 Order Dashboard
  - Lists all orders with customer name, order date, and total.
  - Option to view full details of order items.

📈 Reports Section
  - Displays current stock summary and reorder alerts.

🧠 Future Enhancements
  - Add authentication and role-based access (admin, manager, staff).
  - Implement email notifications for low-stock alerts.
  - Add chart-based analytics dashboard.
  - Integrate barcode/QR scanning for quick product entry.

📄 License
  - This project is open-source and free to use for educational and personal purposes.

--- 

### 🧭 Conclusion
 - The 360 Inventory Management System is a practical, educational project built with ASP.NET Core MVC, Entity Framework, and Razor Views.
 - It demonstrates strong understanding of backend integration, UI flow, and CRUD functionality.
 - This foundation can be easily extended with advanced features like authentication, analytics, and real-time notifications for professional-grade inventory management.
