using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace ManageAppointments
{

    /// <summary>
    /// The data binding View Model.
    /// </summary>
    public class SchedulerViewModel
    {
        #region Fields

        /// <summary>
        /// team management
        /// </summary>
        private List<string> subjects;


        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class.
        /// </summary>
        public SchedulerViewModel()
        {
            this.subjects = GetSubjects();
            this.IntializeAppoitments();
            this.DisplayDate = DateTime.Now.Date.AddHours(8).AddMinutes(50);
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets or sets appointments.
        /// </summary>
        public ObservableCollection<Appointment>? Events { get; set; }


        /// <summary>
        /// Gets or sets the schedule display date.
        /// </summary>
        public DateTime DisplayDate { get; set; }


        #endregion

        #region Methods


        private List<string> GetSubjects()
        {
            List<string> subjects = new List<string>();
            subjects.AddRange(new List<string>()
            {
                "General Check-Up",
                "Asthma",
                "Diagnostic report",
                "Diabetes",
                "Hypothermia",
                "Angina",
            });

            return subjects;
        }

        /// <summary>
        /// Method to get the colors
        /// </summary>
        /// <returns>Returns the colors collection</returns>
        private Brush GetColor(string eventName)
        {
            if (eventName.Equals("General Check-Up"))
            {
                return new SolidColorBrush(Color.FromArgb("#1000C2"));
            }
            else if (eventName.Equals("Asthma"))
            {
                return new SolidColorBrush(Color.FromArgb("#136154"));
            }
            else if (eventName.Equals("Diagnostic report"))
            {
                return new SolidColorBrush(Color.FromArgb("#6A01F5"));
            }
            else if (eventName.Equals("Diabetes"))
            {
                return new SolidColorBrush(Color.FromArgb("#803500"));
            }
            else if (eventName.Equals("Hypothermia"))
            {
                return new SolidColorBrush(Color.FromArgb("#1D55AA"));
            }
            else if (eventName.Equals("Angina"))
            {
                return new SolidColorBrush(Color.FromArgb("#8800D1"));
            }
            return new SolidColorBrush(Color.FromArgb("#1000C2"));
        }

        /// <summary>
        /// Method to initialize the appointments.
        /// </summary>
        private void IntializeAppoitments()
        {
            this.Events = new ObservableCollection<Appointment>();
            Random random = new();
            List<int> randomTimeCollection = this.GettingTimeRanges();

            DateTime date;
            DateTime dateFrom = DateTime.Now.AddDays(-2);
            DateTime dateTo = DateTime.Now.AddDays(3);
            int i = 0;
            for (date = dateFrom; date < dateTo; date = date.AddDays(1))
            {
                var meeting = new Appointment();
                int hour = randomTimeCollection[random.Next(randomTimeCollection.Count)];
                meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                meeting.To = meeting.From.AddHours(2);
                meeting.EventName = this.subjects.ElementAt(i);
                meeting.Background = this.GetColor(meeting.EventName);
                meeting.Location = this.GetImage(meeting.EventName);
                meeting.IsAllDay = false;
                this.Events.Add(meeting);
                i++;
            }
        }

        private string GetImage(string eventName)
        {
            if (eventName.Equals("General Check-Up"))
            {
                return "checkup.png";
            }
            else if (eventName.Equals("Asthma"))
            {
                return "respiratory.png";
            }
            else if (eventName.Equals("Diagnostic report"))
            {
                return "diagnostic.png";
            }
            else if (eventName.Equals("Diabetes"))
            {
                return "glucose.png";
            }
            else if (eventName.Equals("Hypothermia"))
            {
                return "body.png";
            }
            else if (eventName.Equals("Angina"))
            {
                return "heart.png";
            }
            return "checkup.png";
        }

        /// <summary>
        /// Method for get timing range.
        /// </summary>
        /// <returns>return time collection</returns>
        private List<int> GettingTimeRanges()
        {
            List<int> randomTimeCollection = new()
            {
               10,
               14,
               16
            };

            return randomTimeCollection;
        }



        #endregion
    }
}
