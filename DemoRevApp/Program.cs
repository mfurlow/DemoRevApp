using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity1.Users;
using DemoUniversity1.Courses;


namespace DemoRevApp
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Courses demoCourse = new Courses();
            Student mike = new Student("mike", "a", "money", "mikek@gmail.com", 1,"cs");
            Student paul = new Student("paul", "a", "money", "paul@gmail.com", 2);
            Student devonte = new Student("devonte", "a", "money", "devonte@gmail.com", 3);
            Student stephen = new Student("stephen", "a", "money", "stephen@gmail.com", 4);
            Student kirkland = new Student("stephen", "a", "money", "krik@gmail.com", 5);
            Student chris = new Student("chris", "a", "money", "chris@gmail.com", 6);
            Student alain = new Student("alain", "a", "money", "alain@gmail.com", 7);
            Student antone = new Student("antone", "a", "money", "antone@gmail.com", 8);
            Student eric = new Student("eric", "a", "money", "eric@gmail.com", 9);
            Student summer = new Student("summer", "a", "money", "summer@gmail.com", 10);
            Course dotnet = new Course("dotnet", new DateTime());
            dotnet.cr = Administrator.ChangeCourseStatus;

            dotnet.AddStudent(mike);
            dotnet.AddStudent(paul);
            dotnet.AddStudent(devonte);
            dotnet.AddStudent(stephen);
            dotnet.AddStudent(kirkland);
            dotnet.AddStudent(chris);
            dotnet.AddStudent(alain);
            dotnet.AddStudent(antone);
            dotnet.AddStudent(eric);
            dotnet.AddStudent(summer);
            dotnet.AddStudent(mike);
            dotnet.AddStudent(paul);
            dotnet.AddStudent(devonte);
            dotnet.AddStudent(stephen);
            dotnet.AddStudent(kirkland);
            dotnet.AddStudent(chris);
            dotnet.AddStudent(alain);
            dotnet.AddStudent(antone);
            dotnet.AddStudent(eric);
            dotnet.AddStudent(summer);
            

            var studentsNamedStephen = dotnet.GetStudentByFullname("mike");
            //    dotnet.AddStudent(mike);

            Console.WriteLine(studentsNamedStephen);

            Console.WriteLine(dotnet.RemoveStudentById(1));
            Console.WriteLine(dotnet.GetStudentById(1));
            if (dotnet.GetStudentById(1) == null)
            {
                Console.WriteLine("no student found");
            }
           
            Console.WriteLine(dotnet.GetStudentRoster().Count);
           
            List<Student> slist = new List<Student>();
            Administrator admin =  Administrator.GetInstance;
            Administrator admin2 = Administrator.GetInstance;

            Console.ReadLine();
           

      //      Console.WriteLine(demoCourse.GetStudentRositer().Count);
        //    demoCourse.AddStudent(mike);
          //  Console.WriteLine(demoCourse.GetStudentRositer().Count);
           
  /*          for (int i = 0; i < 22; i++)
            {
                slist.Add(mike);
            }
        //    demoCourse.AddStudents(slist);
            Console.WriteLine(demoCourse.GetStudentRositer().Count);  */



    /*        try
            {
                //open file
                //read from file
                //write and save file
                demoCourse.AddStudents(slist);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                //close file
            }                             */
        }

        
    }
}
