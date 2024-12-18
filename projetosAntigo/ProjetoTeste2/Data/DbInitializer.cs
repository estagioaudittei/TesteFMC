using ContosoUniversity.Models;
using System;


namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {   
                new Student{PrimeiroNome="Carson",UltimoNome="Alexander",DataInscricao=DateOnly.Parse("2019-09-01")},
                new Student{PrimeiroNome="Meredith",UltimoNome="Alonso",DataInscricao=DateOnly.Parse("2017-09-01")},
                new Student{PrimeiroNome="Arturo",UltimoNome="Anand",DataInscricao=DateOnly.Parse("2018-09-01")},
                new Student{PrimeiroNome="Gytis",UltimoNome="Barzdukas",DataInscricao=DateOnly.Parse("2017-09-01")},
                new Student{PrimeiroNome="Yan",UltimoNome="Li",DataInscricao=DateOnly.Parse("2017-09-01")},
                new Student{PrimeiroNome="Peggy",UltimoNome="Justice",DataInscricao=DateOnly.Parse("2016-09-01")},
                new Student{PrimeiroNome="Laura",UltimoNome="Norman",DataInscricao=DateOnly.Parse("2018-09-01")},
                new Student{PrimeiroNome="Nino",UltimoNome="Olivetto",DataInscricao=DateOnly.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
                new Course{CourseID=1045,Title="Calculus",Credits=4},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4},
                new Course{CourseID=2021,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}