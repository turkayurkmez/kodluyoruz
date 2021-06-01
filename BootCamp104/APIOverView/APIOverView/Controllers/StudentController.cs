using APIOverView.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOverView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //1. Tüm Öğrencileri Döndürür:,

        List<Student> students = new List<Student>
            {
                new Student { Id=1, Name="Özgün", LastName="Demirel", Address="Kartal/İstanbul"},
                new Student { Id=2, Name="Aydın", LastName="AS", Address="Nilüfer/Bursa "},
                new Student { Id = 3, Name = "Olcay", LastName = "Arpaç", Address = "Merkezefendi/Denizli " },
                new Student { Id = 4, Name = "Bahar", LastName = "Arpaç", Address = "Merkez/Çanakkale " },
                new Student { Id = 5, Name = "Tibet Kağan", LastName = "Arpaç", Address = "Kağıthane/İstanbul" },


            };

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }
        [HttpGet("{ogrID:int}")]
        public IActionResult GetStudent(int ogrID)
        {
           // object value =  default(Student);
            var student = students.FirstOrDefault(stu => stu.Id == ogrID);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
        [HttpGet("{city}")]    
        public IActionResult GetStudentsByCity(string city)
        {
            var findingStutents = students.Where(x => x.Address.Contains(city));
            if (findingStutents == null)
            {
                return NotFound();
            }

            return Ok(findingStutents);
        }

    }
}
