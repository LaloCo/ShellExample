using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellExample
{
    [QueryProperty("Entry", "entry")]
    public partial class SecondaryPage : ContentPage
    {
        public string Entry
        {
            set
            {
                textLabel.Text = Uri.UnescapeDataString(value);
            }
        }

        public SecondaryPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //// Shell.Current.GoToAsync("login");
            Shell.Current.Navigation.PushModalAsync(new LoginPage());
        }
    }
}
