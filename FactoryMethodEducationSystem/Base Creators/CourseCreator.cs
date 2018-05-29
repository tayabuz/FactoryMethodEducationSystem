using FactoryMethodEducationSystem.Base_Classes;

namespace FactoryMethodEducationSystem.Base_Creators
{
    abstract class CourseCreator
    {
        public abstract CourseBase CreateCourse(string name, string[] teachers, string[] students);
    }
}
