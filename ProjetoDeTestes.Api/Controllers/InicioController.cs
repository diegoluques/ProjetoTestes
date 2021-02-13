using Microsoft.AspNetCore.Mvc;
using ProjetoTestes.Enumerador;
using ProjetoTestes.Uteis;
using System.Collections.Generic;

namespace ProjetoDeTestes.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class InicioController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<object> Get()
		{
			//retorna objeto da lista do enum
			return EnumExtensions.ToList<TipoDePagamentoCws>();
		}
	}
}