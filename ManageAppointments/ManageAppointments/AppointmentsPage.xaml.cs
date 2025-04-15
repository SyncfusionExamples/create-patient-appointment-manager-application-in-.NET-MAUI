using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAppointments
{
	public partial class AppointmentsPage : ContentPage
	{
		public AppointmentsPage()
		{
			InitializeComponent();
            var viewModel = this.BindingContext as SchedulerViewModel;
            var events = viewModel?.Events ?? Enumerable.Empty<Appointment>();

            var upcomingEvents = events
                .Where(x => x.From > DateTime.Now)
                .ToList();

            this.Scheduler.AppointmentsSource = upcomingEvents;
            this.Scheduler.MinimumDateTime = DateTime.Now;
        }

        private void Button_Clicked(object sender, EventArgs e)
		{
			var button = sender as Button;
            var upcomingAppointmentBorder = this.FindByName("UpcomingBorder") as BoxView;
            var pastAppointmentBordeer = this.FindByName("PastBordeer") as BoxView;


            if (button != null && button.Text == "Upcoming appointments")
			{
                var viewModel = this.BindingContext as SchedulerViewModel;
                var events = viewModel?.Events ?? Enumerable.Empty<Appointment>();

                var upcomingEvents = events
                    .Where(appointment => appointment.From > DateTime.Now)
                    .ToList();
                if (upcomingAppointmentBorder !=null)
				{
                    upcomingAppointmentBorder.Color = Color.FromArgb("#512BD4");	
                }
			    if(pastAppointmentBordeer != null)
				{
					pastAppointmentBordeer.Color = Colors.Transparent;

                }
                this.Scheduler.AppointmentsSource = upcomingEvents;
                this.Scheduler.MinimumDateTime = DateTime.Now;
                this.Scheduler.MaximumDateTime = DateTime.Now.AddDays(30);
            }
            else if (button != null && button.Text == "Past appointments")
			{
                var viewModel = this.BindingContext as SchedulerViewModel;
                var events = viewModel?.Events?.OfType<Appointment>() ?? Enumerable.Empty<Appointment>();

                var pastAppointments = events
                    .Where(appointment => appointment.From < DateTime.Now)
                    .ToList();

                if (pastAppointmentBordeer != null)
                {
                    pastAppointmentBordeer.Color = Color.FromArgb("#512BD4");
                }
                if(upcomingAppointmentBorder != null)
                {
                    upcomingAppointmentBorder.Color = Colors.Transparent;

                }
                this.Scheduler.AppointmentsSource = pastAppointments;
                this.Scheduler.MinimumDateTime = DateTime.Now.AddDays(-30);
                this.Scheduler.MaximumDateTime = DateTime.Now;
            }

        }
	}
	}