using Plugin.Messaging;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

using Xamarin.Forms.Xaml;

namespace ProjectApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageExample : TabbedPage
    {
        TabbedPage1ViewModel viewModel { get; set; }
        public TabbedPageExample()
        {
            InitializeComponent();
            BindingContext = viewModel = new TabbedPage1ViewModel();
            
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null)
                return;
            Navigation.PushAsync(new ChatsPage(item.Name, item.chats));
        }

        private async void Status_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null)
                return;
           await Navigation.PushAsync(new PopupPageExample(item.Name, item.content, item.img));
        }

        private async void Call_Clicked(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ListItem;
            if (item == null)
                return;
            await Navigation.PushAsync(new CallDetailPage(item.Name, item.img, item.content, item.calls));

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingsPage());
        }

        //private void MakeCall(object sender, ItemTappedEventArgs e)
        //{
        //    var item = e.Item as ListItem;
        //    if (item == null)
        //        return;
        //    var phoneDial = CrossMessaging.Current.PhoneDialer;

        //    if (phoneDial.CanMakePhoneCall)
        //    {
        //       phoneDial.MakePhoneCall(item.PhoneNumber, item.Name);
        //    }
        //}

        

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            
            var phoneDial = CrossMessaging.Current.PhoneDialer;

            if (phoneDial.CanMakePhoneCall)
            {
               phoneDial.MakePhoneCall("9826986262", "neelu gupta");
          }

        }
    }
}