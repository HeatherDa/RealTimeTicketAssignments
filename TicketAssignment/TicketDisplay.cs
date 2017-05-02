using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAssignment
{
    public partial class TicketDisplay : Form
    {
        private TicketingSystem ticketingSystem;
        private Options options;
       


        public TicketDisplay(TicketingSystem ticketingSystem, Options options)
        {
            InitializeComponent();
            this.ticketingSystem = ticketingSystem;
            this.options = options;

        }
        private void TicketDisplay_Load(object sender, EventArgs e)
        {

            List<TimeSlot> availableTimes = ticketingSystem.showAvailablTimeSlots();


            foreach (TimeSlot slot in availableTimes)
            {

                cboTimeSlots.Items.Add(slot);
            }

        }
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            //gets user selected time slot
            TimeSlot selectedTimeSlot = (TimeSlot) cboTimeSlots.SelectedItem;
            //sends selected to method in ticketing system

            ticketingSystem.IssueOneTicket(selectedTimeSlot);
            displayActiveTickets();
            numberOfOutstandingTickets();


        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();

        }


        //displays active tickets in the list box
        private void numberOfOutstandingTickets()
        {
            List<Ticket> outs = ticketingSystem.getOutstandingTickets();
            int outing = outs.Count;
            lblOutstandingTotal.Text = Convert.ToString(outing);
        }
        private void displayActiveTickets()
        {
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(ticketingSystem.IssueTicket.ToArray());
            //need to sort list
        }
        
    }
}
