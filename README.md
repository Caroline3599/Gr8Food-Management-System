# Gr8Food Management System 🍔

> **APU Level 1 Group Assignment - Introduction to Object-Oriented Programming (IOOP)**  
> **Module Code:** CT044-3-1-IOOP-L-4  
> **Intake Code:** APU/D1F2509CS(AI)  

---

## 📘 Project Overview

**Gr8Food Management System** is a modern desktop restaurant management application integrated with an MS-SQL database[cite: 2, 3]. It is designed to streamline restaurant operations by providing dedicated interfaces for four user roles: **System Admin**, **Manager**, **Chef**, and **Customer**[cite: 1]. 

The system is built using **C#** and Windows Forms, applying robust **Object-Oriented Programming (OOP)** principles such as classes, methods, inheritance encapsulation, and centralized database management via `DBHelper`[cite: 2, 3, 35].

---

## 👥 Team Members & Contribution

| Name | TP Number | Role / Main Contributions |
| :--- | :--- | :--- |
| **Darren Matthew Tanoyo** | TP086059 | Admin role page design, system integration, bug fixing, and Manager class diagram[cite: 58]. |
| **Duan Yuqing** *(You)* | TP114820 | Manager pages design & coding, database creation & queries, use-case diagram, and Profile update form[cite: 7, 58]. |
| **Farah Zakiya** | TP092149 | Customer pages development, login pages, and report conclusion. |
| **Omar Ahmed Ramy** | TP078735 | Chef pages design & coding, system testing & test plan validation, and Chef class diagram. |

---

## 🔑 Key Features & User Roles

1. **System Admin**[cite: 1]
   - Add, update, and remove user accounts across all roles[cite: 1].
   - View detailed user tables and filter comprehensive sales reports by month/year, category, and chef[cite: 1, 16].
2. **Manager**[cite: 1]
   - View and respond to customer feedback[cite: 1].
   - Monitor e-wallet top-up and usage reports, filterable by customer and date[cite: 1, 24].
3. **Chef**[cite: 2]
   - Manage menu details (add, edit, delete items, update pricing and stock quantity)[cite: 2, 26, 27].
   - Track customer orders and update their statuses ("In Progress" or "Completed")[cite: 2, 28].
4. **Customer**[cite: 2]
   - Top-up e-wallet balance and browse menu items by category[cite: 2].
   - Place food orders with automatic e-wallet deduction, view order history, and cancel orders for automatic refunds[cite: 2, 20].
   - Submit feedback for completed orders[cite: 2].

---

## 📊 System Architecture & Class Design

- **Centralized Database Connection (`DBHelper`):** Handles connection strings securely through `App.config` and provides a reusable `GetConnection()` method[cite: 35, 42].
- **UML Class Diagram:** Each database table (Admin, Chef, Customer, Manager, Menu, Order, OrderDetails, Feedback) is mapped to a dedicated C# class containing constructors and data-handling methods[cite: 32, 40].

---

## 📺 Demo Video & Database

- **Demo Video:** [点击这里查看项目演示视频链接] *(请在此处替换或补充您的飞书/云盘/YouTube 演示视频链接)*
- **Database File / Script:** 项目数据库基于 Microsoft SQL Server (`Gr8FoodDB`)。相关的 `.mdf` 文件或 SQL 备份脚本已存放在仓库的 `Database/` 目录下，您可以直接附加到本地 SQL Server 中运行。

---

## 🛠️ Getting Started

1. **Prerequisites:**
   - Visual Studio (with .NET desktop development workload)[cite: 2]
   - Microsoft SQL Server / SQL Server Management Studio (SSMS)[cite: 2]
2. **Setup Database:**
   - Restore or attach the `Gr8FoodDB` database provided in the repository.
   - Update the connection string in `App.config` to match your local server instance.
3. **Run the Application:**
   - Open `Gr8Food.sln` in Visual Studio[cite: 2].
   - Build and run the solution (`F5`).
