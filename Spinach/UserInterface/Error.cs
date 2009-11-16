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
using Spinach;

namespace Spinach
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
        
        private executor Ex;
        private PlotReceiver plot;

        private Dictionary<int, string> ErrorDict = new Dictionary<int, string>();

        //----< Create the Dictionary of Errors >----
        public ErrorModule()
        {
            // FrontEnd Error Messages
            ErrorDict.Add(101, "Syntax Error: ");
            ErrorDict.Add(102, "Exception: ");
            // CoreTeam Error Messages
            ErrorDict.Add(112, "Semantic Error: ");
            // PlotTeam Error Messages
            ErrorDict.Add(121, "Plotting Error: ");
            ErrorDict.Add(122, "Plotting Error: ");
            ErrorDict.Add(123, "Plotting Error: ");

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

        public void SetExecutorObject(executor E)
        {
            Ex = E;
            Ex.errEvent +=new executor.err(ErrorMsg);
        }

        public void SetPlotObject(PlotReceiver p)
        {
            plot = p;
            plot.error +=new PlotReceiver.PlotError(ErrorMsg);
        }
        
    }
}
