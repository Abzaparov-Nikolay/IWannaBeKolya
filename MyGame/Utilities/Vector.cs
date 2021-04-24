using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    public struct Vector
    {
		public double X;
		public double Y;
		

		public Vector(double x, double y)
		{
			X = x;
			Y = y;
		}

		public double Length => Math.Sqrt(X * X + Y * Y);
		public static Vector Zero => new Vector(0, 0);

		public Point ToPoint()
        {
			return new Point(Convert.ToInt32(X), Convert.ToInt32(Y));
        }

		public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X + v2.X, v1.Y + v2.Y);
		public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.X - v2.X, v1.Y - v2.Y);
		public static Vector operator *(Vector v1, int k) => new Vector(v1.X * k, v1.Y * k);
		public static Vector operator *(int k, Vector v1) => v1 * k;
		public static Vector operator /(Vector v1, int k) => new Vector(v1.X / k, v1.Y / k);

		public Vector Normalize()
			
        {
			if(Length == 0)
            {
				return new Vector(0, 0);
            }
			return new Vector(X / Length, Y / Length);
        }
	}
}
