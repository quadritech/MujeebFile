using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegister
{
    public class CourseService: ICourseService
    {
        private readonly IStudentService _StudentService;

        public CourseService(IStudentService StudentService)
        {
            _StudentService = StudentService;
        }
        public CourseService()
        {

        }

        public string CreateCourse(CreateCourseModel model)
        {
            return $"Hey! You now have a {model.CourseName} as a new course";
        }

        public string RegisterStudents(string StudentName, string CourseName)
        {
            GenerateMatricNumberModel model = new GenerateMatricNumberModel();

            return "Hi {student name} {matric number} you have succesfully registered for { course name}";

        }
    }
}
