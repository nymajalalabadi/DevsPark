using DevsPark.MVVM.Models;
using DevsPark.Services.OffersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.Search
{
    public class OfferSearchHandler : SearchHandler
    {
        public OfferSearchHandler()
        {
            var services = Application.Current.MainPage.
                Handler.MauiContext.Services.GetService<OffersService>();

            Suggestions = services.Offers;

            ItemsSource = Suggestions;
        }

        public List<Offer> Suggestions { get; set; } = new List<Offer>();

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = Suggestions;
            }
            else
            {
                ItemsSource = Suggestions.Where(o => o.OfferName.ToLower().Contains(newValue.ToLower())).ToList();
            }
        }
    }
}
