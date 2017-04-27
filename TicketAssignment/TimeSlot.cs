using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{
    //represents one slot
    class TimeSlot
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

        public String toString()
        {
            return startTimeSlot.ToString();
        }
    }

}
