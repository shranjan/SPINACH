using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for ProgPlot.xaml
    /// </summary>
    public partial class ProgPlot : Window
    {
        string imagepath = "";
        public ProgPlot(string path)
        {
            InitializeComponent();
            imagepath = path;
        }

        private void frmPlot_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                imgPlot.Source = (ImageSource)new ImageSourceConverter().ConvertFromString(imagepath);
            }
            catch
            {
                MessageBox.Show("No Plot");
            }
        }

        

    }
}
