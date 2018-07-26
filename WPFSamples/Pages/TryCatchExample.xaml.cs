﻿using System;
using System.Windows.Controls;

namespace WPFSamples.Pages
{
    /// <summary>
    /// Interaction logic for TryCatchExample.xaml
    /// </summary>
    public partial class TryCatchExample : Page
    {
        public TryCatchExample()
        {
            InitializeComponent();
        }

        private void OnDivide(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(ValueABox.Text);
                double b = double.Parse(ValueBBox.Text);
                Result.Text = $"Result = {a / b}";
            }
            catch (Exception ex)
            {
                Result.Text = string.Format("Exception = {0}\nStackTrace = {1}", ex.Message,ex.StackTrace);
            }
        }
    }
}
