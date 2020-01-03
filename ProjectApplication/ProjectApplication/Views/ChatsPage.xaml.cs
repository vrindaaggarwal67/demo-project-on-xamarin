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
    public partial class ChatsPage : ContentPage
    {
        ChatPageViewModel viewModel { get; set; }

      
        public ChatsPage(string Name, List<string> ChatList)
        {
            InitializeComponent();
            BindingContext = viewModel = new ChatPageViewModel();
            this.Title = Name;
            
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.Maroon;
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.White;

            viewModel.chat = ChatList;

        }
        private void Send_Clicked(object sender, EventArgs e)
        {
        //    string ele = new string();
        //    ele.content = viewModel.chat;
        //    viewModel.chat.Add(ele);
        //    viewModel.chat = string.Empty;
        }
    }
}