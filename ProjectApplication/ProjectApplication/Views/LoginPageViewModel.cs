using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectApplication.Views
{
    public class LoginPageViewModel : BaseViewModel
    {
        private string _Email  = string.Empty;


        public string Email
        {
            get { return _Email; }
            set { SetProperty(ref _Email, value); }
        }
        private string _Password = string.Empty;


        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }
    }
}
