# WPF Register Student - Course Registration System
## About the Project
WPF Register Student is a simple desktop application developed using C# and WPF (Windows Presentation Foundation) for managing course registration. This project allows users to register for courses, view the courses they have registered for, and ensure they do not exceed a maximum of 9 credit hours.
## Features
- **Course Registration:** Users can select from a list of available courses.
- **Credit Hour Tracking:** Ensures that a user can only register for a maximum of 9 credit hours.
- **Error Handling:** Displays error messages if a user tries to register for a course they are already registered for or exceed the maximum credit hour limit (9).
- **Confirmation Messages:** Displays success messages when a course is successfully registered.
- **View Registered Courses:** Once a course is successfully registered, it will be added to the list below the registration button, and the total credit hours will be updated.
## Files in the Project
- **MainWindow.xaml.cs:** Handles the interaction logic for the main window, including course registration, error handling, and credit hour management.
- **Course.cs:** Contains the `Course` class used to represent a course, its name, and its registration status.
- **App.xaml.cs:** Contains application-level logic (provided as part of the assignment).
## Installation Instructions
1. **Clone the Repository in Git Bash:**  
`git clone https://github.com/Zacarette/WPF-Register-Student.git`  
`cd WPF-Register-Student`  
2. **Open the Solution in Visual Studio:**
- Open the solution file (`WPFRegisterStudent.sln`) in Visual Studio.
- Build and run the project using Visual Studio.
## Usage
1. **Run the Application:** Once the application is launched, you will see a dropdown (ComboBox) containing a list of available courses.
2. **Select a Course:** Choose a course from the dropdown list.
3. **Register for a Course:** Click the 'Register' button to add the selected course to your registration list. If you try to register for a course you've already chosen or exceed the maximum credit hours, an error message will appear.
## Version Used
- Microsoft Visual Studio Community 2022, Version 17.13.0
- .NET Framework 4.8.09037
## Author
Michael Zaccaria
