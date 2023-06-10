using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinessApplication_Polymorphism_.BL;

namespace bussinessApplication_Polymorphism_.UI
{
    class usersUI
    {
        public static void userCName(users u)
        {
            Console.WriteLine(" Name of Student is: " + u.getname());
        }
    }
}
