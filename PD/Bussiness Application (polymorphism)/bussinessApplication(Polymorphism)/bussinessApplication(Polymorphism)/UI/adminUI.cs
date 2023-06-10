using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinessApplication_Polymorphism_.BL;
using bussinessApplication_Polymorphism_.DL;

namespace bussinessApplication_Polymorphism_.UI
{
    class adminUI : users
    {
        public static data signINInput()
        {
            Console.Write(" Enter your Name: ");
            string names = Console.ReadLine();

            Console.Write(" Enter your Password (Password Must be 8 Character: ");
            string passwords = Console.ReadLine();
            data obja = new data(names, passwords);
            return obja;
        }
        public static void adminMenu(ref int currentIndex)
        {
            string choice;
            bool logout = false;
            while (true)
            {

                Console.Clear();
                mainUI.header();
                Console.WriteLine();
                Console.WriteLine(" -------------------------------------");
                Console.WriteLine(" |  Welcome To Admin Functionalities |  ");
                Console.WriteLine(" -------------------------------------");
                Console.WriteLine();
                Console.WriteLine(" Press Any Of Following to Enter:");
                Console.WriteLine(" 1. Modify/ Add Books: ");
                Console.WriteLine(" 2. Search Books: ");
                Console.WriteLine(" 3. View Book List (Details): ");
                Console.WriteLine(" 4. Remove Books: ");
                Console.WriteLine(" 5. View List of All Users : ");
                Console.WriteLine(" 6. View List Of Students who Lend The Books: ");
                Console.WriteLine(" 7. Remove User: ");
                Console.WriteLine(" 8. Change Admin Username And Password: ");
                Console.WriteLine(" 9. Check Complaints of Students: ");
                Console.WriteLine(" 10. Check Reviews of Students: ");
                Console.WriteLine(" 11. Return to Main Menu: ");
                Console.WriteLine(" 12. Exit Program: ");
                Console.WriteLine(" Enter Your Choice (1-12): ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    detailBooksList.addBooks();

                }

                else if (choice == "2")
                {
                    Console.Clear();
                    mainUI.header();
                    string search, auth;
                    Console.WriteLine(" Search Book By Name: ");
                    search = Console.ReadLine();
                    Console.WriteLine(" Enter Author oF Book: ");
                    auth = Console.ReadLine();
                    detailBooks objS = new detailBooks(search, auth);
                    bool isCheck = detailBooksList.searchBooks(objS);

                    if (isCheck == true)
                    {
                        Console.Write(" Book Is Available: ");
                    }

                    if (isCheck == false)
                    {
                        Console.Write(" Book Is Not Available: ");
                    }

                    mainUI.clear();
                }

                else if (choice == "3")
                {
                    Console.Clear();
                    mainUI.header();
                    if (detailBooksList.bookDetail.Count != 0)
                    {
                        Console.Clear();
                        mainUI.header();
                        Console.Write(" Book Details Are ");
                        Console.Write(" .............................");
                        Console.WriteLine();
                        detailBooksList.viewBooks();
                    }

                    else
                    {
                        Console.Write(" No Data Has Been Found ");
                    }

                    mainUI.clear();
                }

                else if (choice == "4")
                {

                    Console.Clear();
                    mainUI.header();
                    string remove, auth;
                    Console.Write(" Enter Book Name You Want to Remove: ");
                    remove = Console.ReadLine();
                    Console.Write(" Enter Author Name You Want to Remove: ");
                    auth = Console.ReadLine();

                    bool check = detailBooksList.checkRbooks(ref remove, ref auth);
                    if (check == true)
                    {
                        Console.Write(" Book Has Been Removed.");
                    }
                    else
                    {
                        Console.Write(" Irrelevant Details ");
                    }

                    mainUI.clear();
                }

                else if (choice == "5")
                {

                    Console.Clear();
                    mainUI.header();
                    bool reg = dataList.viewRegisteredStudents();

                    if (reg == false)
                    {
                        Console.Write(" No student has been Found. ");
                    }

                    mainUI.clear();
                }

                else if (choice == "6")
                {
                    Console.Clear();
                    mainUI.header();
                    dataList.borrowlist();
                    Console.ReadKey();
                    mainUI.clear();
                }

                else if (choice == "7")
                {

                    Console.Clear();
                    mainUI.header();
                    string removeName, userPassword;

                    Console.Write(" Enter username You Want to Remove: ");
                    removeName = Console.ReadLine();

                    Console.Write(" Enter password of Username You Want to Remove: ");
                    userPassword = Console.ReadLine();


                    bool rem = dataList.removeUser(ref removeName, ref userPassword);

                    if (rem == true)
                    {
                        Console.Write(" User Has Been Removed ");

                    }
                    else
                    {
                        Console.Write(" No user Found ");
                    }

                    mainUI.clear();

                }

                else if (choice == "8")
                {

                    Console.Clear();
                    mainUI.header();
                    string names, passwords;
                    Console.Write(" Enter Your Current Admin Name: ");
                    names = Console.ReadLine();

                    Console.Write(" ENter Your Current Admin Password: ");
                    passwords = Console.ReadLine();
                    bool isCheck = dataList.changedetails(ref names, ref passwords);
                    if (isCheck)
                    {
                        Console.Write(" Enter New Admin Name: ");
                        dataList.adminUser[0].setname(Console.ReadLine());

                        Console.Write(" Enter New Admin Password: ");
                        dataList.adminUser[0].setpassword(Console.ReadLine());
                        dataList.saveData();
                        Console.Clear();
                        Console.Write(" Your Id Has Been Updated ");
                        Console.ReadKey();

                    }
                    else
                    {
                        Console.Write("Irrelevent Credentials");
                    }
                    Console.Clear();
                    mainUI.header();



                    mainUI.clear();
                }

                else if (choice == "9")
                {
                    Console.Clear();
                    mainUI.header();

                    dataList.checkComplaint();
                    mainUI.clear();

                }

                else if (choice == "10")
                {
                    Console.Clear();
                    mainUI.header();

                    dataList.checkReview();
                    mainUI.clear();

                }

                else if (choice == "11")
                {
                    logout = true;

                }

                else if (choice == "12")
                {
                    Console.Clear();
                    Console.Write("Programs End ");
                    while (true)
                    {
                        Console.ReadKey();
                    }
                }
                if (logout == true)
                {
                    break;
                }

            }
        }

