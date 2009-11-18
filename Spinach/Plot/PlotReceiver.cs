////////////////////////////////////////////////////////////////////////
// PlotReceiver.cs: Check for new data for plotting in list
// 
// version: 1.0
// description: Receive data for plotting
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: Visual C#
////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;

namespace Spinach
{

public partial class PlotReceiver
{
    List<Plot> list = new List<Plot>();
    bool readerFlag = false;  // State flag
    Plot p1;
    Paint paint = new Paint();
    Thread plot;
    public delegate void BmpImage(PngBitmapEncoder pnbencoder);
    public event BmpImage image;
    public delegate void PlotError(int code, string message);
    public event PlotError error;

    public PlotReceiver()
    {
        //paint.error += new PlotError(OnError);
        paint.error +=new Paint.PlotError(OnError);
        
    }

    public void OnError(int code, string message)
    {
        if (error != null)
            error(code, message);

    } 
    public void retImage(PngBitmapEncoder pnbencoder)
    {
        if (image != null)
            image(pnbencoder);
    }

  

    public void writetolist(Plot p)
    {
        lock (this)  // Enter synchronization block
        {
            if (readerFlag)
            {      // Wait until ReadFromCell is done consuming.
                try
                {
                    Monitor.Wait(this);   // Wait for the Monitor.Pulse in
                    // ReadFromList
                }
                catch (SynchronizationLockException e)
                {
                    Console.WriteLine(e);
                    OnError(121, e.Message);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
            list.Add(p);
            Console.WriteLine("Display invoked By Core Team");
            readerFlag = true;    // Reset the state flag to say insertion to List
            // is done
            Monitor.Pulse(this);  // Pulse tells ReadFromList that 
            // WriteToList is done.
        }   // Exit synchronization block
    }

    private void ReadFromList()
    {
        lock (this)   // Enter synchronization block
        {
            if (!readerFlag)
            {            // Wait until WriteToList is done producing
                try
                {
                    // Waits for the Monitor.Pulse in WriteToList
                    Monitor.Wait(this);
                }
                catch (SynchronizationLockException e)
                {
                    Console.WriteLine(e);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("Display invoked By Plot Team");
            p1 = list[0];
            list.RemoveAt(0);
            readerFlag = false;    // Reset the state flag to say reading
            // is done.
            Monitor.Pulse(this);   // Pulse tells WriteToList that
            // ReadFromList is done.

            parsePaint();
            //call the various subroutines for parsing and other function in paint module

        }   // Exit synchronization block
    }





    public void checklist()
    {
        plot = new Thread(new ThreadStart(ThreadRun));
        plot.ApartmentState = ApartmentState.STA;
        plot.IsBackground = true;
        plot.Start();    
        
    }

    public void terminate()
    {
        if (plot.IsAlive)
            plot.Abort();
    }
   
    private void ThreadRun()
    {
//        Thread.Sleep(2000);
        while (true)
        {
            while(list.Count>0)
            {
                ReadFromList();                
            }
//            if (!Thread.CurrentThread.IsAlive) // program terminates
  //              break;
            //if(list.
//            Thread.CurrentThread.Abort();
        }
}

    [STAThread]
    private void parsePaint()
    {
       
        //paint.Plottitle = paint.Plottitle==null?"sample plot":p1.PlotTitle;
        //paint.X_Fact = paint.X_Fact!=1?paint.X_Fact:1;
        //paint.Y_Fact = paint.Y_Fact != 1 ? paint.Y_Fact : 1;
        //paint.Xtitle = paint.Xtitle != "X-Axis" ? paint.Xtitle : "X-Axis";//paint.Xtitle = "X-axis";
        //paint.Ytitle = paint.Ytitle != "Y-Axis" ? paint.Ytitle : "Y-Axis";//paint.Ytitle = "Y-axis";
        //paint.Mode = paint.Mode;
        
        
        switch (p1.Command)
        {
            case "subPlot":
                
                if (p1.Dimensions == 1) { }// the public function is yet to be designed
                if (p1.Dimensions == 2) 
                {
                    int length = 0;
                    double[] list = new double[p1.Data.GetLength(1) * p1.Data.GetLength(0)];
                    for (int i = 0; i < p1.Data.GetLength(0); i++)
                        for (int j = 0; j < p1.Data.GetLength(1); j++)
                            list[length++] = p1.Data[i, j];
                    paint.subplot2D(list, p1.PaneNum);
                }
                if (p1.Dimensions == 3) { }// the public function is yet to be designed              

                retImage(paint.pmanager.returnEncoderImage());
                break;
            case "plot":

                if (p1.Dimensions == 1) { }// the public function is yet to be designed
                    if (p1.Dimensions == 2)
                    {
                        int length = 0;
                        double[] list = new double[p1.Data.GetLength(1) * p1.Data.GetLength(0)];
                        for (int i = 0; i < p1.Data.GetLength(0); i++)
                            for (int j = 0; j < p1.Data.GetLength(1); j++)
                                list[length++] = p1.Data[i, j];
                        paint.Plottitle = p1.PlotTitle;
                        paint.plot2D(list);  // canvas has to be removed
                    }
                    if (p1.Dimensions == 3) { }// the public function is yet to be designed
                   /* paint.pmanager.returnEncoderImage().Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal,
          new Action(
            delegate()
            {
                retImage(paint.pmanager.returnEncoderImage());
               
            }
        ));*/
                    retImage(paint.pmanager.returnEncoderImage());
                    break;
            case "resetPlot": paint.reset(); retImage(paint.pmanager.returnEncoderImage()); break; // the public function is yet to be designed
            case "setPlotAxis": paint.X_Fact = p1.X_Fact;
                paint.Y_Fact = p1.Y_Fact; break; // for 3D, zfact is to be inserted
            case "setAxisTitle": paint.Xtitle = p1.X_Axis_Title;
                paint.Ytitle = p1.Y_Axis_Title;
                paint.Ztitle = p1.Z_Axis_Title;
                break;
            case "setScaleMode": paint.Mode = p1.ScaleMode;
                break;// the public function is yet to be designed
            

        }
        //mahes is going to give me the public paint module function to plot the data.
    }
}

}