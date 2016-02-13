using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:

            bool boo = true;
            char ch = 'l';
            byte b = 8;
            sbyte sb = 8;
            short sh = 100;
            ushort ush = 10;
            int i = 150;
            uint ui = 150;
            long l = 150L;
            ulong ul = 300L;
            decimal de = 10000.5M;
            float fl = 8.0f;
            double od = -33.1;
            // their names should be: 
            //boo, ch, sb, sh, ush, i, ui, l, ul, de, fl, do
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            //2) declare constants of int and double. Try to change their values.

            const int icons = 5;
            const double dcons = 5.0;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?

            var x = 20;
            var y = 20.5;
            //x = 20.5;
            y = 20;


            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and do. Is it possible?

            //System.Int32 aa = i;
            //System.Double bb = do;


            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //int i;
                //char ch;
                //double do;


                // 6) change values of variables from 1)

                i = 10;
            }

            // 7)check values of variables from 1). Are they changed? Think, why

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 
            // Fix compilation errors (in case of impossible conversion commemt that line).
            // int -> char

            ch = (char)i;

            // bool -> short
            //short = (bool)boo;

            // double -> long

            l = (long)od;

            // float -> char 

            ch = (char)fl;

            // decimal -> double

            // od = (decimal)od;

            // byte -> uint

            b = (byte)ui;

            // ulong -> sbyte

            sb = (sbyte)ul;

            // 9) and reverse conversion with fixing compilation errors.
            i = ch;

            od = l;

            fl = ch;

            ui = b;

            ul = (ulong)sb;

            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible?

            //i = null; impossible;
        }
    }
}
