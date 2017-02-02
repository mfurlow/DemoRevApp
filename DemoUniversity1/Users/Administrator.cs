using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity1.Users
{
    public class Administrator :Users
    {
        public void setPassword(string password)
        {
            this.password = password;
        }
        public override string GetInfo()
        {
            return base.ToString();
        }
    }
}
