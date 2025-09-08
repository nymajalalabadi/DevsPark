using DevsPark.MVVM.ViewModels;
using System.Diagnostics;

namespace DevsPark.MVVM.Pages;

public partial class AppShell : Shell
{
	public AppShell(PlacesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);

        Debug.WriteLine($"--- A navigation was performed: {args.Source}, " +
            $"from {args.Previous?.Location} to {args.Current?.Location}");

    }

    protected override void OnNavigating(ShellNavigatingEventArgs args)
	{
		base.OnNavigating(args);

		Debug.WriteLine($"--- A navigation is about to be performed: {args.Source}, " +
			$"to {args.Target.Location}");

	}
}