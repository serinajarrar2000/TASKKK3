using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace student2.Interfaces
{
    public interface Interfacess
    {
        List<Student> Get();
        Student Get(int id);
        public void Addstudent(Student student);
        Student updatestudent(Student request);
        public void Delete(int id);
    }

    public class studentss: Interfacess
    {

        public List<Student> students = new List<Student>()
            {
                 new Student{id=101,  name="serina",age=101,city="jenin"},

                new Student{id=102,  name="lana",age=23,city="tulkarem"},
                new Student{id=103,  name="mohammad",age=23,city="ramallah"},

            };
        private object student;

        public void Addstudent(Student student)
        {
            students.Add(student);
        }

        public void Delete(int id)
        {
            students.Remove((Student)student);

        }

        public List<Student> Get()
        {
            return students;
        }

        public Student Get(int Id)
        {
            return students.FirstOrDefault(f => f.id == Id);
        }

        public Student updatestudent(Student request)
        {
            var student = students.Find(p => p.id == request.id);

            student.id = request.id;
            student.name = request.name;
            student.age = request.age;
            student.city = request.city;
            return student;

        }

        Student Interfacess.updatestudent(Student request)
        {
            throw new NotImplementedException();
        }
    }
}

