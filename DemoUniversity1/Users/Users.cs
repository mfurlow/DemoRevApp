using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity1.Users
{
    public abstract class Users
    {
        public string Fname;
        public string Lname;
        protected string password;
        private string email;
        private int id;

        public Users()
        {
            
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name">person's name</param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        public Users(string Fname, String Lname, string password, string email, int id)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.password = password;
            this.email = email;
            this.id = id;
        }

        public abstract string GetInfo();
        

        public string FullName
        {
            get {return Fname + "" + Lname;}
          
        }
        public virtual string Password
        {
            get
            {
                return password;
            }
        }
        public string Email
        {
           get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public override string ToString()
        {
            string result = "";
            result += FullName;
            result +="\n" + Email;
            return result;
        }

    }

    
}
