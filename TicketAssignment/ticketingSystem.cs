﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TicketAssignment
//{
//    public class TicketingSystem
//    {
//        public List<TimeSlot> TimeSlots;
//        public int numberTicketsPerSlot;

//        public void createList(DateTime startTimeSlot, DateTime endTimeSlot, int minutesPerWindow)
//        {
//            TimeSpan lengthSlot = endTimeSlot.Subtract(startTimeSlot);
//            int minutes = lengthSlot.Minutes;
//            int numberofslots = minutes / minutesPerWindow;
//            TimeSlots = new List<TimeSlot>();

//            for (int x = 0; x < numberofslots; x++)
//            {
//                DateTime adjustedStartTime = startTimeSlot.AddMinutes(minutesPerWindow * x);
//                TimeSlot thing = new TimeSlot(adjustedStartTime, lengthSlot);
//                TimeSlots.Add(thing);
//            }
//        }

//    }
//}
