using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    /// <summary>
    /// Form that displays a graph from a given function
    /// </summary>
    public partial class frmFunctionPlot : Form
    {
        private string functionString = "";

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

        }

        /// <summary>
        /// Scales the function plot so it does not look like a straight line or a simple dot.
        /// </summary>
        private void ScalePlot()
        {

        }

        /// <summary>
        /// Draws the plot in the defined area
        /// </summary>
        private void DrawPlot()
        {

        }
    }
}
