using System;
namespace sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Write("Insira o nome do competidor: ");
            string nome = Console.ReadLine();

            Console.Write("Insira a Idade do Participante: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade == 10 && idade <= 14)
            {
                Console.WriteLine($"O participante {nome} ira participar da categoria infantil");
            }
            if (idade > 14 && idade <= 17)
            {
                Console.WriteLine($"O participante {nome} ira participar da categotia juvenil");
            }
            if (idade >= 18 && idade <= 25)
            {
                Console.WriteLine($"O participante {nome} ira participar da categoria adulto");
            }
            if (idade > 25)
            {
                Console.WriteLine("sai desgraça");
            }
        }
    }
}