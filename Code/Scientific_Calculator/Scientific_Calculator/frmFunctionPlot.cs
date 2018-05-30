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
        private Pen _erasePen;
        Brush _b;
        Brush _backGroundBrush;
        Brush _scaleBrush;
        Coordinates _origin = new Coordinates(200, 200);
        List<Label> lstLabels = new List<Label>();

        public double ScaleX
        {
            get { return trbScaleX.Value; }
        }
        public double ScaleY
        {
            get { return trbScaleY.Value; }
        }

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

        private void ErasePreviousScale()
        {
            foreach (Label l in lstLabels)
            {
                Controls.Remove(l);
                l.Dispose();
            }   
        }

        private void createLabel(string text, int x, int y)
        {
            Label currentLabel = new Label();
            currentLabel.Text = text;
            currentLabel.Location = new Point(x, y);
            currentLabel.BackColor = Color.White;
            currentLabel.Width = 23;
            currentLabel.Height = 11;
            currentLabel.Font = new Font("Microsoft Sans Serif; 8.25pt", 7.5F);
            currentLabel.Anchor = AnchorStyles.Top;
            Controls.Add(currentLabel);
            lstLabels.Add(currentLabel);
        }

        private void drawAxisScale(float scaleX, float scaleY)
        {
            lstLabels = new List<Label>();

            int numberFreq = 10;
            int lineFreq = 5;

            //X axis scale----------------------------
            if (scaleX <= 25)
            {
                numberFreq = 5;
                lineFreq = 1;
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
            if (scaleY <= 25)
            {
                numberFreq = 5;
                lineFreq = 1;
            }
            else
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
                    createLabel(j.ToString(), 210, originDistance - 7);
                }
            }
        }

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
            lblLoading.Show();
            double x;
            double y;
            double yValue;
            double scaleX = this.ScaleX;
            double scaleY = this.ScaleY;
            double accuracy = this.Accuracy;

            this.Refresh();
            drawScales(scaleX, scaleY);
            
            

            List<Coordinates> coords = new List<Coordinates>();
            double counter = scaleX * -1;
            Function f = new Function("f", expr, "x");
            Expression testExpr = new Expression("f(1)", f);
            if (testExpr.checkSyntax())
            {
                Expression e;
                double increment = 1 / (accuracy * 250) * scaleX;
                while (counter < scaleX)
                {
                    e = new Expression("f(" + counter + ")", f);
                    x = counter/scaleX * 200 + 200;
                    yValue = e.calculate()/scaleY*200;
                    y = _origin.Y - yValue;
                    Coordinates c = new Coordinates((int)Math.Round(x), (int)Math.Round(y));
                    coords.Add(c);
                    counter += increment;
                }

                int coordCount = 0;
                Coordinates lastCoord = new Coordinates(0, 0);
                foreach (Coordinates c in coords)
                {
                    if (c.X < 400 && c.X > 0 && c.Y < 400 && c.Y > 0)
                    {
                        _g.FillRectangle(_b, c.X, c.Y, 1, 1);
                    }
                        
                    coordCount++;
                }
                lblLoading.Hide();
            }
            else
            {
                MessageBox.Show("La syntaxe de la fonction est incorrecte. Veillez bien à avoir respecté toutes les règles");
            }
            
        }

        private void frmFunctionPlot_Load(object sender, EventArgs e)
        {
            _g = this.CreateGraphics();
            _pen = new Pen(Color.Blue, 2);
            _b = (Brush)Brushes.Blue;
            _backGroundBrush = (Brush)Brushes.White;
            _scaleBrush = (Brush)Brushes.Black;
            _scalePen = new Pen(Color.Black, 1);
            _erasePen = new Pen(Color.White, 1);
        }

        private void cmdScale_Click(object sender, EventArgs e)
        {
            //this._scaleX = trbScaleX.Value;
            //this._scaleY = trbScaleY.Value;
            DrawPlot(txtFunction.Text);
        }
    }
}
