////////////////////////////////////////////////////////////////////////
// Plot.cs: Class fr Core team to create object of plot class and store the data
// 
// version: 1.0
// description: Create object of plot and store data for plot command
// author: Rushabh Ravindra Gandhi (rugandhi@syr.edu)
// language: Visual C#
////////////////////////////////////////////////////////////////////////
namespace Spinach
{
    public class Plot
    {
        private int paneno;
        private double[,] data;
        private string plottitle;
        private int mode;
        private int dimensions;
        private double x_fact;
        private double y_fact;
        private double z_fact;
        private string x_axis_name;
        private string y_axis_name;
        private string z_axis_name;
        private int scalemode;
        private string command_name;

        #region Properties

        //Number of Panes
        public int PaneNum
        {
            get { return paneno; }
            set { paneno = value; }
        }

        //Data
        public double[,] Data
        {
            get { return data; }
            set { data = value; }
        }

        //Title of Plot
        public string PlotTitle
        {
            get { return plottitle; }
            set { plottitle = value; }
        }

        //Mode for 3D plots
        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        //Dimensions of the Plot
        public int Dimensions
        {
            get { return dimensions; }
            set { dimensions = value; }
        }

        //Change the Scale of X-Axis
        public double X_Fact
        {
            get { return x_fact; }
            set { x_fact = value; }
        }

        //Change the Scale of Y-Axis
        public double Y_Fact
        {
            get { return y_fact; }
            set { y_fact = value; }
        }

        //Change the Scale of Z-Axis
        public double Z_Fact
        {
            get { return z_fact; }
            set { z_fact = value; }
        }

        //Set the X-Axis Title
        public string X_Axis_Title
        {
            get { return x_axis_name; }
            set { x_axis_name = value; }
        }

        //Set the Y-Axis Title
        public string Y_Axis_Title
        {
            get { return y_axis_name; }
            set { y_axis_name = value; }
        }

        //Set the Z-Axis Title
        public string Z_Axis_Title
        {
            get { return z_axis_name; }
            set { z_axis_name = value; }
        }

        //Set the scale mode 
        public int ScaleMode
        {
            get { return scalemode; }
            set { scalemode = value; }
        }

        //Name of the command
        public string Command
        {
            get { return command_name; }
            set { command_name = value; }
        }

        #endregion
    }
}
