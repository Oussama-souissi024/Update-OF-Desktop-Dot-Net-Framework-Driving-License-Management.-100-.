# 🚗 Driving License Management System (DVLD)

## 📝 Overview

This repository contains a **.NET Framework Windows Forms** application that manages the full lifecycle of driving-licence–related operations for a Department of Vehicles & Licensing Division (DVLD).  
The system provides a modern, multi-tier architecture with **Presentation**, **Business**, and **Data-Access** layers, backed by a SQL Server database (`DVLD.bak`).

Key modules include:

| Module | Purpose |
|--------|---------|
| **People** | Central registry of citizens and personal data |
| **Drivers** | Generates driver profiles once a licence is issued |
| **Applications** | Handles all licence application types (new, renew, replace lost/damaged, international, etc.) |
| **Tests** | Manages written, practical & vision tests, including retakes |
| **Licences** | Issues, detains, renews, and releases driving licences |
| **User & Login** | Role-based authentication and authorisation |
| **Global / Utilities** | Common helpers, settings, and shared enumerations |

<p align="center">
  <img src="screen%20print/MainScreen.png" width="640" alt="Main menu"/>
</p>

---

## ✨ Main Features

- **Multi-layered architecture** (UI → Business → Data) promoting separation of concerns
- **SQL Server** backend with stored procedures & views (backup provided in `DVLD.bak` and `Full DB.rar`)
- **Comprehensive entity management**: people, users, drivers, applications, test types, licence types
- **Licence lifecycle**: issuance, renewal, detaining, releasing, replacement for lost/damaged licences
- **International licence support** with dedicated application flow
- **Role-based security** and password change workflow
- **Printable reports** & exportable lists (drivers, applications, detained licences …)

---

## 🗂️ Project Structure (high level)

```
Update-OF-Desktop-Dot-Net-Framework-Driving-License-Management.-100-.-main
│
├── Applications/               # WinForms for licence application workflows
├── Drivers/                    # Forms & logic related to drivers
├── People/                     # Person registry management
├── Licences/                   # Licence issuance / renewal / detention
├── Login/                      # Authentication screens
├── User/                       # User & role management
│
├── DVLDBusinessLayer/          # Business-logic classes
├── DVLDDataAccessLayer/        # Database CRUD helpers & stored-procedure wrappers
├── Golobal Classes/            # Shared utilities (permissions, helpers, enums…)
│
├── Resources/                  # Images & icons
├── Tests/                      # Unit / integration tests
│
├── Full C# DVLD Project.sln    # Visual Studio Solution (open this!)
└── DVLD.bak                    # SQL Server database backup
```

---

## 🛠  Requirements

- **Windows 10/11**
- **Visual Studio 2019 (or newer)** with **.NET Desktop Development** workload
- **.NET Framework 4.7.2** (change in project properties if you prefer a newer 4.x)
- **SQL Server 2017/2019/Express** to restore the `DVLD` database

---

## 🚀 Getting Started

1. **Clone** this repository or download the zip.
2. **Restore the database**:  
   • Launch *SQL Server Management Studio* → *Restore Database* → select `DVLD.bak`.  
   • Alternatively, extract `Full DB.rar` and restore from the MDF/LDF pair.
3. **Update the connection string** (if needed) in `App.config` → `DVLDConnectionString` to match your SQL Server instance.
4. **Open** `Full C# DVLD Project.sln` in Visual Studio.
5. **Build → Run** (F5).  
   Default credentials can be created directly in the `Users` table or via the Login module.

---

## 🤝 Contributing

Contributions, bug reports and feature requests are welcome!

1. Fork the repo
2. Create your branch: `git checkout -b feature/amazing-feature`
3. Commit your changes: `git commit -m "feat: add amazing feature"`
4. Push to the branch: `git push origin feature/amazing-feature`
5. Open a Pull Request

---

## 📜 License

This project is released under an **open-source license** (see `LICENSE` if available). Feel free to use it for educational or commercial purposes with attribution.

---

## 👤 Author

**Oussama Souissi** – [GitHub](https://github.com/Oussama-souissi024)

> *Driving Licence Management System – Complete Desktop Solution in C# / .NET Framework*
