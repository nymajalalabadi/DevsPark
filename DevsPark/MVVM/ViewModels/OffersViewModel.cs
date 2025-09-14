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
    //[QueryProperty("CompanyName", "name")]
    public partial class OffersViewModel : ObservableObject, IQueryAttributable
    {
        private readonly OffersService offersService;
         
        public OffersViewModel(OffersService _offersService)
        {
            offersService = _offersService;
        }

        [ObservableProperty]
        ObservableCollection<Offer> offers;


        [ObservableProperty]
        string companyName = "Company Name";



        [RelayCommand]
        public async Task Back()
        {
            await Shell.Current.DisplayAlert("Back pressed", "Back pressed", "OK");
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (!query.ContainsKey("offers"))
            {
                var companyId = query["id"].ToString();

                CompanyName = Uri.UnescapeDataString(query["name"].ToString());

                offers = new ObservableCollection<Offer>(offersService.GetOffers(int.Parse(companyId)));
            }

            else
            {
                offers = query["offers"] as ObservableCollection<Offer>;
            }

        }
    }
}
