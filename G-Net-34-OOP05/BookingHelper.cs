using G_Net_34_OOP05.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_OOP05
{
    public static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("--- BookingHelper.PrintAll ---");

            foreach (var item in items)
            {
                item.Print();
            }
        }
    }
}
