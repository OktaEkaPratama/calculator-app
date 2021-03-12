using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Enter '+' untuk Penambahan");
                    Console.WriteLine("Enter '-' untuk Pengurangan");
                    Console.WriteLine("Enter '*' untuk Perkalian");
                    Console.WriteLine("Enter '/' untuk Pembagian");
                    Console.WriteLine("Enter 'C' atau 'c' untuk clear");
                    Console.WriteLine("Enter 'E' atau 'e' untuk exit ");
                    char read = Convert.ToChar(Console.ReadLine());

                    if (read == '+')
                    {
                        Console.WriteLine("Enter angka pertama: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter angka kedua: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Jawaban: {num1 + num2}");
                    }
                    else if (read == '-')
                    {
                        Console.WriteLine("Enter angka pertama: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter angka kedua: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Jawaban: {num1 - num2}");
                    }
                    else if (read == '*')
                    {
                        Console.WriteLine("Enter angka pertama: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter angka kedua: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Jawaban: {num1 * num2}");
                    }
                    else if (read == '/')
                    {
                        Console.WriteLine("Enter angka pertama: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter angka kedua: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Jawaban: {num1 / num2}");
                    }
                    else if (read == 'C' || read == 'c')
                    {
                        Console.Clear();
                    }
                    else if (read == 'E' || read == 'e')
                    {
                        exit = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                catch { Console.WriteLine("Invalid Input"); }
            }
        }
    }
}
