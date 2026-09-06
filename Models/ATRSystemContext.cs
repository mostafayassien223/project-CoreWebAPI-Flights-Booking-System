using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class ATRSystemContext : DbContext
    {
        public ATRSystemContext()
        {
        }

        public ATRSystemContext(DbContextOptions<ATRSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-DCOCRP1\\ESLAM;Database=ATR-System;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.ToTable("Admin");

                entity.Property(e => e.AdminId).HasColumnName("Admin-ID");

                entity.Property(e => e.AEmail).HasColumnName("A-email");

                entity.Property(e => e.APassword).HasColumnName("A-password");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.ContactAdd).HasColumnName("contact-add");

                entity.Property(e => e.FName).HasColumnName("F-name");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.LName).HasColumnName("L-name");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BirthDate).HasColumnName("Birth_date");

                entity.Property(e => e.County).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.ExpirtyDate).HasColumnName("Expirty_date");

                entity.Property(e => e.Fullname).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.IssuingDate).HasColumnName("Issuing_date");

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Passport_number");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.TicketNum)
                    .HasMaxLength(50)
                    .HasColumnName("ticketNum");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId).HasColumnName("Client-ID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Birth_date");

                entity.Property(e => e.CEmail).HasColumnName("C-email");

                entity.Property(e => e.CPassword).HasColumnName("C-password");

                entity.Property(e => e.ContactAddress).HasColumnName("Contact-address");

                entity.Property(e => e.ExpirtyDate)
                    .HasColumnType("date")
                    .HasColumnName("Expirty_date");

                entity.Property(e => e.FName).HasColumnName("F-name");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IssuingCountry).HasColumnName("Issuing_Country");

                entity.Property(e => e.IssuingDate)
                    .HasColumnType("date")
                    .HasColumnName("Issuing_date");

                entity.Property(e => e.LName).HasColumnName("L-name");

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Passport_number");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("Flight");

                entity.Property(e => e.FlightId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Flight_id");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("date")
                    .HasColumnName("Arrival_date");

                entity.Property(e => e.ArrivalTime)
                    .HasMaxLength(10)
                    .HasColumnName("Arrival_time");

                entity.Property(e => e.BookingRefrence)
                    .HasMaxLength(50)
                    .HasColumnName("Booking_refrence");

                entity.Property(e => e.FlightNumber)
                    .HasMaxLength(50)
                    .HasColumnName("Flight_number");

                entity.Property(e => e.LeavesDate)
                    .HasColumnType("date")
                    .HasColumnName("Leaves_date");

                entity.Property(e => e.LeavesTime)
                    .HasMaxLength(10)
                    .HasColumnName("Leaves_time");

                entity.Property(e => e.TerminalArrival).HasColumnName("Terminal_Arrival");

                entity.Property(e => e.TerminalLeaves).HasColumnName("Terminal_Leaves");

                entity.HasOne(d => d.FlightNavigation)
                    .WithOne(p => p.Flight)
                    .HasForeignKey<Flight>(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flight_Reservation");

                entity.HasOne(d => d.Flight1)
                    .WithOne(p => p.Flight)
                    .HasForeignKey<Flight>(d => d.FlightId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Flight_Ticket");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.LoginId).HasColumnName("login_id");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Passord)
                    .IsUnicode(false)
                    .HasColumnName("passord");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegistId);

                entity.ToTable("Registration");

                entity.Property(e => e.RegistId).HasColumnName("regist_ID");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FName)
                    .HasMaxLength(50)
                    .HasColumnName("f_name");

                entity.Property(e => e.LName)
                    .HasMaxLength(50)
                    .HasColumnName("L_name");

                entity.Property(e => e.Password)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.ReportId).HasColumnName("Report_ID");

                entity.Property(e => e.ReportDate)
                    .HasColumnType("date")
                    .HasColumnName("Report_date");

                entity.Property(e => e.ReservationId).HasColumnName("Reservation_ID");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ReservationId)
                    .HasConstraintName("FK_Reports_Reservation");

                entity.HasOne(d => d.Transaction)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.TransactionId)
                    .HasConstraintName("FK_Reports_Transaction");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.ReservationId).HasColumnName("Reservation_ID");

                entity.Property(e => e.AccessTime)
                    .HasMaxLength(50)
                    .HasColumnName("Access_time");

                entity.Property(e => e.AdminId).HasColumnName("Admin-ID");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Birth_date");

                entity.Property(e => e.City).HasMaxLength(10);

                entity.Property(e => e.ClientId).HasColumnName("Client-ID");

                entity.Property(e => e.County).HasMaxLength(10);

                entity.Property(e => e.DateAccommdation)
                    .HasColumnType("date")
                    .HasColumnName("date_accommdation");

                entity.Property(e => e.DateResrvation)
                    .HasColumnType("date")
                    .HasColumnName("date_resrvation");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.ExpirtyDate)
                    .HasColumnType("date")
                    .HasColumnName("Expirty_date");

                entity.Property(e => e.From).HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IssuingAirline)
                    .HasMaxLength(10)
                    .HasColumnName("Issuing_airline");

                entity.Property(e => e.IssuingDate)
                    .HasColumnType("date")
                    .HasColumnName("Issuing_date");

                entity.Property(e => e.PassportNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Passport_number");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Street)
                    .HasMaxLength(10)
                    .HasColumnName("street");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_id");

                entity.Property(e => e.To).HasMaxLength(10);

                entity.Property(e => e.TypeTicket)
                    .HasMaxLength(50)
                    .HasColumnName("type_ticket");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_Admin");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_Client");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reservation_Ticket");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketId).HasColumnName("Ticket_id");

                entity.Property(e => e.AirPort)
                    .HasMaxLength(50)
                    .HasColumnName("Air_PORT");

                entity.Property(e => e.DateAvailable)
                    .HasColumnType("date")
                    .HasColumnName("Date_available");

                entity.Property(e => e.DateFlight)
                    .HasColumnType("date")
                    .HasColumnName("Date_Flight");

                entity.Property(e => e.DetailsTicket).HasColumnName("details_ticket");

                entity.Property(e => e.Isshow).HasColumnName("isshow");

                entity.Property(e => e.PriceTicket)
                    .HasMaxLength(50)
                    .HasColumnName("price_ticket");

                entity.Property(e => e.Terminal).HasMaxLength(10);

                entity.Property(e => e.TicketNum)
                    .HasMaxLength(50)
                    .HasColumnName("Ticket_num");

                entity.Property(e => e.TimeDeparture)
                    .HasMaxLength(50)
                    .HasColumnName("Time_departure");

                entity.Property(e => e.TimeLand)
                    .HasMaxLength(50)
                    .HasColumnName("Time_Land");

                entity.Property(e => e.TypeTicket)
                    .HasMaxLength(50)
                    .HasColumnName("type_ticket");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transaction");

                entity.Property(e => e.TransactionId).HasColumnName("Transaction_ID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("date")
                    .HasColumnName("Transaction_date");

                entity.Property(e => e.TransactionName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Transaction_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
