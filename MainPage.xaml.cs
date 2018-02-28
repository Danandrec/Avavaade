using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Avavaade
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            Hamburger.IsPaneOpen = !Hamburger.IsPaneOpen;
        }

        private void Tootajad_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opetajate_nimekiri));
        }

        private void Nimekiri_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Gruppide_nimekiri));
        }

        private void Tunniplaan_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tunniplaani_vaade));
        }

        private void Ruumid_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Ruumide_nimekiri));
        }

        private void Avaleht_Navigated(object sender, NavigationEventArgs e)
        {

        }

        //   private void Teated_Click(object sender, RoutedEventArgs e)
        // {
        //   this.Frame.Navigate(typeof(Tunniplaanitest));
        //}
    }
}
