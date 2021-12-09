﻿using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ShareAssist
{
    /// <summary>
    /// Interaction logic for Viewer.xaml
    /// </summary>
    public partial class Viewer : Window
    {
        public Viewer()
        {
            InitializeComponent();
        }

        public void HandleDrag(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        public void HandleShow(object sender, MouseEventArgs e)
        {
            Handle.Visibility = Visibility.Visible;
        }
        public void HandleHide(object sender, MouseEventArgs e)
        {
            Handle.Visibility = Visibility.Hidden;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (MainWindow.armed)
            {
                MainWindow.Play();
                MainWindow.armed = false;
                MainWindow.controlPanel.ArmButton.Background = Brushes.LightGray;
            }
        }
    }
}
