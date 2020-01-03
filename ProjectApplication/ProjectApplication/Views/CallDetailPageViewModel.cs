using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectApplication.Views
{
    class CallDetailPageViewModel:BaseViewModel
    {
        private List<string> _call = new List<string>();
        public List<string> call
        {
            get { return _call; }
            set { SetProperty(ref _call, value); }
        }



        string _details = string.Empty;
        public string details
        {
            get { return _details; }
            set { SetProperty(ref _details, value); }
        }
    }
}
