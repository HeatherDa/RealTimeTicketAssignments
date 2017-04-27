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
        public TicketDisplay()
        {
            InitializeComponent();
            ticketingSystem = new TicketingSystem();
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            TimeSlot selectedTimeSlot = (TimeSlot) cboTimeSlots.SelectedItem;

            ticketingSystem.IssueOneTicket(selectedTimeSlot);
            //stores current ticket number
            //when each ticket is issued, +1 to ticketCounter.
            //method to add ticket info
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

            // show to user, user selects a timeslot...

            // get the selected TimeSlot from the combo box


            // now we now which one it is!
        }
        
    }
}
