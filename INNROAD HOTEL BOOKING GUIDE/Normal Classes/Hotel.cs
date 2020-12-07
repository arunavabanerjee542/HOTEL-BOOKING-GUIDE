using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class Hotel
    {
        public string name { get; set; }

        public List<Room> rooms;

        public Address address { get; set; }

        public Hotel()
        {

        }

        public Hotel(string name, Address address)
        {
            
            this.name = name;
            this.address = address;
        }


        public List<Hotel> getHotelDetails()
        {
            List<Hotel> hotellist = new List<Hotel>();
          Hotel h1 = new Hotel(" TAJ ", new Address(" Mg road ", "Mumbai", "Maharashtra", "India", 713334));
            h1.rooms = new List<Room>()
            {
                new Room(1,1000,40),
                new Room(2,1800,50),
                new Room(3,2100,61),
                new Room(4,3000,20)

            };

            Hotel h2 = new Hotel(" Asansol Inn ", new Address(" Bose road ", "Kolkata", "West Bengal", "India", 713335));
            h2.rooms = new List<Room>()
            {
                new Room(1,2000,54),
                new Room(2,3800,47),
                new Room(3,4100,57),
                new Room(4,7300,78)

            };

            Hotel h3 = new Hotel(" ITC ", new Address("Tagore road ", "Chennai", "Tamil Nadu", "India", 713335));
            h3.rooms = new List<Room>()
            {
                new Room(1,2000,100),
                new Room(2,3800,79),
                new Room(3,4100,8),
                new Room(4,7300,14),
                new Room(5,9000,1)

            };

            Hotel h4 = new Hotel(" CAVALLO POINT LODGE ", new Address(" Austin road ", "San Francisco", "New York", "USA", 033335));
            h4.rooms = new List<Room>()
            {
                new Room(1,8000,11),
                new Room(2,9800,0),
                new Room(3,10100,33),
                new Room(4,11300,22)

            };

            Hotel h5 = new Hotel(" Hotel Carvaan ", new Address(" Rao road ", "Pune", "Maharashtra", "India", 033335));
            h5.rooms = new List<Room>()
            { 
                new Room(1,8000,21),
                new Room(2,9800,78),
                new Room(3,10100,4),
                new Room(4,11300,7)

            };
            Hotel h6 = new Hotel(" Annapurna Bhawan", new Address(" Rajiv Ganghi salai ", "Chennai", "Tamil Nadu", "India", 033335));
            h6.rooms = new List<Room>()
            {
                new Room(1,8000,78),
                new Room(2,9800,12),
                new Room(3,10100,4),
                new Room(4,11300,87)

            };
            Hotel h7 = new Hotel(" CAVALLO POINT LODGE ", new Address(" Austin road ", "San Francisco ", "New York", "USA", 033335));
            h7.rooms = new List<Room>()
            {
                new Room(1,8000,7),
                new Room(2,9800,96),
                new Room(3,10100,78),
                new Room(4,1130,12)

            };

            Hotel h8 = new Hotel(" Royal House ", new Address(" Rabindra Sarobar ", "Kolkata", "West Bengal", "India", 033335));
            h8.rooms = new List<Room>()
            {
                new Room(1,8000,0),
                new Room(2,9800,0),
                new Room(3,10100,7),
                new Room(4,11300,7)

            };


            hotellist.Add(h1);
            hotellist.Add(h2);
            hotellist.Add(h3);
            hotellist.Add(h4);
            hotellist.Add(h5);
            hotellist.Add(h6);
            hotellist.Add(h7);
            hotellist.Add(h8);


            return hotellist;



        }




        public int getAverageCost()
        {
            return 0;
        }




    }
}
