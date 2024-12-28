using System;
using System.Threading;

class Aniversario
{
	static void Main(string[] args)
	{
		// Nome do amigo
		string amigo = "Ricardo";

		// Início da celebração
		Console.WriteLine("Preparando algo especial...");
		Thread.Sleep(1500);

		// Animação de confetes
		Console.Clear();
		for (int i = 0; i < 3; i++)
		{
			Console.WriteLine("🎉🎊🎉 Parabéns! 🎉🎊🎉");
			Thread.Sleep(500);
			Console.Clear();
			Thread.Sleep(500);
		}

		// Mensagem de aniversário
		Console.WriteLine($"🎂 Feliz Aniversário, {amigo}! 🎂");
		Console.WriteLine();
		Thread.Sleep(1000);
		Console.WriteLine("Hoje é um dia muito especial, e quero que você saiba...");
		Thread.Sleep(1500);
		Console.WriteLine("Que você é uma pessoa incrível e merece todas as coisas boas deste mundo!");
		Thread.Sleep(2000);

		// Bolo virtual
		Console.WriteLine();
		Console.WriteLine("Aqui está um bolo virtual só para você:");
		Console.WriteLine();
		Console.WriteLine("       [#######]");
		Console.WriteLine("      (         )");
		Console.WriteLine("      |  Parabéns |");
		Console.WriteLine("     (___________)");
		Console.WriteLine("      |||||||||||");
		Console.WriteLine("      |||||||||||");
		Console.WriteLine();
		Thread.Sleep(2000);

		// Toque final
		Console.WriteLine("Desejo que seu ano seja repleto de felicidade, saúde e sucesso! 🥳");
		Thread.Sleep(1000);
		Console.WriteLine("Comemore muito e aproveite cada instante do seu dia especial!");
		Thread.Sleep(1500);
		Console.WriteLine("Pressione qualquer tecla para apagar as velas e encerrar a festa...");
		Console.ReadKey();
	}
}
