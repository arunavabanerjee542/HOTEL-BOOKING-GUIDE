using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    interface HotelAvailabilityIntf
    {
        Dictionary<String, int> ShowStatesInCountry(List<Hotel> h,string country);

        void ShowAllCountries(List<Hotel> h);

        Dictionary<int,string> ShowAvaibleHotelsAndCity(List<Hotel> h, String country);

    }
}
