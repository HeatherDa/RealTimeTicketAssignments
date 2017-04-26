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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        public int startTime;
        public int endTime;
        public int timeWindow;
<<<<<<< HEAD
        public int numberOfGuests;
        public int firstTicketNumber;
        public int timeSpan;
        public TicketingSystem ticketingSystem;
=======
        public int guestNumber;
        public int firstTicket;
     //   public TicketingSystem ticketingSystem;
>>>>>>> origin/master

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            //converting start time to int RL
            DateTime dtStart = dtpStartTime.Value;
            string dtStartS = dtStart.Hour.ToString() + dtStart.Minute.ToString() + dtStart.Second.ToString();
            int startTime = Convert.ToInt32(dtStart);
        }

        private void dtpEndTime_ValueChanged(object sender, EventArgs e)
        {
            //converting end time to Int RL
            DateTime dtEnd = dtpEndTime.Value;
            string dtEndS = dtEnd.Hour.ToString() + dtEnd.Minute.ToString() + dtEnd.Second.ToString();
            endTime = Convert.ToInt32(dtEndS);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (endTime <= startTime)
            {
                //Displays error box if end time is before or the same as start time RL
                MessageBox.Show("End time must be later than the start time.", "Time entry error");
                dtpEndTime.Focus();
            }
            //Could do a switch for this instead
            //to include specific field name in error RL
            if (timeWindow == 0 || numberOfGuests == 0 || firstTicketNumber == 0)
            {
                MessageBox.Show("Minutes per window, Guests per window, and first ticket number must be greater than zero",
                    "Error.");
            }
            if (timeSpan > 0)
            {
                string test = Convert.ToString(timeSpan);
                MessageBox.Show(test, ".");
            }
            else
            {
                this.Close();
            }
        }
        private void numMinPerWindow_ValueChanged(object sender, EventArgs e)
        {
            //Convert time Window to int RL
            int timeWindow = Convert.ToInt32(numMinPerWindow);
        }

        private void numGuestsPerWindow_ValueChanged(object sender, EventArgs e)
        {
            //convert number of guests to Int RL
            int guestNumber = Convert.ToInt32(numGuestsPerWindow);
        }

        public int GetTimeSpan()
        {
            timeSpan = endTime - startTime;
            return timeSpan;

        }
        //divide TimeSpan between start and end by numMinPerWindow and create timeslot object for each of the resulting intervals.  Store these obejects in a collection

        /*
        DateTime startTimeSlot = DateTime.Now;
        DateTime endTimeSlot = startTimeSlot.AddHours(4);
        int minutesPerWindow = 5;
        ticketingSystem.createList(startTimeSlot, endTimeSlot, minutesPerWindow);
        */
    }

}
