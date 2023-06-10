using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessApplication_Polymorphism_.BL
{
    class users
    {
        protected string name;
        protected string password;
        protected string roles;
        public users()
        {

        }
        public users(string name, string password)
        {
            this.name = name;
            this.password = password;

        }
        public void setname(string name)
        {
            this.name = name;
        }
        public void setpassword(string password)
        {
            this.password = password;
        }
        public void setroles(string roles)
        {
            this.roles = roles;
        }
        public string getname()
        {
            return name;
        }
        public string getpassword()
        {
            return password;
        }
        public string getroles()
        {
            return roles;
        }
        public virtual string tooString()
        {
            return (" ");
        }
        public virtual string toString()
        {
            return (" ");
        }
        public virtual string tostring()
        {
            return (" ");
        }
    }
}
