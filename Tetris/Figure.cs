// See https://aka.ms/new-console-template for more information

namespace Tetris
{
    class Figure
    {
        protected Point[] points = new Point[4];
       public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}