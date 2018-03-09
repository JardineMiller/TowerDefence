namespace TowerDefence
{
    public class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public bool IsOnMap (Point point)
        {
            return  point.X >= 0 && 
                    point.X < Width && 
                    point.Y >= 0 && 
                    point.Y < Height;
        }
    }
}
