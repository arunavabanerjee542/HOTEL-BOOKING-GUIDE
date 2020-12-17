using INNROAD_HOTEL_BOOKING_GUIDE.MyFactory;
using INNROAD_HOTEL_BOOKING_GUIDE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE.Services
{
    class GetSortedViewImpl : GetSortedViewIntf
    {


        public void SortedView()
        {
            Console.WriteLine(" ENTER THE DESTINATION COUNTRY NAME ");
            string country = Console.ReadLine();

            var h = Factory.getHotel().getHotelDetails();


            IEnumerable<Hotel> hotels = h.Where(x => x.address.country == country);

            var dict = Factory.getHotel().getAverageCost(hotels);

            foreach(KeyValuePair<string,int> d in dict)
            {
                Console.WriteLine(d.Key + " ---> " + d.Value +"/person");
            }

           


        }


        public void GroupedView()
        {

            var h = Factory.getHotel().getHotelDetails();

           var res = h.GroupBy(x => new
            {
                x.address.country,
                x.address.state
            }
            );


            foreach(var  x in res)
            {
                Console.WriteLine(" Country :" + x.Key.country );

                Console.WriteLine();
                Console.WriteLine(" State --> :" + x.Key.state);
                Console.WriteLine();
                foreach(var i in x)
                {
                    Console.WriteLine("Hotel Name---> " +i.name + " " + " City ---> "+ i.address.city + " ");

                    foreach(var r in i.rooms)
                    {
                        Console.WriteLine( "Persons --- > " + r.nunberofperson +" " + " Rooms Available -----> " +r.vacantrooms+" " + "   Price/day ---> "+ r.cost);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }



              
        }








    }


}