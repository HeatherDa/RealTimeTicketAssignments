using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssignment
{
    public class Ticket
    {
        public int ticketNumber;
        public TimeSlot timeSlotAssigned; 
        //constructor method
        public Ticket(TimeSlot time)
        {
            this.ticketNumber = newNumber();
            this.timeSlotAssigned = time;
        }


        public static void setNextTicketNumber(int sTicket)
        {
            nextTicketNumber = sTicket;
        }

        private static int nextTicketNumber = 1;

        private static int newNumber()
        {
            // returns current value, increments afterwards
            return nextTicketNumber++;
        }

        public override string ToString()
        {
            return "Ticket " + ticketNumber + ": " + timeSlotAssigned;
        }




    }

}
