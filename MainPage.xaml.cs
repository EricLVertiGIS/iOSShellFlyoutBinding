namespace iOSShellFlyoutBinding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            if (Shell.Current is AppShell aShell)
            {
                aShell.VM.DisplayName = "Jane Doe";
                aShell.VM.OrgName = "ArcGIS Enterprise: ArcGIS Enterprise";
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
