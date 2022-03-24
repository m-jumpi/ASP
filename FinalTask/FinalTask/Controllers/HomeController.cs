using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalTask.Models;

namespace FinalTask.Controllers
{
    public class HomeController : Controller
    {
        private StudentSubject db = new StudentSubject();

        [HttpGet]
        public ActionResult Index()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.AllStudents = allStudents;

            var allSubjects = db.Subjects.ToList<Subject>();
            ViewBag.AllSubjets = allSubjects;

            var allGrades = db.Grades.ToList<Grade>();
            ViewBag.AllGrades = allGrades;

            var allSubjectStudents = db.SubjecstStudents.ToList<SubjectStudent>();
            ViewBag.AllSubjectStudents = allSubjectStudents;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student selectedStudent)
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.AllStudents = allStudents;

            var allSubjects = db.Subjects.ToList<Subject>();
            ViewBag.AllSubjets = allSubjects;

            var allGrades = db.Grades.ToList<Grade>();
            ViewBag.AllGrades = allGrades;

            var allXSubjectStudents = db.SubjecstStudents.ToList<SubjectStudent>();
            ViewBag.AllXSubjectStudents = allXSubjectStudents;

            var allSubjectStudents = db.SubjecstStudents.SqlQuery($"select * from dbo.SubjectStudents where Student_StudentId={selectedStudent.StudentId}").ToList<SubjectStudent>();
            ViewBag.AllSubjectStudents = allSubjectStudents;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //private void GetStudents()
        //{
        //    var allStudents = db.Students.ToList<Student>();
        //    ViewBag.AllStudents = allStudents;
        //}

        //private void GetSubjects()
        //{
        //    var allSubjects = db.Subjects.ToList<Subject>();
        //    ViewBag.AllSubjets = allSubjects;
        //}

        [HttpGet]
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public string CreateStudent(Student newStudent)
        {
            db.Students.Add(newStudent);
            db.SaveChanges();
            return "Thank you, student <b>" + newStudent.FirstName + " " + newStudent.LastName + "</b> has been added successfully";
        }

        [HttpGet]
        public ActionResult CreateSubject()
        {
            return View();
        }

        [HttpPost]
        public string CreateSubject(Subject newSubject)
        {
            db.Subjects.Add(newSubject);
            db.SaveChanges();
            return $"Thank you, subject <b> {newSubject.SubjectName} </b> has been added";
        }

        [HttpGet]
        public ActionResult DeleteStudent()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.AllStudents = allStudents;
            return View();
        }

        [HttpPost]
        public string DeleteStudent(Student deleteStudent)
        {
            var delStudent = db.Students.Single(o => o.StudentId == deleteStudent.StudentId);
            db.Students.Remove(delStudent);
            db.SaveChanges();
            return $"Thank you, student <b> {delStudent.FirstName} {delStudent.LastName} </b> has been deleted";
        }

        [HttpGet]
        public ActionResult AddGrade()
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.AllStudents = allStudents;

            var allSubjects = db.Subjects.ToList<Subject>();
            ViewBag.AllSubjets = allSubjects;

            var allGrades = db.Grades.ToList<Grade>();
            ViewBag.AllGrades = allGrades;

            return View();
        }

        [HttpPost]
        public ActionResult AddGrade(Student student, Subject subject, Grade grade)
        {
            var allStudents = db.Students.ToList<Student>();
            ViewBag.AllStudents = allStudents;

            var allSubjects = db.Subjects.ToList<Subject>();
            ViewBag.AllSubjets = allSubjects;

            var allGrades = db.Grades.ToList<Grade>();
            ViewBag.AllGrades = allGrades;

            db.Database.ExecuteSqlCommand($"insert into dbo.SubjectStudents (Grade_GradeId, Student_StudentId, Subject_SubjectId) values({grade.GradeId},  {student.StudentId}, {subject.SubjectId})");
            db.SaveChanges();

            return View();
        }
    }
}