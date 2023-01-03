using System;

namespace LAB_KiK
{
    class Program
    {
        public static string[] tab = new string[9];
        public static int[] tab2 = new int[9];
        public static int k = 1, p = 0;
        public static string s = "   ";

        public static void Gra()
        {
            if (k % 2 == 1)
            {
            G1:
                Console.ForegroundColor = (ConsoleColor.Red);
                Console.WriteLine("\n" +
                    "Tura gracza 1");
                s = " o ";
                k = 1;
                while (!int.TryParse(Console.ReadLine(), out p) || p < 0 || p > 8)
                    Console.WriteLine("Błędny wybór 0-8");
                if (tab[p] != "   ")
                {
                    Console.WriteLine("Błędny agrgument prosze wpisać ponownie");
                    goto G1;
                }
                else
                {
                    tab[p] = s;
                    Console.ForegroundColor = (ConsoleColor.White);
                }
            }
            else
            {
            G2:
                Console.ForegroundColor = (ConsoleColor.Blue);
                Console.WriteLine("\n" +
                    "Tura gracza 2");
                s = " x ";
                while (!int.TryParse(Console.ReadLine(), out p) || p < 0 || p > 8)
                    Console.WriteLine("Błędny wybór 0-8");
                if (tab[p] != "   ")
                {
                    Console.WriteLine("Błędny agrgument prosze wpisać ponownie");
                    goto G2;
                }
                else
                {
                    tab[p] = s;
                    Console.ForegroundColor = (ConsoleColor.White);
                }
            }
        }
        public static void Zasady()
        {
            int x = 0, x2 = 3;
            for (int i = 0; i < 9; i++)
            {
                tab2[i] = i;
            }
            Console.WriteLine("-------------");
            for (int j = 0; j < 3; j++)
            {
                for (int i = x; i < x2; i++)
                {
                    Console.Write("| " + tab2[i] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("-------------");
                x += 3;
                x2 += 3;
            }
        }
        public static void Plansza()
        {
            int x = 0, x2 = 3;
            Console.WriteLine("-------------");
            for (int j = 0; j < 3; j++)
            {
                for (int i = x; i < x2; i++)
                {
                    Console.Write("|" + tab[i]);
                }
                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("-------------");
                x += 3;
                x2 += 3;
            }
            }
        static void Main(string[] args)
        {
            int wybor;
        menu:
            Console.ForegroundColor = (ConsoleColor.Green);
            Console.Clear();
            Console.WriteLine("::::::::::: :::::::::::  ::::::::   :::::::::::     :::      ::::::::   :::::::::::  ::::::::  ::::::::::");
            Console.WriteLine("    :+:         :+:     :+:    :+:      :+:       :+: :+:   :+:    :+:      :+:     :+:    :+: :+:        ");
            Console.WriteLine("    +:+         +:+     +:+             +:+      +:+   +:+  +:+             +:+     +:+    +:+ +:+        ");
            Console.WriteLine("    +#+         +#+     +#+             +#+     +#++:++#++: +#+             +#+     +#+    +:+ +#++:++#   ");
            Console.WriteLine("    +#+         +#+     +#+             +#+     +#+     +#+ +#+             +#+     +#+    +#+ +#+        ");
            Console.WriteLine("    #+#         #+#     #+#    #+#      #+#     #+#     #+# #+#    #+#      #+#     #+#    #+# #+#        ");
            Console.WriteLine("    ###     ###########  ########       ###     ###     ###  ########       ###      ########  ########## ");
            Console.ForegroundColor = (ConsoleColor.White);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu:" +
                "\n 1.Rozpocznij grę" +
                "\n 2.Zasady" +
                "\n 3.Twórca" +
                "\n 4.Wyjście");

            while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 4)
                Console.WriteLine("Błędny wybór 1-4");
            switch (wybor)
            {
                case 1:
                    {
                    gra:
                        k = 1;
                        s = "   ";
                        Console.Clear();
                        Console.WriteLine("Witamy w grze");
                        for (int i = 0; i < 9; i++)
                        {
                            tab[i] = s;
                        }
                        for (int l = 0; l < 9; l++)
                        {
                            Console.Clear();
                            Zasady();
                            Plansza();
                            Gra();
                            if ((tab[0] == " o " && tab[1] == " o " && tab[2] == " o ") || (tab[3] == " o " && tab[4] == " o " && tab[5] == " o ") || (tab[6] == " o " && tab[7] == " o " && tab[8] == " o ") || (tab[0] == " o " && tab[4] == " o " && tab[8] == " o ") || (tab[2] == " o " && tab[4] == " o " && tab[6] == " o ") || (tab[0] == " o " && tab[3] == " o " && tab[6] == " o ") || (tab[1] == " o " && tab[4] == " o " && tab[7] == " o ") || (tab[2] == " o " && tab[5] == " o " && tab[8] == " o "))
                            {
                                Console.Clear();
                                Console.ForegroundColor = (ConsoleColor.Red);
                                Plansza();
                                Console.WriteLine("Wygrał gracz 1");
                                Console.ForegroundColor = (ConsoleColor.White);
                                goto restart;

                            }
                            if ((tab[0] == " x " && tab[1] == " x " && tab[2] == " x ") || (tab[3] == " x " && tab[4] == " x " && tab[5] == " x ") || (tab[6] == " x " && tab[7] == " x " && tab[8] == " x ") || (tab[0] == " x " && tab[4] == " x " && tab[8] == " x ") || (tab[2] == " x " && tab[4] == " x " && tab[6] == " x ") || (tab[0] == " x " && tab[3] == " x " && tab[6] == " x ") || (tab[1] == " x " && tab[4] == " x " && tab[7] == " x ") || (tab[2] == " x " && tab[5] == " x " && tab[8] == " x "))
                            {
                                Console.Clear();
                                Console.ForegroundColor = (ConsoleColor.Blue);
                                Plansza();
                                Console.WriteLine("Wygrał gracz 2");
                                Console.ForegroundColor = (ConsoleColor.White);
                                goto restart;

                            }
                            k++;
                        }
                        Console.Clear();
                        Plansza();
                        Console.WriteLine("REMIS");
                    restart:
                        Console.WriteLine("Czy chcesz zagrać ponownie ?" +
                            "\n 1.tak" +
                            "\n 2.nie");
                        while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 2)
                            Console.WriteLine("Błędny wybór 1-2");
                        if (wybor == 1) goto gra;
                        else goto menu;
                    }
                case 2:
                    {
                        Console.ForegroundColor = (ConsoleColor.Cyan);
                        Console.Clear();
                        Zasady();
                        Console.WriteLine(" Rozpoczyna kółko następnie krzyżyk." +
                            "\n Aby wygrać należy zając 3 pola obok siebie " +
                            "\n pionowo np pola 0/3/6, " +
                            "\n poziomo np pola 0/1/2, " +
                            "\n na skos np pola 0/4/8.\n");
                        Console.WriteLine("Aby wyjść do menu wpisz 1");
                        while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 1)
                            Console.WriteLine("Błędny wybór 1-1");
                        Console.ForegroundColor = (ConsoleColor.White);
                        if (wybor == 1) goto menu;
                        break;
                    }
                case 3:
                    {
                        Console.ForegroundColor = (ConsoleColor.Yellow);
                        Console.Clear();
                        Console.WriteLine("Autor Bartłomiej Misiak" +
                            "\nProgramowanie zaawasnowane" +
                            "\nCzy mogło być lepiej ? Zapewne tak" +
                            "\n\n Aby powrócić do Menu wpisz 1");
                        while (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 1 || wybor > 1)
                            Console.WriteLine("Błędny wybór 1-1");
                        Console.ForegroundColor = (ConsoleColor.White);
                        if (wybor == 1) goto menu;
                        break;
                    }
                case 4:
                    {
                        break;
                    }
            }
        }
    }
}
