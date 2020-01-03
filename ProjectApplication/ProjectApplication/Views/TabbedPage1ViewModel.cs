using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ProjectApplication.Views
{
    class TabbedPage1ViewModel : BaseViewModel
    {
        private ObservableCollection<ListItem> _statusItems = new ObservableCollection<ListItem>();
        public ObservableCollection<ListItem> statusItems
        {
            get { return _statusItems; }
            set { SetProperty(ref _statusItems, value); }
        }


       
        public TabbedPage1ViewModel()
        {
            getList();
        }

        private void getList()
        {
            ListItem it1 = new ListItem();
            it1.Name = "Jenifer";
            it1.content = "Hey! Let's go out in the evening.";
            it1.img = "photo1.jfif";
            it1.Time = "Yesterday,10:30 pm";
            it1.PhoneNumber = "6848915848";
            it1.chats = new List<string>();
            string msg1 = "Hey! Let's go out in the evening.";
            it1.chats.Add(msg1);
            string msg2 = "Are you there?";
            it1.chats.Add(msg2);
            it1.calls = new List<string>();
            string call1 = "today";
            it1.calls.Add(call1);
            string call2 = "yesterday";
            it1.calls.Add(call2);
            statusItems.Add(it1);

            ListItem it2 = new ListItem();
            it2.Name = "Sezal";
            it2.content = "Hey! Let's go out in the evening.";
            it2.img = "photo2.jpg";
            it2.Time = "Yesterday,1:30 pm";
            it2.PhoneNumber = "6848915898";
            it2.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it2.chats.Add(msg1);
            msg2 = "Are you there?";
            it2.chats.Add(msg2);
            it2.calls = new List<string>();
            call1 = "today";
            it2.calls.Add(call1);
            call2 = "yesterday";
            it2.calls.Add(call2);
            statusItems.Add(it2);

            ListItem it3 = new ListItem();
            it3.Name = "Rocky";
            it3.content = "Hey! Let's go out in the evening.";
            it3.img = "photo3.jfif";
            it3.Time = "Yesterday,2:30 pm";
            it3.PhoneNumber = "6048915848";
            it3.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it3.chats.Add(msg1);
            msg2 = "Are you there?";
            it3.chats.Add(msg2);
            it3.calls = new List<string>();
            call1 = "today";
            it3.calls.Add(call1);
            call2 = "yesterday";
            it3.calls.Add(call2);
            statusItems.Add(it3);

            ListItem it4 = new ListItem();
            it4.Name = "Naira";
            it4.content = "Hey! Let's go out in the evening.";
            it4.img = "photo1.jfif";
            it4.Time = "Yesterday,10:03 pm";
            it4.PhoneNumber = "6848910848";
            it4.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it4.chats.Add(msg1);
            msg2 = "Are you there?";
            it4.chats.Add(msg2);
            it4.calls = new List<string>();
            call1 = "today";
            it4.calls.Add(call1);
            call2 = "yesterday";
            it4.calls.Add(call2);
            statusItems.Add(it4);

            ListItem it5 = new ListItem();
            it5.Name = "Riya";
            it5.content = "Hey! Let's go out in the evening.";
            it5.img = "photo2.jfif";
            it5.Time = "Yesterday,11:30 pm";
            it5.PhoneNumber = "6848916748";
            it5.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it5.chats.Add(msg1);
            msg2 = "Are you there?";
            it5.chats.Add(msg2);
            it5.calls = new List<string>();
            call1 = "today";
            it5.calls.Add(call1);
            call2 = "yesterday";
            it5.calls.Add(call2);
            statusItems.Add(it5);

            ListItem it6 = new ListItem();
            it6.Name = "Rishabh";
            it6.content = "Hey! Let's go out in the evening.";
            it6.img = "photo3.jfif";
            it6.Time = "Yesterday,3:30 pm";
            it6.PhoneNumber = "6848565848";
            it6.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it6.chats.Add(msg1);
            msg2 = "Are you there?";
            it6.chats.Add(msg2);
            it6.calls = new List<string>();
            call1 = "today";
            it6.calls.Add(call1);
            call2 = "yesterday";
            it6.calls.Add(call2);
            statusItems.Add(it6);

            ListItem it7 = new ListItem();
            it7.Name = "Ebani";
            it7.content = "Hey! Let's go out in the evening.";
            it7.img = "photo1.jfif";
            it7.Time = "Yesterday,5:30 am";
            it7.PhoneNumber = "6834915848";
            it7.chats = new List<string>();
            msg1 = "Hey! Let's go out in the evening.";
            it7.chats.Add(msg1);
            msg2 = "Are you there?";
            it7.chats.Add(msg2);
            it7.calls = new List<string>();
            call1 = "today";
            it7.calls.Add(call1);
            call2 = "yesterday";
            it7.calls.Add(call2);
            statusItems.Add(it7);
        }


    }
}
