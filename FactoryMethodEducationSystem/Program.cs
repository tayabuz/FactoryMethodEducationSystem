using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;
using FactoryMethodEducationSystem.Base_Classes;
using FactoryMethodEducationSystem.Courses_Creators;
using FactoryMethodEducationSystem.Students_Creators;
using FactoryMethodEducationSystem.Teachers_Creators;

namespace FactoryMethodEducationSystem
{
    class Program
    {
        private const string WRITE_PATH = @"C:\Users\User\Downloads\Result.tsv";
        private static string CurrentPath { get; set; }

        public static void Main()
        {
            CurrentPath = SetPath;
            var dex = new CreateFullTimeStudent();
            StudentBase st = dex.CreateStudent("Rick", new[] { "020" });
            StudentBase st1 = dex.CreateStudent("Alex", new[] { "6", "9" });
            var deg = new CreatePartTimeStudent();
            StudentBase st2 = deg.CreateStudent("Nick", new[] { "4", "5" });
            List<StudentBase> students = new List<StudentBase> { st, st1, st2 };
            Serialize(students);
            var c = new CreateTechCourse();
            CourseBase co = c.CreateCourse("Math", new[] { "0" }, new[] { "001", "002" });
            CourseBase co1 = c.CreateCourse("CS", new[] { "0" }, new[] { "001", "002" });
            List<CourseBase> courses = new List<CourseBase> { co, co1 };
            Serialize(courses);
            var n = new CreateFullTimeTeacher();
            TeacherBase t = n.CreateTeacher("K", 5, new[] { "001", "002" });
            var q = new CreatePartTimeTeacher();
            TeacherBase t1 = q.CreateTeacher("gfgd", 5, new[] { "009", "005" });
            List<TeacherBase> teachers = new List<TeacherBase> { t, t1 };
            Serialize(teachers);
            Console.ReadKey();
        }

        private static void Serialize<T>(IEnumerable<T> data)
        {
            using (StreamWriter sw = new StreamWriter(CurrentPath, true, Encoding.Default))
            {
                var csvWriter = new CsvWriter(sw);
                csvWriter.Configuration.MemberTypes = MemberTypes.Properties | MemberTypes.Fields;
                csvWriter.Configuration.HasHeaderRecord = true;
                csvWriter.Configuration.Delimiter = "\t";

                csvWriter.WriteField(data.GetType());
                csvWriter.NextRecord();
                csvWriter.WriteRecords(data);
                sw.Close();
            }
        }

        private static string SetPath
        {
            get
            {
                FileInfo fi = new FileInfo(WRITE_PATH);
                if (!fi.Exists)
                {
                    FileStream fs = fi.Create();
                    fs.Close();
                    return WRITE_PATH;
                }
                else
                {
                    int number = 1;
                    string path = @"C:\Users\User\Downloads\Result" + number + ".tsv";
                    FileInfo fi1 = new FileInfo(path);
                    while (fi1.Exists)
                    {
                        number++;
                        path = @"C:\Users\User\Downloads\Result" + number + ".tsv";
                        fi1 = new FileInfo(path);
                    }
                    FileStream fs = fi1.Create();
                    fs.Close();
                    return path;
                }
            }
        }
    }
}
