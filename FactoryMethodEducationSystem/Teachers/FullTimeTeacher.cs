using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Teachers
{
    class FullTimeTeacher:TeacherBase
    {
        public FullTimeTeacher(string name, int exp, string[] courses) : base(name, exp, courses)
        {
            PrintInfoAbout();
        }
    }
}
