using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssignment
{
    class TicketingSystem
    {
        public List<TimeSlot>TimeSlots;
        public int numberTicketsPerSlot;

        public void createList(DateTime startTimeSlot, DateTime endTimeSlot, int minutesPerWindow)
        {
            TimeSpan lengthSlot = endTimeSlot.Subtract(startTimeSlot);
            int minutes = lengthSlot.Minutes;
            int numberofslots = minutes / minutesPerWindow;
            TimeSlots = new List<TimeSlot>();

            for (int x = 0; x < numberofslots; x++)
            {
                DateTime adjustedStartTime = startTimeSlot.AddMinutes(minutesPerWindow * x);
                TimeSlot thing = new TimeSlot(adjustedStartTime, minutes);
                TimeSlots.Add(thing);
            }


        }



        public List<Ticket> IssueTicket;

        public TicketingSystem()
        {
            this.IssueTicket = new List<Ticket>();
        }
        //method will be attached to click handler when user adds ticket 
        public void IssueOneTicket(TimeSlot timeSlot)
        {

            Ticket stuffs = new Ticket(timeSlot);
            IssueTicket.Add(stuffs);
            timeSlot.totalTicketsIssuedPerSlot++;

        }

    }
}

