using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Base_Creators
{
    abstract class TeacherCreator
    {
        public abstract TeacherBase CreateTeacher(string name, int exp, string[] courses);
    }
}
