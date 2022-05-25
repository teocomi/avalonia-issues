using Speckle.Core.Api;
using Speckle.Core.Credentials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      Speckle();
    }

    private async void Speckle()
    {
      var StreamId = "f7b978e6ae";

      var a = AccountManager.GetDefaultAccount();
      var Client = new Client(a);


      Client.SubscribeCommitCreated(StreamId);
      Client.OnCommitCreated += (s, e) =>
      {
        var gg = true;
      };


    }
  }
}
