using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE.Normal_Classes
{
    class CheckHotelAvailability
    {


        public void CheckhotelAvailability()
        {
            // fetch the hotel details we have 

            Hotel hotel = new Hotel();

            List<Hotel> HotelList = hotel.getHotelDetails();


            Console.WriteLine(" WELCOME TO INNROAD HOTEL BOOKING GUIDE ");

            Console.WriteLine(" PLEASE ENTER YOUR DESTINATION Country ");


            string country = Console.ReadLine();

            // verify weather this country exist in our database

            ErrorVerificationIntf verify = new ErrorVerificationImpl();

            HotelAvailabilityIntf viewhelper = new HotelAvailabilityImpl();

            while (1 == 1)
            {
                if (verify.VerifyCountry(HotelList, country) == true)
                {
                    break;
                }

                else
                {
                    Console.WriteLine(" SORRY THIS COUNTRY DOES NOT EXISTS IN OUR DATABASE ");
                    Console.WriteLine(" FOR YOUR CONVINIENCE LET ME SHOW THE AVAILABLE COUNTRIES ");
                    viewhelper.ShowAllCountries(HotelList);
                }

                Console.WriteLine(" Enter Your Destination Country Now ");

                string inputcountry = Console.ReadLine();

                country = inputcountry;

            }




            Console.WriteLine(" In " + country + " we have Hotels in these States ");



            // Show the cities present in the selected country



            Dictionary<string, int> StateAndCode = viewhelper.ShowStatesInCountry(HotelList, country);

            Console.WriteLine("Enter the State Code where you want to visit ");

            int code = Convert.ToInt32(Console.ReadLine());

            while (1 == 1)
            {
                if (verify.VerifyCode(StateAndCode, code) == true)
                {
                    break;
                }

                else
                {
                    Console.WriteLine(" Sorry this Code does not exists");
                    Console.WriteLine(" Try again");
                }

                code = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("In " + StateAndCode.FirstOrDefault(x => x.Value == code).Key + " We are availablle in the below listed hotels ");

            // Show the available hotels ans the cities where they are

           Dictionary<int,string> hotelandcity =  viewhelper.ShowAvaibleHotelsAndCity(HotelList, StateAndCode.FirstOrDefault(x => x.Value == code).Key);

            Console.WriteLine(" ENTER HOTEL CODE YOU WANT TO EXPLORE  :");

            int hotelcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ENTER Number of persons YOU WANT TO EXPLORE  :");

            int numofpersons = Convert.ToInt32(Console.ReadLine());

           viewhelper.ShowAvailableRooms( HotelList,hotelandcity[hotelcode],numofpersons);










        }  // end






    }
}
