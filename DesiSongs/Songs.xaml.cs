using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Nokia.Music.Tasks;

namespace DesiSongs
{
    public partial class Songs : PhoneApplicationPage
    {
        public Songs()
        {
            InitializeComponent();
        }

        private void searchSong(object sender, RoutedEventArgs e)
        {
            ShowArtistTask task = new ShowArtistTask();
            task.ArtistName = ArtisttextBox.Text;
            task.Show();
        }
    }
}