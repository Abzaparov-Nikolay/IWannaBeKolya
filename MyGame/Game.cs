using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaBeKolya
{
    public static class Game
    {
        public static bool PlayerDead;
        public static List<GameObject> gameObjects;
        public static LevelEnum CurrentLevel;

        static Game()
        {
            gameObjects = new List<GameObject>();
            ChangeLevel(LevelEnum.Third);
        }

        public static void ChangeLevel(LevelEnum newLevel)
        {
            gameObjects = newLevel.GetLevelObjects();
            gameObjects.Add(new Player());
            CurrentLevel = newLevel;
        }
        

        public static void Update()
        {
            if (Input.IsActionActive("Restart"))
            {
                ChangeLevel(CurrentLevel);
                PlayerDead = false;
            }
            foreach(var gameobject in gameObjects)
            {
                if(!PlayerDead)
                    gameobject.Update();
            }
        }
    }
}
