using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace IWannaBeKolya
{
    public static class LevelCreator
    {
        public static List<GameObject> CreateLevel(Level level)
        {
            var mapData = JObject.Parse(System.IO.File.ReadAllText(level.Path));
            var x = 0;
            var y = 0;
            var tileHeight = mapData["tileheight"].Value<int>();
            var mapWidth = mapData["layers"][0]["width"].Value<int>();
            var allObjects = new List<GameObject>();
            foreach(var tile in mapData["layers"][0]["data"])
            {
                if (tile.Value<int>() == 1)
                {
                    allObjects.Add(new Brick(tileHeight * x, tileHeight * y));
                    //Game.gameObjects.Add(new Brick(tileHeight * x, tileHeight * y));
                }
                if (tile.Value<int>() == 2)
                {
                    allObjects.Add(new DeadlyBrick(tileHeight * x, tileHeight * y));
                    //Game.gameObjects.Add(new DeadlyBrick(tileHeight * x, tileHeight * y));
                }
                if(tile.Value<int>() == 3)
                {
                    allObjects.Add(new GravitationBlock(tileHeight * x, tileHeight * y));

                }
                if (++x == mapWidth)
                {
                    x = 0;
                    y++;
                }
            }
            return allObjects;
        }
    }
}
