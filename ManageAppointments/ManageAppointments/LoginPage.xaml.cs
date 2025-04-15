using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManageAppointments
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (this.loginForm != null && App.Current?.Windows[0].Page != null)
            {
                if (this.loginForm.Validate())
                {
                    App.Current.Windows[0].Page = new NavigationPage();
                    App.Current.Windows[0].Page?.Navigation.PushModalAsync(new AppShell());

                }
                else
                {
                    await DisplayAlert("", "Please enter the required details", "OK");
                }
            }

        }

        /// <summary>
        /// Displays an alert dialog to the user.
        /// </summary>
        /// <param name="title">The title of the alert dialog.</param>
        /// <param name="message">The message to display.</param>
        /// <param name="cancel">The text for the cancel button.</param>
        /// <returns>A task representing the asynchronous alert display operation.</returns>
        private new Task DisplayAlert(string title, string message, string cancel)
        {
            return App.Current?.Windows?[0]?.Page!.DisplayAlert(title, message, cancel)
                   ?? Task.FromResult(false);
        }
    }
}