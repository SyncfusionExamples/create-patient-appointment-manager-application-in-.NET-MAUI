using Microsoft.Maui.Controls;
using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ManageAppointments
{
    public class Appointment
    {
        public Appointment()
        {
            this.From = DateTime.Now;
            this.To = DateTime.Now;
            this.EventName = string.Empty;
            this.IsAllDay = false;
            this.Background = Brush.Transparent;
        }

        /// <summary>
        /// Gets or sets the value to display the start date.
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Gets or sets the value to display the end date.
        /// </summary>
        public DateTime To { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether the appointment is all-day or not.
        /// </summary>
        public bool IsAllDay { get; set; }

        /// <summary>
        /// Gets or sets the value to display the subject.
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Gets or sets the value to display the background.
        /// </summary>
        public Brush Background { get; set; }
    }
}