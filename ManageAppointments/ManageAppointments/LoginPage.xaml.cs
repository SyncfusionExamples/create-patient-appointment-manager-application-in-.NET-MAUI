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
            if (this.loginForm != null && App.Current?.MainPage != null)
            {
              // if (this.loginForm.Validate())
                {
                    App.Current.MainPage = new NavigationPage();
                    App.Current.MainPage.Navigation.PushAsync(new AppShell());

                }
                //else
                //{
                //    await App.Current.MainPage.DisplayAlert("", "Please enter the required details", "OK");
                //}
            }
                
        }
    }
}