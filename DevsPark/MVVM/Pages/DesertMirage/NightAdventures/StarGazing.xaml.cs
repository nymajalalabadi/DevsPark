using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.DesertMirage.NightAdventures;

public partial class StarGazing : ContentPage
{
    public StarGazing(PlacesViewModel viewModel)
    {
        InitializeComponent();

        viewModel.SetCurrentPlace(this.GetName());
        BindingContext = viewModel;
    }
}