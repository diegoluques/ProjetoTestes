using System.ComponentModel;

namespace ProjetoTestes.Enumerador
{
	public enum TipoDePagamentoCws
	{
		[Description("Cartão de Crédito")]
		[DefaultValue("CREDIT_CARD")]
		CartaoCredito = 6,

		[Description("Débito")]
		[DefaultValue("DEBIT")]
		Debito = 12,

		[Description("Boleto Bancário")]
		[DefaultValue("BANK_SLIP")]
		BoletoBancario = 9 
	}
}