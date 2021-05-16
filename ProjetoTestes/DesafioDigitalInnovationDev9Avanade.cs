using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoTestes.Desafios
{
	public class DesafioDigitalInnovationDev9Avanade
	{
		public void Desafio01()
		{
			var chico = 300 * Int32.Parse(Console.ReadLine());
			var bento = 1500 * Int32.Parse(Console.ReadLine());
			var bernardo = 600 * Int32.Parse(Console.ReadLine());
			var marina = 1000 * Int32.Parse(Console.ReadLine());
			var iara = 150 * Int32.Parse(Console.ReadLine());
			var marlene = 225;

			var total = (chico + bento + bernardo + marina + iara + marlene);
			Console.WriteLine(total);
		}

		public void Desafio02()
		{
			int limite = int.Parse(Console.ReadLine());

			for (int i = 1; i <= limite; i++)
			{
				string[] linha = Console.ReadLine().Split(" ");
				string sheldon = linha[0].ToLower();
				string raj = linha[1].ToLower();

				switch (sheldon)
				{
					case "pedra":
						switch (raj)
						{
							case "lagarto":
							case "tesoura":
								Console.WriteLine($"Caso #{i}: Bazinga!");
								break;
							case "pedra":
								Console.WriteLine($"Caso #{i}: De novo!");
								break;
							default:
								Console.WriteLine($"Caso #{i}: Raj trapaceou!");
								break;
						}
						break;

					case "papel":
						switch (raj)
						{
							case "pedra":
							case "spock":
								Console.WriteLine($"Caso #{i}: Bazinga!");
								break;
							case "papel":
								Console.WriteLine($"Caso #{i}: De novo!");
								break;
							default:
								Console.WriteLine($"Caso #{i}: Raj trapaceou!");
								break;
						}
						break;

					case "tesoura":
						switch (raj)
						{
							case "papel":
							case "lagarto":
								Console.WriteLine($"Caso #{i}: Bazinga!");
								break;
							case "tesoura":
								Console.WriteLine($"Caso #{i}: De novo!");
								break;
							default:
								Console.WriteLine($"Caso #{i}: Raj trapaceou!");
								break;
						}
						break;

					case "lagarto":
						switch (raj)
						{
							case "spock":
							case "papel":
								Console.WriteLine($"Caso #{i}: Bazinga!");
								break;
							case "lagarto":
								Console.WriteLine($"Caso #{i}: De novo!");
								break;
							default:
								Console.WriteLine($"Caso #{i}: Raj trapaceou!");
								break;
						}
						break;

					case "spock":
						switch (raj)
						{
							case "tesoura":
							case "pedra":
								Console.WriteLine($"Caso #{i}: Bazinga!");
								break;
							case "spock":
								Console.WriteLine($"Caso #{i}: De novo!");
								break;
							default:
								Console.WriteLine($"Caso #{i}: Raj trapaceou!");
								break;
						}
						break;

					default:
						break;
				}
			}
		}

		public void Desafio03()
		{
			int qtdEntrada = 3;

			while (qtdEntrada > 0)
			{
				var qtdTartarugas = Int32.Parse(Console.ReadLine());

				if (qtdTartarugas >= 1)
				{
					string[] tartarugas = Console.ReadLine().Split(" ");
					var listaTartarugas = new List<int>();

					foreach (var tartaruga in tartarugas)
					{
						listaTartarugas.Add(Int32.Parse(tartaruga));
					}

					var maiorVelocidade = listaTartarugas.Max();

					if (maiorVelocidade < 10)
					{
						Console.WriteLine(1);
					}
					else if (maiorVelocidade >= 10 && maiorVelocidade < 20)
					{
						Console.WriteLine(2);
					}
					else if (maiorVelocidade >= 20)
					{
						Console.WriteLine(3);
					}

					qtdEntrada--;
				}
				else
				{
					Console.WriteLine("Insira um número maior que 1");
				}
			}
		}
	}
}