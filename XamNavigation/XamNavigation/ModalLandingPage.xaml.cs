﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalLandingPage : ContentPage
    {
        public ModalLandingPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new LandingPage()));
        }
    }
}