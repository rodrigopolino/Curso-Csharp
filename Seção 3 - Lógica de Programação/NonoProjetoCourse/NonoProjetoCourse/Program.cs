﻿namespace NonoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3) {
            //    Console.WriteLine("Maior = " + n1);
            //}
            //else if (n2 > n3) {
            //    Console.WriteLine("Maior = " + n2);
            //}
            //else {
            //    Console.WriteLine("Maior = " + n3);
            //}

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);
        }

        static int Maior(int a, int b, int c) {//int é o resultado
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        }
        //debug F10
        //debug para ir na função F11
        //debug pra parar F5

    }

}