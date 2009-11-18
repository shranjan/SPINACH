//////////////////////////////////////////////////////////////////////////////////
//  Chat.cs - Chat handling class                                               //
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
 * version 1.0 : 15 Nov 09
 * - the initial version of the Chat module
 */

using System;
using System.Collections.Generic;
using Spinach;

namespace Spinach
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void ChatNotification(string Uname, string Msg);
    public class ChatModule
    {
        public event ChatNotification Chat;
        //private SwarmConnection SC;

        public ChatModule(/*SwarmConnection SConn*/)
        {
            //SC = SConn;
            //SC.ChatEvent += new SwarmConnection.chat(ChatMsg);
        }

        //----< Sends Error Message to ProgConf >----
        public void ChatMsg(string Uname, string Msg)
        {
            if (Chat != null)
                Chat(Uname, Msg);
        }

    }
}
