using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SimpleBlendAnimations
{
	public partial class MainPage : UserControl
	{
		private Storyboard myStoryboard = null;

        private Storyboard Combination = null;

		public MainPage()
		{
			// Required to initialize variables
			InitializeComponent();
		}

		private void btnStartAnimation_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            myStoryboard.Begin(); 
		}

		private void btnPauseAnimation_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            myStoryboard.Pause(); 
		}

		private void btnStopAnimation_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            myStoryboard.Stop(); 
		}

		private void btnResumeAnimation_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            myStoryboard.Resume(); 
		}

		private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			// When the SL app loads, grab the story board for later use.
            myStoryboard = (Storyboard)this.Resources["AnimateCircle"];
            Combination = (Storyboard)this.Resources["AnimateRect"];
		}

        //private void StartButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Combination.Begin();
        //}

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            Combination.Pause();
        }

        private void ResumeButton_Click(object sender, RoutedEventArgs e)
        {
            Combination.Resume();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            Combination.Stop();
        }
    }
}