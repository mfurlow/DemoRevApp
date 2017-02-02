using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity1.Users;

namespace DemoUniversity1.Courses
{
    interface ICourse
    {
        bool AddStudent(Student student);
        bool RemoveStudent(int id);
        bool RemoveStudent(Student student);
        bool RemoveStudent(string Fname, string Lname);
        
        bool  isFull{ get; }
        int RosterCount { get; }
  //      List<Student> GetStudentRoster();
        //    bool AddStudents(List<Student> roster);

        string title { get;  }

    }
}
