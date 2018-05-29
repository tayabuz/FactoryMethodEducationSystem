using FactoryMethodEducationSystem.Base_Classes;
using FactoryMethodEducationSystem.Base_Creators;
using FactoryMethodEducationSystem.Students;

namespace FactoryMethodEducationSystem.Students_Creators
{
    class CreatePartTimeStudent:StudentCreator
    {
        public override StudentBase CreateStudent(string name, string[] courses)
        {
            return new PartTimeStudent(name, courses);
        }
    }
}
