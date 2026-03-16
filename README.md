# Student Management WPF Application

## Overview

This is a **WPF MVVM-based Student Management Application** built using **C# and .NET**.
The application allows users to **view, add, and edit student details**, including uploading a student photo. All student data is stored locally in a **JSON file**, so the application works without any external database.

---

# Features

| Feature              | Description                                        |
| -------------------- | -------------------------------------------------- |
| View Students        | Displays all students in a DataGrid                |
| Add Student          | Allows users to add a new student                  |
| Edit Student         | Modify existing student details                    |
| Upload Student Photo | Select `.png` or `.jpg` images                     |
| Age Control          | Custom control with minimum and maximum age limits |
| Stream Highlighting  | Stream column color-coded                          |
| Local Data Storage   | Students stored in `students.json`                 |
| MVVM Architecture    | Clean separation of UI, logic, and data            |

---

# Technologies Used

| Technology      | Purpose                   |
| --------------- | ------------------------- |
| C#              | Application logic         |
| WPF             | Desktop UI framework      |
| MVVM Pattern    | Maintainable architecture |
| Newtonsoft.Json | Local JSON storage        |
| XAML            | UI design                 |

---

# Project Structure

```
StudentApp
│
├── Models
│     └── Student.cs
│
├── ViewModels
│     ├── MainViewModel.cs
│     └── EditStudentViewModel.cs
│
├── Views
│     ├── MainWindow.xaml
│     └── EditStudentWindow.xaml
│
├── Controls
│     └── AgeControl.xaml
│
├── Services
│     └── StudentStorageService.cs
│
├── Images
│
└── students.json
```

---

# How to Run the Application

### 1️⃣ Prerequisites

Make sure you have the following installed:

* **Visual Studio 2022 or later**
* **.NET Desktop Development workload**
* **.NET 6 or later**

---

### 2️⃣ Open the Project

1. Download or clone the project.
2. Open **StudentApp.sln** in **Visual Studio**.

---

### 3️⃣ Install Required Package

Open **Package Manager Console** and run:

```
Install-Package Newtonsoft.Json
```

---

### 4️⃣ Run the Application

Press:

```
F5
```

or click **Start Debugging**.

---

# Using the Application

## Viewing Students

When the application starts, all students stored in **students.json** are loaded and displayed in the table.

---

## Adding a New Student

1. Click **Add Student**.
2. A popup window will appear.
3. Enter the following details:

   * Name
   * Age
   * Stream
   * Date of Joining
   * Due Fee
   * Total Fee
4. Click **Browse Image** to select a student photo.
5. Click **Update** to save the student.

The student will be:

* Added to the DataGrid
* Stored in `students.json`

---

## Editing a Student

1. Click the **Edit (✎) icon** in the table.
2. Modify the student details.
3. Click **Update**.

Changes will be saved automatically.

---

# Student Image Upload

Supported formats:

```
.png
.jpg
```

After selecting an image:

* It appears immediately in the popup.
* The image path is saved in `students.json`.

---

# Local Data Storage

All student data is stored in:

```
students.json
```

Example:

```json
[
  {
    "Name": "Ritik",
    "Age": 25,
    "Stream": 2,
    "DateOfJoining": "2024-01-10T00:00:00",
    "DueFee": 200,
    "TotalFee": 5000,
    "Image": "C:\\Images\\student1.jpg"
  }
]
```

---

# Key Design Concepts

| Concept                | Description                     |
| ---------------------- | ------------------------------- |
| MVVM                   | Separates UI and business logic |
| ObservableCollection   | Automatically updates UI        |
| INotifyPropertyChanged | Enables real-time UI updates    |
| Commands               | Replaces button click events    |
| Value Converters       | Used for stream color logic     |

---

# Future Improvements

Possible enhancements:

* Use **SQLite database instead of JSON**
* Add **image storage inside application folder**
* Implement **form validation**
* Add **search and filtering**
* Add **delete student functionality**

---

# Author

Developed using **C# and WPF MVVM architecture** as part of a **desktop application assignment**.

---
