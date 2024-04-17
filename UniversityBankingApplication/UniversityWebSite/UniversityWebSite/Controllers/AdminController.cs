using Microsoft.AspNetCore.Mvc;
using UniversityWebSite.Context;
using UniversityWebSite.Entities;
using UniversityWebSite.Response;

namespace UniversityWebSite.Controllers
{
    public class AdminController : ControllerBase
    {
        readonly private UWSContext context;

        public AdminController(UWSContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("AddTuition")]
        public ApiResponse AddTuition(int studentNumber , DateTime period , string username , string password)
        {
            var admin = context.Admins.Any(x=>x.Name == username &&  x.Password == password);
            if (admin)
            {
                var student = context.Students.FirstOrDefault(x => x.StudentNumber == studentNumber && x.Period == period);
                if (student != null)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                    return new ApiResponse
                    {
                        TransactionStatus = true,
                        Response = "Ekleme işlemi başarılı"
                    };
                }
                else
                {
                    return new ApiResponse
                    {
                        Response = "Öğrenci bulunamadı"
                    };
                }
            }
            else
            {
                return new ApiResponse
                {
                    Response = "Kullanıcı Adı veya Şifre hatalı"
                };
            }
        }

        [HttpPost]
        public IActionResult UnpaidTuitionStatus(string username, string password, DateTime period)
        {
            var isAdmin = context.Admins.Any(x => x.Name == username && x.Password == password);

            if (isAdmin)
            {
                var unpaidStudents = context.Students.Where(x => x.Period == period && x.Debt > 1).ToList();
                return Ok(unpaidStudents); 
            }
            else
            {
                return Unauthorized(); 
            }
        }

    }
}
