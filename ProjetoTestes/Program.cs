﻿using ProjetoTestes.Enumerador;
using ProjetoTestes.Uteis;
using System.Data;
using System;
using System.Linq;

namespace ProjetoTestes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Início.............");
			Console.WriteLine("-");

			//ObterNomesDoEnumerdor();
			ObterPrimeiroTextoDeUmString();

			Console.WriteLine("-");
			Console.ReadLine();
		}

		private static void ObterNomesDoEnumerdor()
		{
			var listaTipoPagamento = EnumExtensions.ToList<TipoDePagamentoCws>();
			Console.WriteLine(listaTipoPagamento.Count + " linhas na lista");

			Console.WriteLine("-");

			DataTable dT = EnumExtensions.TransformarEnumEmUmDataTable(typeof(TipoDePagamentoCws));
			Console.WriteLine(dT.Rows.Count + " linhas na tabela");
		}

		private static void ObterPrimeiroTextoDeUmString()
		{
			var texto = "Marte tem dunas de areias";
			var texto1 = texto.Split(' ');
			var texto2 = texto.Split(' ').FirstOrDefault();
			Console.WriteLine(texto1[0]);
			Console.WriteLine(texto2);
		}
	}
}