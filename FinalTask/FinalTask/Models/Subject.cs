using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class Subject
    {
        public virtual int SubjectId { get; set; }
        public virtual string SubjectName { get; set; }

        //public Student Student { get; set; }

        public virtual List<SubjectStudent> SubjectStudents { get; set; }
        public Subject()
        {
            SubjectStudents = new List<SubjectStudent>();
        }

        //public ICollection<Student> Students { get; set; }
        //public List<SubjectStudent> subjectStudents { get; set; }

    }
}