using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Xamarin.Lab.PrismNavigation.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";


            this.OnGoView1 = new DelegateCommand(() =>
              {
                  NavigationParameters datas = new NavigationParameters();
                  datas.Add("data1", new MyDataItem() { Value="100" });
                  datas.Add("data2", "456");
                  this.NavigationService.NavigateAsync("View1Page?id=123", datas);
              });
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            var mode= parameters.GetNavigationMode();
            var backValue = parameters.GetValue<string>("dataBack");
        }

        public ICommand OnGoView1 { get; set; }
    }

    public class MyDataItem
    {
        public string Value { get; set; }
    }
}
