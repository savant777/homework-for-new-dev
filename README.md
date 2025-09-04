# Homework for New Dev

This repository contains the **assignment test** consisting of **3 exercises**.  
Each exercise is organized into its own folder with instructions and implementation details.  

---

## 📂 Project Structure

```

homework-for-new-dev/
├── class\_registration\_app/    # Exercise 1: WinForms + SQL
├── line\_oa\_api/               # Exercise 2: Line OA API
└── responsive\_html/            # Exercise 3: Responsive HTML

````

---

## 📝 Exercises

### 1. WinForms + SQL
- **Path**: `./class_registration_app/`
- **Status**: ✅ Completed
- **Description**: Desktop application built with **C# WinForms** and **SQL Server LocalDB**.  
  - Allows viewing classes, registering for classes, and managing registrations.  
  - Uses a local `.mdf` database file (`ClassRegistrationDB.mdf`) stored within the project.  
  - Posters for classes are stored in `class_poster/` and loaded dynamically.
- **Origin Note**:  
  This project was originally intended to be implemented using **Power App + SharePoint**
  Due to limitations and incompatibility with the assignment requirements, it was re-implemented as a WinForms desktop application with a local SQL database to better demonstrate CRUD operations and data management.
- **Setup**:
  1. Clone the repository.  
  2. Open `ClassRegistrationApp.sln` in Visual Studio 2019/2022.  
  3. Restore NuGet packages (via `packages.config`) if prompted.  
  4. Build and run the project.  
- **Notes**:
  - Database file path is set relative to the executable (`ClassRegistrationDB.mdf`) for portability.  
  - Ensure LocalDB is installed on your system.

---

### 2. Line OA API
- **Path**: `./line_oa_api/`
- **Status**: ✅ Completed
- **Tech stack**: Node.js, Express  
- **Setup**:
  1. Copy `.env.example` and create your own `.env` file with the required environment variables.
  2. Install dependencies:  
     ```bash
     npm install
     ```
  3. Start the server:  
     ```bash
     node littleChat.js
     ```
- **Notes**:
  - The project includes `.gitignore` and environment variable management.  
  - API endpoints and sample usage are described in the folder’s own `README.md`.

---

### 3. Responsive HTML
- **Path**: `./responsive_html/`
- **Status**: ✅ Completed
- **Description**: Static HTML + CSS page built according to the provided design brief. The layout is fully responsive.  
- **How to view**:
  - Open `index.html` directly in the browser, or  
  - Visit the deployed version here: [**Deploy Link**](https://savant777.github.io/homework-for-new-dev/responsive_html/)

---

## 🚀 How to Use
1. Clone the repository:  
   ```bash
   git clone https://github.com/savant777/homework-for-new-dev.git
   ```

2. Navigate into each exercise folder to find detailed instructions (`README.md` files).

---

## ℹ️ Notes

* This repository was created as part of the technical test for the interview process.
* Each folder is self-contained and includes details for setup, usage, or deployment.
