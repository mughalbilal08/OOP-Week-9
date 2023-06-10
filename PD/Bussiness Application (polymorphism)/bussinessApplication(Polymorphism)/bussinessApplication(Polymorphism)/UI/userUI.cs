using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinessApplication_Polymorphism_.BL;
using bussinessApplication_Polymorphism_.DL;


namespace bussinessApplication_Polymorphism_.UI
{
    class userUI
    {
        public static void SignUpInput()
        {
            Console.Write(" Enter your Name: ");
            string names = Console.ReadLine();

            bool isName = validations.name_check(names);
            if (isName == true)
            {
                Console.Write(" Enter the password (Must Be 8 Characters)");
                string passwords = Console.ReadLine();

                bool valid = validations.password_check(passwords);
                data objs = new data(names, passwords);
                if (valid == true)
                {
                    bool isCheck = dataList.signUpConditionCheck(objs);
                    if (isCheck == true)
                    {
                        Console.WriteLine("Already Exit");
                        Console.ReadKey();
                    }
                    if (isCheck == false)
                    {
                        Console.Clear();
                        mainUI.header();
                        dataList.Signup(objs);
                        Console.Write(" THE ID HAS BEEN CREATED Successfully !! ");
                        Console.ReadKey();
                    }

                }
                else if (valid == false)
                {
                    Console.Clear();
                    mainUI.header();
                    Console.Write(" Please Enter a strong password . ");
                }
            }
            else if (isName == false)
            {
                Console.Clear();
                mainUI.header();
                Console.Write(" Please Enter a Name without integers");
            }
        }

