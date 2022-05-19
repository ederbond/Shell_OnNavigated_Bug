using System.Diagnostics;

namespace Shell_OnNavigated_Bug;

public partial class AppShell : Shell
{
    public AppShell()
    {
        Routing.RegisterRoute("PageC", typeof(PageC));
        InitializeComponent();
    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        var page = Shell.Current.CurrentPage;

        Debug.WriteLine($"---------------------------- OnNavigated ----------------------------");
        Debug.WriteLine($"args.Source: {args.Source}");
        Debug.WriteLine($"Shell.Current.CurrentPage : {page.GetType().Name}");
        Debug.WriteLine($"------------------------------------------------------------------------");
        base.OnNavigated(args);
    }

    protected override void OnNavigating(ShellNavigatingEventArgs args)
    {
        if (Shell.Current == null)
        {
            base.OnNavigating(args);
            return;
        }

        var page = Shell.Current.CurrentPage;
        Debug.WriteLine($"---------------------------- OnNavigating ----------------------------");
        Debug.WriteLine($"args.Source: {args.Source}");
        Debug.WriteLine($"Shell.Current.CurrentPage : {page.GetType().Name}");
        Debug.WriteLine($"------------------------------------------------------------------------");
        base.OnNavigating(args);
    }
}
