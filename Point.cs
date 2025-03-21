using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    public class Point
    {
        private double _x, _y, _z;

        public Point(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void MoveBy(double dx, double dy, double dz)
        {
            _x += dx;
            _y += dy;
            _z += dz;

        }


    }
}
