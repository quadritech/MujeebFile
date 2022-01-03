using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegister
{
    public interface IStudentService
    {
        string Register(RegisterModel model);

        string GenerateMatricNumber();
    }
}
