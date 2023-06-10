using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessApplication_Polymorphism_.UI
{
    class mainUI
    {
        // ############################# MAIN MENU ###############################################

        public static string menu()
        {
            string choice;
            Console.WriteLine(" Press 1 to Sign IN: ");
            Console.WriteLine(" Press 2 to Sign UP: ");
            Console.WriteLine(" Press 3 to Exit: ");
            Console.WriteLine(" Press (1 - 3) to Enter: ");
            choice = Console.ReadLine();
            return choice;
        }


        public static void header()
        {

            Console.WriteLine(""); ;
            Console.WriteLine("              #######################################################################################################################################################################");
            Console.WriteLine("              #                                                                                                                                                                     #");
            Console.WriteLine("              #  $     $  $$$$$$   $$$$$  $$$$$  $$$$$  $    $    $$$$$$$ $$$$$$ $$$$$ $$$$$$ $$$$$$  $$$$$ $$$$$$$ $$$$$ $$$$$ $$$$$    $$$$$$ $    $ $$$$$$ $$$$$ $$$$$  $$$$$$$  #");
            Console.WriteLine("              #  $     $  $     $   $   $  $   $ $    $ $    $    $  $  $ $    $ $   $ $    $ $    $  $     $  $  $ $     $   $   $      $      $    $ $        $   $      $  $  $  #");
            Console.WriteLine("              #  $$    $$ $$$$$$$$ $$$$$$ $$$$$$ $$$$$$ $$$$$$    $$ $  $ $$$$$$ $$  $ $$$$$$ $$      $$$$$ $$ $  $ $$$$$ $$  $   $$     $$$$$$ $$$$$$ $$$$$$   $$  $$$$$  $$ $  $  #");
            Console.WriteLine("              #  $$    $$ $$     $ $$   $ $$   $ $$   $   $$      $$ $  $ $$   $ $$  $ $$   $ $$ $$$$ $$    $$ $  $ $$    $$  $   $$         $$   $$       $$   $$  $$     $$ $  $  #");
            Console.WriteLine("              #  $$$$$ $$ $$$$$$$$ $$   $ $$   $ $$   $   $$      $$ $  $ $$   $ $$  $ $$   $ $$$$$ $ $$$$$ $$ $  $ $$$$$ $$  $   $$     $$$$$$   $$   $$$$$$   $$  $$$$$  $$ $  $  #");
            Console.WriteLine("              #                                                                                                                                                                     #");
            Console.WriteLine("              #######################################################################################################################################################################");
            Console.WriteLine(""); ;
            Console.WriteLine(""); ;
            Console.WriteLine("                                        <><><>---<>---<>---<>---<>---<>---<>---<>---<>---<>---<>----<>---<>---<>---<>---<>---<>----<>----<>---<><><>");
            Console.WriteLine("                                        <><><>---<>---<>---<>---<>---<>---<>---< LIBRARY MANAGEMENT SYSTEM >---<>---<>---<>---<>---<>---<>---<><><>");
            Console.WriteLine("                                        <><><>---<>---<>---<>---<>---<>---<>---<>---<>---<>---<>----<>---<>---<>---<>---<>---<>----<>----<>---<><><>");
            Console.WriteLine(""); ;
        }

        public static void clear()
        {
            Console.WriteLine();
            Console.Write(" Press any Key to Continue ....... ");
            Console.ReadKey();
            Console.Clear();
        }
        public static string complianmenu()
        {
            string option;
            Console.WriteLine(" 1. Submit a Complian");
            Console.WriteLine(" 2. Remove the Complain");
            Console.WriteLine();
            Console.Write(" Enter your choice:");
            option = (Console.ReadLine());
            return option;
        }
        public static string changeUserDetailsMenu()
        {
            string option;
            Console.WriteLine(" 1. To Change Name");
            Console.WriteLine(" 2. To Change Password");
            Console.Write(" Enter your choice:");
            option = Console.ReadLine();
            return option;

        }
        public static void adminNote()
        {
            Console.WriteLine(" ---------------------------------------------------------");
            Console.WriteLine(" | Note: If Your're Admin Enter Only Predefined Admin ID |");
            Console.WriteLine(" ---------------------------------------------------------");
            Console.WriteLine("");
        }
        public static void userinvalid()
        {
            Console.WriteLine(" User is not Present: ");
            Console.WriteLine(" Please enter valid data");
        }
        public static void userV()
        {
            Console.WriteLine(" You Have Entered Data Wrong data 5-times, We are going to sign-in page again ");
        }
        public static void adminW()
        {
            Console.WriteLine("Welcome to Admin Interface");
        }
        public static void userW()
        {
            Console.WriteLine("Welcome to User Interface");
        }
        public static void udataL()
        {
            Console.WriteLine("Users Has Been Loaded ");
        }
        public static void udataNotL()
        {
            Console.WriteLine("Users Data Not Found ");
        }
        public static void BdataL()
        {
            Console.WriteLine("Books Has Been Loaded ");
        }
        public static void BdataNotL()
        {
            Console.WriteLine("Books Data Not Found ");
        }
    }
}
