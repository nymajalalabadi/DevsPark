using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.Frozen.SnowActivities;

public partial class IceSculptures : ContentPage
{
    public IceSculptures(PlacesViewModel viewModel)
    {
        InitializeComponent();

        viewModel.SetCurrentPlace(this.GetName());
        BindingContext = viewModel;
    }
}