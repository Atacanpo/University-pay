using Microsoft.AspNetCore.Mvc;
using UniversityBankingApplication.Context;
using UniversityBankingApplication.Response;

namespace UniversityBankingApplication.Controllers
{
    public class StudentController : ControllerBase
    {
        readonly private UBAContext context;

        public StudentController(UBAContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route("QueryTuition")]
        public StudentResponse QueryTuition(int studentnumber)
        {
            var student = context.Students.Find(studentnumber);
            if (student != null)
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
        [HttpPost]
        [Route("StudentPayment")]
        public string StudentPayment(int studentNumber, DateTime period, decimal paymentTotal)
        {
            var student = context.Students.FirstOrDefault(x => x.StudentNumber == studentNumber && x.Period == period);

            if (student == null)
            {
                return "Öğrenci bulunamadı.";
            }

            if (student.Debt < paymentTotal)
            {
                return $"Ödemek istediğiniz tutar borcunuzu aşıyor. En fazla {student.Debt}₺ ödeme yapabilirsiniz.";
            }

            student.Debt -= paymentTotal; 
            context.Students.Update(student);
            context.SaveChanges();

            return $"Ödeme başarıyla gerçekleştirildi. Kalan borcunuz: {student.Debt}₺";
        }


    }
}
