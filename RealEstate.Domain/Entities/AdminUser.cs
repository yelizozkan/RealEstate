using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Domain.Entities
{
    public class AdminUser
    {
		public string UserName { get; set; }
		public string Email { get; set; }
		public string PasswordHash { get; set; }
		public ICollection<Listing> Listings { get; set; }=new List<Listing>();	
	}
}
