using Microsoft.Win32;
using StudentApp.Commands;
using StudentApp.Models;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace StudentApp.ViewModels
{
    public class EditStudentViewModel : BaseViewModel
    {
        public Student Student { get; set; }

        public List<StreamType> Streams { get; }

        public ICommand UpdateCommand { get; }

        public ICommand CloseCommand { get; }

        public ICommand BrowseImageCommand { get; }

        public EditStudentViewModel(Student student)
        {
            Student = student;

            Streams = new List<StreamType>()
            {
                StreamType.Arts,
                StreamType.Commerce,
                StreamType.Science
            };

            UpdateCommand = new RelayCommand(Update);

            CloseCommand = new RelayCommand(Close);

            BrowseImageCommand = new RelayCommand(BrowseImage);
        }

        private void BrowseImage(object obj)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";

            if (dialog.ShowDialog() == true)
            {
                Student.Image = dialog.FileName;

                OnPropertyChanged(nameof(Student));
            }
        }

        private void Update(object obj)
        {
            if (obj is Window window)
            {
                window.DialogResult = true;
                window.Close();
            }
        }

        private void Close(object obj)
        {
            if (obj is Window window)
            {
                window.Close();
            }
        }
    }
}