using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class MainMenu : Page
    {
        public MainMenu()
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

        async void DrinkClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg4 = new MessageDialog("We will calculate whats in it..", "Select a Drink");
            await msg4.ShowAsync();

        }

        async void ReminderClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg3 = new MessageDialog("We will Set reminders..", "Set a Reminder");
            await msg3.ShowAsync();

        }

        async void MediClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg2 = new MessageDialog("Put your medical Issues here so we can Guide you..", "Medical issues");
            await msg2.ShowAsync();

        }

        async void MusicClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg1 = new MessageDialog("we will play you r selected music..", "Play Music");
            await msg1.ShowAsync();

        }

        async void StatClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg5 = new MessageDialog("We will show and manage your health profile...", "View and edit your Health profile");
            await msg5.ShowAsync();

        }

        async void RecipeClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog ms6 = new MessageDialog("We will SHow how its made..", "Select a recipe");
            await ms6.ShowAsync();

        }

        async void GlucoClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msg7 = new MessageDialog("We will calculate whats in it..", "Sugar level");
            await msg7.ShowAsync();

        }

        async void FaceClicked(object sender, RoutedEventArgs e)
        {
           

        }
        void backClicked(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login),null);

        }

        async void MailClicked(object sender, RoutedEventArgs e)
        {
            MessageDialog msgDialog = new MessageDialog("We will show your mail..", "Mail");
            await msgDialog.ShowAsync();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg8 = new MessageDialog("Login out","log out ");
            await msg8.ShowAsync();
            Frame.Navigate(typeof(Login), null);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ex), null);
        }
    }
}
