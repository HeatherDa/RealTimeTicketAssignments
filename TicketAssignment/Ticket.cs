using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAssignment
{
    public class Ticket
    {
        public int ticketNumber;
        public TimeSlot timeSlotAssigned;
        public string ticketText;
        //constructor method
        public Ticket(TimeSlot time)
        {
            this.ticketNumber = newNumber();
            this.timeSlotAssigned = time;
            //makes a  string for the listbox
            ticketText = "Ticket " + ticketNumber + ": " + timeSlotAssigned;
            
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





    }

}
