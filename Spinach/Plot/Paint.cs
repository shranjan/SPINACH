////////////////////////////////////////////////////////////////////////
// Paint.cs - contains Paint class which generates points and returns
//            Canvas object depending on the properties and data given to
//            it.
// version: 1.0
// 
// author: Mahesh Uma Gudladona (ugudlado@syr.edu) & Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: C#
////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;


namespace Spinach
{
    // Paints the canvas
    class Paint
    {   //Private data members
        private int numPanes;
        private int spanX,spanY;
        private double factx, facty;
        private Point origin;
        private Canvas activeCanvas;
        private Canvas smallCanvas;
        private List<Point> pointslist;
        private PlotManager pm;
        private int mode;
        private string xtitle;
        private string ytitle;
        private string ztitle;
        private string plottitle;

        public delegate void PlotError(int code, string message);
        public event PlotError error;

        public void OnError(int code, string message)
        {
            if (error != null)
                error(code, message);

        } 

        //Properties
        #region Properties    
        public string Xtitle
        {
            get { return xtitle; }
            set { xtitle = value; }
        }

        public PlotManager pmanager
        {
            get { return pm; }
            set { pm = value; }

        }
        public string Ytitle
        {
            get { return ytitle; }
            set { ytitle = value; }
        }

        public string Ztitle
        {
            get { return ztitle; }
            set { ztitle = value; }
        }

        public string Plottitle
        {
            get { return plottitle; }
            set { plottitle = value; }
        }
            
        //Number of Panes
        public int NumberPanes  
        {           
            get { return numPanes; }
            set { numPanes = value; }
        }

        //Origin of Plot
        public Point Origin 
        {
            get { return origin; }
            set { origin = value; }
        }

        //Active Canvas
        public Canvas ActiveCanvas
        {
            get { return activeCanvas; }
            set { activeCanvas = value; }
        }

        //X-Factor
        public double X_Fact
        {
            get{return factx;}
            set { factx = value; }
        }

        //Y-Factor
        public double Y_Fact
        {
            get { return facty; }
            set { facty = value; }
        }

        //Scale Mode
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }
        #endregion

        #region Methods
        //Methods

        //Paint Constructor
        public Paint()
        {
            numPanes = 1;
            spanX = 30;
            spanY = 30;
            activeCanvas = new Canvas();
            activeCanvas.Width = 500;
            activeCanvas.Height = 500;
            mode = 1;
            factx = 1;
            facty = 1;
            Xtitle = "X-Axis";
            Ytitle = "Y-Axis";
            Plottitle = "sample plot";
            pm = new PlotManager(this);
            pm.error += new PlotManager.PlotError(OnError);
        }

        //Reset method
        public void reset()
        {
            numPanes = 1;
            spanX = 30;
            spanY = 30;      
            activeCanvas = new Canvas();
            mode = 1;
            pm = new PlotManager(this);
        }


        //Method for setting Xaxis Title
        public void setXaxisTitle(string title)
        {
            Point xpoint = new Point();
            double x = (activeCanvas.Width - Origin.X) / 2;
            xpoint.X = x + Origin.X;
            xpoint.Y = Origin.Y + 5;
            setText(title, xpoint);
            
        }
        //Method for setting Yaxis Title
        public void setYaxisTitle(string title)
        {
            Point ypoint = new Point();
            double y = Origin.Y / 2;
            ypoint.X = Origin.X - 35;
            ypoint.Y = y;
            setText(title, ypoint);

        }

        ////Method for setting zaxis Title
        //private void setzaxisTitle(string title)
        //{
        //    Point zpoint = new Point();
        //    double z = activeCanvas.Width / 2;
        //    ypoint.X = origin.X - 35;
        //    ypoint.Y = y;
        //    setText(title, ypoint);

        //}

        //Method for setting Plot Title
        public void setPlotTitle(string title)
        {
            Point point = new Point();
            double x = (activeCanvas.Width - Origin.X);
            x = 0.8 * x;
            point.X = x + Origin.X;
            double y = activeCanvas.Height - Origin.Y;
            point.Y = 0.2 * y;
            setText(title, point);

        }



        //Method for setting axes        

        private string pointToText(Point point)
        {
            string temp = ((point.X - origin.X) / spanX).ToString() + "," + ((origin.Y - point.Y) / spanY).ToString();
            return temp;
        }

