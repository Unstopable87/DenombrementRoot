using System;

namespace Denombrements
{
    class Program
    {
        
        static void Main(string[] args) //main function
        {
            int c = 1;
            while (c != 0 ) //Allows to exit in case we press 0
            {
                Menu();
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1) //calculates the permutation
                {
                    Permutation();
                }
                else
                {
                    if (c == 2) //calculates the sorting
                    {
                        Arrangement();
                    }
               

                    else if (c == 3) //calculates the combination
                    {
                        Combination();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.ReadLine();
        }
        static void Menu() // Function to display the menu
        {
            Console.WriteLine("Permutation ...................... 1");
            Console.WriteLine("Arrangement ...................... 2");
            Console.WriteLine("Combinaison ...................... 3");
            Console.WriteLine("Quitter .......................... 0");
        }


        static void Permutation() //Function to calculate the permutation
        {
            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                   // calcul de r
            long r = 1;
            for (int k = 1; k <= n; k++)
                r *= k;
            Console.WriteLine(n + "! = " + r);
        }
        static void Arrangement() //Function to calculate the sorting
        {
            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
            int t = int.Parse(Console.ReadLine()); // saisir le nombre
            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                   // calcul de r
            long r = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r *= k;
            //Console.WriteLine("résultat = " + (r1 / r2));
            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
        }

        static void Combination() //Function to calculate the combination
        {
            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
            int t = int.Parse(Console.ReadLine()); // saisir le nombre
            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                   // calcul de r1
            long r1 = 1;
            for (int k = (t - n + 1); k <= t; k++)
                r1 *= k;
            // calcul de r2
            long r2 = 1;
            for (int k = 1; k <= n; k++)
                r2 *= k;
            // calcul de r3
            //Console.WriteLine("résultat = " + (r1 / r2));
            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
        }

    }
}
