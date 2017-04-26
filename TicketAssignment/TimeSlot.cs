using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{

    class TimeSlot
    {
        public DateTime startTimeSlot { get; set; }
        public string slotInterval { get; set; }
        public int totalTicketsPerSlot { get; set; }
        

        public TimeSlot(DateTime startTimeSlot, string slotInterval)//start time and interval from options form
        {
            this.startTimeSlot = startTimeSlot;
            this.slotInterval = slotInterval;
            this.totalTicketsPerSlot = 0;
            this.endTime = endTime;
        }
       
        public DateTime endTime//calculate end time
        {
            //working on retrieving from options form to calculate 
           get
            {
                return endTime;
            }
            set
            {
                endTime = startTimeSlot.AddMinutes(double.Parse(slotInterval));
            }
        }
    }

}
