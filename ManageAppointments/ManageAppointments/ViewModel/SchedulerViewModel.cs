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

        /// <summary>
        /// color collection
        /// </summary>
        private List<Brush> colors;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerViewModel" /> class.
        /// </summary>
        public SchedulerViewModel()
        {
            this.subjects = GetSubjects();
            this.colors = GetColors();
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
                "Follow-up Consultation",
                "Diagnostic Test Review",
                "Hypertension",
                "Heart operation",
                "Angina",
                "Rheumatic heart disease",
            });

            return subjects;
        }

        /// <summary>
        /// Method to get the colors
        /// </summary>
        /// <returns>Returns the colors collection</returns>
        private List<Brush> GetColors()
        {
            List<Brush> colors = new List<Brush>();
            colors.AddRange(new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#FF8B1FA9")),
                new SolidColorBrush(Color.FromArgb("#FFD20100")),
                new SolidColorBrush(Color.FromArgb("#FFFC571D")),
                new SolidColorBrush(Color.FromArgb("#FF36B37B")),
                new SolidColorBrush(Color.FromArgb("#FF3D4FB5")),
                new SolidColorBrush(Color.FromArgb("#FFE47C73")),
                new SolidColorBrush(Color.FromArgb("#FF85461E")),
                new SolidColorBrush(Color.FromArgb("#FF0F8644")),
            });
            return colors;
        }

        /// <summary>
        /// Method to initialize the appointments.
        /// </summary>
        private void IntializeAppoitments()
        {
            this.Events = new ObservableCollection<Appointment>();
            Random randomTime = new();
            List<Point> randomTimeCollection = this.GettingTimeRanges();

            DateTime date;
            DateTime dateFrom = DateTime.Now.AddDays(-15);
            DateTime dateTo = DateTime.Now.AddDays(15);

            for (date = dateFrom; date < dateTo; date = date.AddDays(3))
            {
                for (int additionalAppointmentIndex = 0; additionalAppointmentIndex < 1; additionalAppointmentIndex++)
                {
                    var meeting = new Appointment();
                    int hour = randomTime.Next((int)randomTimeCollection[additionalAppointmentIndex].X, (int)randomTimeCollection[additionalAppointmentIndex].Y);
                    meeting.From = new DateTime(date.Year, date.Month, date.Day, hour, 0, 0);
                    meeting.To = meeting.From.AddHours(2);
                    meeting.EventName = this.subjects[randomTime.Next(this.subjects.Count)];
                    meeting.Background = this.colors[randomTime.Next(this.colors.Count)];
                    meeting.Location = "health.png";
                    meeting.IsAllDay = false;
                    this.Events.Add(meeting);
                }
            }
        }

        /// <summary>
        /// Method for get timing range.
        /// </summary>
        /// <returns>return time collection</returns>
        private List<Point> GettingTimeRanges()
        {
            List<Point> randomTimeCollection = new()
            {
                new Point(9, 11),
                new Point(12, 14),
                new Point(15, 17)
            };

            return randomTimeCollection;
        }

        

        #endregion
    }
}
