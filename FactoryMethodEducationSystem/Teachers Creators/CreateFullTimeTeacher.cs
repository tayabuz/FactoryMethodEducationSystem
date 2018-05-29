using FactoryMethodEducationSystem.Base_Classes;
using FactoryMethodEducationSystem.Base_Creators;
using FactoryMethodEducationSystem.Teachers;

namespace FactoryMethodEducationSystem.Teachers_Creators
{
    class CreateFullTimeTeacher : TeacherCreator
    {
        public override TeacherBase CreateTeacher(string name, int exp, string[] courses)
        {
            return new FullTimeTeacher(name, exp, courses);
        }
    }
}
