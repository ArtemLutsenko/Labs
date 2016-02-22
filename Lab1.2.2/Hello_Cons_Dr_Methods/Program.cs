using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Box box1 = new Box();
                Console.WriteLine("Type position of the box, x = ");
                box1.x_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type position of the box, y = ");
                box1.y_pos = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type width of rectangle: ");
                box1.width = uint.Parse(Console.ReadLine());
                Console.WriteLine("Type heigth of rectangle");
                box1.height = uint.Parse(Console.ReadLine());
                Console.WriteLine("Choose a char from: *, +, . ");
                box1.borderSymbol = char.Parse(Console.ReadLine());
                Console.WriteLine("Type your massage: ");
                box1.message = Console.ReadLine();

                string s = box1.message;
                Console.Clear();

                box1.DrawRectangle();

                Console.WriteLine("Enter nuber for fuctorial: ");
                int fact = int.Parse(Console.ReadLine());
                Console.WriteLine("!{0} = {1}", fact, Factorial(fact));

    
            }
            catch (Exception)
            {
                Console.WriteLine("Error!");
            }
           

            
        }

        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            return n * Factorial(n - 1);
        }


    }

}
