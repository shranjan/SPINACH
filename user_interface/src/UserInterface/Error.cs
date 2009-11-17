//////////////////////////////////////////////////////////////////////////////////
//  Error.cs - Error handling class                                             //
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
 * version 1.0 : 4 Nov 09
 * - the initial version of the Error module
 */

using System;
using System.Collections.Generic;

namespace UserInterface
{
    /// <summary>
    /// 
    /// </summary>
    public delegate void ErrorNotification(string Msg);
    public class ErrorModule
    {
        public event ErrorNotification ConnError;
        public event ErrorNotification ProgConfError;
        public event ErrorNotification ProgWinError;

        private Dictionary<int, string> ErrorDict = new Dictionary<int, string>();

        //----< Create the Dictionary of Errors >----
        public ErrorModule()
        {
            ErrorDict.Add(101, "Syntax Error: ");
            ErrorDict.Add(102, "Exception: ");
        }

        //----< Sends Error Message to appropriate window >----
        public void ErrorMsg(int Code, string Msg)
        {
            string ErrMsg = ErrorDict[Code] + Msg;
            if (Code < 50 && ConnError != null)
              ConnError(ErrMsg);
            else if (Code < 100 && ProgConfError != null)
              ProgConfError(ErrMsg);
            else if (Code < 150 && ProgWinError != null)
              ProgWinError(ErrMsg);
        }    
    }
}
