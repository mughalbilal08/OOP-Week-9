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
    class detailBooksList
    {
        public static List<detailBooks> bookDetail = new List<detailBooks>();

        public static detailBooks takeBookFromList(int x)
        {
            return bookDetail[x];
        }
        public static int returnBookCount()
        {
            return bookDetail.Count;
        }
        public static void addIntoBookList(detailBooks s)
        {
            bookDetail.Add(s);
        }

        //  File Handling

        public static bool loadData1()
        {
            int index = 0;
            string line;
            string path = "bookData.txt";
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path);
                while ((line = myFile.ReadLine()) != null)
                {
                    detailBooks objdata = new detailBooks();
                    objdata.setbooklist(dataList.getfield(line, 1));
                    objdata.setbookPublish(dataList.getfield(line, 2));
                    objdata.setbookauthur(dataList.getfield(line, 3));
                    index++;
                    addIntoBookList(objdata);

                }
                myFile.Close();
                return true;
            }
            return false;
        }
        public static void saveData1()
        {
            string path = "bookData.txt";
            StreamWriter myFile = new StreamWriter(path, false);
            for (int x = 0; x < bookDetail.Count; x++)
            {
                myFile.Write(bookDetail[x].getbookList() + ",");
                myFile.Write(bookDetail[x].getbookpublish() + ",");
                myFile.WriteLine(bookDetail[x].getbookAuthur());
            }

            myFile.Close();
        }

        //    Functions

        public static void AddintoBookList(detailBooks b)
        {
            bookDetail.Add(b);
        }
        public static bool searchBooks(detailBooks b)
        {
            bool isCheck = false;
            for (int index = 0; index < bookDetail.Count; index++)
            {
                if (b.getbookC() == bookDetail[index].getbookList() && b.getauthurC() == bookDetail[index].getbookAuthur())
                {

                    isCheck = true;
                    break;
                }
            }
            return isCheck;
        }
        public static bool checkRbooks(ref string remove, ref string auhtor)
        {
            bool valid = false;
            for (int index = 0; index < bookDetail.Count; index++)
            {
                if (remove == bookDetail[index].getbookList() && auhtor == bookDetail[index].getbookAuthur())
                {

                    bookDetail.RemoveAt(index);
                    valid = true;
                    break;
                }

            }
            return valid;
        }
        public static bool booksWidraw(detailBooks c, data d)
        {
            for (int index = 0; index < bookDetail.Count; index++)
            {
                if (c.getbookC() == bookDetail[index].getbookList() && c.getauthurC() == bookDetail[index].getbookAuthur())
                {
                    bookDetail.RemoveAt(index);
                    d.setbookwidraw(true);
                    d.setborrowbookname(c.getbookC());
                    return true;
                }
            }
            return false;
        }
        public static void issueDates(data d, data dataM)
        {
            dataM.setdate(d.getdates());
            dataM.setmonth(d.getmonths());
        }
        public static void addBooks()
        {
            int size = adminUI.bookS();
            for (int i = 0; i < size; i++)
            {
                adminUI.inputBooks();
            }
            adminUI.bookAddShow();
        }
        public static void viewBooks()
        {
            adminUI.viewBooksInterFace();
            foreach (detailBooks b in bookDetail)
            {
                adminUI.toStringInput(b);
            }
        }
    }
}
