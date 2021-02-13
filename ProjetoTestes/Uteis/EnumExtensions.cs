using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace ProjetoTestes.Uteis
{
	public static class EnumExtensions
	{
		public static List<object> ToList<T>()
		{
			var enumTipoPagamento = new List<object>();

			var enumType = typeof(T);
			var infos = enumType.GetFields(BindingFlags.Public | BindingFlags.Static);

			foreach (FieldInfo fi in infos)
			{
				var description = RetornarDescricaoEnum(fi);
				var value = Convert.ToInt32(fi.GetValue(enumType));

				enumTipoPagamento.Add(new
				{
					id = value,
					nome = description
				});
			}

			return enumTipoPagamento;
		}

		public static DataTable TransformarEnumEmUmDataTable(Type enumType)
		{
			var infos = enumType.GetFields(BindingFlags.Public | BindingFlags.Static);

			DataTable table = new DataTable();
			table.Columns.Add("Id", Enum.GetUnderlyingType(enumType));
			table.Columns.Add("Nome", typeof(string));

			foreach (FieldInfo fi in infos)
			{
				string nome = RetornarDescricaoEnum(fi);
				int id = Convert.ToInt32(fi.GetValue(enumType));
				table.Rows.Add(id, nome);
			}

			return table;
		}

		private static string RetornarDescricaoEnum(FieldInfo fi)
		{
			var descricaoAtributo = fi.CustomAttributes.FirstOrDefault(item => item.AttributeType.Name == "DescriptionAttribute");
			if (descricaoAtributo != null)
				return descricaoAtributo.ConstructorArguments.FirstOrDefault().Value.ToString();

			return "";
		}
	}
}