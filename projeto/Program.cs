using System;
using System.Globalization;

namespace Projetinho
{
    public class Produto
    {
        static void Main(string[] args)
        {

            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";
            byte idade = 30;
            char genero = 'M';
            int codigo = 5290;
            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1}, cujo preço é $ 2100.00.");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}.");
            Console.WriteLine();
            Console.WriteLine($"Registro:{idade} de idade, código {codigo} e genero:{genero}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais: {medida:f3}");
            Console.WriteLine("Separador decimal invariant culture:" + medida.ToString("f3", CultureInfo.InvariantCulture));
        }

    }
}