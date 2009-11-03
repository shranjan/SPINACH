//////////////////////////////////////////////////////////////////////////////////
//  Connection.xaml.cs - Program Configuration Window                           //
//  ver 1.0                                                                     //
//                                                                              //
//  Language:      C#                                                           //
//  Platform:      Windows Vista                                                //
//  Application:   SPINACH                                                      //
//  Author:        Abhay Ketkar (asketkar@syr.edu)                              //
//                 (315) 751 7324                                               //
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

namespace SPINACH_UI
{
  /// <summary>
  /// Interaction logic for Connection.xaml
  /// </summary>
  public partial class Connection : Window
  {

    private List<string> userList = new List<string>();
    public Connection()
    {
      InitializeComponent();
    }

    private string GetIP()
    {
      string strHostName = "";
      strHostName = System.Net.Dns.GetHostName();
      IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
      IPAddress[] addr = ipEntry.AddressList;
      return addr[addr.Length-1].ToString();
    }

    private void rdbJoinSwarm_Checked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Visible;
      txtPeerPort.Visibility = Visibility.Visible;
      lblPeerIP.Visibility = Visibility.Visible;
      lblPeerPort.Visibility = Visibility.Visible;

    }

    private void rdbJoinSwarm_Unchecked(object sender, RoutedEventArgs e)
    {
      txtPeerIP.Visibility = Visibility.Hidden;
      txtPeerPort.Visibility = Visibility.Hidden;
      lblPeerIP.Visibility = Visibility.Hidden;
      lblPeerPort.Visibility = Visibility.Hidden;
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      txtSelfIP.Text = GetIP();
      txtPort.Text = "8080";
      txtSelfIP.Focus();
      txtSelfIP.SelectAll();
    }

    private void btnConnect_Click(object sender, RoutedEventArgs e)
    {
      ProgConf winProgConf = new ProgConf();
      if (txtUsername.Text == "")
      {
        MessageBox.Show("Please enter a valid username", "Username", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        txtUsername.Focus();
      }
      else if ((rdbCreateSwarm.IsChecked == false) && (rdbJoinSwarm.IsChecked == false))
      {
          MessageBox.Show("Please select the Swarm Type", "Swarm Type", MessageBoxButton.OK, MessageBoxImage.Exclamation);
          rdbCreateSwarm.Focus();
      }
      else
      {
          //userList = SwarmConnect(selfip, selfport, username, peerip, peerport);
          //userList = SwarmConnect1(selfip, selfport, username);

          //for prototype only
          if (rdbJoinSwarm.IsChecked == true)
          {
              userList.Add("Prateek : 129.234.234.0 : 8080");
              userList.Add("Abhay : 129.234.908.0 : 4040");
              userList.Add("Arun : 129.432.543.0 : 3030");
              userList.Add("Rutu : 129.324.355.0 : 2020");
              //make sure whether the user has entered the peer ip and port
              //i am making this as a function so that it can be used later
              if (!validatePeer())
              {
                  MessageBox.Show("Please enter valid Peer IP/Port", "Peer IP/Port", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                  return;
              }
          }
          //prototype ends

          winProgConf.setUserList(userList);

          winProgConf.setUsername(txtUsername.Text);
          winProgConf.Show();
          this.Close();
      }
    }

    private bool validatePeer()
    {
        if (txtPeerIP.Text == "" || txtPeerPort.Text == "")
            return false;
        else
            return true;
    }

    
  }
}
