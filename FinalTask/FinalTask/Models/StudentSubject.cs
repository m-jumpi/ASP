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
        //protected override void OnModelCreating(ModuleBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Entity<Student>()
        //        .HasMany(p => p.Subjects)
        //        .WithMany(p => p.Students)
        //        .UsingEntity(j => j.HasData(new { Subject_SubjectId = 1, Student_StudentId = 1 }));
        //}
    }
}