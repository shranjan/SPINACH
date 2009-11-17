//////////////////////////////////////////////////////////////////////////////////
//  ProgConf.xaml.cs - Program Configuration Window                             //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Prateek Jain (pjain02@syr.edu)                               //
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
    public partial class ProgConf : Window
    {
        private bool connected = false;                         //Specifies the state of the connection
        private string username = "";
        private List<string> userList;
        public ProgConf()
        {
            InitializeComponent();
            mnuProg.Visibility = Visibility.Visible;
            txtMessage.Focus();
        }

        private void mnuFile_Click(object sender, RoutedEventArgs e)
        {

        }

        //Runs on Exit Button being clicked
        private void submnuExit_Click(object sender, RoutedEventArgs e)
        {
            if (connected == true)
            {
                submnuDisconnect_Click(sender, e);
            }
            Environment.Exit(1);
        }

        private void submnuDisconnect_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Do you really want to disconnect from the swarm?", "Disconnect?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (result == MessageBoxResult.Yes)
            {
                //Code for disconnecting from thw swarm
              Connection conn = new Connection();
              conn.Show();
              frmProgConf.Close();
              connected = false;
            }
        }

        private void frmProgConf_Loaded(object sender, RoutedEventArgs e)
        {
          for (int i = 0; i < userList.Count; i++)
          {
            lstUserList.Items.Add(userList[i]);
          }
        }

        private void cmdSend_Click(object sender, RoutedEventArgs e)
        {
            if (txtMessage.Text != "")
            {
                int size = username.Length;

                TextPointer tp = rtbChat.CaretPosition.GetPositionAtOffset(0, LogicalDirection.Forward);
                rtbChat.CaretPosition.InsertTextInRun(username + ": " + txtMessage.Text + "\n");
                //rtbChat.CaretPosition.InsertParagraphBreak();
                rtbChat.CaretPosition = tp;

                //rtbChat.BeginChange();
                //rtbChat.FontWeight = FontWeights.Bold;
                //rtbChat.AppendText(username + ": ");
                //rtbChat.EndChange();

                //rtbChat.AppendText(txtMessage.Text + "\n");
                txtMessage.Text = "";
                rtbChat.ScrollToEnd();
            }
        }

      public void setUsername(string user)
      {
        username = user;
      }

      public void setUserList(List<string> list)
      {
        userList = list;
      }

      private void submnuNew_Click(object sender, RoutedEventArgs e)
      {
        ProgWin editor = new ProgWin(ProgWin.editorType.owner);
        //owner is the user itself. so pass the username here
        //list of the users in swarm
        //take the program name and send the program name
        editor.Show();
        editor.setUserList(userList);
      }

      private void submnuLoad_Click(object sender, RoutedEventArgs e)
      {
          ProgWin editor = new ProgWin(ProgWin.editorType.owner);
          editor.Show();
          editor.setUserList(userList);
      }
    }
}
