# 🎓 Class Registration System (WinForms)

A robust desktop application designed for streamlined academic class management. Built with **C# .NET** and **SQL Server**, this application demonstrates efficient CRUD operations, dynamic UI rendering, and local database integration.

---

## 🌟 Key Features

- **Dynamic Class Browsing:** View available classes filtered by month with an intuitive UI.
- **Automated Registration:** Seamlessly register for courses with real-time data persistence.
- **Enrollment Tracking:** Dedicated view for users to manage and monitor their registered classes.
- **Dynamic Asset Loading:** Efficiently handles and displays class posters from local storage using relative path mapping.
- **Robust Database Helper:** Centralized `DBHelper.cs` class for clean, reusable, and secure SQL operations.

---

## 📂 Project Structure

```bash
class_registration_app/
├─ DB/                      # SQL schema and initial data scripts
├─ Forms/                   # Application UI Layer (WinForms)
│  ├─ HomeForm              # Main dashboard & class listing
│  ├─ ClassDetailForm       # Course information view
│  ├─ RegisterForm          # Enrollment interface
│  └─ ViewRegisteredForm    # User registration summary
├─ class_poster/            # Dynamic image assets for class thumbnails
├─ DBHelper.cs              # Core Data Access Object (DAO) for SQL operations
├─ ClassRegistrationDB.mdf  # Portable SQL Server LocalDB
└─ App.config               # Configuration and connection strings

```

---

## 🛠️ Requirements & Environment

* **IDE:** Visual Studio 2019 or later
* **Framework:** .NET Framework 4.7.2
* **Database:** SQL Server Express LocalDB
* **Dependencies:** `System.Data.SqlClient` (NuGet package)

---

## 🚀 Getting Started

1. **Clone the repository:**
```bash
git clone https://github.com/savant777/homework-for-new-dev.git

```


2. **Open Solution:** Launch `ClassRegistrationApp.sln` in Visual Studio.
3. **Restore Packages:** Ensure NuGet packages are restored (`System.Data.SqlClient`).
4. **Build & Run:** Press `F5` to start the application.

*Note: The application utilizes a portable connection string. The `.mdf` database will be automatically attached upon execution.*

---

## ℹ️ Technical Implementation Notes

* **Data Persistence:** Uses **SQL Server LocalDB** for a lightweight yet powerful database experience without requiring a full SQL Server instance.
* **Portability:** Designed with **Relative Path Management**. Both the database file and image assets (`class_poster/`) are referenced relative to the executable path, ensuring the project works out-of-the-box upon cloning.
* **Clean Code:** Separated UI logic from Data Access logic via the `DBHelper` class to ensure maintainability.

---

## 📜 License

MIT License
