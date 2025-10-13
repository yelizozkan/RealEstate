using RealEstate.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class Photo : BaseEntity
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }

        public Guid ListingId { get; set; }
        public Listing Listing { get; set; }
    }
}
