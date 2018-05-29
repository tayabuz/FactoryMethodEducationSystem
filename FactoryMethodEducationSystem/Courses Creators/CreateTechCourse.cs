using FactoryMethodEducationSystem.Base_Classes;
using FactoryMethodEducationSystem.Base_Creators;
using FactoryMethodEducationSystem.Courses;

namespace FactoryMethodEducationSystem.Courses_Creators
{
    class CreateTechCourse:CourseCreator
    {
        public override CourseBase CreateCourse(string name, string[] teachers, string[] students)
        {
            return new TechCource(name, teachers, students);
        }
    }
}
