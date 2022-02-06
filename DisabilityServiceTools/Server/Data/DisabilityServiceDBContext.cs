using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DisabilityServiceTools.Shared.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DisabilityServiceTools.Server.Data
{
    public partial class DisabilityServiceDBContext : DbContext
    {
        public DisabilityServiceDBContext()
        {
        }

        public DisabilityServiceDBContext(DbContextOptions<DisabilityServiceDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseStream> CourseStream { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<ExamArrangement> ExamArrangement { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<SupportStaff> SupportStaff { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestArrangement> TestArrangement { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DisabilityServiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CourseStream>(entity =>
            {
                entity.Property(e => e.Crn).HasColumnName("CRN");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseStream)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_CourseStream_Course");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasIndex(e => e.Course);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.HasOne(d => d.CourseNavigation)
                    .WithMany(p => p.Exam)
                    .HasForeignKey(d => d.Course)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_ToCourse");
            });

            modelBuilder.Entity<ExamArrangement>(entity =>
            {
                entity.HasIndex(e => e.Exam);

                entity.HasIndex(e => e.ReaderWriter);

                entity.HasOne(d => d.ExamNavigation)
                    .WithMany(p => p.ExamArrangement)
                    .HasForeignKey(d => d.Exam)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExamArrangement_ToExam");

                entity.HasOne(d => d.ReaderWriterNavigation)
                    .WithMany(p => p.ExamArrangement)
                    .HasForeignKey(d => d.ReaderWriter)
                    .HasConstraintName("FK_ExamArrangement_ToSupportStaff");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SupportStaff>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasIndex(e => e.CourseId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK_Test_Course");
            });

            modelBuilder.Entity<TestArrangement>(entity =>
            {
                entity.HasIndex(e => e.ReaderWriter);

                entity.HasIndex(e => e.Test);

                entity.HasOne(d => d.ReaderWriterNavigation)
                    .WithMany(p => p.TestArrangement)
                    .HasForeignKey(d => d.ReaderWriter)
                    .HasConstraintName("FK_TestArrangement_ToSupportStaff");

                entity.HasOne(d => d.TestNavigation)
                    .WithMany(p => p.TestArrangement)
                    .HasForeignKey(d => d.Test)
                    .HasConstraintName("FK_TestArrangement_ToTest");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
