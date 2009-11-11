////////////////////////////////////////////////////////////////////////
// Paint.cs - contains Paint class which generates points and returns
//            Canvas object depending on the properties and data given to
//            it.
// version: 1.0
// 
// author: Mahesh Uma Gudladona (ugudlado@syr.edu)
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


namespace PlotModule
{
    class Paint
    {   //Private data members
        private int numPanes;
        private int spanX,spanY;
        private Point origin;
        private Canvas activeCanvas;
        private List<Point> pointslist;
        //Properties
        #region Properties        
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
        #endregion

        #region Methods
        //Methods

        //Paint Constructor
        public Paint()
        {
            numPanes = 1;
            spanX = 20;
            spanY = 20;            
            origin = new Point(20,20);
        }

        //Method for setting axes
        public void setAxes() 
        {
            origin = new Point(activeCanvas.Width / 2, activeCanvas.Height / 2);
            Canvas canvas = activeCanvas;
            double xstep = spanX; 
            double ystep = -spanY;
            Line l = new Line();
            l.X1 = origin.X;
            l.Y1 = origin.Y;
            l.X2 = canvas.Width;
            l.Y2 = origin.Y;
            l.Stroke = Brushes.Black;
            Line ly = new Line();
            ly.X1 = origin.X;
            ly.Y1 = origin.Y - canvas.Height;
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
            ly1.Y1 = canvas.Height;
            ly1.X2 = origin.X;
            ly1.Y2 = origin.Y;
            ly1.Stroke = Brushes.Black;            
            canvas.Children.Add(ly);
            canvas.Children.Add(l);
            canvas.Children.Add(ly1);
            canvas.Children.Add(l1);
            Path path1 = new Path();
            path1.Fill = Brushes.Black;
            GeometryGroup gg = new GeometryGroup();           
            TextBlock txt = new TextBlock();
            TextBlock txt1 = new TextBlock();
            int i = 1;
            txt.Text = Convert.ToString(0);
            Canvas.SetLeft(txt, origin.X - 5);
            Canvas.SetTop(txt, origin.Y);
            gg.Children.Add(new EllipseGeometry(origin, 2, 2));
            canvas.Children.Add(txt);
            while ((origin.X + xstep < canvas.Width) || (origin.Y + ystep > 0))
            {
                Point px = (origin.X + xstep < canvas.Width) ? new Point(origin.X + xstep, origin.Y) : new Point(origin.X, origin.Y);
                Point py = (origin.Y + ystep > 0) ? new Point(origin.X, origin.Y + ystep) : new Point(origin.X, origin.Y);
                EllipseGeometry elg = new EllipseGeometry(px, 2, 2);
                txt = new TextBlock();
                txt1 = new TextBlock();
                txt.Text = Convert.ToString(i);
                Canvas.SetLeft(txt, origin.X + spanX * i);
                Canvas.SetTop(txt, origin.Y);
                EllipseGeometry elg1 = new EllipseGeometry(py, 2, 2);
                txt1.Text = Convert.ToString(i);
                Canvas.SetLeft(txt1, (origin.X - spanX + 5));
                Canvas.SetTop(txt1, (origin.Y - spanY * i));
                canvas.Children.Add(txt);
                canvas.Children.Add(txt1);
                gg.Children.Add(elg);
                gg.Children.Add(elg1);
                xstep += spanX;
                ystep -= spanY;
                i++;
            }

            
            path1.Data = gg;
            canvas.Children.Add(path1);
        }

        //Helper method for setting text at specified point on Pane
        private void setText(ref Point origin, Canvas can, ref Point point)
        {
            TextBlock txt = new TextBlock();
            txt.Text = ((point.X - origin.X) / spanX).ToString() + "," + ((origin.Y - point.Y) / spanX).ToString();
            Canvas.SetLeft(txt, point.X - 10);
            Canvas.SetTop(txt, point.Y);
            can.Children.Add(txt);
        }

        //Helper method for transforming values to 2D points
        public List<Point> transformValuesToPoints(int[] pvalues)
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
        public void plotPoints(int[] plist, Canvas can)
        {
            pointslist=transformValuesToPoints(plist);            
            activeCanvas = can;
            setAxes();            
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
            setText(ref origin, can, ref stpoint);
            for (int i = 1; i < pointslist.Count; i++)
            {
                Point point = pointslist[i];
                point.X = origin.X + spanX * point.X;
                point.Y = origin.Y - spanY * point.Y;
                LineSegment ls = new LineSegment(point, true);
                elg = new EllipseGeometry(point, 2, 2);
                setText(ref origin, can, ref point);
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
        public void subplot2D(int[] plist,int panenum,Canvas can)
        {
            activeCanvas = can;
            adjustPaneSize(panenum);
            plotPoints(plist, activeCanvas);
        }

        //Helper method which adjusts the pane size depending on the number of panes property
        void adjustPaneSize(int panenum)
        {
            int wfactor=1;
            int hfactor = 1;
            if (panenum > NumberPanes)
            {
                switch (panenum - NumberPanes)
                {                    
                    case 1:
                        NumberPanes *= 2;
                        break;
                    case 2:
                    case 3:
                        NumberPanes = 4;
                        break;
                    default:
                        NumberPanes = 1;
                        break;
                }
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
        //        setText(ref origin, can, ref point);
        //        can.Children.Add(el);

        //    }

        //}
        #endregion

    }
}
