using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using AvaloniaApplication1.ViewModels;
using AvaloniaApplication1.Views;
using Material.Styles.Themes;

namespace AvaloniaApplication1
{
  public partial class App : Application
  {
    //Speckle theme
    public static readonly Color Primary = Color.FromRgb(59, 130, 246);
    public static readonly Color Secondary = Color.FromRgb(131, 180, 255);
    public static readonly Color Accent = Color.FromRgb(255, 191, 0);

    public override void Initialize()
    {
      AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
      var theme = Theme.Create(Theme.Light, Primary, Accent);
      var themeBootstrap = this.LocateMaterialTheme<MaterialThemeBase>();
      themeBootstrap.CurrentTheme = theme;

      if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
      {
        desktop.MainWindow = new MainWindow
        {
          DataContext = new MainWindowViewModel(),
        };
      }

      base.OnFrameworkInitializationCompleted();
    }

   
  }
}
