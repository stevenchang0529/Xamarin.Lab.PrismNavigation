using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace Xamarin.Lab.PrismNavigation.ViewModels
{
    public class View1PageViewModel : ViewModelBase
    {
        public ICommand OnBack { get; set; }
        public View1PageViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.Title = "View1";
            this.OnBack = new DelegateCommand(() =>
              {
                  NavigationParameters datas = new NavigationParameters();
                  datas.Add("dataBack", "789");
                  this.NavigationService.GoBackAsync(datas);
              });
        }

        public override void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            var id= parameters.GetValue<string>("id");
            var data1 = parameters.GetValue<MyDataItem>("data1");
            var data2 = parameters.GetValue<string>("data2");
        }
    }
}
