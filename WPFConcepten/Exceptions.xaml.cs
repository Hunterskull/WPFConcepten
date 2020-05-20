using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFConcepten
{
    /// <summary>
    /// Interaction logic for Exceptions.xaml
    /// </summary>
    public partial class Exceptions : Window
    {
        public Exceptions()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string s = null;
            try
            {
                s.Trim();
            }
            catch (Exception exception)
            {
                MessageBox.Show("A handled exception just occured: " + exception.Message, "Exception Sample",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            s.Trim();

        }
    }
}
