using ShowMens.Pages;
using ShowMens.ViewModels;

namespace ShowMens;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(OtherPage), typeof(OtherPage));
	}
}
