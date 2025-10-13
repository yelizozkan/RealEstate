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
        public PropertyType PropertyType { get; set; }
        public decimal? Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public double? Area { get; set; }
        public int? Rooms { get; set; }
        public bool IsPublished { get; set; } = true;

        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    }
}
