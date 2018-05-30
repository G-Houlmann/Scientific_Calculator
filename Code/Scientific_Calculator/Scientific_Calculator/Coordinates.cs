using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator
{
    class Coordinates
    {
        private int _x;

        public Coordinates(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public bool IsParticular()
        {
            return (this.Y == double.NaN || this.Y == double.PositiveInfinity || this.Y == double.NegativeInfinity);
        }
                
    }
}
