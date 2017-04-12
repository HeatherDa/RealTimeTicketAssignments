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

        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {

        }
        //Minutes per window has numericUpDown control (verify not 0)
        //Guests per window has numbericUpDown control (verify not 0)
        //start and end time textboxes (need to validate time format)
        //first ticket number is numericUpDown control (verify not 0)
        //divide TimeSpan between start and end by numMinPerWindow and create timeslot object for each of the resulting intervals.  Store these obejects in a collection
    }
}
