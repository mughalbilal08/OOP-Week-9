using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessApplication_Polymorphism_.BL
{
    class detailBooks : users
    {
        public data objuser;
        private string bookC;
        private string authurC;
        private string bookList;
        private string bookAuthur;
        private string bookPublish;
        private bool widrawBooks;
        public detailBooks()
        {

        }
        public detailBooks(string bookList, string bookAuthur, string bookPublish)
        {
            this.bookList = bookList;
            this.bookAuthur = bookAuthur;
            this.bookPublish = bookPublish;
        }
        public detailBooks(string bookC, string authurC)
        {
            this.bookC = bookC;
            this.authurC = authurC;
        }
        public string getbookC()
        {
            return bookC;
        }
        public void setfines(string bookC)
        {
            this.bookC = bookC;
        }
        public string getauthurC()
        {
            return authurC;
        }
        public void setauhturC(string authurC)
        {
            this.authurC = authurC;
        }
        public string getbookList()
        {
            return bookList;
        }
        public void setbooklist(string bookList)
        {
            this.bookList = bookList;
        }
        public string getbookAuthur()
        {
            return bookAuthur;
        }
        public void setbookauthur(string bookAuthur)
        {
            this.bookAuthur = bookAuthur;
        }
        public string getbookpublish()
        {
            return bookPublish;
        }
        public void setbookPublish(string bookPublish)
        {
            this.bookPublish = bookPublish;
        }
        public bool getbookwidraw()
        {
            return widrawBooks;
        }
        public void setbookwidraw(bool widrawBooks)
        {
            this.widrawBooks = widrawBooks;
        }
        public override string ToString()
        {
            return (bookList + "\t\t" + bookAuthur + "\t\t" + bookPublish);
        }
    }
}
