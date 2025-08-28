using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.Frozen.IcyTreats;

public partial class FrozenDrinksBar : ContentPage
{
    public FrozenDrinksBar(PlacesViewModel viewModel)
    {
        InitializeComponent();

        viewModel.SetCurrentPlace(this.GetName());
        BindingContext = viewModel;
    }
}