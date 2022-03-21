using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalTask.Models
{
    public class SubjectStudent
    {
        [Key]
        public int EnrolmentId { get; set; }
        public string Grade { get; set; }
        //public int StudentId { get; set; }
        public Student Student { get; set; }

        //public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}