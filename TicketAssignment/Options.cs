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

        public string[] optionList;
        public Options()
        {
            InitializeComponent();
            
            ticketingSystem = new TicketingSystem();
            ticketDisplay = new TicketDisplay(ticketingSystem, this);

            Timer showTime = new Timer();
            showTime.Interval = 500;
             //showTime.Tick += new EventHandler(showTime_tick);
            showTime.Start();
            //this.Text = DateTime.Now.ToString("HH:mm:ss"); 

            // Default values
            txtMinutes.Text = (5).ToString();
            txtGuests.Text = (5).ToString();
            txtStart.Text = DateTime.Now.ToShortTimeString();
            txtEnd.Text = (DateTime.Now.AddHours(4)).ToShortTimeString();
            txtTicketNumber.Text = (1).ToString();

        }

        public int startTime;
        public int endTime;
        public int timeWindow;
        public int numberOfGuests;
        public int firstTicketNumber;
        private TicketingSystem ticketingSystem;
        private TicketDisplay ticketDisplay;

    


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Exception handler
            try
            {
                // Validates inputs before proceeding further
                if (goodDataCheck(txtMinutes, "The Minutes field", 1) && goodDataCheck(txtGuests, "The Number of Allowed Guests field", 1) && goodDataCheck(txtStart, "The Start Time", 2) && goodDataCheck(txtEnd, "The End Time", 2) && goodDataCheck(txtGuests, "The First Ticket Number field", 1))
                //&& checkDateDiff(Convert.ToDateTime(txtStart), Convert.ToDateTime(txtEnd), Convert.ToInt32(txtMins)))
                {
                    // Compiles textbox values in a list for referencing
                    makeOptionList(txtMinutes.Text, txtGuests.Text, txtStart.Text, txtEnd.Text, txtTicketNumber.Text);
                    ticketingSystem.setUp(this.Start, this.End, this.minutes, numberOfGuests, firstTicketNumber);
                    



                    this.Hide();
                    
                    ticketDisplay.Show();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unknown error has occurred");
            }
        }

        private void makeOptionList(string mins, string guests, string start, string end, string first)
        {
            // Converts specific values for incrementing then combines provided values in an array
            string startStart = start.ToString();
            start = Convert.ToDateTime(start).AddMinutes(5).ToString();
            string[] tempList = { mins, guests, start, end, first, startStart };
            optionList = tempList;
        }


          private bool goodDataCheck(TextBox textboxv, string namev, byte type)
        {   // type 1 = int; type 2 = datetime

            // Validates inputs and returns message if fails
            if (!isPresent(textboxv, namev))
            {
                //MessageBox.Show(namev + " is empty still");
                return false;
            }
            switch (type)
            {
                case 1:
                    if (!isInt(textboxv, namev))
                    {
                        //MessageBox.Show(namev + " is not an integer");
                        return false;
                    }
                    break;
                case 2:
                    DateTime datevalue;
                    if (!DateTime.TryParse(textboxv.Text, out datevalue))
                    {
                        MessageBox.Show(namev + " is not a valid time value");
                        return false;
                    }
                    break;
            }
            return true;
        }

        private bool isPresent(TextBox vtextbox, string vname)
        {
            // Checks if textbox is empty or not
            if (vtextbox.Text == "")
            {
                MessageBox.Show(vname + " is empty. Please fill it in!", "Missing Entry");
                vtextbox.Focus();
                return false;
            }
            return true;
        }

        private bool isInt(TextBox vtextbox, string vname)
        {
            // Checks if textbox value can be converted correctly
            int number = 0;
            if (Int32.TryParse(vtextbox.Text, out number))
                return true;
            else
            {
                MessageBox.Show(vname + " Please enter a number!", "Invalid Entry");
                vtextbox.Focus();
                return false;
            }
        }

        private bool checkDateDiff(DateTime start, DateTime end, int interval)
        {
            // Checks if provided times allow for at least 2 intervals
            var diff = end.Subtract(start.AddMinutes(interval * 2)).TotalMinutes;
            //TimeSpan diff = end - (start.AddMinutes(interval * 2));
            if (diff < 0)
            {
                MessageBox.Show("The End Time must allow for at least 2 timeslots.");
                return false;
            }
            return true;
        }




        private void showTime_tick(object sender, EventArgs e)
        {

            Text = "-Options- " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DateTime End
        {
            get
            {
                return Convert.ToDateTime(txtEnd.Text);
            }
        }
        public int minutes
        {
            get
            {
                return Convert.ToInt32(txtMinutes.Text);
            }
        }
        public DateTime Start
        {
            get
            {
                return Convert.ToDateTime(txtStart.Text);
            }
        }


    }


}
