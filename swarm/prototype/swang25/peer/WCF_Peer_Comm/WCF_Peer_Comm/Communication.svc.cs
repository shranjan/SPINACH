using System;
using System.Collections.Generic;
/////////////////////////////////////////////////////////////////////
// Communication.svc.cs - Peer-To-Peer WCF Communicator            //
// ver 2.0                                                         //
// Jim Fawcett, CSE681 - Software Modeling & Analysis, Summer 2008 //
/////////////////////////////////////////////////////////////////////
/*
 * Maintenance History:
 * ====================
 * ver 2.0 : 06 Nov 08
 * - added close functions that close the service and receive channel
 * ver 1.0 : 14 Jul 07
 * - first release
 */
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SWTools;

namespace WCF_Peer_Comm
{
  public class Receiver : ICommunicator
  {
    static BlockingQueue<string> BlockingQ = null;
    ServiceHost service = null;

    public Receiver()
    {      
      if (BlockingQ == null)
        BlockingQ = new BlockingQueue<string>();
    }

    public void Close()
    {
      service.Close();
    }

    public void CreateRecvChannel(string address)
    {
      BasicHttpBinding binding = new BasicHttpBinding();
      Uri baseAddress = new Uri(address);
      ServiceHost service = new ServiceHost(typeof(Receiver), baseAddress);
      service.AddServiceEndpoint(typeof(ICommunicator), binding, baseAddress);
      service.Open();
    }

    public void PostMessage(string msg)
    {
      BlockingQ.enQ(msg);
    }

    public string GetMessage()
    {
      return BlockingQ.deQ();
    }
  }

  public class Sender
  {
    ICommunicator channel;
    string lastError = "";

    public void CreateSendChannel(string address)
    {
      EndpointAddress baseAddress = new EndpointAddress(address);
      BasicHttpBinding binding = new BasicHttpBinding();
      ChannelFactory<ICommunicator> factory 
        = new ChannelFactory<ICommunicator>(binding, address);
      channel = factory.CreateChannel();
    }

    public void PostMessage(string msg)
    {
      try
      {
        channel.PostMessage(msg);
      }
      catch (Exception ex)
      {
        lastError = ex.Message;
      }
    }

    public string GetLastError()
    {
      string temp = lastError;
      lastError = "";
      return temp;
    }

    public void Close()
    {
      ChannelFactory<ICommunicator> temp = (ChannelFactory<ICommunicator>)channel;
      temp.Close();
    }
  }
}
