using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegister
{
    public class StudentService: IStudentService
    {
        public StudentService()
        {

        }

        public string Register(RegisterModel model)
        {
            return $"welcome  {model.FirstName} {model.LastName}";
        }

        public string GenerateMatricNumber()
        {
            string matric = $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}";
            return matric;
        }
    }
}
