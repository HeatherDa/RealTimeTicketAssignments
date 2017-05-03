using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssignment
{
    public class TicketingSystem 
    {
        public int numberOfTicketsAllowedPerSlot;
        public List<TimeSlot> TimeSlots;

        //creates list of time slots based on option selections
        public List<TimeSlot> createList(DateTime startTimeSlot, DateTime endTimeSlot, int minutesPerWindow)
        {
            
            TimeSpan length = endTimeSlot.Subtract(startTimeSlot);
            int minutes = (int) length.TotalMinutes;
            int numberofslots = minutes / minutesPerWindow;
            TimeSlots = new List<TimeSlot>();

            for (int x = 0; x < numberofslots; x++)
            {
                DateTime adjustedStartTime = startTimeSlot.AddMinutes(minutesPerWindow * x);
                
                TimeSlots.Add(new TimeSlot(adjustedStartTime, minutesPerWindow));
                Console.WriteLine();
            }
            
            return TimeSlots;
        }

        public List<Ticket> IssueTicket;

        public TicketingSystem()
        {
            this.IssueTicket = new List<Ticket>();
            this.TimeSlots = new List<TimeSlot>();
        }

        //method will be attached to click handler when user adds ticket 
        public void IssueOneTicket(TimeSlot timeSlot)
        {
            //creates ticket and adds one to the variable storing how many tickets are assigned to each timeslot
            IssueTicket.Add(new Ticket(timeSlot));
            timeSlot.totalTicketsIssuedPerSlot++;

        }

        //takes in all info from options menu
        public void setUp(DateTime startTimeSlot, DateTime endTimeSlot, int minutesPerWindow, int numberOfGuests,
                          int firstTicketNumber)
        {
            createList(startTimeSlot, endTimeSlot, minutesPerWindow);
            Ticket.setNextTicketNumber(firstTicketNumber);
            numberOfTicketsAllowedPerSlot = numberOfGuests;
        }
        //creating a list of available time slots
        public List<TimeSlot> showAvailablTimeSlots()
        {
            List<TimeSlot>AvailableTimeSlots = new List<TimeSlot>();

            for (int x = 0; x < TimeSlots.Count; x++)
            {
                bool ticketsAvailable = TimeSlots[x].totalTicketsIssuedPerSlot < numberOfTicketsAllowedPerSlot;
                bool occursInFuture = TimeSlots[x].startTimeSlot > DateTime.Now;
                if (ticketsAvailable && occursInFuture)
                {
                    AvailableTimeSlots.Add(TimeSlots[x]);
                }

            }

            return AvailableTimeSlots;
        }

        //gets a list of tickets that are outstanding
        public List<Ticket> getOutstandingTickets()
        {
            List<Ticket> OutstandingTickets = new List<Ticket>();

            for (int x = 0; x < IssueTicket.Count; x++)
            {
                Ticket ticket = IssueTicket[x];
                TimeSlot time = ticket.timeSlotAssigned;
                bool ticketOutstanding = time.startTimeSlot > DateTime.Now;
                if (ticketOutstanding)
                    OutstandingTickets.Add(IssueTicket[x]);
            }
            return OutstandingTickets;
        }

        //gets the ticket numbers that are entering the ride
        public List<Ticket> getTicketsBoardingNow()
        {
            List<Ticket> boardingNowTickets = new List<Ticket>();

            for (int x = 0; x < IssueTicket.Count; x++)
            {
                Ticket ticket = IssueTicket[x];
                TimeSlot time = ticket.timeSlotAssigned;
                bool ticketBoardings = time.startTimeSlot <= DateTime.Now;
                bool ticketBoardinge = time.endTime > DateTime.Now;
                if (ticketBoardinge && ticketBoardings)
                {
                    boardingNowTickets.Add(IssueTicket[x]);
                }
            }
            return boardingNowTickets;
        }

    }
}

