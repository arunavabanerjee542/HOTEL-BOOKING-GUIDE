﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE.Normal_Classes
{
    class Logger
    {
       public int Log()
        {
            Console.WriteLine();
            Console.WriteLine(" How can we help you ");
            Console.WriteLine(" 1---> Check out room availability ");
            Console.WriteLine(" 2--> Filter the Hotels based on their price ");
            Console.WriteLine(" 3--> Hotels Grouped By Country and States ");

            int x = Convert.ToInt32(Console.ReadLine());

            return x;
        }

    }
}
