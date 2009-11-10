/////////////////////////////////////////////////////////////////////
// Window1.xaml.cs - WPF User Interface for WCF Communicator       //
// ver 2.0                                                         //
// Jim Fawcett, CSE681 - Software Modeling & Analysis, Summer 2008 //
/////////////////////////////////////////////////////////////////////
/*
 * Maintenance History:
 * ====================
 * ver 2.0 : 06 Nov 08
 * - fixed bug that had local and remote ports swapped
 * - made Receive thread background so it would not keep 
 *   application alive after close button is clicked
 * - now closing sender and receiver channels on window
 *   unload
 * ver 1.0 : 17 Jul 07
 * - first release
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
using System.Threading;

namespace WPF_GUI
{
  public partial class Window1 : Window
  {
    WCF_Peer_Comm.Receiver recvr;
    WCF_Peer_Comm.Sender sndr;
    Peer mPeer=new Peer();
    string rcvdMsg = "";

    Thread thrd = null;
    delegate void NewMessage(string msg);
    event NewMessage OnNewMessage;

    //----< receive thread processing >------------------------------

    void ThreadProc()
    {
      while (true)
      {
        rcvdMsg = recvr.GetMessage();

        // call window functions on UI thread
        this.Dispatcher.BeginInvoke(
          System.Windows.Threading.DispatcherPriority.Normal,
          OnNewMessage, 
          rcvdMsg);
      }
    }

    //----< receive thread handler >---------------------------------

    void OnNewMessageHandler(string msg)
    {
        MessageParser mMsg = new MessageParser();
        mMsg.GetMsg(msg);
        String temp=mMsg.parse(ref mPeer);
        listBox2.Items.Insert(0, temp);
      
      
    }

    //----< subscribe to new message events >------------------------

    public Window1()
    {
      InitializeComponent();
      OnNewMessage += new NewMessage(OnNewMessageHandler);
      button1.IsEnabled = false;
      button3.IsEnabled = false;
      button4.IsEnabled = false;
    }
    //----< start listener >-----------------------------------------

    private void button2_Click(object sender, RoutedEventArgs e)
    {
        Peer p = new Peer();
        p.SetIP(textBox1.Text);
        p.SetPort(textBox2.Text);
        p.SetName(textBox6.Text);
        mPeer = p;
        mPeer.InsertPeer(mPeer.GetIP() + ":" + mPeer.GetPort(),mPeer.GetName(),mPeer.GetCPU());
      string localPort = textBox2.Text;
      string endpoint = "http://" + textBox1.Text + ":" + localPort + "/ICommunicator";

      try
      {
        recvr = new WCF_Peer_Comm.Receiver();
        recvr.CreateRecvChannel(endpoint);

        // create receive thread - calls BlockingQ.deQ()
        thrd = new Thread(new ThreadStart(this.ThreadProc));
        thrd.IsBackground = true;
        thrd.Start();
        button1.IsEnabled = true;
        button2.IsEnabled = false;
      }
      catch (Exception ex)
      {
        Window temp = new Window();
        StringBuilder msg = new StringBuilder(ex.Message);
        msg.Append("\nport = ");
        msg.Append(localPort.ToString());
        temp.Content = msg.ToString();
        temp.Height = 100;
        temp.Width = 500;
        temp.Show();
      }
    }
    //----< connect to remote listener >-----------------------------

    private void button1_Click(object sender, RoutedEventArgs e)
    {
      string remoteAddress = textBox5.Text;
      string remotePort = textBox3.Text;
      string endpoint = "http://" + textBox5.Text + ":" + remotePort + "/ICommunicator";

      sndr = new WCF_Peer_Comm.Sender();
      sndr.CreateSendChannel(endpoint);
      button3.IsEnabled = true;
      button4.IsEnabled = true;
      button1.IsEnabled = false;
    }
    //----< send message to connected listener >---------------------

    private void button3_Click(object sender, RoutedEventArgs e)
    {
      try
      {
        listBox1.Items.Insert(0, textBox4.Text);
        sndr.PostMessage(textBox4.Text);
      }
      catch (Exception ex)
      {
        Window temp = new Window();
        temp.Content = ex.Message;
        temp.Height = 100;
        temp.Width = 500;
      }
    }

    private void Window_Unloaded(object sender, RoutedEventArgs e)
    {
      sndr.PostMessage("quit");
      sndr.Close();
      recvr.Close();
    }

    private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private void button4_Click(object sender, RoutedEventArgs e)
    {
        MessageGenerator mMsg = new MessageGenerator();
       // string msg = mMsg.msgIPNameCPU(ref mPeer);
        string msg = mMsg.msgRun();
        textBox4.Text = msg;
    }

    private void listBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
  }
}
