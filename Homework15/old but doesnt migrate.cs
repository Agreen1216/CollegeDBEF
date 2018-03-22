using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using static System.Console;

namespace CollegeDBEF

{
    public class Students
    {
        [Key]
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class Courses
    {
        [Key]
        public virtual int ID { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public int CRN { get; set; }
       
    }

    public class Scores
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public virtual int CRN { get; set; }
    }

    public class StudentsContext : DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Scores> Scores { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentsContext())
            {
                //    Students Student = new Students { Fname = "Kobe", Lname = "Bryant", ID = 8, Address = "1111 S Figueroa St", City = "Los Angeles" };
                //    db.Students.Add(Student);
                //    Students Student2 = new Students { Fname = "Zeke", Lname = "Elliot", ID = 21, Address = "1 AT&T Way", City = "Arlington" };
                //    db.Students.Add(Student2);
                //    Students Student3 = new Students { Fname = "Lavar", Lname = "Ball", ID = 1, Address = "3 B Baller Way", City = "Big Baller Village" };
                //    //db.Students.Add(Student3);
                //    db.SaveChanges();
                //};
                //db.Books.Add(book1);

                //using (var db = new CoursesContext())
                //{
                //    Courses Course = new Courses { Title = "Geometry", Dept = "Math", CRN =102 };
                //    Courses Course2 = new Courses { Title = "Chemisty", Dept = "Science", CRN = 1212 };
                //    Courses Course3 = new Courses { Title = "Gym", Dept = "Physical Education", CRN = 501 };
                //}

                //using (var db = new CoursesContext())
                //{
                //    Scores Score = new Scores { Homework = "98% A+", Description = "Estimate your neighbors internet bill", Points = 98 };
                //    Scores Score2 = new Scores { Homework = "76% C", Description = "Fuse 2 Atoms together", Points = 76 };
                //    Scores Score3 = new Scores { Homework = "58% F+", Description = "", Points = 58 };
                //}

                Students Student1 = new Students
                {
                    Fname = "Kobe",
                    Lname = "Bryant",

                    Address = "1111 S Figueroa St",
                    City = "Los Angeles",
                    State = "Ca",
                };
                 db.Students.add(Student1);

                Students Student2 = new Students
                {
                    Fname = "Zeke",
                    Lname = "Elliot",
                    Address = "1 AT&T Way",
                    City = "Arlington",
                    State = "TX",
                };
                db.Students.add(Student2);

                Students Student3 = new Students
                {
                    Fname = "Lavar",
                    Lname = "Ball",
                    Address = "3 B Baller Way",
                    City = "Big Ballerville",
                    State = "CA",
                };
                db.Students.add(Student3);


                Courses Class1 = new Courses
                {
                    Title = "Geometry",
                    CRN = 102,
                    Dept = "Math",
                };
                db.Courses.add(Class1);

                Courses Class2 = new Courses
                {
                    Title = "Chemistry",
                    CRN = 1212,
                    Dept = "Science",
                };
                db.Courses.add(Class2);

                Courses Class3 = new Courses
                {
                    Title = "Gym",
                    CRN = 501,
                    Dept = "Physical Education",
                };
                  db.Courses.add(Class3);

                Scores Score = new Scores
                {
                    Type = "HW",
                    Description = "Estimate your neighbor's WiFi password",
                    Points = 98,
                    //PointsPossible = 100
                };
                    db.Scores.add(Score1);

                Scores Score2 = new Scores
                {
                    Type = "Quiz",
                    Description = "Fuse 2 Atoms together",
                    Points = 76,
                    //PointsPossible = 100
                };
                    db.Scores.add(Score2);

                Scores Score3 = new Scores
                {
                    Type = "Exam",
                    Description = "Run a sub 5.0 Second 40 yard dash",
                    Points = 58,
                    //PointsPossible = 100
                };
                     db.Scores.add(Score3);


            }

        }
    }
}

