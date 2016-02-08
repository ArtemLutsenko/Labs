using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {
        // 1) declare enum ComputerType

       enum ComputerType {Descktop, Laptop, Server};
        // 2) declare struct Computer

        struct Computer
        {
            public ComputerType comType;
            public int Core;
            public double Frequency;
            public int Memory;
            public int HDD;

            public Computer(ComputerType comType)
            {
                this.comType = comType;
                Core = 0;
                Frequency = 0;
                Memory = 0;
                HDD = 0;
            }
        }

        static void Main(string[] args)
        {
            int TotalComp = 0;
            int numberOfDesctops = 0;
            int numperOfLaptops = 0;
            int numberOfServer = 0;


            // 3) declare jagged array of computers size 4 (4 departments)

            Computer [][] oficeComputers = new Computer[4][];


         //   Console.WriteLine(ComputerType.Descktop);


            // 4) set the size of every array in jagged array (number of computers)


            oficeComputers[0] = new Computer[5];

            oficeComputers[0][0].comType = ComputerType.Descktop;
            oficeComputers[0][1].comType = ComputerType.Descktop;
            oficeComputers[0][2].comType = ComputerType.Laptop;
            oficeComputers[0][3].comType = ComputerType.Laptop;
            oficeComputers[0][3].comType = ComputerType.Server;

            oficeComputers[1] = new Computer[3];

            oficeComputers[1][0].comType = ComputerType.Laptop;
            oficeComputers[1][1].comType = ComputerType.Laptop;
            oficeComputers[1][2].comType = ComputerType.Laptop;

            oficeComputers[2] = new Computer[5];

            oficeComputers[2][0].comType = ComputerType.Descktop;
            oficeComputers[2][1].comType = ComputerType.Descktop;
            oficeComputers[2][2].comType = ComputerType.Descktop;
            oficeComputers[2][3].comType = ComputerType.Laptop;
            oficeComputers[2][4].comType = ComputerType.Laptop;

            oficeComputers[3] = new Computer[4];

            oficeComputers[3][0].comType = ComputerType.Descktop;
            oficeComputers[3][1].comType = ComputerType.Laptop;
            oficeComputers[3][2].comType = ComputerType.Server;
            oficeComputers[3][3].comType = ComputerType.Server;
           



            // 5) initialize array

            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].comType == ComputerType.Descktop)
                    {
                        oficeComputers[i][j].Core = 4;
                        oficeComputers[i][j].Frequency = 2.5;
                        oficeComputers[i][j].Memory = 6;
                        oficeComputers[i][j].HDD = 500;
                    }
                    else if (oficeComputers[i][j].comType == ComputerType.Laptop)
                    {
                        oficeComputers[i][j].Core = 2;
                        oficeComputers[i][j].Frequency = 1.7;
                        oficeComputers[i][j].Memory = 4;
                        oficeComputers[i][j].HDD = 250;
                    }
                    else if (oficeComputers[i][j].comType == ComputerType.Server)
                    {
                        oficeComputers[i][j].Core = 8;
                        oficeComputers[i][j].Frequency = 3.0;
                        oficeComputers[i][j].Memory = 16;
                        oficeComputers[i][j].HDD = 2048;
                    }
                }
            }


            // 6) count total number of every type of computers
            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    TotalComp++;

                    if (oficeComputers[i][j].comType == ComputerType.Descktop)
                    {  
                        numberOfDesctops++;
                    }
                    else if (oficeComputers[i][j].comType == ComputerType.Laptop)
                    {
                        numperOfLaptops++;
                    }
                    else if (oficeComputers[i][j].comType == ComputerType.Server)
                    {
                        numberOfServer++;
                    }
                }
            }
            Console.WriteLine("Total number of all computers are {0}: {1} descktops, {2} laptops and {3} servers", TotalComp, numberOfDesctops, numperOfLaptops, numberOfServer);
            Console.WriteLine();
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int lagestStorege = -1;

            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].HDD > lagestStorege)
                    {
                        lagestStorege = oficeComputers[i][j].HDD;
                    }
                }
            }
            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].HDD == lagestStorege)
                    {
                        Console.WriteLine("Computer with indexes {0}{1} has a lagest storege {2} GB", i, j, lagestStorege);
                    }
                }
            }
            Console.WriteLine();
            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            int lowestMemory = int.MaxValue;
            double LowestCPU = double.MaxValue;

            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].Memory < lowestMemory && oficeComputers[i][j].Frequency * oficeComputers[i][j].Core < LowestCPU)
                    {
                        lowestMemory = oficeComputers[i][j].Memory;
                    }
                }
            }
            for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].Memory == lowestMemory)
                    {
                      Console.WriteLine("Computer with indexes {0}{1} has a lowest productivity CPU {2} cores, {3}, memory  {4} GB", i, j, oficeComputers[i][j].Core, oficeComputers[i][j].Frequency, oficeComputers[i][j].Memory);
                    }
                }
            }

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
           for (int i = 0; i < oficeComputers.Length; i++)
            {
                for (int j = 0; j < oficeComputers[i].Length; j++)
                {
                    if (oficeComputers[i][j].comType == ComputerType.Descktop)
                    {
                        oficeComputers[i][j].Memory = 8;
                    }
                }
            }
            

        }
    }
}
