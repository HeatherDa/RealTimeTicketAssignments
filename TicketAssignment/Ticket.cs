using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{
    class Ticket
    {
        public int ticketNumber;
        public TimeSlot timeSlotAssigned; 
        //constructor method
        public Ticket(TimeSlot time)
        {
            this.ticketNumber = newNumber();
            this.timeSlotAssigned = time;
        }




        private static int previousTicketNumber = 0;//set to one less than starting number

        private static int newNumber()
        {
            previousTicketNumber++;
            return previousTicketNumber;
        }






    }

}
