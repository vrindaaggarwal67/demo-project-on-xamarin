using ProjectApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ProjectApplication.Views
{
    class SettingsViewModel : BaseViewModel
    {
        private ObservableCollection<SettingsList> _settingItems = new ObservableCollection<SettingsList>();
        public ObservableCollection<SettingsList> settingItems
        {
            get { return _settingItems; }
            set { SetProperty(ref _settingItems, value); }
        }



        public SettingsViewModel()
        {
            getList();
        }

        private void getList()
        {
            SettingsList it1 = new SettingsList();
            it1.SettingName = "Account";
            it1.SettingDescription = "Privacy, security, change number";
            it1.SettingImage = "SecurityKey.png";
            settingItems.Add(it1);
            SettingsList it2 = new SettingsList();
            it2.SettingName = "Chats";
            it2.SettingDescription = "Backup, history, wallpaper";
            it2.SettingImage = "chat.png";
            settingItems.Add(it2);
            SettingsList it3 = new SettingsList();
            it3.SettingName = "Notifications";
            it3.SettingDescription = "Message, group & call tones";
            it3.SettingImage = "notificationSetting.png";
            settingItems.Add(it3);
            SettingsList it4 = new SettingsList();
            it4.SettingName = "Data and storage usage";
            it4.SettingDescription = "Network usage, auto-download";
            it4.SettingImage = "dataStorage.png";
            settingItems.Add(it4);
            SettingsList it5 = new SettingsList();
            it5.SettingName = "Help";
            it5.SettingDescription = "FAQ, contact us, privacy policy";
            it5.SettingImage = "questionmark.png";
            settingItems.Add(it5);

        }

    }
}
