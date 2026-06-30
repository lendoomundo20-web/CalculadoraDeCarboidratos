using System;

class Program
{
    static void Main()
    {
        Refeicao refeicao = new Refeicao();

        Console.Write("Nome da refeição: ");
        refeicao.name = Console.ReadLine();

        while (true)
        {
            Componente componente = new Componente();

            Console.Write("\nNome do componente: ");
            componente.name = Console.ReadLine();

            Console.Write("Peso (g): ");
            componente.peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Carboidratos por 100g: ");
            componente.carboidratosPor100g = Convert.ToDouble(Console.ReadLine());

            refeicao.Componentes.Add(componente);

            Console.Write("Adicionar outro componente? (s/n): ");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
                break;
        }

        Console.WriteLine("\n===== " + refeicao.name + " =====");

        foreach (Componente componente in refeicao.Componentes)
        {
            Console.WriteLine(
                $"{componente.name} - {componente.peso}g - {componente.carboidratosAtuais:F1}g de carboidratos");
        }

        Console.WriteLine("------------------------");
        Console.WriteLine($"Total: {refeicao.carboidratosTotais:F1}g de carboidratos");
    }
}