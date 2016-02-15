using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hello_Operators_lect
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
//do something
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;
                    
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error");
                    }
                    finally
                    {

                    } }
//end do something
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }





        }
        #region ToFromBinary
        static void My_Binary()
        {
           
            string result = "";
            int x;
            int tempA = 0;
            Console.WriteLine("Type positive integer: ");
            x = int.Parse(Console.ReadLine());

            while (x > 0)
            {
                tempA = x % 2;
                x = x / 2;
                result += tempA;
            }

            char[] arr;
            arr = result.ToCharArray();
            Array.Reverse(arr);
            result = new string(arr);
            Console.WriteLine(result);
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //begin code 
            Console.WriteLine("Please, enter two positive integer ");
            uint a;
            uint b;
            uint result;
            int aLength;
            int bLength;
            int min;
            a = uint.Parse(Console.ReadLine());
            b = uint.Parse(Console.ReadLine());

            string aUnary = "";
            string bUnary = "";
            string resultUnary = "";
            string abConcat = "";
           
            for (int i = 0; i < a; i++)
            {
                aUnary = aUnary + "1";
            }

            for (int i = 0; i < b; i++)
            {
                bUnary = bUnary + "1";
            }
            
            Console.WriteLine(aUnary);
            Console.WriteLine(bUnary);

            abConcat = aUnary + "#" + bUnary;

            aLength = aUnary.Length;
            bLength = bUnary.Length;

            if (aLength == 0)
            {
                resultUnary = bUnary;
            }
            else if (bLength == 0)
            {
                resultUnary = aUnary;
            }
            else
            {
                if (aLength < bLength)
                {
                    min = aLength;
                }
                else
                {
                    min = bLength;
                }
                resultUnary = abConcat;

                for (int i = 0; i < min; i++)
                {
                    resultUnary = resultUnary.Replace("1#1", "#");
                }
                resultUnary = resultUnary.Trim(new Char[] { '#' });
            }


            Console.WriteLine("Unary | a - b |= " + resultUnary);
            Console.WriteLine(resultUnary.Length);
           
            //end code 
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {
            //begin code 
            string word = "sos";
            string[,] Dictionary_arr = new string[,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};


            foreach (char c in word.ToCharArray())
            {

                string rslt = "";
                for (int i = 0; i < 36; i++)
                {
                    if (Dictionary_arr[0, i] == c.ToString())
                    {
                        rslt = Dictionary_arr[1, i];
                        rslt = rslt.Trim();
                    }
                }


                foreach (char c2 in rslt.ToCharArray())
                {
                    if (c2 == '.')
                        Console.Beep(400, 250);
                    else
                        Console.Beep(400, 750);
                }
           
            }
            //end code                      
        }

        #endregion
    }
}
