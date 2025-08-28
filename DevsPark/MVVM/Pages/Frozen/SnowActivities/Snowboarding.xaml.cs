using DevsPark.MVVM.ViewModels;
using DevsPark.Utilities;

namespace DevsPark.MVVM.Pages.Frozen.SnowActivities;

public partial class Snowboarding : ContentPage
{
    public Snowboarding(PlacesViewModel viewModel)
    {
        InitializeComponent();

        viewModel.SetCurrentPlace(this.GetName());
        BindingContext = viewModel;
    }
}