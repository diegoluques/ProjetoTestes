using FluentAssertions;
using Xunit;

namespace ProjetoTestes.Test
{
	public class ObterBandeiraCartaoTest
	{
		[Fact]
		public void ObterTipoCartaoCredito_Visa_Valido()
		{
			//Arrange:
			var bandeira = "visa".ToUpper();
			var numeroCartao = "4716 4754 2606 6495";
			var obterBandeira = new ObterBandeiraCartao();

			//Act:
			var bandeiraObtida = obterBandeira.ObterTipoCartaoCredito(numeroCartao).ToUpper();

			//Assert:
			bandeiraObtida.Should().Be(bandeira);
		}

		[Fact]
		public void ObterTipoCartaoCredito_MasterCard_Valido()
		{
			//Arrange:
			var bandeira = "MasterCard".ToUpper();
			var numeroCartao = "5141 9716 8167 6715";
			var obterBandeira = new ObterBandeiraCartao();

			//Act:
			var bandeiraObtida = obterBandeira.ObterTipoCartaoCredito(numeroCartao).ToUpper();

			//Assert:
			bandeiraObtida.Should().Be(bandeira);
		}

	}
}