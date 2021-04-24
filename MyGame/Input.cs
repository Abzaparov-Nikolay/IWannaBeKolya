using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IWannaBeKolya
{
    public static class Input
    {
        private static Dictionary<string, Key> Controls;
        static Input()
        {
            Controls = new Dictionary<string, Key>();
            Controls.Add("Down", Key.S);
            Controls.Add("Up", Key.W);
            Controls.Add("Left", Key.A);
            Controls.Add("Right", Key.D);
            Controls.Add("Restart", Key.E);
            
        }

        public static bool IsActionActive(string action)
        {
            return Keyboard.IsKeyDown(Controls[action]);
        }
    }
}
