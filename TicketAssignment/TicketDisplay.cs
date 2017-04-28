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

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            //gets user selected time slot
            TimeSlot selectedTimeSlot = (TimeSlot) cboTimeSlots.SelectedItem;
            //sends selected to method in ticketing system
            ticketingSystem.IssueOneTicket(selectedTimeSlot);
            displayActiveTickets();


        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();

        }

        private void something()
        {

            // set the list of TimeSlots as an array to the combo box as options
            cboTimeSlots.Items.AddRange(ticketingSystem.TimeSlots.ToArray());


        }
        //displays active tickets in the list box
        private void displayActiveTickets()
        {
            lstTickets.Items.Clear();
            lstTickets.Items.AddRange(ticketingSystem.IssueTicket.ToArray());
            //need to sort list
        }
        
    }
}
