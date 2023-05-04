using System.Collections.Generic;

namespace Linq_method_2
{
    public class Student
    {
        private int _id;
        private string _name;
        private int _age;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }   
        public Student() { }
        public Student(int id, string name, int age)
        {
           
            Id = id;
            Name = name;
            Age = age;
        }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "sra", 23));
            students.Add(new Student(2, "manj", 24));
            return students;
        }
    }
}