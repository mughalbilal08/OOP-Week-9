using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bussinessApplication_Polymorphism_.DL;
using bussinessApplication_Polymorphism_.UI;

namespace bussinessApplication_Polymorphism_.BL
{
    class data : users
    {
        private string reviews;
        private int months;
        private int dates;
        private string fines;
        private string bookBorrow;
        private bool bookWidraw;
        private string userComplaints;
        private bool complaintCheck;
        private bool reviewCheck;
        private string borrowBookName;
        private int datesC;
        private int monthsC;
        public data()
        {

        }
        public data(string name, string password) : base(name, password)
        {

        }
        public data(int dates, int months)
        {
            this.dates = dates;
            this.months = months;

        }
        public string getreview()
        {
            return reviews;
        }
        public void setreview(string reviews)
        {
            this.reviews = reviews;
        }
        public int getmonths()
        {
            return months;
        }
        public void setmonth(int months)
        {
            this.months = months;
        }
        public int getdates()
        {
            return dates;
        }
        public void setdate(int dates)
        {
            this.dates = dates;
        }
        public string getfines()
        {
            return fines;
        }
        public void setfines(string fines)
        {
            this.fines = fines;
        }
        public string getbookborrow()
        {
            return bookBorrow;
        }
        public void setbookborrow(string bookBorrow)
        {
            this.bookBorrow = bookBorrow;
        }
        public string getusercomplaints()
        {
            return userComplaints;
        }
        public void setusercomplaints(string userComplaints)
        {
            this.userComplaints = userComplaints;
        }
        public string getborrowbookname()
        {
            return borrowBookName;
        }
        public void setborrowbookname(string borrowBookName)
        {
            this.borrowBookName = borrowBookName;
        }
        public int getmonthsC()
        {
            return monthsC;
        }
        public void setmonthC(int monthsC)
        {
            this.monthsC = monthsC;
        }
        public int getdatesC()
        {
            return datesC;
        }
        public void setdatesC(int datesC)
        {
            this.datesC = datesC;
        }
        public bool getbookwidraw()
        {
            return bookWidraw;
        }
        public void setbookwidraw(bool bookWidraw)
        {
            this.bookWidraw = bookWidraw;
        }
        public bool getcomplaincheck()
        {
            return complaintCheck;
        }
        public void setcomplaincheck(bool complaintCheck)
        {
            this.complaintCheck = complaintCheck;
        }
        public bool getreviewcheck()
        {
            return reviewCheck;
        }
        public void setreviewcheck(bool reviewCheck)
        {
            this.reviewCheck = reviewCheck;
        }
        public void review1()
        {
            reviews = "Excellent";
            reviewCheck = true;
        }
        public void review2()
        {
            reviews = "Good";
            reviewCheck = true;
        }
        public void review3()
        {
            reviews = "SatisFactory";
            reviewCheck = true;
        }
        public void review4()
        {
            reviews = "UnSatisFactory";
            reviewCheck = true;
        }
        public void review5()
        {
            reviews = "Poor";
            reviewCheck = true;
        }
        public static void fine(ref int date1, ref int month1, ref int currentIndex)
        {
            int sum;
            sum = ((month1 - dataList.adminUser[currentIndex].getmonths()) * 30) + (date1 - dataList.adminUser[currentIndex].getdatesC());
            if (dataList.adminUser[currentIndex].getbookwidraw() == true)
            {
                if (sum >= 90)
                {
                    userUI.Fine1();
                }
                else if (sum < 90)
                {
                    userUI.Fine2();
                }
            }
            else if (dataList.adminUser[currentIndex].getbookwidraw() == false)
            {
                userUI.Fine3();
            }
            mainUI.clear();
        }
        public override string tooString()
        {
            return (name + "\t\t" + password + "\t\t" + roles);
        }
        public override string tostring()
        {
            return (name);
        }
    }
}
