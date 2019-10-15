using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpInvestigacion.Models
{
	public class Producto
	{
		[BsonId]
		public ObjectId id { get; set; }

		[BsonElement ("nombre")]
		public string Nombre { get; set; }

		[BsonElement("cantidad")]
		public int Cantidad { get; set; }

		[BsonElement("precio")]
		public int Precio { get; set; }
	}
}
