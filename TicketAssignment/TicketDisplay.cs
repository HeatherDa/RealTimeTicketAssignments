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
       

        private void TicketDisplay_Load(object sender, EventArgs e)
        {
            List<TimeSlot> availableTimes = ticketingSystem.showAvailablTimeSlots();
            
            foreach (TimeSlot item in availableTimes)
            {
                
                cboTimeSlots.Items.Add(item);
            }
            
        }
        public TicketDisplay(TicketingSystem ticketingSystem, Options options)
        {
            InitializeComponent();
            this.ticketingSystem = ticketingSystem;
            this.options = options;
            
            
            List<TimeSlot> availableTimes = ticketingSystem.showAvailablTimeSlots();
            foreach (TimeSlot item in availableTimes)
            {
                cboTimeSlots.Items.Add(item);
            }
                
            
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            //gets user selected time slot
            TimeSlot selectedTimeSlot = (TimeSlot) cboTimeSlots.SelectedItem;
            //sends selected to method in ticketing system
            ticketingSystem.IssueOneTicket(selectedTimeSlot);
            displayActiveTickets();
            int outstanding = ticketingSystem.checkHowManyTicketsIssued(5);
            lblOutstandingTotal.Text = Convert.ToString(outstanding);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();

        }

        private void something()
        {

            // set the list of TimeSlots as an array to the combo box as options
            List<TimeSlot> availableTimes = ticketingSystem.showAvailablTimeSlots();
            cboTimeSlots.Items.AddRange(availableTimes.ToArray());


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
