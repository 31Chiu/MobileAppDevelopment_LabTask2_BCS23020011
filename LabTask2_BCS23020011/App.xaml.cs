namespace LabTask2_BCS23020011
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        // We will use this "CreateWindow" method as the only way to start the application
        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Here we return to the HomePage that wraps the navigation function
            return new Window(new NavigationPage(new HomePage()));
        }
    }
}