        //Helper method for setting text at specified point on Pane
        private void setText(string pointText,Point point)
        {
            TextBlock txt = new TextBlock();
            txt.Text = pointText;
            Canvas.SetLeft(txt, point.X );
            Canvas.SetTop(txt, point.Y);
            activeCanvas.Children.Add(txt);
        }

        //Helper method for transforming values to 2D points
        private List<Point> transformValuesToPoints(double[] pvalues)
        {
            List<Point> templist = new List<Point>();
            for (int i = 0; i < pvalues.GetLength(0); i++)
            {
                Point temp = new Point(i, pvalues[i]);
                templist.Add(temp);
            }
            return templist;
        }

        //Plot method for displaying value into 2D points in a line graph
        public void plot2D(double[] plist)
        {
            activeCanvas = new Canvas();
            activeCanvas.Width = 500;
            activeCanvas.Height = 500;
            try
            {
                switch (mode)
                {
                    case 1: pointslist = transformValuesToPoints(plist);
                        plotPoints(pointslist);
                        break;
                    case 2:
                        pointslist = transformValuesToPoints(plist);
                        plotLogPoints();
                        break;
                }
                pm.Convert_to_Image(activeCanvas, -1);
                subplot2D(plist, -1);
                activeCanvas = new Canvas();
                activeCanvas.Width = 500;
                activeCanvas.Height = 500;
            }
            catch (Exception e)
            {
                OnError(122, e.Message);
            }
        }                


        public void plotPoints(List<Point> pointslist)
        {                        
            setAxes();
            setXaxisTitle(Xtitle);
            setYaxisTitle(Ytitle);
            setPlotTitle(Plottitle);
            GeometryGroup s = new GeometryGroup();
            PathGeometry pg = new PathGeometry();
            PathFigureCollection pfc = new PathFigureCollection();
            PathFigure pf = new PathFigure();
            PathSegmentCollection psc = new PathSegmentCollection();
            Point stpoint = pointslist[0];            
            stpoint.X = origin.X + spanX * stpoint.X;
            stpoint.Y = origin.Y - spanY * stpoint.Y;
            pf.StartPoint = stpoint;
            EllipseGeometry elg = new EllipseGeometry(stpoint, 2, 2);
            s.Children.Add(elg);
            string pointText = pointToText(stpoint);
            setText(pointText,stpoint);
            for (int i = 1; i < pointslist.Count; i++)
            {
                Point point = pointslist[i];
                point.X = origin.X + spanX * point.X ;
                point.Y = origin.Y - spanY * point.Y;
                LineSegment ls = new LineSegment(point, true);
                elg = new EllipseGeometry(point, 2, 2);
                setText(pointToText(point),point);
                s.Children.Add(elg);
                psc.Add(ls);
            }
            pf.Segments = psc;
            pfc.Add(pf);           
            pg.Figures = pfc;
            Path p = new Path();
            Path p1 = new Path();
            p.Data = pg;            
            p.Stroke = Brushes.Green;
            p1.Data = s;
            p1.Fill = Brushes.Blue;            
            activeCanvas.Children.Add(p);
            activeCanvas.Children.Add(p1);
            activeCanvas.ClipToBounds = true;            
        }

        //Method to plot depending on the given pane number
        public void subplot2D(double[] plist,int panenum)
         {
            if (panenum != -1){
            activeCanvas = new Canvas();
            activeCanvas.Width = 500;
            activeCanvas.Height = 500;
            adjustPaneSize(4);
            pointslist = transformValuesToPoints(plist);
            if (mode == 1)
                plotPoints(pointslist);
            else
                plotLogPoints();
            pm.Convert_to_Image(activeCanvas, panenum);
            }
            else{
                activeCanvas = new Canvas();
                activeCanvas.Width = 500;
                activeCanvas.Height = 500;
                adjustPaneSize(4);
                pointslist = transformValuesToPoints(plist);
                if (mode == 1)
                    plotPoints(pointslist);
                else
                    plotLogPoints();
                smallCanvas = activeCanvas;
            }                           
        }

        public Canvas resubplot2D()
        {            
            
            return smallCanvas;
        }


