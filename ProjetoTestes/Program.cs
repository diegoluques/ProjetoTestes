using ProjetoTestes.Enumerador;
using ProjetoTestes.Uteis;
using System.Data;
using System;

namespace ProjetoTestes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Início.............");
			Console.WriteLine("-");

			var listaTipoPagamento = EnumExtensions.ToList<TipoDePagamentoCws>();
			Console.WriteLine(listaTipoPagamento.Count + " linhas na lista");

			Console.WriteLine("-");

			DataTable dT = EnumExtensions.TransformarEnumEmUmDataTable(typeof(TipoDePagamentoCws));
			Console.WriteLine(dT.Rows.Count + " linhas na tabela");

			Console.WriteLine("-");
			Console.ReadLine();
		}
	}
}