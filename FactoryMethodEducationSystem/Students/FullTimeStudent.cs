using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Students
{
    class FullTimeStudent:StudentBase
    {
        public FullTimeStudent(string name, string[] courses) : base(name, courses)
        {
            PrintInfoAbout();
        }
    }
}
