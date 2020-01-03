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
    public partial class CallDetailPage : ContentPage
    {
        CallDetailPageViewModel viewModel { get; set; }

        public CallDetailPage(string Name, string img, string content, List<string> CallLogs)
        {
            InitializeComponent();
            BindingContext = viewModel = new CallDetailPageViewModel();
            ProfileImage.Source = img;
            MyName.Text = Name;
            Status.Text = content;
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Maroon;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            viewModel.call = CallLogs;
        }
    }
}