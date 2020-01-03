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
    public partial class LoginPage : ContentPage
    {
        LoginPageViewModel viewModel { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new LoginPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
           

        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            if( viewModel.Email != "vrinda.aggarwal@rediffmail.com")
            {
                DisplayAlert("Oops!","your e-mail address is not registered with us", "ok");
            }
            else if(viewModel.Password != "12345")
            {
                DisplayAlert("Oops!", "Password is incorrect", "ok");
            }
            else
            {
                //Navigation.PushAsync(new TabbedPageExample());
                App.Current.MainPage = new NavigationPage(new TabbedPageExample());


            }

        }
    }
}