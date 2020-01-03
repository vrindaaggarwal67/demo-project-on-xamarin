using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomePageViewModel viewModel { get; set; }

    public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new HomePageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new LoginPage());
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}