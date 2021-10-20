using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Program
    {

        static int Kino_suurus()
        {
            Console.WriteLine("Vali saali suurus: 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        public static void Kino_taitmine()
        {
            Console.WriteLine("Ввидите интересующий вас зал. 1 - маленький. 2 - средний. 3 - большой");
            string vibor = Console.ReadLine();
            Console.Clear();


            if (vibor == "1")
            {
                for (int i = 0; i < 1; i++)
                {
                    int[,] kino = new int[20, 30];
                    Random rnd = new Random();
                    int number = 1;

                    for (int rida = 0; rida < 20; rida++)
                    {
                        for (int koht = 0; koht < 30; koht++)
                        {
                            kino[rida, koht] = rnd.Next(0, 2);   //заполняет 1 и 0 массив

                        }

                    }
                    for (int rida = 0; rida < 20; rida++)
                    {
                        for (int koht = 0; koht < 30; koht++)
                        {
                            Console.Write(kino[rida, koht]);
                        }

                        Console.WriteLine();
                    }
                }
            }
            else if (vibor == "2")
            {
                for (int i = 0; i < 1; i++)
                {
                    int[,] kino = new int[25, 35];
                    Random rnd = new Random();


                    for (int rida = 0; rida < 25; rida++)
                    {
                        for (int koht = 0; koht < 35; koht++)
                        {
                            kino[rida, koht] = rnd.Next(0, 2);   //заполняет 1 и 0 массив

                        }
                    }
                    for (int rida = 0; rida < 25; rida++)
                    {
                        for (int koht = 0; koht < 35; koht++)
                        {
                            Console.Write(kino[rida, koht]);

                        }
                        Console.WriteLine();
                    }
                }
            }
            else if (vibor == "3")
            {
                for (int i = 0; i < 1; i++)
                {
                    int[,] kino = new int[30, 40];
                    Random rnd = new Random();


                    for (int rida = 0; rida < 30; rida++)
                    {
                        for (int koht = 0; koht < 40; koht++)
                        {
                            kino[rida, koht] = rnd.Next(0, 2);   //заполняет 1 и 0 массив

                        }
                    }
                    for (int rida = 0; rida < 30; rida++)
                    {
                        for (int koht = 0; koht < 40; koht++)
                        {
                            Console.Write(kino[rida, koht]);

                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некоректные данные");

            }
        }
        public static void Kino_ekraanile()
        {/*
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    Console.WriteLine(saal[rida, koht]);
                }
                Console.WriteLine();
            }*/
        }
        public static void Muuk()
        {
            /*Console.WriteLine("Rida: ");
            int pileti rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Koht: ");
            int pileti_koht = int.Parse(Console.ReadLine());
            if (saal[pileti_rida - 1,pileti_koht-1]==0)
            {
                saal[pileti_rida - 1, pileti_koht - 1] = 1;
                return true;
            }
            else
            {
                return false;
            }*/
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Kino_taitmine();

            Console.WriteLine("Ввидите ряд который вы хотите купить");
            string time_rjad = Console.ReadLine();
            int rjad = Convert.ToInt32(time_rjad);

            Console.WriteLine("Ввидите место который вы хотите купить");
            string time_mesto = Console.ReadLine();
            int mesto = Convert.ToInt32(time_mesto);
            Console.Clear();
            Console.ReadKey();
        }
    }
}