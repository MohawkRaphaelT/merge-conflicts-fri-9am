using Raylib_cs;
using System.Numerics;

namespace game
{
    public class Brick
    {
        Vector2 position;
        Vector2 size;
        public Brick() 
        {
            position.X = 200;
            position.Y = 200;
            size.X = 100;
            size.Y = 100;

        }

        public void Draw()
        {
            Raylib.DrawRectangleV(position, size, Color.RED);
        }
    }
}
