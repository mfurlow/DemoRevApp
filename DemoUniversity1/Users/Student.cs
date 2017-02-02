using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity1.Users
{
    public class Student:Users
    {
        private string major;
        private bool isFulltime;
        private string registeredCourses;
     //   Dictionary<string, Courses >
        // enum year
        //array of their courses

        public Student(string Fname, String Lname, string password, string email, int id, string major = "undecided") : base(Fname, Lname, password, email, id)
        {
            this.major = major;
            isFulltime = false;
        }

        public override string GetInfo()
        {
            
            StringBuilder info = new StringBuilder(base.ToString());
            info.Append($"\n (major)");
            info.Append($"\nfulltime: (isFulltime)");

                      if (classes.Count == 0)
                      {
                          info.Append($"not registered for classes");
                      }
                      else
                      {
                          foreach(var item in classes)
                          {
                              info.Append('\n');
                              info.Append(item.);
                          }
                      }        
            return "";     
        }

    }
}