        //      Admin Functions

        public static int bookS()
        {
            Console.Clear();
            mainUI.header();
            int size;
            Console.Write(" Enter no. of Books You Want to ENTER: ");
            size = int.Parse(Console.ReadLine());
            return size;
        }
        public static void inputBooks()
        {

            Console.Write(" Enter Book Name: ");
            string bookList = Console.ReadLine();

            Console.Write(" Enter Authuor Name: ");
            string bookAuthur = Console.ReadLine();

            Console.Write(" Enter Publish Year: ");
            string bookPublish = Console.ReadLine();

            detailBooks objB = new detailBooks(bookList, bookAuthur, bookPublish);
            detailBooksList.AddintoBookList(objB);
        }
        public static void bookAddShow()
        {
            Console.WriteLine("Book Has Been Added ");
            detailBooksList.saveData1();
            Console.ReadKey();
        }
        public static void viewBooksInterFace()
        {
            Console.WriteLine("Book Name" + "\t" + "Book Auhur" + "\t" + "Book Publish");
        }
        public static void toStringInput(detailBooks b)
        {
            Console.WriteLine(b.ToString());
        }
        public static void viewRegisteredStudentsInterface()
        {
            Console.WriteLine("User Name" + "\t" + "Password" + "\t\t" + "Role");
        }
        public static void toStringInput(data d)
        {
            Console.WriteLine(d.tooString());
        }
        public static void tostringInput(data d)
        {
            Console.WriteLine(d.tostring());
        }
        public static void NoB()
        {
            Console.WriteLine(" Status: No book Has been Borrowed. ");
        }
        public static void viewUserBookBorow(data d)
        {
            Console.WriteLine(" Book name Is: " + d.getborrowbookname());
        }
        public static void NoC()
        {
            Console.WriteLine(" Complaint Status :  NO complaint has been submitted. ");
        }
        public static void viewUserC(data d)
        {
            Console.WriteLine(" Complaint is: " + d.getusercomplaints());
        }
        public static void NoR()
        {
            Console.WriteLine(" Review: No review Has been given. ");
        }
        public static void viewUserReview(data d)
        {
            Console.WriteLine(" Review Is: " + d.getreview());
        }

    }
}
