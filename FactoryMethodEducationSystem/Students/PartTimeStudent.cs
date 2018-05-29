using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Students
{
    class PartTimeStudent : StudentBase
    {
        public PartTimeStudent(string name, string[] courses) : base(name, courses)
        {
            PrintInfoAbout();
        }
    }
}
