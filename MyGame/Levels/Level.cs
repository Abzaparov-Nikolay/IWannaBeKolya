using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    public class Level
    {
        public List<GameObject> GameObjects
        {
            get 
            {
                return LevelCreator.CreateLevel(this);
            }
        }
        public Gravitation Gravitation { get; }
        public string Path { get; }
        public LevelEnum LevelNumber { get; }

        public Level(string path, LevelEnum levelNumber, Gravitation gravitation)
        {
            Path = path;
            LevelNumber = levelNumber;
            Gravitation = gravitation;
        }
    }
}
