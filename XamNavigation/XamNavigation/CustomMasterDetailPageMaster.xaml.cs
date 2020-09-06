using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public CustomMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new CustomMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CustomMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CustomMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public CustomMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<CustomMasterDetailPageMasterMenuItem>(new[]
                {
                    new CustomMasterDetailPageMasterMenuItem { Id = 0, Title = "Landing Page", TargetType = typeof(LandingPage) },
                    new CustomMasterDetailPageMasterMenuItem { Id = 1, Title = "Modal Page", TargetType = typeof(ModalLandingPage) },
                    new CustomMasterDetailPageMasterMenuItem { Id = 2, Title = "Tabbed Page", TargetType = typeof(CustomTabbedPage) },
                    //new CustomMasterDetailPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    //new CustomMasterDetailPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}