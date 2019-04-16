﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.DAL.Context
{
	public class WebStoreContext : IdentityDbContext<User>
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Section> Sections { get; set; }
		public DbSet<Brand> Brands { get; set; }

		public WebStoreContext(DbContextOptions<WebStoreContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			//modelBuilder.Entity<Section>()
			//	.HasMany(section => section.Products)
			//	.WithOne(product => product.Section)
			//	.HasForeignKey(product => product.SectionId);
		}
	}
}
