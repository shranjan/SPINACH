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
        private PngBitmapEncoder PBE = new PngBitmapEncoder();
        public ProgPlot(PngBitmapEncoder encoder)
        {
            InitializeComponent();
            PBE = encoder;
        }

        private void frmPlot_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                imgPlot.Source = PBE.Frames[0];
            }
            catch
            {
                MessageBox.Show("No Plot");
            }
        }

        

    }
}
