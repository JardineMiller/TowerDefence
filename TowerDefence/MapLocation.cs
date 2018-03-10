using System;
namespace TowerDefence
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if(!map.IsOnMap(this)) throw new Exception(x + ", " + y + " is outside the boundaries of this map.");
        }
    }
}
