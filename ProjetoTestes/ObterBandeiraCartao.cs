using ProjetoTestes.Enumerador;
using System.Text.RegularExpressions;

namespace ProjetoTestes
{
	public class ObterBandeiraCartao
	{
		public string ObterTipoCartaoCredito(string numeroCartao)
		{
			var numCartao = numeroCartao.Trim().Replace(" ", "").Replace("-", "");

			Regex regVisa = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
			Regex regMasterCard = new Regex("^(?:5[1-5][0-9]{2}|222[1-9]|22[3-9][0-9]|2[3-6][0-9]{2}|27[01][0-9]|2720)[0-9]{12}$");
			Regex regExpress = new Regex("^3[47][0-9]{13}$");
			Regex regDiners = new Regex("^3(?:0[0-5]|[68][0-9])[0-9]{11}$");
			Regex regDiscover = new Regex("^6(?:011|5[0-9]{2})[0-9]{12}$");
			Regex regJCB = new Regex("^(?:2131|1800|35\\d{3})\\d{11}$");
			Regex regVisaElectron = new Regex("^4(026|17500|405|508|844|91[37])");
			Regex regAmericanExpress = new Regex("^3[47][0-9]{13}$");

			if (regVisa.IsMatch(numCartao))
				return Bandeiras.Visa.ToString();

			else if (regExpress.IsMatch(numCartao))
				return Bandeiras.Aexpress.ToString();

			else if (regDiners.IsMatch(numCartao))
				return Bandeiras.Diners.ToString();

			else if (regDiscover.IsMatch(numCartao))
				return Bandeiras.Discover.ToString();

			else if (regJCB.IsMatch(numCartao))
				return Bandeiras.JCB.ToString();

			else if (regMasterCard.IsMatch(numCartao))
				return Bandeiras.MasterCard.ToString();

			else if (regVisaElectron.IsMatch(numCartao))
				return Bandeiras.Visa.ToString();

			else if (regAmericanExpress.IsMatch(numCartao))
				return Bandeiras.AmericanExpress.ToString();

			else
				return Bandeiras.Invalid.ToString();
		}
	}
}