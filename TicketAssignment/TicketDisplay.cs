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
        int ticketCounter = 0;//increment for calculating current ticket number
        List<TimeSlot> timeSlots = new List<TimeSlot>();
        public TicketDisplay()
        {
            InitializeComponent();
            FillTimeSlots();
        }

        private void FillTimeSlots()
        {
            foreach(TimeSlot t in timeSlots)
            {

                cboTimeSlots.Items.Add(t.startTimeSlot.ToString() +" - "+ t.endTime.ToString());
            }
        }

        private void btnIssueTicket_Click(object sender, EventArgs e)
        {
            //stores current ticket number 
            //when each ticket is issued, +1 to ticketCounter.
            TimeSlot slot = cboTimeSlots.SelectedItem();
            Ticket t = new Ticket(ticketCounter, slot);
            ticketCounter = ticketCounter + 1;
            
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options Options = new Options();
            Options.Show();

        }
    }
}
