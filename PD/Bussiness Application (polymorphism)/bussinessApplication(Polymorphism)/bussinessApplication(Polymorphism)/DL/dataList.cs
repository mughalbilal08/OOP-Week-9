using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using bussinessApplication_Polymorphism_.BL;
using bussinessApplication_Polymorphism_.UI;

namespace bussinessApplication_Polymorphism_.DL
{
    class dataList : users
    {
        public static List<data> adminUser = new List<data>();

        public static void addIntoList(data d)
        {
            adminUser.Add(d);
        }

        public static data takeUserFromList(int x)
        {
            return adminUser[x];
        }

        public static int giveUser()
        {
            return adminUser.Count;
        }

        // ############################# Sign In ###############################################

        public static string signin(data a, ref int currentIndex)
        {
            for (int index = 0; index < adminUser.Count; index++)
            {

                if (a.getname() == adminUser[index].getname() && a.getpassword() == adminUser[index].getpassword())
                {
                    currentIndex = index;
                    if (index == 0)
                    {

                        return "admin";
                    }
                    else
                    {
                        return "student";
                    }
                }
            }
            return "isAbsent";
        }

        // ############################# Sign UP ###############################################

        public static void Signup(data s)
        {
            data d = new data();

            d.setname(s.getname());
            d.setpassword(s.getpassword());
            if (s.getname() == adminUser[0].getname() && s.getpassword() == adminUser[0].getpassword())
            {
                d.setroles("Admin");
                adminUser.Add(d);
            }
            else
            {

                d.setroles("Student");
                adminUser.Add(d);
            }
        }

        public static bool signUpConditionCheck(data s)
        {
            for (int index = 0; index < adminUser.Count; index++)
            {
                if (adminUser[index].getname() == s.getname() && adminUser[index].getname() == s.getpassword())
                {
                    return true;
                }
            }
            return false;
        }

        //              File Handling
        public static string getfield(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public static bool loadData()
        {
            int index = 0;
            string line;
            string widraw, complain, check;
            string path = "usersData.txt";
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                while ((line = myFile.ReadLine()) != null)
                {
                    data objdata = new data();
                    objdata.setname(getfield(line, 1));
                    objdata.setroles(getfield(line, 2));
                    objdata.setpassword(getfield(line, 3));
                    objdata.setdate(int.Parse(getfield(line, 4)));
                    objdata.setmonth(int.Parse(getfield(line, 5)));
                    objdata.setusercomplaints(getfield(line, 6));
                    objdata.setbookborrow(getfield(line, 7));
                    objdata.setreview(getfield(line, 8));
                    objdata.setborrowbookname(getfield(line, 9));
                    widraw = getfield(line, 10);
                    complain = getfield(line, 11);
                    check = getfield(line, 12);
                    helper(widraw, complain, check, ref objdata);
                    index++;
                    addIntoList(objdata);
                }
                myFile.Close();
                return true;
            }
            return false;
        }
        public static void saveData()
        {
            string path = "usersData.txt";
            StreamWriter myFile = new StreamWriter(path, false);
            for (int x = 0; x < adminUser.Count; x++)
            {
                myFile.Write(adminUser[x].getname() + ",");
                myFile.Write(adminUser[x].getroles() + ",");
                myFile.Write(adminUser[x].getpassword() + ",");
                myFile.Write(adminUser[x].getdates() + ",");
                myFile.Write(adminUser[x].getmonths() + ",");
                myFile.Write(adminUser[x].getusercomplaints() + ",");
                myFile.Write(adminUser[x].getbookborrow() + ",");
                myFile.Write(adminUser[x].getreview() + ",");
                myFile.Write(adminUser[x].getborrowbookname() + ",");
                myFile.Write(adminUser[x].getbookwidraw() + ",");
                myFile.Write(adminUser[x].getcomplaincheck() + ",");
                myFile.WriteLine(adminUser[x].getreviewcheck());
            }
            myFile.Flush();
            myFile.Close();
        }
        public static void helper(string widraw, string complain, string check, ref data objdt)
        {

            if (widraw == "True")
            {
                objdt.setbookwidraw(true);
            }
            if (widraw == "False")
            {
                objdt.setbookwidraw(false);
            }
            if (complain == "True")
            {
                objdt.setcomplaincheck(true);
            }
            if (complain == "False")
            {
                objdt.setcomplaincheck(false);
            }
            if (check == "True")
            {
                objdt.setreviewcheck(true);
            }
            if (check == "False")
            {
                objdt.setreviewcheck(false);
            }
        }

