namespace iOSShellFlyoutBinding
{
    public partial class AppShell : Shell
    {
        public AppShellViewModel VM { get; set; }

        public AppShell()
        {
            InitializeComponent();
        }

        public AppShell(AppShellViewModel vm)
        {
            BindingContext = vm;
            VM = vm;
            InitializeComponent();
        }
    }
}
