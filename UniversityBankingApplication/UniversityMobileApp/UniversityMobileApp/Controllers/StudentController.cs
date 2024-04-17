using Microsoft.AspNetCore.Mvc;
using UniversityMobileApp.Context;
using UniversityMobileApp.Entity;
using UniversityMobileApp.Response;

namespace UniversityMobileApp.Controllers
{
    public class StudentController : ControllerBase
    {
        readonly private UMAContext context;
        public StudentController(UMAContext context)
        {
            this.context = context;
        }
        [HttpPost]
        [Route("Add")]
        public string Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return "Ekleme işlemi tamamlandı";
        }
        [HttpPost]
        [Route("QueryTuition")]
        public StudentResponse QueryTuition(int studentnumber)
        {
            var student = context.Students.Find(studentnumber);
            if(student != null)
            {
                return new StudentResponse
                {
                    StudentNumber = student.StudentNumber,
                    Balance = student.Balance,
                    Debt = student.Debt,
                    TuitionTotal = student.TuitionTotal,
                    Response = "İşlem başarılı!"

                };
            }
            else
            {
                return new StudentResponse
                {
                    Response = "Hatalı işlem!"
                };
            }
           

        }
    }
}
