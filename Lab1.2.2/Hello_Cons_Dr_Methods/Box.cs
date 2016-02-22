using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public uint width { get; set; }
        public uint height { get; set; }
        public uint x_pos { get; set; }
        public uint y_pos { get; set; }
        public string message { get; set; }
        public char borderSymbol { get; set; }

        public void DrawRectangle()
        {

            if (message == null)
            {
                message = "";
            }
            if (message.Length > (width - 2))
            {
                message = message.Remove((int)width - 2);
            }
            string mesInBox = message;
            this.draw((int)x_pos, (int)y_pos, width, (int)height, borderSymbol, ref mesInBox);
        }


        private void draw(int X, int Y, uint Width, int Height, char Symb, ref string Message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if ((Width >= 3) && (Height >= 3))
            {
                Console.SetCursorPosition((int)(X + (Width - Message.Length) / 2), (int)( Y + Height / 2));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Message);

                Console.SetCursorPosition(X, Y);


                Console.ForegroundColor = ConsoleColor.DarkRed;
                for (int i = 0; i <= Height - 1; i++)
                {
                    for (int j = 0; j <= Width - 1; j++)
                    {

                        if (i % (Height - 1) == 0 || j % (Width - 1) == 0)
                        {
                            Console.SetCursorPosition(X + j, Y + i);
                            Console.Write(Symb);
                        }
                    }

                }
            }


           
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ok! square = " + Height * Width);
            Console.WriteLine();

        }
    }
}
