using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            /*Square s = new Square(2, 5, '*');
            s.Draw();*/

            Stick s = new Stick(2, 5, '*');
            s.Draw();

            /*Point p1 = new Point(2, 3, '*');
            
            p1.Draw();*/

            Console.ReadLine();
        }
    }
}
