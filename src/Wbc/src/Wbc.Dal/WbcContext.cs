using Microsoft.EntityFrameworkCore;
using Wbc.Domain.Models;

namespace Wbc.Dal
{
    public class WbcContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(@"server=localhost;user id=chris;password=chris123;database=Wbc");
            optionsBuilder.UseNpgsql(@"server=23.83.228.210;user id=wbc;password=psT123;database=Wbc");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("wbc_company");

                entity.HasIndex(e => e.DateModified)
                    .HasName("Idx_DateModified");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

                entity.Property(e => e.DateModified).HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.EmailSuffix)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("wbc_post");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

                entity.Property(e => e.DateModified).HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("wbc_user");

                entity.HasIndex(e => e.DateModified)
                    .HasName("Idx_DateModified1");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

                entity.Property(e => e.DateModified).HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Ignore(p => p.CompanyInfo)
                    .Ignore(p => p.UserExtensionInfo)
                    .Ignore(p => p.Photos);
            });

            modelBuilder.Entity<UserExtension>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__wbc_user__1788CC4C3B0A1FB7");

                entity.ToTable("wbc_user_ext");

                entity.HasIndex(e => e.DateModified)
                    .HasName("Idx_DateModified2");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Birthplace)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

                entity.Property(e => e.DateModified).HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Height).HasColumnType("decimal");

                entity.Property(e => e.Hobby)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IncomeDesc)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Introduction)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.MinRequirement)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.ParentsDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SpecialRequirement)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ToPartner)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UserPhoto>(entity =>
            {
                entity.ToTable("wbc_user_photo");

                entity.HasIndex(e => e.DateModified)
                    .HasName("Idx_DateModified3");

                entity.HasIndex(e => e.UserId)
                    .HasName("Idx_UserId");

                entity.Property(e => e.DateCreated).HasDefaultValueSql("now()");

                entity.Property(e => e.DateModified).HasDefaultValueSql("'0001-01-01'");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(45);
            });
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserExtension> UserExtension { get; set; }
        public virtual DbSet<UserPhoto> UserPhoto { get; set; }
    }
}