using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
	public class PropertyType 
	{
		public string Name { get; set; }
		public ICollection<Listing> Listings { get; set; } = new List<Listing>(); // 1-N ilişkisi kurar
	}
}
