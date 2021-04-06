using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Figure[] f = new Figure[2];
            f[0] = new Square(2, 5, '*');
            f[1] = new Stick(4, 5, '#');

            foreach (Figure fig in f)
            {
                fig.Draw();
            }

            /*Square s = new Square(2, 5, '*');
            s.Draw();

            Stick s = new Stick(2, 5, '*');
            s.Draw();

            Point p1 = new Point(2, 3, '*');
            
            p1.Draw();*/

            Console.ReadLine();
        }
    }
}
