using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class HotelAvailabilityImpl : HotelAvailabilityIntf
    {
        public void ShowAllCountries(List<Hotel> h)
        {

            IEnumerable<String> countries = h.Select(x => x.address.country).Distinct();

            foreach( string s in countries)
            {
                Console.WriteLine(s);
            }

        }




        // shows the cities and their codes

        public Dictionary<String, int> ShowStatesInCountry(List<Hotel> h,string country)
        {
           IEnumerable<Hotel> hotel =  h.Where(x => x.address.country == country);
            Dictionary<String, int> StateandCode = new Dictionary<string, int>();

            int code = 1;

            Console.WriteLine("CITY " + "--> " + " CODE");
            Console.WriteLine();
            foreach (Hotel hh in hotel)
            {
                if (!StateandCode.ContainsKey(hh.address.state))
                {
                    StateandCode.Add(hh.address.state, code);

                    Console.WriteLine(hh.address.state + " --> " + code);
                    code++;
                }
            }

            return StateandCode;
            
        }




        public Dictionary<int,string> ShowAvaibleHotelsAndCity(List<Hotel> h , string state)
        {
            IEnumerable<Hotel> hotels = h.Where(x => x.address.state == state);

            Dictionary<int, string> dict = new Dictionary<int, string>();

            Console.WriteLine(hotels.Count());
            int hotelcode = 0;

            foreach(Hotel x in hotels)
            {
                
                Console.WriteLine(x.name + " ---> " + x.address.city + " --> "+ hotelcode);
                dict.Add(hotelcode, x.name);
                hotelcode++;

            }

            return dict;

        }

        public void ShowAvailableRooms(List<Hotel> h, string hotelname, int numofpersons)
        {
           IEnumerable<Hotel> hotel = h.Where(x => (x.name == hotelname) && (x.rooms[numofpersons-1].vacantrooms !=0));
        
            foreach(Hotel hh in hotel)
            {
                Console.WriteLine("In " + hh.name + " " + hh.rooms[numofpersons-1].vacantrooms + " Rooms are available for " + numofpersons+ " persons" );
            }
        }
    }
}
