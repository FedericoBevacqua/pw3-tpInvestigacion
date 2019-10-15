using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TpInvestigacion.Models;

namespace TpInvestigacion.Services
{
	public class ProductoDAL
	{
		private readonly IMongoDatabase _database;

		public ProductoDAL()
		{
			_database = Conectar();
		}

		public IEnumerable<Producto> Todos()
		{
			var productos = _database.GetCollection<Producto>("productos").Find(new BsonDocument()).ToListAsync();
			return productos.Result;
		}

		private IMongoDatabase Conectar()
		{
			var cliente = new MongoClient("mongodb://localhost:27017");
			var database = cliente.GetDatabase("mitienda");
			return database;
		}
	}
}
