using FlightWizard.Business.Domain;
using FlightWizard.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightWizard.Data.Contexts;
public class ApplicationContext : DbContext
{
	public ApplicationContext()
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<User>().HasKey(e => e.UserId);
		modelBuilder.Entity<User>().Property(e => e.UserId).ValueGeneratedOnAdd();
		modelBuilder.Entity<User>().HasIndex(e => e.Username).IsUnique();

		modelBuilder.Entity<Flight>().HasKey(e => e.FlightId);
		modelBuilder.Entity<Flight>().Property(e => e.FlightId).ValueGeneratedOnAdd();

		modelBuilder.Entity<FlightReservation>().HasKey(e => e.FlightReservationId);
		modelBuilder.Entity<FlightReservation>().Property(e => e.FlightReservationId).ValueGeneratedOnAdd();

		modelBuilder.Entity<FlightSeat>().HasKey(e => e.FlightSeatId);
		modelBuilder.Entity<FlightSeat>().Property(e => e.FlightSeatId).ValueGeneratedOnAdd();

		modelBuilder.Entity<User>().HasMany(e => e.FlightReservations).WithOne(e => e.User).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Cascade);
		modelBuilder.Entity<Flight>().HasMany(e => e.FlightSeats).WithOne(e => e.Flight).HasForeignKey(e => e.FlightId).OnDelete(DeleteBehavior.Cascade);
		
	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlServer("Data Source=(localdb)\\flight_wizard;Initial Catalog=FlightWizard;Integrated Security=SSPI");
	}

	public DbSet<User> Users { get; set; }
	public DbSet<Flight> Flights { get; set; }
	public DbSet<FlightSeat> FlightSeats { get; set; }
	public DbSet<FlightReservation> FlightReservations { get; set; }
}
