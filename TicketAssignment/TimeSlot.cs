using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{
    //represents one slot
    public class TimeSlot
    {
        public DateTime startTimeSlot { get; set; }
        public int slotInterval { get; set; }
        public int totalTicketsIssuedPerSlot { get; set; }
        

        public TimeSlot(DateTime startTimeSlot, int slotInterval)//start time and interval from options form
        {
            this.startTimeSlot = startTimeSlot;
            this.slotInterval = slotInterval;
            this.totalTicketsIssuedPerSlot = 0;

        }
       //time each time slot ends
        public DateTime endTime//calculate end time
        {
            //working on retrieving from options form to calculate 
           get
            {
                return endTime;
            }

        }
        //allows list to be displayed as text
        public override string ToString()
        {
           string TimeSlot =  String.Format("{0:t}", startTimeSlot);
           return TimeSlot;
        }
    }

}
/////using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TicketAssignment
//{
//    //represents one slot
//    public class TimeSlot
//    {
//        //    public DateTime startTimeSlot { get; set; }
//        //    public int slotInterval { get; set; }
//        //    public int totalTicketsIssuedPerSlot { get; set; }


//        // Declares variables
//        public int slotNumber;
//        public int numberGuests;
//        private string theStartTime;
//        public DateTime startTime;
//        public DateTime endTime;
//        public int firstTicket;
//        public int ticketsIssued;
//        public int lastTicket;
//        public int outstandingTickets;

//        public TimeSlot() { }


//        public TimeSlot(string minutes, string guests, string start, string end, string first, int total)
//        {
//            // Constructor
//            slotNumber = Convert.ToInt32(minutes);
//            numberGuests = Convert.ToInt32(guests);
//            startTime = Convert.ToDateTime(start);
//            endTime = Convert.ToDateTime(end);
//            firstTicket = Convert.ToInt32(first);
//            lastTicket = firstTicket + (numberGuests - 1);
//            outstandingTickets = total;
//        }

//        //public TimeSlot(DateTime startTimeSlot, int slotInterval)//start time and interval from options form
//        //{
//        //    this.startTimeSlot = startTimeSlot;
//        //    this.slotInterval = slotInterval;
//        //    this.totalTicketsIssuedPerSlot = 0;

//        //}
//        //time each time slot ends


//        public void addTicket()
//        {
//            //incrementing accumulators
//            ticketsIssued += 1;
//            outstandingTickets += 1;
//        }




//        public DateTime EndTime//calculate end time
//        {
//            //working on retrieving from options form to calculate 
//            get
//            {
//                return endTime;
//            }

//        }

//        public string TheStartTime
//        {
//            // Setter
//            set
//            {
//                theStartTime = value;
//            }
//        }
//        //allows list to be displayed as text

//    }

//}
