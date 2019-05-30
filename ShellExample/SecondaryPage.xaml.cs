using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellExample
{
    public partial class SecondaryPage : ContentPage
    {
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
