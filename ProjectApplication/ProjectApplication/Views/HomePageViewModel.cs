using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectApplication.Views
{
    class HomePageViewModel:BaseViewModel
    {

        private ObservableCollection<CrousalImageViewModel> _CrousalImageList = new ObservableCollection<CrousalImageViewModel>();
        public ObservableCollection<CrousalImageViewModel> CrousalImageList
        {
            get { return _CrousalImageList; }
            set { SetProperty(ref _CrousalImageList, value); }
        }

        public  HomePageViewModel() { getList(); }
        private void getList()
        {
            CrousalImageList = new ObservableCollection<CrousalImageViewModel>();
            var count = 3;
            for (int i = 1; i <= count; i++)
            {
                CrousalImageViewModel hgm = new CrousalImageViewModel();
                hgm.ImageUrl = string.Format("img{0}.png", i);
                hgm.Position = i;
                CrousalImageList.Add(hgm);
            }
        }
    }
}
