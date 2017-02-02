﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoUniversity1.Users;

namespace DemoUniversity1.Courses
{
    public class Course : ICourse
    {
        private List<Student> studentRoster = new List<Student>();

        public delegate bool CloseRegistration();
        public CloseRegistration cr;

        public bool isFull
        {
            get
            {
                if(cr != null && studentRoster.Count == Global.maxStudents)
                {

                }
                return studentRoster.Count == Global.maxStudents;
            }

            
        }

        private string title;
        private string major;
        private DateTime timeOfDay;
        private int creditHour;
       
        
        public Course(string title, DateTime timeOfDay, int creditHour = 1, string major = "Elective")
        {
            this.title = title;
            this.major = major;
            this.timeOfDay = timeOfDay;
            this.creditHour = creditHour;
          //  this.id = id;
        }

        public Course()
        {
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

        public List<Student> GetStudentRoster()
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
