using INNROAD_HOTEL_BOOKING_GUIDE.Normal_Classes;
using INNROAD_HOTEL_BOOKING_GUIDE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE.MyFactory
{
    static class Factory
    {
        static public CheckHotelAvailability GetCheckHotelAvailablity()
        {
            return new CheckHotelAvailability();
        }

        static public Logger getLogger()
        {
            return new Logger();
        }

        static public Hotel getHotel()
        {
            return new Hotel();
        }


        static public  GetSortedViewImpl GetSortedViewImplObj()
        {
            return new GetSortedViewImpl();
            
        }


    }
}
