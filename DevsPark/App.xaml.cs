using DevsPark.MVVM.Pages;

namespace DevsPark
{
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;

        public App(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();

            RegisterRoutes();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(_serviceProvider.GetRequiredService<AppShell>());
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("//featuredView", typeof(FeaturedView));
        }
    }
}