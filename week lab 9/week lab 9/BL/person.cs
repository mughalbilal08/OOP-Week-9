using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_lab_9.BL
{
    class person
    {
        protected string name;
        public string address;
        public person()
        {

        }
        public person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public virtual string toString()
        {
            return ("Name: " + name + "Address: " + address);
        }
    }
    class student : person
    {
        private string program;
        private int year;
        private double fee;
        public student()
        {

        }
        public student(string name, string address, string program, int year, double fee)
        {
            this.name = name;
            this.address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return program;
        }
        public void setPorgram(string program)
        {
            this.program = program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public override string toString()
        {
            return ("Name: " + name + " Address: " + address + " Program: " + program + " Fee: " + fee + " Year: " + year);
        }
    }
    class staff : person
    {
        private string school;
        private double pay;
        public staff()
        {

        }
        public staff(string name, string address, string school, double pay)
        {
            this.name = name;
            this.address = address;
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            return ("Name: " + name + " Address: " + address + " School: " + school + " Pay: " + pay);
        }
    }
}
