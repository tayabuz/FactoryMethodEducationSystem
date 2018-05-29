using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Teachers
{
    class PartTimeTeacher:TeacherBase
    {
        public PartTimeTeacher(string name, int exp, string[] courses) : base(name, exp, courses)
        {
            PrintInfoAbout();
        }
    }
}