        //              Functions
        public static bool removeUser(ref string name, ref string password)
        {

            bool isCheck = false;
            for (int index = 1; index < adminUser.Count; index++)
            {
                if (name == adminUser[index].getname() && password == adminUser[index].getpassword())
                {

                    adminUser.RemoveAt(index);
                    isCheck = true;
                    break;
                }
            }
            return isCheck;
        }
        public static bool changedetails(ref string name, ref string password)
        {
            if (name == adminUser[0].getname() && password == adminUser[0].getpassword())
            {
                return true;
            }
            return false;
        }
        public static void changeUserDetail(ref int currentIndex)
        {
            string option;
            option = mainUI.changeUserDetailsMenu();
            Console.Clear();
            if (option == "1")
            {
                ChangeUserName(ref currentIndex);
            }
            if (option == "2")
            {
                ChangeUserpassword(ref currentIndex);
            }
        }
        public static void ChangeUserName(ref int currentIndex)
        {
            if (userUI.userNameChange() == dataList.adminUser[currentIndex].getname())
            {
                dataList.adminUser[currentIndex].setname(userUI.userNameChange2());
            }
            else
            {
                userUI.irrelevelntDetails();
            }
        }
        public static void ChangeUserpassword(ref int currentIndex)
        {
            if (userUI.ChangeUserpass() == dataList.adminUser[currentIndex].getpassword())
            {
                dataList.adminUser[currentIndex].setname(userUI.changePass2());
            }
            else
            {
                userUI.irrelevelntDetails();
            }
        }
        public static void submitReview(string choice1, ref int currentIndex)
        {

            if (choice1 == "1")
            {
                adminUser[currentIndex].review1();
            }

            if (choice1 == "2")
            {
                adminUser[currentIndex].review2();
            }

            if (choice1 == "3")
            {
                adminUser[currentIndex].review3();
            }

            if (choice1 == "4")
            {
                adminUser[currentIndex].review4();
            }

            if (choice1 == "5")
            {
                adminUser[currentIndex].review5();
            }

        }
        public static bool viewRegisteredStudents()
        {
            adminUI.viewRegisteredStudentsInterface();
            foreach (data d in adminUser)
            {
                adminUI.toStringInput(d);
            }
            return true;
        }
        public static void borrowlist()
        {
            int size = giveUser();
            for (int x = 1; x < size; x++)
            {
                data ser = takeUserFromList(x);
                if (ser.getbookwidraw() == true)
                {

                    adminUI.tostringInput(ser);
                    adminUI.viewUserBookBorow(ser);

                }
                else
                {
                    adminUI.tostringInput(ser);
                    adminUI.NoB();
                }

            }

        }
        public static void checkComplaint()
        {
            int size = giveUser();
            for (int x = 1; x < size; x++)
            {
                data d = takeUserFromList(x);
                if (d.getcomplaincheck() == true)
                {
                    usersUI.userCName(d);
                    adminUI.viewUserC(d);

                }
                else if (d.getcomplaincheck() == false)
                {
                    usersUI.userCName(d);
                    adminUI.NoC();
                }
                Console.WriteLine();
            }
        }
        public static void checkReview()
        {
            int size = giveUser();
            for (int x = 1; x < size; x++)
            {
                data d = takeUserFromList(x);
                if (d.getreviewcheck() == true)
                {
                    adminUI.tostringInput(d);
                    adminUI.viewUserReview(d);
                }
                else if (d.getreviewcheck() == false)
                {
                    adminUI.tostringInput(d);
                    adminUI.NoR();
                }

                Console.WriteLine();
            }
        }
    }
}
