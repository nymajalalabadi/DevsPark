using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DevsPark.MVVM.Models;
using DevsPark.Services.OffersService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.MVVM.ViewModels
{
    public partial class OffersViewModel : ObservableObject
    {
        private readonly OffersService offersService;

        public OffersViewModel(OffersService _offersService)
        {
            offersService = _offersService;
        }

        [ObservableProperty]
        ObservableCollection<Offer> offers;

        string companyName = "Company Name";


        [RelayCommand]
        public async Task Back()
        {
            await Shell.Current.DisplayAlert("Back pressed", "Back pressed", "OK");
        }
    }
}
