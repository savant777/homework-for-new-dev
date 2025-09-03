# Class Registration App

A simple WinForms application for managing class registrations. Users can view classes by month, register for classes, and see already registered classes.

---

## Project Structure

```

class\_registration\_app
│
├─ DB                                  # SQL scripts and database setup files
│   └─ ClassRegistrationDB.sql         # Initial SQL script to create the Classes table
│
├─ Forms                               # All WinForms for the application
│   ├─ ClassDetailForm.cs              # Form to view class details
│   ├─ ClassDetailForm.Designer.cs
│   ├─ ClassDetailForm.resx
│   ├─ HomeForm.cs                     # Main form listing classes
│   ├─ HomeForm.Designer.cs
│   ├─ HomeForm.resx
│   ├─ RegisterForm.cs                 # Form to register for a class
│   ├─ RegisterForm.Designer.cs
│   ├─ RegisterForm.resx
│   ├─ ViewRegisteredForm.cs           # Form to view registered classes
│   ├─ ViewRegisteredForm.Designer.cs
│   └─ ViewRegisteredForm.resx
│
├─ Properties                          # Project resources and settings
│   ├─ AssemblyInfo.cs
│   ├─ Resources.Designer.cs
│   ├─ Resources.resx
│   ├─ Settings.Designer.cs
│   └─ Settings.settings
│
├─ class\_poster                       # Images used for class posters
│   ├── poster-001.png
│   ├── poster-002.png
│   └── ... (poster-003.png to poster-020.png)
│
├─ .gitignore                          # Git ignore rules
├─ App.config                          # Application configuration
├─ ClassRegistrationApp.csproj         # Visual Studio project file
├─ ClassRegistrationApp.sln            # Visual Studio solution file
├─ ClassRegistrationDB.mdf             # Local database file
├─ DBHelper.cs                         # Database helper class for SQL operations
├─ Program.cs                          # Main program entry point
└─ packages.config                     # NuGet package references used by the project

````

---

## Requirements

- Visual Studio 2019 or later
- .NET Framework 4.7.2
- SQL Server Express LocalDB
- `System.Data.SqlClient` NuGet package

---

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/savant777/homework-for-new-dev.git
````

2. Open `ClassRegistrationApp.sln` in Visual Studio.

3. Build the solution (`Ctrl + Shift + B`).

4. Run the app (`F5` or Start Debugging).

5. The app will automatically attach the local database `ClassRegistrationDB.mdf` and load class posters from the `class_poster` folder.

---

## Database

* The database file `ClassRegistrationDB.mdf` is located in the root folder of the project.
* SQL scripts for creating tables can be found in `DB/ClassRegistrationDB.sql`.
* DBHelper.cs handles all database operations.

---

## Notes

* Ensure that `ClassRegistrationDB.mdf` and `class_poster` are **not moved**; they are referenced using relative paths.
* All poster images are stored in `class_poster`.
* This project uses **relative paths** for database and images, so it should work immediately after cloning.

---

## License

MIT License
