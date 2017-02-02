using DemoUniversity1.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity1.Users
{
    public class Administrator :Users
    {
        private static Administrator instance;

        private Administrator ()
        {

        }
        public static Administrator GetInstance
        {
            get
            {

                if (instance == null)
                {
                    instance = new Administrator();
                }
                return instance;
            }
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public override string GetInfo()
        {
            return base.ToString();
        }

        public static bool CloseCourse(Course thisCourseToClose)
        {
            thisCourseToClose.isClosed = true;
            Console.WriteLine("registration closed for " + thisCourseToClose.Title);
            return true;
        }
        public static bool ChangeCourseStatus(Course thisCourseToChange)
        {
            thisCourseToChange.isClosed = !thisCourseToChange.isClosed;
            Console.WriteLine("registration is " + (thisCourseToChange.isClosed ? "Closed" : "Open"));
            return true;
        }
    }
}
