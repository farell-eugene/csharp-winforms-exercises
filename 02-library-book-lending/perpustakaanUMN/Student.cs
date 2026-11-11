using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perpustakaanUMN
{
    internal class Student
    {
        public string Nim { get; set; }
        public string Name { get; set; }
        public string BookTitle { get; set; }

        public Student(string nim, string name, string bookTitle)
        {
            Nim = nim;
            Name = name;
            BookTitle = bookTitle;
        }

        public static List<Student> Mahasiswa = new List<Student>();

        public void AddBorrow(Student student)
        {
            Mahasiswa.Add(student);
        }

        public static List<Student> GetStudents()
        {
            return Mahasiswa;
        }
    }
}
