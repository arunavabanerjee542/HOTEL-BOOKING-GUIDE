using INNROAD_HOTEL_BOOKING_GUIDE.MyFactory;
using INNROAD_HOTEL_BOOKING_GUIDE.Normal_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class Program
    {
        static void Main(string[] args)
        {

            var check = Factory.GetCheckHotelAvailablity();

            var logger = Factory.getLogger();

            var sortedview = Factory.GetSortedViewImplObj();
        


            while (1 == 1)
            {
                int choice = logger.Log();

                switch (choice)
                {

                    case 1:
                        check.CheckhotelAvailability();
                        break;

                    case 2:
                        sortedview.SortedView();
                        break;


                }

            }



            




            





        }
    }
}
