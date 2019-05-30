using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellExample
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Shell.Current.Navigation.PopAsync();
            // Shell.Current.Navigation.PopModalAsync();
        }
    }
}
