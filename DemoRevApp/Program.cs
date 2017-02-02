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
            Courses demoCourse = new Courses();
            Student mike = new Student("mike", "furlow", "money", "mark@gmail.com", 22);
            List<Student> slist = new List<Student>();
            Administrator admin = new Administrator();
           

            Console.WriteLine(demoCourse.GetStudentRositer().Count);
            demoCourse.AddStudent(mike);
            Console.WriteLine(demoCourse.GetStudentRositer().Count);
           
            for (int i = 0; i < 22; i++)
            {
                slist.Add(mike);
            }
        //    demoCourse.AddStudents(slist);
            Console.WriteLine(demoCourse.GetStudentRositer().Count);



            try
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
            }
        }
    }
}