        //Helper method which adjusts the pane size depending on the number of panes property
        private void adjustPaneSize(int panenum)
        {
            int wfactor=1;
            int hfactor = 1;
            if (panenum > NumberPanes)
            {
                switch (panenum - NumberPanes)
                {                    
                    case 1:                             
                    case 2:
                    case 3:
                        NumberPanes = 4;
                        break;
                    default:
                        NumberPanes = 1;
                        break;
                }
                //NumberPanes *= 2;
                //break;
            }
            switch (NumberPanes)
            {
                case 2:
                    wfactor = 2;
                    break;
                case 4:
                    wfactor = 2;
                    hfactor = 2;
                    break;
                default:
                    wfactor = 1;
                    hfactor = 1;
                    break;
            }
            activeCanvas.Width = 500 / wfactor;
            activeCanvas.Height = 500 / hfactor;
        }
   
        #endregion

        #region 3DMethods
        //Helper method for transforming values to 3D points
        //public List<Point3D> transformValuesTo3DPoints(int[,] pvalues)
        //{
        //    List<Point3D> templist = new List<Point3D>();
        //    for (int i = 0; i < pvalues.GetLength(1); i++)
        //    {
        //        for(int j=0;j<pvalues.GetLength(0);j++){
        //            Point3D temp = new Point3D(i+1,j+1,pvalues[i,j]);
        //            templist.Add(temp);
        //        }
        //    }
        //    return templist;
        //}

        //Method to plot 3D data into 2D with z-index as color variation
        //public void plot3DInto2D(int[,] values,Canvas can)
        //{
        //    List<Point3D> plist = transformValuesTo3DPoints(values);
        //    activeCanvas = can;
        //    setAxes();            
        //    GeometryGroup s = new GeometryGroup();                    
        //    for (int i = 0; i < plist.Count; i++)
        //    {
        //        Point point = new Point(plist[i].X, plist[i].Y);
        //        point.X = origin.X + 20 * point.X;
        //        point.Y = origin.Y - 20 * point.Y;
        //        Ellipse el = new Ellipse();
        //        el.Height = 8;
        //        el.Width = 8;
        //        Canvas.SetLeft(el, point.X);
        //        Canvas.SetTop(el, point.Y);
        //        Color c = new Color();
        //        c.ScR = 1 - i * 0.1F;
        //        c.ScG = i * 0.1F;
        //        c.ScB = i * 0.2F;
        //        c.ScA = 1;
        //        el.Fill = new SolidColorBrush(c);
        //        el.Stroke = Brushes.Black;
        //        setText(pointToText(point), point);
        //        can.Children.Add(el);

        //    }

        //}
        #endregion

        #region Rushabh
        // made by rushabh
        public Point MinPoint()
        {
            Point MinXY = pointslist[0];
            for (int i = 1; i < pointslist.Count; i++)
            {
                if (pointslist[i].X < MinXY.X)
                    MinXY.X = pointslist[i].X;
                if (pointslist[i].Y < MinXY.Y)
                    MinXY.Y = pointslist[i].Y;
            }
            return (MinXY);
        }

        // made by rushabh
        public Point MaxPoint()
        {
            Point MaxXY = pointslist[0];
            for (int i = 1; i < pointslist.Count; i++)
            {
                if (pointslist[i].X > MaxXY.X)
                    MaxXY.X = pointslist[i].X;
                if (pointslist[i].Y > MaxXY.Y)
                    MaxXY.Y = pointslist[i].Y;
            }
            return (MaxXY);
        }

        // made by rushabh
        private void CalOrigin()
        {
            Point min = MinPoint();
            Point max = MaxPoint();
            double orix = ((max.X >= 0 && min.X <= 0) || (max.X <= 0 && min.X >= 0)) ? Math.Abs(min.X) + 1 : (min.X > 0) ? 1 : Math.Abs(min.X) + 1;
            double oriy = ((max.Y >= 0 && min.Y <= 0) || (max.Y <= 0 && min.Y >= 0)) ? Math.Abs(min.Y) + 1 : (min.Y > 0) ? 1 : Math.Abs(min.Y) + 1;
            Origin = new Point(orix * spanX, activeCanvas.Height - ((oriy * spanY)));
        }

