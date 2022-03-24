using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection.Emit;

namespace FinalTask.Models
{
    public class DbInitializer: DropCreateDatabaseIfModelChanges<StudentSubject>
    {
        protected override void Seed(StudentSubject context)
        {
            context.Students.Add(new Student { FirstName = "Alan", LastName = "Ford" });
            context.Students.Add(new Student { FirstName = "Jery", LastName = "Mur" });
            context.Students.Add(new Student { FirstName = "Kobe", LastName = "Hofman" });

            Student student1 = new Student { FirstName = "Kevin", LastName = "Garent" };
            context.Students.Add(student1);

            Student student2 = new Student { FirstName = "Dwane", LastName = "Wade" };
            context.Students.Add(student2);

            context.Subjects.Add(new Subject { SubjectName = "Physics" });
            context.Subjects.Add(new Subject { SubjectName = "Phychology" });
            context.Subjects.Add(new Subject { SubjectName = "Biology" });

            Subject subject1 = new Subject { SubjectName = "Giology" };
            Subject subject2 = new Subject { SubjectName = "Math" };


            Grade a = new Grade { GradeName = "5" };
            Grade b = new Grade { GradeName = "4" };
            Grade c = new Grade { GradeName = "3" };
            Grade d = new Grade { GradeName = "2" };
            context.Grades.Add(a);
            context.Grades.Add(b);
            context.Grades.Add(c);
            context.Grades.Add(d);

            context.SubjecstStudents.Add(new SubjectStudent { Grade = a, Student = student1, Subject = subject1 });
            context.SubjecstStudents.Add(new SubjectStudent { Grade = b, Student = student1, Subject = subject2 });
            context.SubjecstStudents.Add(new SubjectStudent { Grade = c, Student = student2, Subject = subject1 });
            context.SubjecstStudents.Add(new SubjectStudent { Grade = c, Student = student2, Subject = subject2 });

            base.Seed(context);
        }

    }
}