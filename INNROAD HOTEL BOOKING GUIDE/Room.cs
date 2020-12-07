using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INNROAD_HOTEL_BOOKING_GUIDE
{
    class Room
    {
        public int  nunberofperson;
        public int cost;
        int vacantrooms;
       public Room (int numberofperson,int cost,int vacantrooms)
        {
            this.nunberofperson = numberofperson;
            this.cost = cost;
            this.vacantrooms = vacantrooms;

        }

        


    }
}