        public static void userMenu(ref int currentIndex)
        {
            string choice;
            bool logout = false;

            while (true)
            {
                Console.Clear();
                mainUI.header();

                Console.WriteLine();


                Console.WriteLine(" -----------------------------------");
                Console.WriteLine(" | Welcome To User Functionalities | ");
                Console.WriteLine(" -----------------------------------");
                Console.WriteLine("                                    ");
                Console.WriteLine(" Press Any Of Following to Enter:");
                Console.WriteLine();
                Console.WriteLine(" 1. Enter Books Names You Want To Borrow :");
                Console.WriteLine(" 2. Search Books: ");
                Console.WriteLine(" 3. View My Fine Status  ");
                Console.WriteLine(" 4. View List Of Library Books: ");
                Console.WriteLine(" 5. Change My Username/Password: ");
                Console.WriteLine(" 6. Show Books Name To Return: ");
                Console.WriteLine(" 7. Show My Book Borrow Date: ");
                Console.WriteLine(" 8. Book Return: ");
                Console.WriteLine(" 9. Submit Complaints: ");
                Console.WriteLine(" 10. Give Your Review: ");
                Console.WriteLine(" 11. Return to Main Menu: ");
                Console.WriteLine(" 12. Exit Program: ");
                Console.WriteLine(" Enter Your Choice (1-12): ");

                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Clear();
                    mainUI.header();
                    string name, author;
                    Console.WriteLine(" Enter Name of Book You Want to Borrow: ");
                    name = Console.ReadLine();

                    Console.WriteLine(" Enter Author of Book You Want to Borrow: ");
                    author = Console.ReadLine();
                    detailBooks objC = new detailBooks(name, author);

                    bool check = detailBooksList.booksWidraw(objC, dataList.adminUser[currentIndex]);
                    if (check == true)
                    {
                        Console.WriteLine(" Enter Date Of Borrowing Book: ");
                        int date = int.Parse(Console.ReadLine());

                        Console.WriteLine(" Enter Month Of Borrowing Book: ");
                        int month = int.Parse(Console.ReadLine());
                        data objI = new data(date, month);
                        detailBooksList.issueDates(objI, dataList.adminUser[currentIndex]);
                        Console.Clear();
                        Console.WriteLine("Book Has Been Borrowed");
                    }
                    else
                    {
                        Console.WriteLine("Irrelevent Credentials");
                    }
                    mainUI.clear();

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
                    bool searching = detailBooksList.searchBooks(objS);

                    if (searching == true)
                    {
                        Console.WriteLine(" Book Is Present in Library. ");
                    }

                    else if (searching == false)
                    {
                        Console.WriteLine(" Book is Not Present in Library. ");
                    }

                    mainUI.clear();

                }

                else if (choice == "3")
                {
                    Console.Clear();
                    mainUI.header();
                    Console.WriteLine("Enter a date (dd):");
                    int day = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a month (mm):");
                    int month = int.Parse(Console.ReadLine());

                    if (validations.IsValidDate(day, month))
                    {
                        Console.WriteLine("Valid date & Month!");
                        data.fine(ref day, ref month, ref currentIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Date! ");
                        Console.WriteLine("Enter date Again ");
                    }



                    mainUI.clear();
                }

                else if (choice == "4")
                {
                    Console.Clear();
                    mainUI.header();

                    if (detailBooksList.bookDetail.Count != 0)
                    {
                        Console.Clear();
                        mainUI.header();
                        Console.WriteLine(" Book Details Are ");
                        Console.WriteLine(".............................");
                        Console.WriteLine();
                        detailBooksList.viewBooks();
                    }

                    else
                    {
                        Console.WriteLine(" No Data Has Been Found ");
                    }

                    mainUI.clear();

                }

                else if (choice == "5")
                {

                    Console.Clear();
                    mainUI.header();
                    dataList.changeUserDetail(ref currentIndex);
                    mainUI.clear();

                }

                else if (choice == "6")
                {

                    Console.Clear();
                    mainUI.header();

                    viewBorrow(dataList.adminUser[currentIndex]);
                    Console.ReadKey();
                    mainUI.clear();

                }

                else if (choice == "7")
                {
                    Console.Clear();
                    mainUI.header();

                    ViewBorrowDate(dataList.adminUser[currentIndex]);

                    mainUI.clear();

                }

                else if (choice == "8")
                {
                    Console.Clear();
                    mainUI.header();


                    viewBookToReturn(dataList.adminUser[currentIndex]);

                    mainUI.clear();

                }

                else if (choice == "9")
                {

                    Console.Clear();
                    mainUI.header();
                    string option3 = mainUI.complianmenu();
                    if (option3 == "1")
                    {
                        Console.Clear();
                        submitcomplain(dataList.adminUser[currentIndex]);
                        successfullucomplain();
                        Console.ReadKey();
                    }
                    else if (option3 == "2")
                    {
                        string password = getpasswordforuser();
                        if (password == dataList.adminUser[currentIndex].getpassword())
                        {
                            removecomplains();
                            resetcomplain(dataList.adminUser[currentIndex]);
                        }

                    }

                }

                else if (choice == "10")
                {

                    Console.Clear();
                    mainUI.header();
                    review(ref currentIndex);
                    Console.Clear();
                    Console.WriteLine(" Your Review Has Been Submitted ");
                    mainUI.clear();

                }

                else if (choice == "11")
                {
                    logout = true;

                }

                else if (choice == "12")
                {
                    Console.Clear();
                    Console.WriteLine("Programs End ");
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

        //      User Functions

        public static void viewBorrow(data obj)
        {

            if (obj.getbookwidraw() == true)
            {
                Console.WriteLine(" You Have Withdrawn the book : " + obj.getborrowbookname());
            }
            else if (obj.getbookwidraw() == false)
            {
                Console.WriteLine(" You Have Not Withdrawn the book");
            }
        }
        public static void submitcomplain(data s)
        {
            string complain;
            Console.Write(" Complain: ");
            complain = Console.ReadLine();
            s.setusercomplaints(complain);
            s.setcomplaincheck(true);
        }
        public static void removecomplains()
        {
            Console.WriteLine(" Your Complain has been removed.");
        }
        public static void successfullucomplain()
        {
            Console.WriteLine();
            Console.WriteLine(" Your Complain has been filed.");
        }
        public static string getpasswordforuser()
        {
            Console.Write(" Enter your account password: ");
            string password = Console.ReadLine();
            return password;
        }
        public static void resetcomplain(data s)
        {
            s.setusercomplaints("No Complain");
        }
        public static void ViewBorrowDate(data s)
        {
            Console.WriteLine("You Have Borrow the Book On Date : " + s.getdates());
            Console.WriteLine("You Have Borrow the Book On Month : " + s.getmonths());
        }
        public static void viewBookToReturn(data obj)
        {
            if (obj.getbookwidraw() == true)
            {
                Console.WriteLine(" You Have Book To Return Named : " + obj.getborrowbookname());
            }
            else if (obj.getbookwidraw() == false)
            {
                Console.WriteLine(" You Have No Book To Return ");
            }
        }
        public static void review(ref int currentIndex)
        {
            string choice;
            Console.WriteLine(" Submit your review about Library : ");
            Console.WriteLine();
            Console.WriteLine(" 1. Excellent.");
            Console.WriteLine(" 2. Good.");
            Console.WriteLine(" 3. Satisfactory.");
            Console.WriteLine(" 4. Unsatisfactory.");
            Console.WriteLine(" 5. Poor.");
            Console.WriteLine(" Select Any of the above options: ");
            choice = Console.ReadLine();
            dataList.submitReview(choice, ref currentIndex);
        }
        public static string userNameChange()
        {
            Console.Write("Enter Current Name: ");
            string name = Console.ReadLine();
            Console.Clear();
            return name;
        }
        public static string userNameChange2()
        {
            Console.WriteLine(" YEP ! Your Name Found in Records. ");
            Console.WriteLine("Now You Can Change Your Name ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" Enter New name ");
            string name1 = Console.ReadLine();
            return name1;
        }
        public static string ChangeUserpass()
        {
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();
            Console.Clear();
            return pass;
        }
        public static string changePass2()
        {
            Console.WriteLine("YEP ! Your Account Found in Records. ");
            Console.WriteLine("Now You Can Change Your Password ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" Enter New Password ");
            string pass1 = Console.ReadLine();
            return pass1;
        }
        public static void irrelevelntDetails()
        {
            Console.WriteLine("Irrelevent Credentials ");
        }
        public static void Fine1()
        {
            Console.WriteLine("Your time has run out, You have been fined !!");
        }
        public static void Fine2()
        {
            Console.WriteLine("You still have time, you are not fined. ");
        }
        public static void Fine3()
        {
            Console.WriteLine("You have not withdrawn any book.");
        }
    }
}
