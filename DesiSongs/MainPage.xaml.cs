﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DesiSongs.Resources;
using Nokia.Music;
using Windows.Phone.Speech.Synthesis;
using Windows.Phone.Speech.Recognition;
using Windows.Phone.Speech.VoiceCommands;
using Nokia.Music.Types;
using Nokia.Music.Tasks;

namespace DesiSongs
{
    public partial class MainPage : PhoneApplicationPage
    {
        private MusicClient ms;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void searchArtist(object sender, RoutedEventArgs e)
        {

            

            //ms = new MusicClient("d5117c1efbda09d54b21504d6cf2aa81");
            //MessageBox.Show(ms.AppId);
            //Artist artist=new Artist();
            //ms.SearchArtists((ListResponse<Artist> artistResponse) =>
            //                        {
            //                              if (artistResponse.Count() > 0)
            //                              {
            //                                   artist = artistResponse.First<Artist>(); //let's assume that the first returned artist is the one we're looking for
            //                                   Deployment.Current.Dispatcher.BeginInvoke(() => this.Artist.Content = artist.Country );
            //                              }
            //                                else
            //                                {
            //                                    MessageBox.Show("Sorry, we couldn't find any artist named ");
            //                                }
            //                         }, "Akon");

 /*           ms.GetArtistProducts(
  (ListResponse<Product> productResponse) =>
  {
      var songs = productResponse.Where((x) => //productResponse will include all products, not just songs. this will only return tracks and singles
      {
          if (x.Category == Category.Track || x.Category == Category.Single)
          {
              return true;
          }
          else
          {
              return false;
          }
      }
      );
      String ArtistName = "Akon";
      List<Product> productList = songs.ToList<Product>();
      if (productList.Count >= 3)
      {
          MessageBox.Show("The top songs by " +  ArtistName + productList[0].Name + ", " + productList[1].Name + ", and " + productList[2].Name);
      }
      else if (productList.Count >= 1)
      {
          MessageBox.Show("The top song by " + ArtistName + " is " + productList[0].Name);
      }
      else
      {
          MessageBox.Show("Sorry, we don't have song info for " + ArtistName);
      }
  }, artist); */
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Explore Nokia Music World easily with this application. Developed by Bharath MG");
        }

        private void listItemClicked(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = sender as ListBox;
            switch (list.SelectedIndex)
            {
                case 0:
                    {
                        NavigationService.Navigate(new Uri("/Page1.xaml", UriKind.Relative));
                        break;
                    }
                case 1:
                    {
                        NavigationService.Navigate(new Uri("/Songs.xaml", UriKind.Relative));
                        break;
                    }
                case 2:
                    {
                        NavigationService.Navigate(new Uri("/Mix.xaml", UriKind.Relative));
                        break;
                    }
                case 3:
                    {
                        ShowGigsTask task = new ShowGigsTask();
                        task.Show();
                        break;
                    }
            }
            list.SelectedIndex = -1;
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}