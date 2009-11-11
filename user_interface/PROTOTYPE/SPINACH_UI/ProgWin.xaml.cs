//////////////////////////////////////////////////////////////////////////////////
//  ProgWin.xaml.cs - Program Editor                                            //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Arunkumar K T (akyasara@syr.edu)                             //
//                 (315) 751 7324                                               //
//////////////////////////////////////////////////////////////////////////////////
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

namespace SPINACH_UI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProgWin : Window
    {
        private List<string> swarmUserList;
        private List<string> progUserList;
        public editorType et;

        public enum editorType { owner, collaborator };

        //this is to know the type of invocation

        public ProgWin()
        {
            InitializeComponent();
        }

        public ProgWin(editorType e)
        {
            InitializeComponent();
            et = e;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void mnuFile_Click(object sender, RoutedEventArgs e)
        {
            mnuSave.Visibility = Visibility.Visible;
            mnuExit.Visibility = Visibility.Visible;
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void mnuWrap_Click(object sender, RoutedEventArgs e)
        {   
            if (rtbInput.HorizontalScrollBarVisibility == ScrollBarVisibility.Disabled)
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                fdInput.PageWidth =2000;
            }
            else
            {
                rtbInput.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
                fdInput.PageWidth = rtbInput.Width;
            }
        }

        private void mnuOption_Click(object sender, RoutedEventArgs e)
        {
            mnuLine.Visibility = Visibility.Visible;
            mnuWrap.Visibility = Visibility.Visible;
            mnuHighlight.Visibility = Visibility.Visible;
            
        }

        private void mnuAccess_Click(object sender, RoutedEventArgs e)
        {
            mnuAdd.Visibility = Visibility.Visible;
            mnuDelete.Visibility = Visibility.Visible;
            mnuEdit.Visibility = Visibility.Visible;
        }
       
        private void mnuPlot_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void mnuAdd_Click(object sender, RoutedEventArgs e)
        {
            AddUser user = new AddUser();
            user.setUserList(swarmUserList);
            user.ShowDialog();
        }
        private void mnuEdit_Click(object sender, RoutedEventArgs e)
        {
            EditPermissions editPerm = new EditPermissions();
            editPerm.ShowDialog();
        }
        private void mnuDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteUser delUser = new DeleteUser();
            delUser.ShowDialog();
        }

        public void setUserList(List<string> list)
        {
            swarmUserList = list;
        }

        public void setProgUserList(List<string> list)
        {
            progUserList = list;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (et == editorType.collaborator)
            {
                for (int i = 0; i < progUserList.Count; i++)
                {
                    lstUsers.Items.Add(progUserList[i]);
                }
            }
        }
        
    }
}
