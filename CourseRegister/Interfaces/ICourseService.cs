using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegister
{
    public interface ICourseService
    {

        string CreateCourse(CreateCourseModel model);

        string RegisterStudents(string StudentName, string CourseName);
    }
}
