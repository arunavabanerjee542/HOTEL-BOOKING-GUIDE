using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class Address
    {
        public string road;
        public string city;
        public string state;
        public string country;
        public int pin;

        public Address(string road, string city, string state,string country,int pin)
        {
            this.city = city;
            this.country = country;
            this.state = state;
            this.pin = pin;
            this.road = road;
        }

    }
}
