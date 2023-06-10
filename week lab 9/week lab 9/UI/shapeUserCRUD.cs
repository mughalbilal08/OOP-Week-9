using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_lab_9.BL;
using week_lab_9.DL;

namespace week_lab_9.UI
{
    class shapeUserCRUD
    {
        public static reactangle takeinput()
        {
            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());
            reactangle objR = new reactangle(width, height);
            return objR;
        }
        public static square takeInputS()
        {
            Console.Write("Enter Side: ");
            double side = double.Parse(Console.ReadLine());
            square objS = new square(side);
            return objS;
        }
        public static cirrcle takeInputC()
        {
            Console.Write("Enter Radius: ");
            double rad = double.Parse(Console.ReadLine());
            cirrcle objC = new cirrcle(rad);
            return objC;
        }
        public static void view()
        {
            foreach (shape v in shapeList.List)
            {
                Console.WriteLine(v.toString());
            }
        }
    }
}
