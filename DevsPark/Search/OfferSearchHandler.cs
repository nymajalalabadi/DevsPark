using DevsPark.Services.OffersService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsPark.Search
{
    public class OfferSearchHandler :  SearchHandler
    {
        public OfferSearchHandler()
        {
            var services = Application.Current.MainPage.
                Handler.MauiContext.Services.GetService<OffersService>();

            ItemsSource = services.Offers;
        }
    }
}
