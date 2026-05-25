using MauiNavigation.Pages;

namespace MauiNavigation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetallePage), typeof(DetallePage));
        }
    }
}
