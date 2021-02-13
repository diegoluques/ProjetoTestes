using System.ComponentModel;

namespace ProjetoTestes.Enumerador
{
	public enum ETipoPessoa
	{
		[Description("Pessoa Física")]
		[DefaultValue("PF")]
		Fisica = 6,

		[Description("Pessoa Jurídica")]
		[DefaultValue("PJ")]
		Juridica = 12 
	}
}