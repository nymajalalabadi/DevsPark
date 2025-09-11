using DevsPark.MVVM.ViewModels;

namespace DevsPark.MVVM.Pages;

public partial class OffersView : ContentPage
{
    public OffersView(OffersViewModel offersViewModel)
    {
        InitializeComponent();
        BindingContext = offersViewModel;
    }
}