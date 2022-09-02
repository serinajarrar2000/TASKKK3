using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using student2.Interfaces;


namespace student2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class student : ControllerBase
    {

        
        public List<Student> students = new List<Student>()
            {
                 new Student{id=101,  name="serina",age=101,city="jenin"},
                 
                new Student{id=102,  name="lana",age=23,city="tulkarem"},
                 new Student{id=103,  name="mohammad",age=23,city="ramallah"},

            };
        private Interfacess _studenss;

        public student(Interfacess studentss)
        {
            studentss = _studenss;
        }

        [HttpGet]
        [Route("getStudents")]
        public async Task<ActionResult<Student>> GetSudents()
        {

            return Ok(students);
        }

        [HttpGet]
        [Route("getStudent")]
        public async Task<ActionResult<Student>> GetSudent(int id)
        {
            var student = students.Find(x => x.id == id);
            if (student == null)
                return
                    BadRequest("No students found");
            return Ok(student);
        }

        [HttpPost]
        [Route("addStudent")]
        public async Task<ActionResult<Student>> AddSudent(Student request)
        {
            students.Add(request);
            return Ok(students);
        }

        [HttpPut]
        [Route("updateStudent")]
        public async Task<ActionResult<Student>> updateSudent(Student request)
        {
            var student = students.Find(x => x.id == request.id);
            if (student == null)
               
            student.name = request.name;
            student.city = request.city;
            student.age = request.age;
           
            return Ok(students);
        }

        [HttpDelete]
        [Route("deleteStudent")]
        public async Task<ActionResult<Student>> DeleteSudent(int id)
        {
            var student = students.Find(x => x.id == id);
            if (student == null)
                return
                    BadRequest("No students found");

            students.Remove(student);
            return Ok(student);

        }
    }
}