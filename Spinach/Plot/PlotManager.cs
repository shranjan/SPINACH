////////////////////////////////////////////////////////////////////////
// PlotManager.cs: Convert paint objects to image and send it to UI team,
// saving image to local directory
// version: 1.0
// description: Manages all the plots
// author: Rohan Pandit (rspandit@syr.edu)
// language: Visual C#
////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using System.Windows.Media.Media3D;
using System.Collections;


namespace Spinach
{
    partial class PlotManager
    {

        private Hashtable Canvas_Obj;
        private Hashtable Updates;
        private string imagepath = "..\\images";
        private Paint paint;
        private PngBitmapEncoder encoder1;

        public delegate void PlotError(int code, string message);
        public event PlotError error;

        public void OnError(int code, string message)
        {
            if (error != null)
                error(code, message);

        }


       
        public PlotManager(Paint pa)
        {
            Canvas_Obj = new Hashtable();
            Updates = new Hashtable();
            encoder1 = new PngBitmapEncoder();
            paint = pa;
            

        }

        // Converts to Bitmap Image
        public void Convert_to_Image(Canvas can, int pane_number)
        {

            if (pane_number == -1)
            {
                try
                {
                    //clear hashtable as new plot will overwirte previous image
                    Canvas_Obj.Clear();
                    Updates.Clear();

                    PngBitmapEncoder encoder = new PngBitmapEncoder();
                    Canvas_Obj[1] = can;
                    Transform transform = can.LayoutTransform;

                    // reset current transform incase of scalling or rotating
                    can.LayoutTransform = null;

                    // get size of canvas
                    Size size = new Size(can.Width, can.Height);

                    // measure and arrange the canvas
                    can.Measure(size);
                    can.Arrange(new Rect(size));

                    // create and render surface and push bitmap to it
                    RenderTargetBitmap renderBitmap = new RenderTargetBitmap((Int32)size.Width, (Int32)size.Height, 100d, 100d, PixelFormats.Pbgra32);

                    // now render surface to bitmap
                    renderBitmap.Render(can);

                    // puch rendered bitmap into it
                    encoder.Frames.Add(BitmapFrame.Create(renderBitmap));

                    encoder1 = encoder;

                    //passing encoder to plotreceiver module
                    returnEncoderImage();

                    // create image to return
                   /* Image returnImage = new Image();
                    // set source of image as frame
                    returnImage.Source = encoder.Frames[0];

                    // restore previously saved layout
                    can.LayoutTransform = transform;

                    //check if the directory exists or not and if not exist create a new one.
                    if (!Directory.Exists(imagepath))
                        Directory.CreateDirectory(imagepath);

                    // string for saving
                    String tempPath = imagepath + "\\image.png";

                    // create a file stream for saving image
                    using (FileStream outStream = new FileStream(tempPath, FileMode.Create))
                    {
                        encoder.Save(outStream);
                    } */

                }
                catch (Exception e)
                {
                    OnError(123, e.Message);
                }
            }
            else
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                int resized_pane_number = 0;

                Canvas resized_canvas = new Canvas();


                //IDictionaryEnumerator entry = Canvas_Obj.GetEnumerator();
                foreach (DictionaryEntry entry in Canvas_Obj)
                {

                    Canvas canvas_value = (Canvas)entry.Value;
                    if (canvas_value.ActualHeight != can.Height)
                    {
                        resized_canvas = resize_canvas(canvas_value, pane_number);                        
                        resized_pane_number = FindKey(canvas_value);
                        Updates.Add(resized_pane_number, resized_canvas);
                    }
                }
                foreach (DictionaryEntry upd in Updates)
                {
                    Canvas_Obj[upd.Key] = upd.Value;
                }


                Canvas_Obj[pane_number] = can;
                Canvas cannew = new Canvas();
                cannew = mergePlots();
                


                Transform transform = can.LayoutTransform;

                // reset current transform incase of scalling or rotating
                 can.LayoutTransform = null;

                // get size of canvas
                Size size = new Size(cannew.Width,cannew.Height);

                // measure and arrange the canvas 
                cannew.Measure(size);
                cannew.Arrange(new Rect(size));

                // create and render surface and push bitmap to it
                RenderTargetBitmap renderBitmap = new RenderTargetBitmap((Int32)size.Width, (Int32)size.Height, 100d, 100d, PixelFormats.Pbgra32);

                // now render surface to bitmap
                renderBitmap.Render(cannew);

                // puch rendered bitmap into it
                encoder.Frames.Add(BitmapFrame.Create(renderBitmap));

                encoder1 = encoder;
                //passing encoder to plotreceiver module
                returnEncoderImage();

                // create image to return
                /*Image returnImage = new Image();
                // set source of image as frame
                returnImage.Source = encoder.Frames[0];

                // restore previously saved layout
                 can.LayoutTransform = transform;

                //check if the directory exists or not and if not exist create a new one.
                if (!Directory.Exists(imagepath))
                    Directory.CreateDirectory(imagepath);

                // string for saving
                String tempPath = imagepath + "\\image.png";

                // create a file stream for saving image
                using (FileStream outStream = new FileStream(tempPath, FileMode.Create))
                {
                    encoder.Save(outStream);
                }*/
                


            }


        }
        public int FindKey(Canvas myValue)
        {
            int myKey = 0;

            foreach (int aKey in Canvas_Obj.Keys)
            {
                if (Canvas_Obj[aKey] == myValue)
                    myKey = aKey;
            }
            return myKey;
        }

        public Canvas resize_canvas(Canvas resize_canvas, int size_number)
        {
            //int i = resize_canvas.Children.Count;
            //System.Windows.Shapes.Path p = new System.Windows.Shapes.Path();
            //p = (System.Windows.Shapes.Path)resize_canvas.Children[i - 1];
            //GeometryGroup temp = (GeometryGroup)p.GetValue(System.Windows.Shapes.Path.DataProperty);
            //List<Point> templist = new List<Point>();
            //for (int k = 0; k < temp.Children.Count; k++)
            //{
            //    EllipseGeometry elg = (EllipseGeometry)temp.Children[k];
            //    templist.Add(elg.Center);
            //}
            //paint.subplot2D(templist, size_number);
            return paint.resubplot2D();
        }
        public Canvas mergePlots()
        {
            
            Canvas newCanvas = new Canvas();
            newCanvas.Children.Capacity = 4;
            newCanvas.Height = 550;
            newCanvas.Width = 550;
            foreach (DictionaryEntry entry in Canvas_Obj)
            {
                Canvas canvas_value = (Canvas)entry.Value;
                if (canvas_value.Parent != null)
                {
                    Canvas temp = (Canvas)canvas_value.Parent;
                    temp.Children.Remove(canvas_value);
                }
                switch ((int)entry.Key)
                {
                    case 1:
                        Canvas.SetTop(canvas_value, 0);
                        Canvas.SetLeft(canvas_value, 0);
                        break;
                    case 2:
                        Canvas.SetTop(canvas_value, 0);
                        Canvas.SetLeft(canvas_value, 250);
                        break;
                    case 3:
                        Canvas.SetTop(canvas_value, 250);
                        Canvas.SetLeft(canvas_value, 0);
                        break;
                    case 4:
                        Canvas.SetTop(canvas_value, 250);
                        Canvas.SetLeft(canvas_value, 250);
                        break;
                }

                newCanvas.Children.Add(canvas_value);

            }
            return newCanvas;
        }

        public PngBitmapEncoder returnEncoderImage()
        {
            return encoder1;
        }
    }
}



