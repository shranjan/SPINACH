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
using System.Windows.Forms;
using System.IO;

namespace Spinach
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ProgConf : Window
    {
        private bool connected = false;                         //Specifies the state of the connection
        private string username = "";
        private List<string> userList;
        private ErrorModule err = new ErrorModule();
        
        /// <summary>
        /// Default constructor - Initializing the intial things
        /// </summary>
        // TODO check all the initializations
        public ProgConf()
        {
            InitializeComponent();
            mnuProg.Visibility = Visibility.Visible;
            txtMessage.Focus();
            err.ProgConfError += new ErrorNotification(ShowError);
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
            result = System.Windows.MessageBox.Show("Do you really want to disconnect from the swarm?", "Disconnect?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
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

      /// <summary>
      /// Sets the username to be displayed on the screen.
      /// This is sent by the connection module.
      /// </summary>
      /// <param name="user">username which was accepted by the swarm while connecting</param>
      public void setUsername(string user)
      {
        username = user;
      }

      /// <summary>
      /// Sets the userlist sent by the connection module.
      /// This list contains all the users currently in the swarm.
      /// </summary>
      /// <param name="list">List of all the users in the swarm</param>
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

      /// <summary>
      /// This will load the file and pass the text to the editor.
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void submnuLoad_Click(object sender, RoutedEventArgs e)
      {
          Stream myStream = null;
          OpenFileDialog openFileDialog1 = new OpenFileDialog();

          openFileDialog1.InitialDirectory = "c:\\";
          openFileDialog1.Filter = "ssf files (*.ssf)|*.ssf|All files (*.*)|*.*";
          openFileDialog1.FilterIndex = 1;
          openFileDialog1.RestoreDirectory = true;
          String text = "";

          if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
              try
              {
                  if ((myStream = openFileDialog1.OpenFile()) != null)
                  {
                      StreamReader sr = new StreamReader(openFileDialog1.FileName);
                      using(sr)
                      {
                          string line;
                          line = sr.ReadLine();
                          while ((line) != null)
                          {
                              text = text + line;
                              line = sr.ReadLine();
                              if (line != null)
                              {
                                  text += "\n";
                              }
                          }
                      }
                  }
                  ProgWin editor = new ProgWin(ProgWin.editorType.owner);
                  
                  editor.loadProgram(0, 0, text);
                  editor.Show();
                  editor.setUserList(userList);
              }
              catch (Exception ex)
              {
                  System.Windows.MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
              }
          }

      }

      private void NewAccessPermission(int read, int write, string text)
      {
      }

      private void ShowError(string errorMsg)
      {
          System.Windows.MessageBox.Show(errorMsg, "Fatal Error", MessageBoxButton.OK, MessageBoxImage.Error);
      }

      /// <summary>
      /// Updates the list of users in the swarm.
      /// </summary>
      /// <param name="userList">List of users in the swarm</param>
      private void updateList(List<string> userList)
      {
      }
    }
}
