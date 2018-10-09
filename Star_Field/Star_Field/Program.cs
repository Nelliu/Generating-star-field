using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool main = true;
            bool uinputb = true;
            int number;
            int num2 = 0;
            int stage = 0;
            int basen = 1;
            int basen2 = 6;
            bool building = true;
            bool outof = true;
            bool firstrow = true;



            // creating first and last row 
            void row()
            {
                Console.WriteLine();
                for (int i = 0; i < num2 + 1; i++)
                {
                    Console.Write(" ---");
                }
                Console.WriteLine();
            }

            while (main)
            {
                while (uinputb)
                {
                    string uinput = Console.ReadLine();

                    bool parsetry = int.TryParse(uinput, out number);

                    if (parsetry)
                    {
                        // is num
                        num2 = number;
                        uinputb = false;
                        building = true;
                    }
                    else
                    {
                        // is not num
                        Console.WriteLine("Please Enter number only");
                    }

                }
                while (building)
                {
                    while (outof)
                    {
                        if (firstrow)
                        {
                            row();

                            for (int i = 0; i < num2; i++)
                            {
                                if (i == 0)
                                {
                                    Console.Write("|");
                                    Console.Write("   *");
                                }
                                else
                                {
                                    Console.Write("   *");
                                }


                                if (i == (num2 - basen))
                                {
                                    Console.Write("  |");
                                    stage++;
                                }
                            }

                            firstrow = false;
                        }
                        basen++;

                        Console.WriteLine();
                        if (stage == num2 - 1)
                        {
                            outof = false;
                        }

                        for (int i = 0; i < num2 - stage; i++)
                        {
                            if (i == 0)
                            {
                                Console.Write("|");
                                Console.Write("   *");
                            }
                            else
                            {
                                Console.Write("   *");
                            }
                            if (i == num2 - basen)
                            {
                                for (int a = 0; a < basen2; a++)
                                {
                                    Console.Write(" ");
                                    if (a == (basen2 - 1))
                                    {
                                        Console.Write("|");
                                    }
                                }
                                stage++;
                            }

                        }
                        basen2 = basen2 + 4;
                        if (num2 == stage)
                        {
                            Console.Write(" ");

                            row();
                            outof = false;

                        }



                    }





                }
            }

        }
    }
}

