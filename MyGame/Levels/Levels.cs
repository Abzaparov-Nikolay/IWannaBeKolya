using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    public static class Levels
    {
        private static readonly Dictionary<LevelEnum, Level> LevelLinking;

        static Levels()
        {
            LevelLinking = new Dictionary<LevelEnum, Level>();
            LevelLinking.Add(LevelEnum.First, new Level(@"./Res/Levels/map3.json", LevelEnum.First, location => new Vector(0, 1)));
            LevelLinking.Add(LevelEnum.Second, new Level(@"./Res/Levels/map5.json", LevelEnum.Second, location => new Vector(0, 0.1)));
            LevelLinking.Add(LevelEnum.Third, new Level(@"./Res/Levels/map6.json", LevelEnum.Third, location => new Vector(0, 0.1)));
        }

        public static string GetLevelPath(this LevelEnum level)
        {
            return LevelLinking[level].Path;
        }

        public static List<GameObject> GetLevelObjects(this LevelEnum level)
        {
            return LevelLinking[level].GameObjects;
        }

        public static Gravitation GetLevelGravitation(this LevelEnum level)
        {
            return LevelLinking[level].Gravitation;
        }
    }

    public enum LevelEnum
    {
        First,
        Second,
        Third
    }
}
