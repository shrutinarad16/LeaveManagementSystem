<h1 align="center">🛠️ Workflow-Driven Leave Management System</h1>
<p align="center">
  🚀 Built using ASP.NET MVC (.NET Framework 4.8), SQL Server, Bootstrap, DataTables & SMTP  
</p>

---

## 📌 Overview

This project is a **multi-role Leave Management System** built to streamline and automate the employee leave application and approval workflow. It ensures secure access, real-time notifications, and visual dashboards — making it an ideal HR tech solution for organizations.

✅ **Tech Stack**  
ASP.NET MVC • C# • SQL Server • SMTP • Bootstrap 4 • DataTables

---

## 🎯 Key Features

- 🔐 **Secure Login** for Employees, Managers, and HR
- 🔄 **Custom Workflow Engine**:  
  `Draft → Manager → HR Finalized → Rejected → Resubmission`
- 📧 **Email Notifications** via SMTP for real-time alerts
- 📊 **Dynamic Dashboards** with DataTables and status-based filtering
- 📁 **Role-Based Views**: Employees apply, Managers/HR approve or reject
- 📈 **Analytics Ready**: Leave trends and status breakdowns

---

## 💡 Modules

| Module        | Description                                   |
|---------------|-----------------------------------------------|
| 👨‍💼 Account    | Login, Role-based access, Session mgmt         |
| 📝 Apply Leave | Leave form with From-To dates, reasons        |
| 📄 My Leaves   | View personal leave history with status       |
| ✅ Approvals   | Manager/HR leave queue with action buttons    |
| 📬 Email       | SMTP alerts on approval/rejection/resubmission|
| 📊 Dashboard   | DataTables with search/sort/filter capabilities|

---

## 🧠 Workflow Logic

```plaintext
Employee Applies (Draft) ➝ Manager Reviews (Manager) ➝ HR Finalizes (HR Finalized)
             ⬇
         Rejected ⬅──── Resubmission Available
```
---

## 🏗️ Tech Used
ASP.NET MVC 5 (C#, .NET Framework 4.8)

Entity Framework 6 (Code First)

SQL Server 2019

Bootstrap 4

DataTables jQuery Plugin

SMTP (System.Net.Mail)

-----
## ⚙️ Setup Instructions
1. Clone the Repository
```bash
git clone https://github.com/yourusername/LeaveManagementSystem.git
```


2. Database Setup
```
   Open SQL Server → Create DB named LeaveDB

   Run TableScripts.sql from /DBScripts
```

4. Update Web.config
   ```xml
   <connectionStrings>
  <add name="DefaultConnection" connectionString="Data Source=.;Initial Catalog=LeaveDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
```


4. Install NuGet Dependencies
```
     EntityFramework 6

     DataTables (CDN or Scripts folder)
```

5. 
  Default login credentials:
```
     Employee: employee1 / pass123

     Manager: manager1 / pass123

     HR: hr1 / pass123
```
---

## 📬 SMTP Email Configuration

```xml
<system.net>
  <mailSettings>
    <smtp from="admin@yourdomain.com">
      <network host="smtp.yourserver.com" port="587" userName="your_email" password="your_password" enableSsl="true" />
    </smtp>
  </mailSettings>
</system.net>
```

## 🧑‍💻 About Me
🙋‍♀️ Hi, I’m Shruti Narad – a passionate CSE student, writer & developer.

🌱 Exploring .NET, Java, Frontend & DevOps

💌 Connect with me:

🚀 **Author**: Shruti Narad  
📧 **Email**: shrutinarad06@gmail.com  
🌐 **LinkedIn**: [linkedin.com/in/shrutinarad16](https://linkedin.com/in/shrutinarad16)  
📍 **Location**: Noida, Uttar Pradesh, India  

## 🎯 HR Note
Dear Hiring Manager/HR,

This project reflects my ability to:

Write scalable MVC code using real-world workflows

Integrate database, UI, and SMTP seamlessly

Build secure, enterprise-ready applications

Take ownership from planning → coding → deployment

📢 I am actively looking for roles as a .NET Developer / Software Engineer (Java/.NET).
Let's build something amazing together!