        // made by rushabh
        public void setScale()
        {
            Point minPt = MinPoint();
            Point maxPt = MaxPoint();
            double Xlen = ((maxPt.X >= 0 && minPt.X <= 0) || (maxPt.X <= 0 && minPt.X >= 0)) ? (Math.Abs(maxPt.X) + Math.Abs(minPt.X)) + 2 : (minPt.X > 0) ? maxPt.X + 2 : Math.Abs(minPt.X) + 2;
            double Ylen = ((maxPt.Y >= 0 && minPt.Y <= 0) || (maxPt.Y <= 0 && minPt.Y >= 0)) ? (Math.Abs(maxPt.Y) + Math.Abs(minPt.Y)) + 2 : (minPt.Y > 0) ? maxPt.Y + 2 : Math.Abs(minPt.Y) + 2;
            spanX = (int)(activeCanvas.Width / Xlen / factx);
            spanY = (int)(activeCanvas.Height / Ylen / facty);
            spanX=spanX==0?1:spanX;
            spanY=spanY==0?1:spanY;
        }

        // changed by rushabh
        public void setAxes()
        {
            EllipseGeometry elg;
            setScale();
            CalOrigin();
            double xstep = spanX;
            double ystep = -spanY;
            Line l = new Line();
            l.X1 = origin.X;
            l.Y1 = origin.Y;
            l.X2 = activeCanvas.Width;
            l.Y2 = origin.Y;
            l.Stroke = Brushes.Black;
            Line ly = new Line();
            ly.X1 = origin.X;
            ly.Y1 = origin.Y - activeCanvas.Height;
            ly.X2 = origin.X;
            ly.Y2 = origin.Y;
            ly.Stroke = Brushes.Black;
            Line l1 = new Line();
            l1.X1 = origin.X;
            l1.Y1 = origin.Y;
            l1.X2 = 0;
            l1.Y2 = origin.Y;
            l1.Stroke = Brushes.Black;
            Line ly1 = new Line();
            ly1.X1 = origin.X;
            ly1.Y1 = activeCanvas.Height;
            ly1.X2 = origin.X;
            ly1.Y2 = origin.Y;
            ly1.Stroke = Brushes.Black;
            activeCanvas.Children.Add(ly);
            activeCanvas.Children.Add(l);
            activeCanvas.Children.Add(ly1);
            activeCanvas.Children.Add(l1);
            Path path1 = new Path();
            path1.Fill = Brushes.Black;
            GeometryGroup gg = new GeometryGroup();

            int jx, jy, xtext, ytext;
            int xpart = (int)activeCanvas.Width / spanX;
            int ypart = (int)activeCanvas.Height / spanY;
            //xtext = jx = (xpart < 25) ? 1 : (xpart < 50) ? 2 : (xpart < 100) ? 5 : (xpart < 200) ? 10 : 50;
            //ytext = jy = (ypart < 25) ? 1 : (ypart < 50) ? 2 : (ypart < 100) ? 5 : (ypart < 200) ? 10 : 50;
            xtext = jx = Math.Ceiling((double)xpart / 10) == 0 ? 1 : (int)Math.Ceiling((double)xpart / 10);
            ytext = jy = Math.Ceiling((double)ypart / 10) == 0 ? 1 : (int)Math.Ceiling((double)ypart / 10);
            xstep *= jx;
            ystep *= jy;
            int xincre = (int)xstep;
            int yincre = (int)ystep;

            setText(Convert.ToString(0), new Point(origin.X - 5, origin.Y));
            gg.Children.Add(new EllipseGeometry(origin, 2, 2));
            while ((origin.X + xstep < activeCanvas.Width) || (origin.Y + ystep > 0) || (origin.X - xstep > 0) || (origin.Y - ystep < activeCanvas.Height))
            {
                Point px = (origin.X + xstep < activeCanvas.Width) ? new Point(origin.X + xstep, origin.Y) : new Point(origin.X, origin.Y);
                Point py = (origin.Y + ystep > 0) ? new Point(origin.X, origin.Y + ystep) : new Point(origin.X, origin.Y);
                Point pnx = (origin.X - xstep > 0) ? new Point(origin.X - xstep, origin.Y) : new Point(origin.X, origin.Y);
                Point pny = (origin.Y - ystep < activeCanvas.Height) ? new Point(origin.X, origin.Y - ystep) : new Point(origin.X, origin.Y);

                elg = new EllipseGeometry(px, 2, 2);
                setText(Convert.ToString(xtext), new Point(origin.X + xstep, origin.Y));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(py, 2, 2);
                setText(Convert.ToString(ytext), new Point(origin.X - 10, origin.Y + ystep));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(pnx, 2, 2);
                setText(Convert.ToString(-xtext), new Point(origin.X - xstep, origin.Y));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(pny, 2, 2);
                setText(Convert.ToString(-ytext), new Point(origin.X - 10, origin.Y - ystep));
                gg.Children.Add(elg);

                xstep += xincre;
                ystep += yincre;
                xtext += jx;
                ytext += jy;
            }
            path1.Data = gg;
            activeCanvas.Children.Add(path1);
        }

