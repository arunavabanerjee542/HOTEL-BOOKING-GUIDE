using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class ErrorVerificationImpl : ErrorVerificationIntf
    {


        public bool VerifyCountry(List<Hotel> h,string country)
        {
            IEnumerable<Hotel> hh = h.Where(x => x.address.country.Equals(country));

            if(hh.Count() >0)
            {
                return true;
            }

            return false;
            
            
        }



        public bool VerifyCode(Dictionary<string, int> CityandCode, int code)
        {
            if(CityandCode.ContainsValue(code))
            {
                return true;
            }

            return false;
        }






    }
}
