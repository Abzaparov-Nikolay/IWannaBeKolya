using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IWannaBeKolya
{
    public class GameObject
    {
        public Sprite Sprite;
        public Vector Position;
        public Vector Size;
        public Vector LastPosition;
        protected Vector Velocity;


        public double UpBorder => Position.Y;
        public double RightBorder => Position.X + Size.X;
        public double DownBorder => Position.Y + Size.Y;
        public double LeftBorder => Position.X;

        public virtual void Update()
        {

        }
    }
}
