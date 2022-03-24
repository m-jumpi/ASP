using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Reflection.Emit;

namespace FinalTask.Models
{
    public class StudentSubject : DbContext
    {
        public StudentSubject() : base("StudensAchievement")
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectStudent> SubjecstStudents { get; set; }

        public DbSet<Grade> Grades { get; set; }
    }
}