using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Base_Creators
{
    abstract class StudentCreator
    {
        public abstract StudentBase CreateStudent(string name, string[] courses);
    }
}
