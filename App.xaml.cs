using Microsoft.Extensions.DependencyInjection;

namespace iOSShellFlyoutBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var vm = new AppShellViewModel();
            return new Window(new AppShell(vm));
        }
    }
}