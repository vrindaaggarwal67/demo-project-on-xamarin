using ProjectApplication.Views;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ProjectApplication.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private ObservableCollection<CrousalImageViewModel> _CrousalImageList = new ObservableCollection<CrousalImageViewModel>();
        public ObservableCollection<CrousalImageViewModel> CrousalImageList
        {
            get { return _CrousalImageList; }
            set { SetProperty(ref _CrousalImageList, value); }
        }


        public AboutViewModel()
        {
            Title = "About";
            getList();

        }


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