using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TpInvestigacion.Models;
using TpInvestigacion.Services;

namespace TpInvestigacion.Controllers
{
	[Route("api/[controller]")]
	public class ProductosController : Controller
    {
		[HttpGet]
		public IEnumerable<Producto> GetAll()
		{
			ProductoDAL dal = new ProductoDAL();
			return dal.Todos();
		}
	}
}