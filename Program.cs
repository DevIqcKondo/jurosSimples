using System;

namespace jurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double c=0;
            double i=0;
            double td=0;
            double t=0;
            double m=0;
            double juros=0;
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.WriteLine("Calculando juros simples!");
            Console.ResetColor();
            Console.Write("Digite um valor para capital: ");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            c=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.Write("Digite um valor para taxa de juros: ");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            td=Convert.ToDouble(Console.ReadLine());
            i=(td/100);
            Console.ResetColor();
            Console.Write("Digite um valor para tempo: ");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            t=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            juros=(c*i*t);
            Console.Write("Juros= ");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write(juros);
            Console.ResetColor();
            Console.WriteLine();
            m=(juros+c);
            Console.Write("Montante = ");
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write(m);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
