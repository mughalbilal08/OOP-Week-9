using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_lab_9.BL;

namespace week_lab_9.DL
{
    class shapeList
    {
        public static List<shape> List = new List<shape>();
        public static void addIntoList(shape s)
        {
            List.Add(s);
        }
    }
}
