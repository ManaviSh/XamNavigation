using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }
        private static bool _showAnimation = true;
        private static bool ToggleAnimation()
        {
            _showAnimation = !_showAnimation;
            return _showAnimation;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            var viewModel = this.BindingContext as LandingPageViewModel;

            if(viewModel==null)
            {
                return;
            }

            var secondPage = new SecondPage();
            var secondViewModel = secondPage.BindingContext as SecondPageViewModel;

            await Navigation.PushAsync(secondPage, ToggleAnimation());

            secondViewModel.Text = viewModel.Text;
        }
    }
}