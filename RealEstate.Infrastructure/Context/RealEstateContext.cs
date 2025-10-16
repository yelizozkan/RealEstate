using Microsoft.EntityFrameworkCore;
using RealEstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Infrastructure.Context
{
	public class RealEstateContext:DbContext
	{
		public RealEstateContext(DbContextOptions<RealEstateContext> options) : base(options) { }

		public DbSet<Listing> Listings { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<AdminUser> Admins { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Listing -> Photo ilişki tanımı
			modelBuilder.Entity<Listing>()
				.HasMany(l => l.Photos)
				.WithOne(p => p.Listing)
				.HasForeignKey(p => p.ListingId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}

