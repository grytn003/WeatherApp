using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Xamarin.Forms;
using System.ComponentModel;

namespace WeatherApp.ViewModels
{
    public class MapsPageViewModel : BindableBase, INotifyPropertyChanged, INavigationAware
    {
        INavigationService _navigationService;

        



        public MapsPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}