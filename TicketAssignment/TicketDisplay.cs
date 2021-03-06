﻿using System;
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

            Timer showTime = new Timer();
            showTime.Interval = 1000;
            showTime.Tick += new EventHandler(showTime_tick);
            showTime.Start();
        }

        private Timer updateTicketsTimer;
        private void TicketDisplay_Load(object sender, EventArgs e)
        {

            //updateAvailableTimeSlots();


            updateAvailableTimeSlots();
            List<TimeSlot> timeSlots = ticketingSystem.showAvailablTimeSlots();
            if (timeSlots.Count > 0)
            {
                updateTicketsTimer = new Timer();
                updateTicketsTimer.Interval = (int) ticketingSystem.showAvailablTimeSlots()[0].startTimeSlot.Subtract(DateTime.Now).TotalMilliseconds;
                updateTicketsTimer.Tick += new EventHandler(updateAllTheThings);
                updateTicketsTimer.Start();
                Console.Write(updateTicketsTimer.Interval);
            }
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
        //This is probably where we need to fix the deleting problem if we don't want it to do that-
        //shows available ticket slots, and deletes when max number of tickets issued
    
        private void updateAvailableTimeSlots()
        {
            cboTimeSlots.Items.Clear();
            cboTimeSlots.Items.AddRange(ticketingSystem.showAvailablTimeSlots().ToArray());
            if (cboTimeSlots.Items.Count > 0)
            {
                cboTimeSlots.SelectedIndex = 0;
            }
            else
            {
                cboTimeSlots.SelectedIndex = -1;
                cboTimeSlots.ResetText();
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //Displays Dialog prompting confirmation to return to options menu
            DialogResult dialogResult = MessageBox.Show("This will erase all ticketing information and start a new session. " +
                "Are you sure you would like to proceed?", "Close form?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Options Options = new Options();
                Options.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
       
        }

        //gets number of outstanding tickets
        private void numberOfOutstandingTickets()
        {
            List<Ticket> outs = ticketingSystem.getOutstandingTickets();
            int outing = outs.Count;
            lblOutstandingTotal.Text = Convert.ToString(outing);
        }

        private void nextTimeSlot()
        {
            lblNextEntryTime.Text = Convert.ToString(ticketingSystem.showAvailablTimeSlots()[0]);
        }
        //gets boarding now tickets and puts them in the form
        private void boardingNowTickets()
        {
            lblBoardingNow.Text = "";
            List<Ticket> boarding = ticketingSystem.getTicketsBoardingNow();
            string boardingTickets = "";
            foreach (Ticket item in boarding)
            {
                boardingTickets += item.ticketNumber + " ";
            }
            lblBoardingNow.Text = boardingTickets;

        }
        //displays active tickets in the list box
        private void displayActiveTickets()
        {
            lstTickets.Items.Clear();
            List<Ticket> sorted = ticketingSystem.sortIt();
            lstTickets.Items.AddRange(sorted.ToArray());
        }
        private void showTime_tick(object sender, EventArgs e)
        {
            Text = String.Format("{0:T}", DateTime.Now);
        }
        //updates tickets based on timer intervals
        private void updateAllTheThings(object sender, EventArgs e)
        {
            updateAvailableTimeSlots();
            displayActiveTickets();
            numberOfOutstandingTickets();
            boardingNowTickets();
            nextTimeSlot();

            // update timer
            List<TimeSlot> timeSlots = ticketingSystem.showAvailablTimeSlots();
            if (timeSlots.Count > 0)
            {
                updateTicketsTimer.Interval = 60000 * (ticketingSystem.showAvailablTimeSlots()[0].slotInterval);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
