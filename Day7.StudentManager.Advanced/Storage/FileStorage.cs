using System.Text.Json;
using Day7.StudentManager.Advanced.Models;

namespace Day7.StudentManager.Advanced.Storage
{
    public class FileStorage
    {
        private readonly string _filePath = "students.json";

        public List<Student> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Student>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }

        public void Save(List<Student> students)
        {
            var json = JsonSerializer.Serialize(students, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_filePath, json);
        }
    }
}