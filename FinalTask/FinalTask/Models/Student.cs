using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        //public virtual List<Subject> Subjects { get; set; }
        //public Student()
        //{
        //    Subjects = new List<Subject>();
        //}

        public virtual List<SubjectStudent> SubjectStudents { get; set; }
        public Student()
        {
            SubjectStudents = new List<SubjectStudent>();
        }

        //public ICollection<Subject> Subjects { get; set; }
        //public List<SubjectStudent> subjectStudents { get; set; }
    }
}