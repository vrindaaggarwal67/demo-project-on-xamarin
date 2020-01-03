using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectApplication.Views
{
    class ChatPageViewModel:BaseViewModel
    {
        private List<string> _chat = new List<string>();
        public List<string> chat
        {
            get { return _chat; }
            set { SetProperty(ref _chat, value); }
        }



        string _msg = string.Empty;
        public string msg
        {
            get { return _msg; }
            set { SetProperty(ref _msg, value); }
        }


    }
}
