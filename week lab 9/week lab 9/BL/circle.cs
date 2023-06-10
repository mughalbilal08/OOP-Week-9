using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_lab_9.BL
{
    class circle
    {
        protected double radius = 1.0;
        protected string color = "red";
        protected double area;
        public circle()
        {

        }
        public circle(double radius)
        {
            this.radius = radius;
        }
        public circle(double radius, string color)
        {

        }
        public double getradius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            area = 2 * Math.Pow(radius, 2) * Math.PI;
            return area;
        }
        public string toString()
        {
            return "Radius: " + radius + " Color: " + color + " Area : " + area;
        }
    }
    class cylinder : circle
    {
        private double height = 1.0;
        private double volume;
        public cylinder()
        {

        }
        public cylinder(double radius)
        {
            this.radius = radius;
        }
        public cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public cylinder(double radius, double height, string color)
        {
            this.radius = radius;
            this.height = height;
            this.color = color;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            volume = (2 * Math.PI * radius * height);
            return volume;
        }
    }
}