        //changed by Rushabh
        private void setlogAxes()
        {
            EllipseGeometry elg;
            setLogScale();
            CalLogOrigin();
            double xstep = spanX;
            double ystep = -spanY;
            Line l = new Line();
            l.X1 = origin.X;
            l.Y1 = origin.Y;
            l.X2 = activeCanvas.Width;
            l.Y2 = origin.Y;
            l.Stroke = Brushes.Black;
            Line ly = new Line();
            ly.X1 = origin.X;
            ly.Y1 = origin.Y - activeCanvas.Height;
            ly.X2 = origin.X;
            ly.Y2 = origin.Y;
            ly.Stroke = Brushes.Black;
            Line l1 = new Line();
            l1.X1 = origin.X;
            l1.Y1 = origin.Y;
            l1.X2 = 0;
            l1.Y2 = origin.Y;
            l1.Stroke = Brushes.Black;
            Line ly1 = new Line();
            ly1.X1 = origin.X;
            ly1.Y1 = activeCanvas.Height;
            ly1.X2 = origin.X;
            ly1.Y2 = origin.Y;
            ly1.Stroke = Brushes.Black;
            activeCanvas.Children.Add(ly);
            activeCanvas.Children.Add(l);
            activeCanvas.Children.Add(ly1);
            activeCanvas.Children.Add(l1);
            Path path1 = new Path();
            path1.Fill = Brushes.Black;
            GeometryGroup gg = new GeometryGroup();

            int jx, jy, xtext, ytext;
            int xpart = (int)activeCanvas.Width / spanX;
            int ypart = (int)activeCanvas.Height / spanY;
            xtext = jx = (xpart < 25) ? 1 : (xpart < 50) ? 2 : (xpart < 100) ? 5 : (xpart < 200) ? 10 : 50;
            ytext = 10;
            jy = 10;
            xstep *= jx;
            int xincre = (int)xstep;
            int yincre = (int)ystep;

            setText(Convert.ToString(0), new Point(origin.X - 5, origin.Y));
            gg.Children.Add(new EllipseGeometry(origin, 2, 2));
            while ((origin.X + xstep < activeCanvas.Width) || (origin.Y + ystep > 0) || (origin.X - xstep > 0) || (origin.Y - ystep < activeCanvas.Height))
            {
                Point px = (origin.X + xstep < activeCanvas.Width) ? new Point(origin.X + xstep, origin.Y) : new Point(origin.X, origin.Y);
                Point py = (origin.Y + ystep > 0) ? new Point(origin.X, origin.Y + ystep) : new Point(origin.X, origin.Y);
                Point pnx = (origin.X - xstep > 0) ? new Point(origin.X - xstep, origin.Y) : new Point(origin.X, origin.Y);
                Point pny = (origin.Y - ystep < activeCanvas.Height) ? new Point(origin.X, origin.Y - ystep) : new Point(origin.X, origin.Y);

                elg = new EllipseGeometry(px, 2, 2);
                setText(Convert.ToString(xtext), new Point(origin.X + xstep, origin.Y));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(py, 2, 2);
                setText(Convert.ToString(ytext), new Point(origin.X - 10, origin.Y + ystep));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(pnx, 2, 2);
                setText(Convert.ToString(-xtext), new Point(origin.X - xstep, origin.Y));
                gg.Children.Add(elg);

                elg = new EllipseGeometry(pny, 2, 2);
                setText(Convert.ToString(-1 / ytext), new Point(origin.X - 10, origin.Y - ystep));
                gg.Children.Add(elg);

                xstep += xincre;
                ystep += yincre;
                xtext += jx;
                ytext *= jy;
            }
            path1.Data = gg;
            activeCanvas.Children.Add(path1);
        }

