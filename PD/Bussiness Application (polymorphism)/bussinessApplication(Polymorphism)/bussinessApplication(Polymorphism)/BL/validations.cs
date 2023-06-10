using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessApplication_Polymorphism_.BL
{
    class validations
    {
        public static bool name_check(string name)
        {
            bool flag = false;
            int i = 0;
            while (i < name.Length)
            {
                if ((name[i] > 63 && name[i] < 91) || (name[i] > 96 && name[i] < 123))
                {
                    i++;
                    if (i >= 5)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        public static bool password_check(string password)
        {
            bool flag = false;
            int i = 0;
            while (i < password.Length)
            {
                if ((password[i] > 63 && password[i] < 91) || (password[i] > 96 && password[i] < 123) || (password[i] > 47 && password[i] < 58) || (password[i] > 34 && password[i] < 39))
                {
                    i++;
                    if (i >= 8)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }
        public static bool IsValidDate(int day, int month)
        {
            // Check if the month is valid
            if (month < 1 || month > 12)
            {
                return false;
            }
            else
            {
                return true;
            }

            // Check if the day is valid based on the month
            switch (month)
            {
                case 2: // February
                    if (day < 1 || day > 28)
                    {
                        return false;
                    }
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    if (day < 1 || day > 30)
                    {
                        return false;
                    }
                    break;
                default: // All other months
                    if (day < 1 || day > 31)
                    {
                        return false;
                    }
                    break;
            }
        }
    }
}
