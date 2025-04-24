using Microsoft.Maui.Controls;
using Syncfusion.Maui.Scheduler;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Resources;

namespace ManageAppointments
{
    public class Appointment : INotifyPropertyChanged
    {
        private DateTime from;
        private DateTime to;
        private bool isAllDay;
        private string eventName;
        private Brush background;
        public string location = string.Empty;
        public Appointment()
        {
            this.from = DateTime.Now;
            this.to = DateTime.Now;
            this.eventName = string.Empty;
            this.isAllDay = false;
            this.background = Brush.Transparent;
        }

        /// <summary>
        /// Gets or sets the value to display the start date.
        /// </summary>
        public DateTime From
        {
            get
            { return this.from; }
            set { this.from = value;
                this.OnPropertyChanged(nameof(From));
            }  
        }

        /// <summary>
        /// Gets or sets the value to display the end date.
        /// </summary>
        public DateTime To
        {
            get { return this.to; } 
            set { this.to = value;
                this.OnPropertyChanged(nameof(To));
            }   
        }

        /// <summary>
        /// Gets or sets the value indicating whether the appointment is all-day or not.
        /// </summary>
        public bool IsAllDay
        {
            get { return this.isAllDay; }
            set { this.isAllDay = value;
                this.OnPropertyChanged(nameof(IsAllDay));
            }
        }

        /// <summary>
        /// Gets or sets the value to display the subject.
        /// </summary>
        public string EventName
        {
            get { return this.eventName; }
            set { this.eventName = value; }
        }

        /// <summary>
        /// Gets or sets the value to display the background.
        /// </summary>
        public Brush Background
        {
            get { return this.background; }
            set { this.background = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}