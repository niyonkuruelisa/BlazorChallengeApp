using Microsoft.EntityFrameworkCore;
using System.Collections;
using Newtonsoft.Json;
using BlazorChallengeApp.Shared;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorChallengeApp.Server.DatabaseContext
{
    public class MovieDbContext : DbContext
    {
        #region Contructor
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
        #endregion

        #region Public properties
        public DbSet<Movie> Movie { get; set; }
        public DbSet<RunningTimes> RunningTimes { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Booking> Booking { get; set; }
        #endregion

        #region Overidden methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var valueComparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList());

            // Populate Tickets on creationg of the database

            modelBuilder.Entity<Ticket>().HasData(GetTickets());

            modelBuilder.Entity<RunningTimes>().Property(p => p.Mon)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Tue)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Wed)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Thu)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Fri)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Sat)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);
            modelBuilder.Entity<RunningTimes>().Property(p => p.Sun)
      .HasConversion(v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<List<string>>(v)).Metadata.SetValueComparer(valueComparer);

            base.OnModelCreating(modelBuilder);

        }
        #endregion

        #region Private methods
        private List<Ticket> GetTickets()
        {
            return new List<Ticket>
            {
                new Ticket { Id = Guid.NewGuid().ToString(), _ticketName = "ADULT", _price= 10.00 },
                new Ticket { Id = Guid.NewGuid().ToString(), _ticketName = "CHILD (AGE 14 AND UNDER)", _price= 10.00 },
                new Ticket { Id = Guid.NewGuid().ToString(), _ticketName = "FAMILY X 4(2 AD + 2CH OR 1AD +3 CH)", _price= 32.00 },
                new Ticket { Id = Guid.NewGuid().ToString(), _ticketName = "STUDENT", _price= 8.50 },
                new Ticket { Id = Guid.NewGuid().ToString(), _ticketName = "SENIOR(65 & OVER)", _price= 8.50 },
            };
        }
        #endregion
    }
}
