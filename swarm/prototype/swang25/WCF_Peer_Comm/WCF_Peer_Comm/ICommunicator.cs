/////////////////////////////////////////////////////////////////////
// ICommunicator.cs - Peer-To-Peer Communicator Service Contract   //
//                                                                 //
// Jim Fawcett, CSE681 - Software Modeling & Analysis, Summer 2008 //
/////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Peer_Comm
{
  // NOTE: If you change the interface name "IService1" here, you must also update the reference to "IService1" in Web.config.
  [ServiceContract]
  public interface ICommunicator
  {
    [OperationContract(IsOneWay = true)]
    void PostMessage(string msg);

    [OperationContract]
    string GetMessage();
  }
}
