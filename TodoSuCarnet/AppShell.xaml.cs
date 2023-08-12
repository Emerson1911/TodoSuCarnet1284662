using TodoSuCarnet.Views;

namespace TodoSuCarnet;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
    }
}
