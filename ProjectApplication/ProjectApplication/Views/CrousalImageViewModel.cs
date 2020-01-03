using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectApplication.Views
{
    public class CrousalImageViewModel : BaseViewModel
    {

        private string _ImageUrl;
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { SetProperty(ref _ImageUrl, value); }
        }
        private int _Position;
        public int Position
        {
            get { return _Position; }
            set { SetProperty(ref _Position, value); }
        }
        public CrousalImageViewModel()
        {
        }
    }
}
