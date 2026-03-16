using StudentApp.Commands;
using StudentApp.Models;
using StudentApp.Services;
using StudentApp.Views;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace StudentApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private StudentStorageService storage;

        public ObservableCollection<Student> Students { get; set; }

        public ICommand EditCommand { get; }

        public ICommand AddStudentCommand { get; }

        public MainViewModel()
        {
            storage = new StudentStorageService();

            Students = new ObservableCollection<Student>(storage.LoadStudents());

            EditCommand = new RelayCommand(EditStudent);

            AddStudentCommand = new RelayCommand(AddStudent);
        }

        private void AddStudent(object obj)
        {
            Student newStudent = new Student()
            {
                Name = "",
                Age = 18,
                Stream = StreamType.Arts,
                DateOfJoining = System.DateTime.Now,
                DueFee = 0,
                TotalFee = 0,
                Image = "/Images/user1.png"
            };

            EditStudentWindow window = new EditStudentWindow();

            window.DataContext = new EditStudentViewModel(newStudent);

            if (window.ShowDialog() == true)
            {
                Students.Add(newStudent);

                storage.SaveStudents(Students.ToList());
            }
        }

        private void EditStudent(object obj)
        {
            Student student = obj as Student;

            EditStudentWindow window = new EditStudentWindow();

            window.DataContext = new EditStudentViewModel(student);

            if (window.ShowDialog() == true)
            {
                storage.SaveStudents(Students.ToList());
            }
        }
    }
}