        //changed by rushabh
        private void plotLogPoints()
        {
            setlogAxes();
            setXaxisTitle(Xtitle);
            setYaxisTitle(Ytitle);
            setPlotTitle(Plottitle);
            GeometryGroup s = new GeometryGroup();
            PathGeometry pg = new PathGeometry();
            PathFigureCollection pfc = new PathFigureCollection();
            PathFigure pf = new PathFigure();
            PathSegmentCollection psc = new PathSegmentCollection();
            Point stpoint = pointslist[0];
            Point pt = new Point();
            //stpoint.X = Math.Round(origin.X + spanX * stpoint.X, 2);
            //stpoint.Y = Math.Round(origin.Y - spanY * stpoint.Y, 2);
            pt.X = Math.Round(origin.X + spanX * stpoint.X, 2);
            pt.Y = Math.Round(origin.Y - spanY * Math.Log10(stpoint.Y), 2);

            pf.StartPoint = pt;
            EllipseGeometry elg = new EllipseGeometry(pt, 2, 2);
            s.Children.Add(elg);
            setText(pointToText(stpoint), pt);
            for (int i = 1; i < pointslist.Count; i++)
            {
                Point point = pointslist[i];
                point.X = Math.Round(point.X, 2);
                point.Y = Math.Round(point.Y, 2);
                pt.X = Math.Round(origin.X + spanX * point.X, 2);
                pt.Y = Math.Round(origin.Y - spanY * Math.Log10(point.Y), 2);
                LineSegment ls = new LineSegment(pt, true);
                elg = new EllipseGeometry(pt, 2, 2);
                setText(point.X.ToString() + "," + point.Y.ToString(), pt);
                s.Children.Add(elg);
                psc.Add(ls);
            }
            pf.Segments = psc;
            pfc.Add(pf);
            pg.Figures = pfc;
            Path p = new Path();
            Path p1 = new Path();
            p.Data = pg;
            p.Stroke = Brushes.Green;
            p1.Data = s;
            p1.Fill = Brushes.Blue;
            activeCanvas.Children.Add(p);
            activeCanvas.Children.Add(p1);
            activeCanvas.ClipToBounds = true;
        }

        //made by rushabh
        private void CalLogOrigin()
        {
            Point min = MinPoint();
            Point max = MaxPoint();
            double orix = ((max.X >= 0 && min.X <= 0) || (max.X <= 0 && min.X >= 0)) ? Math.Abs(min.X) + 1 : (min.X > 0) ? 1 : Math.Abs(min.X) + 1;
            double oriy = ((Math.Log10(max.Y) >= 0 && Math.Log10(min.Y) <= 0) || (Math.Log10(max.Y) <= 0 && Math.Log10(min.Y) >= 0)) ? Math.Abs(Math.Log10(min.Y)) : (Math.Log10(min.Y) > 0) ? 0.1 : Math.Abs(Math.Log10(min.Y));
            Origin = new Point(orix * spanX, activeCanvas.Height - ((oriy * spanY)));
        }

        // made by rushabh
        private void setLogScale()
        {
            Point minPt = MinPoint();
            Point maxPt = MaxPoint();
            double Xlen = ((maxPt.X >= 0 && minPt.X <= 0) || (maxPt.X <= 0 && minPt.X >= 0)) ? (Math.Abs(maxPt.X) + Math.Abs(minPt.X)) + 2 : (minPt.X > 0) ? maxPt.X + 2 : Math.Abs(minPt.X) + 2;
            double Ylen = Math.Ceiling(((Math.Log10(maxPt.Y) >= 0 && Math.Log10(minPt.Y) <= 0) || (Math.Log10(maxPt.Y) <= 0 && Math.Log10(minPt.Y) >= 0)) ? (Math.Abs(Math.Log10(maxPt.Y)) + Math.Abs(Math.Log10(minPt.Y))) : ((Math.Log10(minPt.Y)) > 0) ? Math.Log10(maxPt.Y) : Math.Abs(Math.Log10(minPt.Y)));
            Ylen += Ylen / 10;
            spanX = (int)(activeCanvas.Width / Xlen / factx);
            spanY = (int)(activeCanvas.Height / Ylen / facty);
        }

        #endregion

        
    }

    
}

