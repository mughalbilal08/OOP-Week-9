using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_lab_9.BL
{
    class shape
    {
        public virtual string toString()
        {
            return (" ");
        }
    }
    class reactangle : shape
    {
        private double width;
        private double height;
        private double area;
        public reactangle()
        {

        }
        public reactangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double getArea()
        {
            area = width * height;
            return area;
        }
        public override string toString()
        {
            return ("The shape is Rectangle and its area is " + getArea());
        }
    }
    class cirrcle : shape
    {
        private double radius;
        public cirrcle()
        {

        }
        public cirrcle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return (2 * Math.PI * Math.Pow(radius, 2));
        }
        public override string toString()
        {
            return ("The shape is Circle and its area is " + getArea());
        }
    }
    class square : shape
    {
        private double side;
        public square()
        {

        }
        public square(double side)
        {
            this.side = side;
        }
        public double getArea()
        {
            return (Math.Pow(side, 2));
        }
        public override string toString()
        {
            return ("The shape is Square and its area is " + getArea());
        }
    }
}
