using PassportLogin.Vistas;
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
using PassportLogin.Utils;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PassportLogin
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        //private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        //{
        //    //Frame.Navigate(typeof(Login));

        //    // Load the local Accounts List before navigating to the UserSelection page
        //    await AccountHelper.LoadAccountListAsync();
        //    Frame.Navigate(typeof(UserSelection));

        //}


        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserSelection));
        }
    }
}
