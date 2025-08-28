using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.DesertMirage.NightAdventures;

public partial class NightDuneBuggy : ContentPage
{
    public NightDuneBuggy(PlacesViewModel viewModel)
    {
        InitializeComponent();

        viewModel.SetCurrentPlace(this.GetName());
        BindingContext = viewModel;
    }
}