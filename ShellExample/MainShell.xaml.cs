using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellExample
{
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("login", typeof(LoginPage));
        }
    }
}
