using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Net.Http;
using static WeatherApp.Models.WeatherItemModel;

namespace WeatherApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _navigationService;

        public DelegateCommand NavToCheckCitiesPageCommand { get; set; }

        private string _buttonText;
        public string ButtonText
        {
            get { return _buttonText; }
            set { SetProperty(ref _buttonText, value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavToCheckCitiesPageCommand = new DelegateCommand(NavToCheckCitiesPage);

            Title = "Weather Application with Prism";
            ButtonText = "Add Name";
        }

        private async void NavToCheckCitiesPage()
        {
            await _navigationService.NavigateAsync("CheckCitiesPage");
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

