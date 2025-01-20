using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_Proxy.Model;

namespace WPF_Proxy.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<ProfileDetail> _Profiles;
        public ObservableCollection<ProfileDetail> Profiles
        {
            get => _Profiles;
            set
            {
                _Profiles = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            LoadCommand();
            FirstLoad();
        }
        public ICommand PauseProfile_CMD { get; set; }
        void LoadCommand()
        {
            PauseProfile_CMD = new RelayCommand<ProfileDetail>((p) => { return p != null && Profiles != null && Profiles.Contains(p); }, (p) => { PauseProfile(p); });
        }
        void FirstLoad()
        {
            Add500Row();
        }
        void Add500Row()
        {
            StartTask(() => {
                for (int i = 0; i < 1; i++)
                {
                    int val = i;
                    CreateProfile(val + "");
                }
            }, null, null);
        }
        ProfileDetail CreateProfile(string profileName = null)
        {
            if (Profiles == null)
            {
                Profiles = new ObservableCollection<ProfileDetail>();
            }
            var profile = new ProfileDetail() { Name = profileName, STT = "Created" };
            Application.Current.Dispatcher.InvokeAsync(new Action(() =>
            {
                Profiles.Add(profile);
                UpdateProfileIndex();
            }));

            return profile;
        }
        void UpdateProfileIndex()
        {
            if (Profiles == null || Profiles.Count == 0)
            {
                return;
            }
            int i = 0;
            foreach (var item in Profiles)
            {
                item.ID = ++i;
            }
        }
        async void PauseProfile(ProfileDetail p)
        {
            if (await p.PauseTask())
            {
                p.STT = "Paused";
            }
        }
    }
}
