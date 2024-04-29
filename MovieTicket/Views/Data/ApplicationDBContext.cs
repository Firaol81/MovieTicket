﻿using Microsoft.EntityFrameworkCore;
using MovieTicket.Models;


namespace MovieTicket.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure any additional settings for your entities here
        }
    }
}
