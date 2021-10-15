using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            centralizarMensagem("Este programa fará a soma de 2 valores", 1);

            n1 = entrarInt("Digite o valor de n1: ", 4, 25, 5, 10);
            n2 = entrarInt("Digite o valor de n2: ", 6, 25, 10, 20);

            mostrarMensagem("Saída: ", 8, 25);
            Console.WriteLine("Resultado da soma de {0} com {1} é {2}", n1, n2, calcular(n1, n2));

            centralizarMensagem("Encerrando o programa...", 12);
            emoldurarMensagem("FIM", 14);

            /*
                +-----+  
                | FIM |
                +-----+
            */

        }

        static int entrarInt(string msg, int linha, int coluna, int li, int ls)
        {
            int x;
            do
            {
               mostrarMensagem(msg, linha, coluna);
               x = int.Parse(Console.ReadLine());
            }
            while (x < li || x > ls);
            return x;
        }

        static int calcular(int x, int y)
        {
            return (x + y);
        }

        static void centralizarMensagem(string msg, int linha)
        {
            int coluna;
            coluna = ((120 - msg.Length) / 2) + 1;
            mostrarMensagem(msg, linha, coluna);
        }

        static void mostrarMensagem(string msg, int linha, int coluna)
        {
            Console.SetCursorPosition(coluna, linha);
            Console.Write(msg);
        }

        static void emoldurarMensagem(string msg, int linha)
        {
            // Você codifica aqui...
        }
    }
}
