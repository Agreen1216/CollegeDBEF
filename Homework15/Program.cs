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
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public virtual List<Course> Courses_ID { get; set; }
    }

    public class Course
    {
        [Key]
        public  int ID { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public int CRN { get; set; }
        public virtual List <Score> Scores_ID { get; set; }
        public string Points { get; set; }
        public string Instructor { get; set; }
    }

    public class Score
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public  int CRN { get; set; }
   
    }

    public class StudentsContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Score> Scores { get; set; }
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

                Student Student1 = new Student
                {
                    Fname = "Kobe",
                    Lname = "Bryant",

                    Address = "1111 S Figueroa St",
                    City = "Los Angeles",
                    State = "Ca",
                    Courses_ID= new List<Course>()
                };
                 db.Students.Add(Student1);

                Student Student2 = new Student
                {
                    Fname = "Zeke",
                    Lname = "Elliot",
                    Address = "1 AT&T Way",
                    City = "Arlington",
                    State = "TX",
                    Courses_ID = new List<Course>()
                };
                db.Students.Add(Student2);

                Student Student3 = new Student
                {
                    Fname = "Lavar",
                    Lname = "Ball",
                    Address = "3 B Baller Way",
                    City = "Big Ballerville",
                    State = "CA",
                    Courses_ID = new List<Course>()
                };
                db.Students.Add(Student3);


               Course Class1 = new Course
                {

                    Title = "Geometry",
                    CRN = 102,
                    Dept = "Math",
                    Points = "98",
                    Instructor= "Skip Bayless",
                    Scores_ID = new List <Score>()

                };
                Student2.Courses_ID.Add(Class1);

                Course Class2 = new Course
                {
                    Title = "Chemistry",
                    CRN = 1212,
                    Dept = "Science",
                    Points = "76",
                    Instructor = "Stephen A Smith",
                    Scores_ID = new List<Score>()

                };
                Student1.Courses_ID.Add(Class2);

                Course Class3 = new Course
                {
                    Title = "Gym",
                    CRN = 501,
                    Dept = "Physical Education",
                    Points= "58",
                    Instructor="Shannon Sharpe",
                    Scores_ID = new List<Score>()

                };
                Student2.Courses_ID.Add(Class3);

                Score Score = new Score
                {
                    Type = "HW",
                    Description = "Estimate your neighbor's WiFi password",
                    Points = 98,
                    
                };
                    Class2.Scores_ID.Add(Score);

                Score Score2 = new Score
                {
                    Type = "Quiz",
                    Description = "Fuse 2 Atoms together",
                    Points = 76,
                   
                };
                    Class3.Scores_ID.Add(Score2);

                Score Score3 = new Score
                {
                    Type = "Exam",
                    Description = "Run a sub 5.0 Second 40 yard dash",
                    Points = 58,
                  
                };
                    Class2.Scores_ID.Add(Score3);
                     db.SaveChanges();
                var query = from student in db.Students
                            orderby student.Address
                            select student;

                WriteLine("Students first name is");
                WriteLine();
                foreach (var student in query)
                {

                    Console.WriteLine($"{student.Fname}  {student.Lname}");

                    foreach (var Student in query) 
                   {
                        WriteLine($"- Title: {Score.Type}");
                        WriteLine($"-- Student in Class: {Student2.ID}");
                    
                    }
                    WriteLine();
                }

                WriteLine("Press a key to exit...");
                ReadKey();
            }

        }
    }
}

