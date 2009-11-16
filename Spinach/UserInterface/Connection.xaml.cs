//////////////////////////////////////////////////////////////////////////////////
//  Connection.xaml.cs - Program Configuration Window                           //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows 7                                                    //
//  Application:   SPINACH                                                      //
//  Author:        Abhay Ketkar (asketkar@syr.edu)                              //
//                 (315) 439 7224                                               //
//////////////////////////////////////////////////////////////////////////////////

/*
 * Maintenance History:
 * ====================
 * version 1.1 : 25 Oct 09
 * - introduced validation for the radio buttons and similarly passed the requisite
 *   user list
 * - made connection button the default button
 * - also validated the peer ip/port
 * version 1.0 : 24 Oct 09
 * - the initial version of the connection module
 */

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
using System.Net;
using System.Net.Sockets;

namespace Spinach
{
  /// <summary>
  /// Interaction logic for Connection.xaml
  /// </summary>

  public partial class Connection : Window
  {
    private ErrorModule Err = new ErrorModule();
    //private SwarmConnection SC = new SwarmConnection();
    private List<string> userList = new List<string>();

    //----< Connection Ctor >----
    public Connection()
    {
      InitializeComponent();
      Err.ConnError += new ErrorNotification(ShowError);
    }

    //----< Connection Window Load Event >----
    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        txtSelfIP.Text = GetIP();
        txtPort.Text = "8080";
        txtSelfIP.Focus();
        txtSelfIP.SelectAll();
    }

    //----< Get the IP of the machine >----
    private string GetIP()
    {
      string strHostName = "";
      string ipAddr = "";
      strHostName = System.Net.Dns.GetHostName();
      IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
      //IPAddress[] addr = ipEntry.AddressList;
      foreach (IPAddress ip in ipEntry.AddressList)
      {
          if (ip.AddressFamily.ToString() == ProtocolFamily.InterNetwork.ToString())
              ipAddr = ip.ToString();
      }
      return ipAddr;
    }

    //----< Join Swarm Radio Button Checked Event >----
    private void rdbJoinSwarm_Checked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Visible;
      txtPeerPort.Visibility = Visibility.Visible;
      lblPeerIP.Visibility = Visibility.Visible;
      lblPeerPort.Visibility = Visibility.Visible;

    }

    //----< Join Swarm Radio Button Unchecked Event >----
    private void rdbJoinSwarm_Unchecked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Hidden;
      txtPeerPort.Visibility = Visibility.Hidden;
      lblPeerIP.Visibility = Visibility.Hidden;
      lblPeerPort.Visibility = Visibility.Hidden;
    }

    //----< Show error MessageBox to the user >----
    private void ShowError(string Msg)
    {
      MessageBox.Show(Msg, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
    }

    //----< Connect Button Click Event >----
    private void btnConnect_Click(object sender, RoutedEventArgs e)
    {
      bool conn = false;
      if (txtUsername.Text.Trim() == "")
      {
          MessageBox.Show("Please enter the Username", "Username", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          txtUsername.Focus();
      }
      else if ((rdbCreateSwarm.IsChecked == false) && (rdbJoinSwarm.IsChecked == false))
      {
          MessageBox.Show("Please select the Swarm Type", "Swarm Type", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          rdbCreateSwarm.Focus();
      }
      else
      {
          //Connect to the Swarm
          if (rdbJoinSwarm.IsChecked == true)
          {
//              userList.Add("Prateek : 129.234.234.0 : 8080");
//              userList.Add("Abhay : 129.234.908.0 : 4040");
//              userList.Add("Arun : 129.432.543.0 : 3030");
//              userList.Add("Rutu : 129.324.355.0 : 2020");
              //make sure whether the user has entered the peer ip and port
              if (txtPeerIP.Text.Trim() == "" || txtPeerPort.Text.Trim() == "")
              {
                  MessageBox.Show("Please enter valid Peer IP/Port", "Peer IP/Port", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                  return;
              }
              else
              {
                  //userList = SC.JoinSwarm(txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim(), txtPeerIP.Text.Trim(), txtPeerPort.Text.Trim());
                  conn = true;
              }
          }
          else if (rdbCreateSwarm.IsChecked == true)
          {
              //SC.CreateSwarm(txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim());
              conn = true;
          }
          //SWARM MUST TELL ME IF THE CONNECTION WAS SUCCESSFUL OR NOT
          //Go to the next Window
          if (conn == true)
          {
              ProgConf winProgConf = new ProgConf(/*SC*/);
              winProgConf.setUserList(userList);
              winProgConf.setDetails(txtSelfIP.Text.Trim(), txtPort.Text.Trim(), txtUsername.Text.Trim());
              winProgConf.Show();
              this.Close();
          }
      }
    }
  }
}
