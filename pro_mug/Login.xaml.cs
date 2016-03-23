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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace pro_mug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
      //  public TextBox TxtUsername;
        //public PasswordBox Txtpassword;
        public Login()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        void OnClick1(object sender, RoutedEventArgs e)//login
        {
            //action in login and the login
            LoginButton.Begin();
            this.Frame.Navigate(typeof(MainMenu), null);// should be home here then the main menu from that
          //  this.Frame.Navigate(typeof(Home), null);+ still doing :P

        }

        void OnClick2(object sender, RoutedEventArgs e)//Canel
        {
             ExitButton.Begin();
           // Environment();
        }

        void Signup(object sender, RoutedEventArgs e)//login
        {
            this.Frame.Navigate(typeof(RegisterPart2), null);
        }

    }
}
