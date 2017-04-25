using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{

    class TimeSlot
    {
        public DateTime startTimeSlot;
        public TimeSpan slotInterval;
        public int totalTicketsPerSlot;
        //constructor (Start and end time from options menu)

        //get time slot end time (startTimeSlot+SlotInterval)

        public TimeSlot(DateTime startTimeSlot, TimeSpan slotInterval)
        {
            this.startTimeSlot = startTimeSlot;
            this.slotInterval = slotInterval;
            this.totalTicketsPerSlot = 0;
        }
        public DateTime StartTimeSlot
        {
            get
            {
                return startTimeSlot;
            }
            set
            {
                startTimeSlot = value;
            }
        }
        public TimeSpan SlotInterval
        {
            get
            {
                return slotInterval;
            }
            set
            {
                slotInterval = value;
            }
        }
        //number of tickets that have been assigned so far to this slot 
        public int TotalTicketsPerSlot
        {
            get
            {
                return totalTicketsPerSlot;
            }
            set
            {
                totalTicketsPerSlot = value;
            }
        }
        public int endTime
        {
            //working on retrieving from options form to calculate 
           get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }
    }

    }
