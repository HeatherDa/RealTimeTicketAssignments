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

        public Ticket(int prevTicket, TimeSlot time)
        {
            this.ticketNumber = newNumber(prevTicket);
            this.timeSlotAssigned = time;
        }

        private int newNumber(int prevTicket)
        {
            return prevTicket+1;
        }
    }

}
