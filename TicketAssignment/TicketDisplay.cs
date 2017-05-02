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
            updateAvailableTimeSlots();
        }
        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            //gets user selected time slot
            TimeSlot selectedTimeSlot = (TimeSlot) cboTimeSlots.SelectedItem;

            //sends selected to method in ticketing system
            if (selectedTimeSlot != null)
            {
                ticketingSystem.IssueOneTicket(selectedTimeSlot);
                updateAvailableTimeSlots();
                displayActiveTickets();
                numberOfOutstandingTickets();
            }

        }


        private void updateAvailableTimeSlots()
        {
            cboTimeSlots.Items.Clear();
            cboTimeSlots.Items.AddRange(ticketingSystem.showAvailablTimeSlots().ToArray());
            cboTimeSlots.SelectedIndex = 0;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();
        }



        //gets number of outstanding tickets
        private void numberOfOutstandingTickets()
        {
            List<Ticket> outs = ticketingSystem.getOutstandingTickets();
            int outing = outs.Count;
            lblOutstandingTotal.Text = Convert.ToString(outing);
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
