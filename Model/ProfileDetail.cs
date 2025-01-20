using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Proxy.ViewModel;

namespace WPF_Proxy.Model
{
    public class ProfileDetail : BaseViewModel
    {
        private int _ID;
        public int ID { get => _ID; set { _ID = value; OnPropertyChanged(); } }

        private string _Name;
        public string Name { get => _Name; set { _Name = value; OnPropertyChanged(); } }

        private string _API;
        public string API { get => _API; set { _API = value; OnPropertyChanged(); } }

        private string _Location;
        public string Location { get => _Location; set { _Location = value; OnPropertyChanged(); } }

        private string _Protocal;
        public string Protocal { get => _Protocal; set { _Protocal = value; OnPropertyChanged(); } }

        private string _ProxyPublic;
        public string ProxyPublic { get => _ProxyPublic; set { _ProxyPublic = value; OnPropertyChanged(); } }

        private string _LocalProxy;
        public string LocalProxy { get => _LocalProxy; set { _LocalProxy = value; OnPropertyChanged(); } }

        private string _DateOfPurchase;
        public string DateOfPurchase { get => _DateOfPurchase; set { _DateOfPurchase = value; OnPropertyChanged(); } }

        private string _ExpDate;
        public string ExpDate { get => _ExpDate; set { _ExpDate = value; OnPropertyChanged(); } }

        private string _STT;
        public string STT { get => _STT; set { _STT = value; OnPropertyChanged(); } }

    }
}
