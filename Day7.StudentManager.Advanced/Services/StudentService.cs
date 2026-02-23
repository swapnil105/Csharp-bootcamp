using Day7.StudentManager.Advanced.Models;
using Day7.StudentManager.Advanced.Storage;

namespace Day7.StudentManager.Advanced.Services
{
    public class StudentService
    {
        private readonly FileStorage _storage;
        private List<Student> _students;
        private int _idCounter;

        public StudentService()
        {
            _storage = new FileStorage();
            _students = _storage.Load();
            _idCounter = _students.Count + 1;
        }

        public void Add(string name)
        {
            _students.Add(new Student
            {
                Id = _idCounter++,
                Name = name
            });

            _storage.Save(_students);
        }

        public List<Student> GetAll() => _students;



        public bool Add(String name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (name.Length < 2)
                return false;
            _students.Add(new Student
            {
                Id = _idCounter++,
                Name = name.Trim()
            });
            _storage.Save(_students);
            return true;
        }
        public bool Delete(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            _students.Remove(student);
            ReassignIds();
            _storage.Save(_students);
            return true;
        }

        public bool Update(int id, string newName)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            if (string.IsNullOrWhiteSpace(newName))
                return false;

                student.Name = newName.Trim();
                _storage.Save(_students);
                return true;

            student.Name = newName;
            _storage.Save(_students);
            return true;

            if (id <= 0 ) return false;
        }

        public List<Student> Search(string term)
        {
            return _students
                .Where(s => s.Name.Contains(term, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void SortByName(bool desc = false)
        {
            _students = desc
                ? _students.OrderByDescending(s => s.Name).ToList()
                : _students.OrderBy(s => s.Name).ToList();

            ReassignIds();
            _storage.Save(_students);
        }

        private void ReassignIds()
        {
            for (int i = 0; i < _students.Count; i++)
                _students[i].Id = i + 1;

            _idCounter = _students.Count + 1;
        }
    }
}