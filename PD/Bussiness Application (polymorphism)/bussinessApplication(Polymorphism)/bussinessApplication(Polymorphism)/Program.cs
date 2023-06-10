using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinessApplication_Polymorphism_.BL;
using bussinessApplication_Polymorphism_.DL;
using bussinessApplication_Polymorphism_.UI;

namespace bussinessApplication_Polymorphism_
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentIndex = 0;
            string option = " ";
            int n2;
            bool check = dataList.loadData();
            if (check)
            {
                mainUI.udataL();
            }
            else
            {
                mainUI.udataNotL();
            }
            Console.ReadKey();

            bool check1 = detailBooksList.loadData1();
            if (check1)
            {
                mainUI.BdataL();
            }
            else
            {
                mainUI.BdataNotL();
            }
            Console.ReadKey();

            // ############################################## MAIN FUNCTION ###########################################################

            while (option != "3")
            {
                string role = "";
                Console.Clear();
                mainUI.header();
                n2 = 1;
                option = mainUI.menu();

                if (option == "1")
                {

                    for (int x = 0; x < 6; x++)
                    {
                        Console.Clear();
                        mainUI.header();
                        mainUI.adminNote();

                        data obja = adminUI.signINInput();
                        role = dataList.signin(obja, ref currentIndex);
                        Console.WriteLine(role);
                        Console.Read();

                        if (role == "Invalid")
                        {
                            mainUI.userinvalid();
                            continue;
                        }
                        if (role == "admin" || role == "student")
                        {
                            break;
                        }

                        if (x >= 5)
                        {
                            n2 = 0;
                            break;
                        }

                    }

                    if (n2 == 0)
                    {
                        mainUI.clear();
                        mainUI.userV();
                        continue;
                    }

                    while (true)
                    {

                        if (role == "admin")
                        {
                            Console.Clear();
                            mainUI.adminW();
                            Console.ReadKey();
                            adminUI.adminMenu(ref currentIndex);
                            break;
                        }

                        else if (role == "student")
                        {
                            Console.Clear();
                            mainUI.userW();
                            Console.ReadKey();
                            userUI.userMenu(ref currentIndex);
                            Console.ReadKey();
                            break;
                        }
                    }

                }

                else if (option == "2")
                {

                    Console.Clear();
                    mainUI.header();
                    userUI.SignUpInput();
                }

                else if (option == "3")
                {
                    dataList.saveData();
                    detailBooksList.saveData1();

                }

            }
        }
    }
}
