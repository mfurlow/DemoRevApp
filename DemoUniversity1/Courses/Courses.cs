using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity1.Users;
using System.Threading;

namespace DemoUniversity1.Courses
{
    public class Course : ICourse
    {
        private List<Student> studentRoster = new List<Student>();

        public delegate bool CloseRegistration(Course thisCourseToClose);
        public CloseRegistration cr = null;

        public bool isFull
        {
            get
            {
                
                return studentRoster.Count == Global.maxStudents;
            }

            
        }

        private string title;
        private string major;
        private DateTime timeOfDay;
        private int creditHour;
        public bool isClosed;

        public Course(string title, DateTime timeOfDay, int creditHour = 1, string major = "Elective")
        {
            this.title = title;
            this.major = major;
            this.timeOfDay = timeOfDay;
            this.creditHour = creditHour;
          //  this.id = id;
        }

        

        public int RosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        public Student GetStudentById(int id)
        {
            var student = studentRoster.Where(x => x.Id == id).FirstOrDefault();
                return student;
        }

        public Student GetStudentByFirstName(string fn)
        {
            var results = studentRoster.Where(person => person.Fname == fn).FirstOrDefault();
            return results;
        }

        public Student GetStudentByFullname(string name)
        {
            var result = studentRoster.Where(p => p.FullName == name).FirstOrDefault();
            return result;
        }

        public Student GetStudentByFullName(string firstname, string lastname)
        {
            return GetStudentByFullname(firstname + " " + lastname);
        }

        public bool RemoveStudentById(int id)
        {
          return  studentRoster.Remove(GetStudentById(id));            
        }

        public string Title
        {
            get
            {
                return title; ;
            }
        }

        string ICourse.title
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool AddStudent(Student student)
        {

            SpaceCheck(studentRoster.Count + 1);
            studentRoster.Add(student);
            if ( cr != null && isFull)
            {
                cr(this);
            }
            return true;
        }
        public bool AddStudents(List<Student> roster)
        {         
           SpaceCheck(roster.Count + studentRoster.Count);                    
            foreach (Student item in roster)
            {
                AddStudent(item);
            }
            return true;
        }

        public async Task<List<Student>> GetStudentRoster()
        {
            Console.WriteLine("Start async");
            var results = await FetchRoster();
            Console.WriteLine("End async");
            return results;
        }

        // just some method thqt returns student list, this is a throw away method
        public void PrintRosterCount()
        {
            Thread.Sleep(1000);
            Console.WriteLine("this is just a test for thread " + studentRoster.Count);
        }

        public Task<List<Student>> FetchRoster()
        {
            return Task.Run(() => { return studentRoster; });
        }
        public bool RemoveStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveStudent(string Fname, string Lname)
        {
            throw new NotImplementedException();
        }

        private bool SpaceCheck(int newCount)
        {
            if (newCount > Global.maxStudents)
            {
                throw new Exception( Errors.notEnoughSpace);
            }
            return true;
        }
        
        
    }
}
