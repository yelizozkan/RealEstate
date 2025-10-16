using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstate.Domain.Common;

namespace RealEstate.Domain.Entities
{
    public class Listing : BaseEntity
    {
		
		public string Title { get; set; }
        public string Description { get; set; }

		//Property type ilişkisi
		public Guid PropertyTypeId { get; set; }  
		public PropertyType PropertyType { get; set; }

		//Admin İlişkisi
		public Guid AdminId { get; set; }
		public AdminUser AdminUser { get; set; }

		public ICollection<Photo> Photos { get; set; } = new List<Photo>();

		//Gayrimenkul özellikleri
		public decimal? Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
		public int SquareMeters { get; set; }
		public int NumberOfRooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public int BuildingAge { get; set; }
		public int Floor { get; set; }
		public int TotalFloors { get; set; }
		public string HeatingType { get; set; }
		public bool IsFurnished { get; set; } // eşyalı ?


		public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
		public DateTime? UpdatedAt { get; set; }


	}
}
