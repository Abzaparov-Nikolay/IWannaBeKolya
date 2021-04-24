using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    public static class CollisionCheck
    {
        public static bool IsColliding(this GameObject go1, GameObject go2)
        {
            return go1.LeftBorder < go2.RightBorder
                && go1.RightBorder > go2.LeftBorder
                && go1.UpBorder < go2.DownBorder
                && go1.DownBorder > go2.UpBorder;
        }

        public static Vector SolveCollision(this GameObject go1, GameObject go2)
        {
            if (go1.WasUpper(go2))
            {
                return new Vector(0, go1.DownBorder - go2.UpBorder);
            }
            if (go1.WasDown(go2))
            {
                return new Vector(0, go1.UpBorder - go2.DownBorder);
            }
            if (go1.WasRight(go2))
            {
                return new Vector(go1.LeftBorder - go2.RightBorder, 0);
            }
            if (go1.WasLeft(go2))
            {
                return new Vector(go1.RightBorder - go2.LeftBorder, 0);
            }
            return Vector.Zero;
        }

        public static bool WasUpper(this GameObject go1, GameObject go2) => go1.LastPosition.Y + go1.Size.Y <= go2.Position.Y;
        public static bool WasDown(this GameObject go1, GameObject go2) => go1.LastPosition.Y >= go2.Position.Y + go2.Size.Y;
        public static bool WasLeft(this GameObject go1, GameObject go2) => go1.LastPosition.X + go1.Size.X <= go2.Position.X;
        public static bool WasRight(this GameObject go1, GameObject go2) => go1.LastPosition.X >= go2.Position.X + go2.Size.X;

        public static bool StandsOn(this GameObject go1, GameObject go2) =>
            go1.IsColliding(go2) && go1.WasUpper(go2);
    }
}
