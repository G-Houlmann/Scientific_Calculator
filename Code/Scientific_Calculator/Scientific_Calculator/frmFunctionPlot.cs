using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using org.mariuszgromada.math.mxparser;

namespace Scientific_Calculator
{
    /// <summary>
    /// Form that displays a graph from a given function
    /// </summary>
    public partial class frmFunctionPlot : Form
    { 
        private Graphics _g;
        private Pen _pen;
        private Pen _scalePen;
        Brush _graphBrush;
        Brush _scaleBrush;
        Point _origin = new Point(200, 200);
        List<Label> lstLabels = new List<Label>();

        /// <summary>
        /// Returns the value of the trbScaleX trackbar
        /// </summary>
        public double ScaleX
        {
            get { return trbScaleX.Value; }
        }

        /// <summary>
        /// Returns the value of the trbScaleY trackbar
        /// </summary>
        public double ScaleY
        {
            get { return trbScaleY.Value; }
        }

        /// <summary>
        /// Returns the value of the trbAccuracy trackbar
        /// </summary>
        public double Accuracy
        {
            get { return trbAccuracy.Value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public frmFunctionPlot()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retrieves the function string when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdFunction_Click(object sender, EventArgs e)
        {
            DrawPlot(txtFunction.Text);
        }

        /// <summary>
        /// Erases the previous labels that were used to show values on the scales in the previous graph
        /// </summary>
        private void ErasePreviousScale()
        {
            foreach (Label l in lstLabels)
            {
                Controls.Remove(l);
                l.Dispose();
            }   
        }

        /// <summary>
        /// Creates a label used to show values on the axis
        /// </summary>
        /// <param name="text">The number that will be displayed on the label</param>
        /// <param name="x">the X coordinate</param>
        /// <param name="y">the Y coordinate</param>
        private void createLabel(string text, int x, int y)
        {
            Label currentLabel = new Label();
            currentLabel.Text = text;
            currentLabel.Location = new Point(x, y);
            currentLabel.BackColor = Color.White;

            //The smaller the text, the thinner the label, so it won't go over the graph
            currentLabel.Width = currentLabel.Text.Length*9 + 2;

            currentLabel.Height = 11;
            currentLabel.Font = new Font("Microsoft Sans Serif; 8.25pt", 7.5F);
            currentLabel.Anchor = AnchorStyles.Top;
            Controls.Add(currentLabel);

            //Adding the label in the list so it can be deleted after
            lstLabels.Add(currentLabel);
        }

        /// <summary>
        /// Draws the axis and their scales according the scale decided by the user
        /// </summary>
        /// <param name="scaleX">max value of the X axis</param>
        /// <param name="scaleY">max value of the Y axis</param>
        private void drawAxisScale(float scaleX, float scaleY)
        {
            lstLabels = new List<Label>();

            int numberFreq = 5;
            int lineFreq = 1;

            //X axis scale----------------------------

            //the smaller the scale, the more numbers will be shown
            if (scaleX <= 25 && scaleX > 5)
            {
                numberFreq = 5;
                lineFreq = 1;
            }
            else if (scaleX <= 5)
            {
                lineFreq = 1;
                numberFreq = 1;
            }
            else if (scaleX > 25)
            {
                numberFreq = 10;
                lineFreq = 5;
            }


            for (int j = (int)scaleX * -1; j < scaleX; j++)
            {
                int originDistance = (int)Math.Round(200 + j * 200 / scaleX);

                //adding lines
                if (j % lineFreq == 0)
                {
                    PointF p1 = new PointF(originDistance, 195);

                    if(j%numberFreq == 0 && j != 0 && j != scaleX * -1)
                    {
                        _g.FillRectangle(_scaleBrush, (int)p1.X, (int)p1.Y - 2, 3, 15);
                    }
                    _g.FillRectangle(_scaleBrush, (int)p1.X, (int)p1.Y, 1, 11);
                }

                //Adding labels
                if (j % numberFreq == 0 && j != 0 && j != scaleX * -1)
                {
                    createLabel(j.ToString(), originDistance - 8, 205);
                }
            }

            //Y axis scale-----------------------

            //the smaller the scale, the more numbers will be shown
            if (scaleY <= 25 && scaleY > 5)
            {
                numberFreq = 5;
                lineFreq = 1;
            }
            else if (scaleY <=5)
            {
                lineFreq = 1;
                numberFreq = 1;
            }
            else if(scaleY >25)
            {
                numberFreq = 10;
                lineFreq = 5;
            }

            for (int j = (int)scaleY * -1; j < scaleY; j++)
            {
                int originDistance = (int)Math.Round(200 + j * 200 / scaleY);

                //adding lines
                if (j % lineFreq == 0)
                {
                    if (j % numberFreq == 0 && j != 0 && j != scaleY * -1)
                    {
                        _g.FillRectangle(_scaleBrush, 193, originDistance - 2, 15, 3);
                    }
                    _g.FillRectangle(_scaleBrush, 195, originDistance, 11, 1);
                }

                //Adding labels
                if (j % numberFreq == 0 && j != 0 && j != scaleY * -1)
                {
                    createLabel((j * -1).ToString(), 210, originDistance - 7);
                }
            }
        }

        /// <summary>
        /// Erases the previous scale numbers and creates the new axis
        /// </summary>
        /// <param name="scaleX">max value of the X axis</param>
        /// <param name="scaleY">max value of the Y axis</param
        private void drawScales(double scaleX, double scaleY)
        {
            ErasePreviousScale();
            drawAxisScale((float)scaleX, (float)scaleY);
        }

        /// <summary>
        /// Draws the plot in the defined area
        /// </summary>
        private void DrawPlot(string expr)
        {
            //shows the loading label and initializing variables
            lblLoading.Show();
            double x;
            double y;
            double yValue;
            double scaleX = this.ScaleX;
            double scaleY = this.ScaleY;
            double accuracy = this.Accuracy;

            //Erases the previous axis by refreshing the form
            this.Refresh();
            drawScales(scaleX, scaleY);
            

            List<Point> coords = new List<Point>();
            
            //Creating a function and a test expression to check the syntax
            Function f = new Function("f", expr, "x");
            Expression testExpr = new Expression("f(1)", f);

            double counter = scaleX * -1;
            //If the syntax of the function is OK, the graph is calculated and displayed. Else, an error message is shown
            if (testExpr.checkSyntax())
            {
                Expression e;
                //Defines the increment according the the accuracy wanted by the user
                double increment = 1 / (accuracy * 250) * scaleX;

                //Calculates the value of every point and stores those in a list of Points
                while (counter < scaleX)
                {
                    e = new Expression("f(" + counter + ")", f);
                    x = counter/scaleX * 200 + 200;
                    yValue = e.calculate()/scaleY*200;
                    y = _origin.Y - yValue;
                    Point p = new Point((int)Math.Round(x), (int)Math.Round(y));
                    coords.Add(p);
                    counter += increment;
                }

                //Drawing the points of the graph
                foreach (Point p in coords)
                {
                    if (p.X < 400 && p.X > 0 && p.Y < 400 && p.Y > 0)
                    {
                        _g.FillRectangle(_graphBrush, p.X, p.Y, 1, 1);
                    }
                }

                //Hides the loading label
                lblLoading.Hide();
            }
            else
            {
                MessageBox.Show("La syntaxe de la fonction est incorrecte. Veillez bien à avoir respecté toutes les règles");
            }
            
        }

        /// <summary>
        /// Initializes the graphic variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmFunctionPlot_Load(object sender, EventArgs e)
        {
            _g = this.CreateGraphics();
            _pen = new Pen(Color.Blue, 2);
            _graphBrush = (Brush)Brushes.Blue;
            _scaleBrush = (Brush)Brushes.Black;
            _scalePen = new Pen(Color.Black, 1);
        }

        /// <summary>
        /// Draws or redraws the graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdScale_Click(object sender, EventArgs e)
        {
            DrawPlot(txtFunction.Text);
        }
    }
}
