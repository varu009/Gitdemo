using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudy
{
    class Student
    {
        internal int id { get; set; }
        internal string Name { get; set; }
        internal DateTime DOB { get; set; }

        internal int[] phone = new int[10];

        static string college="VIT";

        
        internal Student(int id, string name, DateTime DOB)
        {
            this.id = id;
            this.Name = name;
            this.DOB = DOB;
           // this.phone = phone;
        }


    }

    class Info
    {
        public static void Display(Student student)
        {
            Console.WriteLine("ID:{0} || Name:{1} || Age:{2}", student.id, student.Name,
                student.DOB.ToString("dd/MM/yyyy"));

        }
        public static void Display(Course course)
        {
            Console.WriteLine("CID:{0} || Name:{1} || Fees:{2}", Convert.ToString(course.id), course.name, course.fees);
        }

    }

    class App
    {

        public static void Scenario1()
        {
            Student st1 = new Student(1, "VARAD", Convert.ToDateTime("01/01/2021"));
            Student st2 = new Student(2, "MAYANK", Convert.ToDateTime("01/03/2024"));
            Student st3 = new Student(3, "DHANANJAY", Convert.ToDateTime("05/01/1998"));

            
            Info.Display(st1);
            Info.Display(st2);
            Info.Display(st3);

        }

        public static void Scenario2()
        {
            // int n;
            Student[] s1 = new Student[3];
           // Info info = new Info();
            s1[0] = new Student(4, "NIKHIL", Convert.ToDateTime("01/01/2021"));
            s1[1] = new Student(5, "MAYUR", Convert.ToDateTime("01/03/2024"));
            s1[2] = new Student(6, "SAM", Convert.ToDateTime("05/01/1998"));

            foreach (var su in s1)
            {
                Info.Display(su);
            }

        }

        public static void Scenario3()
        {
            int id;
            string name;
            DateTime DOB;
            //Info info = new Info();
            Student[] s1 = new Student[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Student ID");
                id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student NAME");
                name = Console.ReadLine();

                Console.WriteLine("Enter Date of Birth");
                DOB = DateTime.Parse(Console.ReadLine());


                s1[i] = new Student(id, name, DOB);
            }
            foreach (var su in s1)
            {
                Info.Display(su);
            }

        }

        public static void Scenario4()
        {
            Console.WriteLine("Enter the number of students");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] s = new Student[n];
            

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("Enter roll no,name, and dob");
                int id = Convert.ToInt32(Console.ReadLine());
                String name = Console.ReadLine();
                DateTime date = DateTime.Parse(Console.ReadLine());
                s[i] = new Student(id, name, date);
            }

            ArrayList st = new ArrayList();
            foreach (object o in st)
            {
                st.Add(o);
            }
            foreach (Student su in s)
            {
                Info.Display(su);
            }
        }
        static void Main()
        {
            
           App.Scenario1();
            App.Scenario2();
            App.Scenario3();
            App.Scenario4();

            DateTime DOB = Convert.ToDateTime("29/09/1998"); 
            int id = 1;
            string name = "JAVA";
            String duration = "10 HR";
            double fees = 10000;
            DegreeCourse.Level level = (DegreeCourse.Level)Convert.ToInt32 (DegreeCourse.Level.Bachelors);
            bool isPlacementAvailable = true;

            Course c = new DegreeCourse(id, name,duration,fees,Convert.ToString( level), isPlacementAvailable);
            c.CalculateMonthlyFee(fees);
            
            Info.Display(c);
            Student st = new Student(id, name, DOB);
            

            InMemoryAppEngine ima = new InMemoryAppEngine();
            ima.introduce(c);
            ima.register(st);
            ima.enroll(st, c);
            ima.ListofStudents();
            

        }
    }
    abstract class Course
    {
        internal int id { get; set; }
        internal string name { get; set; }
        internal string duration { get; set; }
        internal double fees { get; set; }

        internal Course(int id, string name, string duration,double fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }
        

        abstract public double CalculateMonthlyFee(double fees);



    }

    class DegreeCourse : Course
    {
        internal enum Level
        {
            Bachelors = 1,
            Masters = 2
        };
        internal Level level;
        internal bool isPlacementAvailable;

        internal DegreeCourse(int id, string name, string duration, double fees, string levelp,
            bool isPlacementAvailable) : base(id, name,duration, fees)
        {
            this.isPlacementAvailable = isPlacementAvailable;
            level = (Level)Enum.Parse(typeof(Level), levelp);
        }
        public override double CalculateMonthlyFee(double fees)
        {
            
            return (fees / 12) + (0.1 * (fees / 12));
        }

    }

    class DiplomaCourse : Course
    {
        internal enum Type
        {
            Professional,
            Academic
        };

        internal Type type;

        internal DiplomaCourse(int id, string name, string duration, double fees, string typep) 
            : base(id, name,duration,fees)
        {
            type = (Type)Enum.Parse(typeof(Type), typep);
        }

        public override double CalculateMonthlyFee(double fees)
        {
            if (type == (Type)0) { return (fees / 12) + (0.1 * (fees / 12)); }
            else if (type == (Type)1) { return (fees / 12) + (0.05 * (fees / 12)); }
            else return -1;
        }

    }

   
    class Enroll
    {
        private Student student { get; set; }
        private Course course { get; set; }
        private DateTime enrollmentDate { get; set; }

        internal Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        void ExceptionH()
        {
            if (course.id > 4)
            {
                throw new MaxStudentException("Maximum student capacity acheived");
            }
        }


    }
    interface AppEngine
    {
        public void introduce(Course course);
        public void register(Student student);
        public List<Student> ListofStudents();
        public void enroll(Student student, Course course);
        public List<Enroll> ListofEnrollments();
    }

    class InMemoryAppEngine : AppEngine
    {
        List<Student> students = new List<Student>();

        List<Enroll> enrollments = new List<Enroll>();

        public void introduce(Course course)
        {
            Console.WriteLine("<-- Course -->");
            Console.WriteLine("NAME:{0}", course.name);
            Console.WriteLine("ID:{0}", course.id);
            Console.WriteLine("DURATION:{0}", course.duration);
            Console.WriteLine("FEES:{0}", course.fees);

        }

        public void register(Student student)
        {
            //Taking Input From The Student For Registration
            string[] phonenumbers = new string[2];
            Console.WriteLine("Enter the Id: ");
            student.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter the Date in dd/mm/yyyy fromat: ");
            student.DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter your first phone number:");
            phonenumbers[0] = Console.ReadLine();
            Console.WriteLine("Enter your second phone number:");
            phonenumbers[1] = Console.ReadLine();
            
            //Storing the Students in <students LIST>
            students.Add(student);
          
        }

        public List<Student> ListofStudents()
        {
            return students;
        }

        public void enroll(Student student, Course course)
        {
            
            Enroll enroll = new Enroll(student, course, DateTime.Today);
            enrollments.Add(enroll);
        }

        public List<Enroll> ListofEnrollments()
        {
            return enrollments;
        }

    }
    class MaxStudentException : ApplicationException
    {
        public MaxStudentException(string message) : base(message)
        {
            Console.WriteLine("Maximun Student Limit Reached !!! ");
        }
    }
    class Studentdb
    {

    }

}
