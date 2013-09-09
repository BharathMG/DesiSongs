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
    public partial class Mix : PhoneApplicationPage
    {
        public Mix()
        {
            InitializeComponent();
        }

        private void searchMix(object sender, RoutedEventArgs e)
        {
            PlayMixTask task = new PlayMixTask();
            task.ArtistName = MixTextBox.Text;
            task.Show();
        }
    }
}