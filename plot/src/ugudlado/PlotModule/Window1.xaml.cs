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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PlotModule
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Paint p = new Paint();
            int[] plist = {1,3,5,1,-5};
            //for (int i = -1,j=0; j < plist.GetLength(0); i++)
            //{               
            //    plist[0]=i;               
            //}            
            canvas2.Visibility = Visibility.Hidden;
            canvas5.Visibility = Visibility.Hidden;
            canvas3.Visibility = Visibility.Hidden;
            canvas4.Visibility = Visibility.Hidden;
            p.subplot2D(plist,2, canvas1);            
        }
    }
}


//p.plot3DInto2D(p3list,canvas1);
//int[,] p3list=new int[3,3];
//for(int i=0;i<3;i++){
//                p3list[i,i]=i+1;
//            }