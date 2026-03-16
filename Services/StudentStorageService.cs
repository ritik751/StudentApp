using Newtonsoft.Json;
using StudentApp.Models;
using System.Collections.Generic;
using System.IO;

namespace StudentApp.Services
{
    public class StudentStorageService
    {
        private readonly string filePath = "students.json";

        public List<Student> LoadStudents()
        {
            if (!File.Exists(filePath))
                return new List<Student>();

            string json = File.ReadAllText(filePath);

            return JsonConvert.DeserializeObject<List<Student>>(json);
        }

        public void SaveStudents(List<Student> students)
        {
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);

            File.WriteAllText(filePath, json);
        }
    }
}