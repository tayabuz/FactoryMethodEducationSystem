using FactoryMethodEducationSystem.Base_Classes;
using FactoryMethodEducationSystem.Base_Creators;
using FactoryMethodEducationSystem.Teachers;

namespace FactoryMethodEducationSystem.Teachers_Creators
{
    class CreatePartTimeTeacher:TeacherCreator
    {
        public override TeacherBase CreateTeacher(string name, int exp, string[] courses)
        {
            return new PartTimeTeacher(name, exp, courses);
        }
    }
}
