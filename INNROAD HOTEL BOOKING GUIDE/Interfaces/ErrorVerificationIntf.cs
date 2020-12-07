using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    interface ErrorVerificationIntf
    {
       bool VerifyCountry(List<Hotel> hotels,string country);

        bool VerifyCode(Dictionary<string, int> CityandCode, int code);

    }
}
