using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity1.Users;

namespace DemoUniversity1.Courses
{
    public class Courses : ICourse
    {
        private List<Student> studentRoster = new List<Student>();
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
        public Courses(string title, DateTime timeOfDay, int creditHour = 1, string major = "Elective")
        {
            this.title = title;
            this.major = major;
            this.timeOfDay = timeOfDay;
            this.creditHour = creditHour;
        }

        public Courses()
        {
        }

        public int RosterCount
        {
            get
            {
                return studentRoster.Count;
            }
        }

        

        public string Title
        {
            get
            {
                throw new NotImplementedException();
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

        public List<Student> GetStudentRositer()
        {
            return studentRoster;
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
