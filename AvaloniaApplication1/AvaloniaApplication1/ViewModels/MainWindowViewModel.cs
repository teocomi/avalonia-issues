using Avalonia;
using Material.Styles.Themes;
using System;
using System.Collections.Generic;
using System.Text;


namespace AvaloniaApplication1.ViewModels
{
  public class MainWindowViewModel : ViewModelBase
  {
    public string Greeting => "Welcome to Avalonia!";


    public void DarkThemeCommand()
    {
      var materialTheme = Application.Current.LocateMaterialTheme<MaterialThemeBase>();
      var theme = materialTheme.CurrentTheme.SetBaseTheme(Theme.Dark);
      materialTheme.CurrentTheme = theme;
    }
  }
}
