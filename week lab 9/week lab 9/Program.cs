using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_lab_9.BL;
using week_lab_9.DL;
using week_lab_9.UI;
namespace week_lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // t1();
            // t2();
            // t3();
            // t4();
        }
        public static void t1()
        {
            cylinder obj1 = new cylinder();
            cylinder obj2 = new cylinder(2);
            cylinder obj3 = new cylinder(3, 3, "red");
            obj2.setHeight(5);
            double volume = obj2.getVolume();
            Console.WriteLine("VOlume is: " + volume);
            Console.ReadKey();

        }
        public static void t2()
        {
            student objS = new student("Bilal", "Bilal Street", "BSCS", 2022, 80000);
            student objS1 = new student();
            objS1.setName("Abdullah");
            objS1.setAddress("Wahdat Road");
            objS1.setPorgram("BSCS");
            objS1.setYear(2022);
            objS1.setFee(590000);
            staff objS2 = new staff("Bilal", "Bilal Street", "Dastagir School", 10000);
            staff objS3 = new staff();
            objS3.setName("Ali");
            objS3.setAddress("Walton Road");
            objS3.setSchool("FootPath");
            objS3.setPay(0);
            Console.WriteLine(objS.toString());
            Console.WriteLine(objS1.toString());
            Console.WriteLine();
            Console.WriteLine(objS2.toString());
            Console.WriteLine(objS3.toString());
            Console.ReadKey();
        }
        public static void t3()
        {
            List<animal> list = new List<animal>();
            cat objC = new cat("Simba");
            cat objC1 = new cat("Lucy");
            dog d = new dog();
            dog objD = new dog("Tommy");
            dog objD1 = new dog("Jenny");
            list.Add(objC);
            list.Add(objC1);
            list.Add(objD);
            list.Add(objD1);
            foreach (animal a in list)
            {
                Console.WriteLine(a.toString());
                a.greets();
                a.greet(d);
            }
            Console.ReadKey();
        }
        public static void t4()
        {
            reactangle r = shapeUserCRUD.takeinput();
            shapeList.addIntoList(r);
            cirrcle c = shapeUserCRUD.takeInputC();
            shapeList.addIntoList(c);
            square s = shapeUserCRUD.takeInputS();
            shapeList.addIntoList(s);
            reactangle r1 = shapeUserCRUD.takeinput();
            shapeList.addIntoList(r1);
            cirrcle c1 = shapeUserCRUD.takeInputC();
            shapeList.addIntoList(c1);
            shapeUserCRUD.view();
            Console.ReadKey();

        }
    }
}
