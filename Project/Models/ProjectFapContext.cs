using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Project.Models
{
    public partial class ProjectFapContext : DbContext
    {
        public ProjectFapContext()
        {
        }

        public ProjectFapContext(DbContextOptions<ProjectFapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScheduleOfStudent> ScheduleOfStudents { get; set; }
        public virtual DbSet<ScheduleOfTeacher> ScheduleOfTeachers { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                                                     .SetBasePath(Directory.GetCurrentDirectory())
                                                     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ProjectFap"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("Account");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Account_Role");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("Attendance");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.RollNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rollNumber");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_Attendance_Class");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_Attendance_Student");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_Attendance_Teacher");
            });

            modelBuilder.Entity<Date>(entity =>
            {
                entity.ToTable("Date");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date1)
                    .HasColumnType("datetime")
                    .HasColumnName("Date");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ScheduleOfStudent>(entity =>
            {
                entity.ToTable("ScheduleOfStudent");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DateId).HasColumnName("dateId");

                entity.Property(e => e.Room)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.StudentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName).HasMaxLength(255);

                entity.HasOne(d => d.Date)
                    .WithMany(p => p.ScheduleOfStudents)
                    .HasForeignKey(d => d.DateId)
                    .HasConstraintName("FK_ScheduleOfStudent_Date");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.ScheduleOfStudents)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK__Schedule__slotId__398D8EEE");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ScheduleOfStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK_ScheduleOfStudent_Student");
            });

            modelBuilder.Entity<ScheduleOfTeacher>(entity =>
            {
                entity.ToTable("ScheduleOfTeacher");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateId).HasColumnName("dateId");

                entity.Property(e => e.Room)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlotId).HasColumnName("slotId");

                entity.Property(e => e.SubjectCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName).HasMaxLength(50);

                entity.Property(e => e.TeacherId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TeacherID");

                entity.HasOne(d => d.Date)
                    .WithMany(p => p.ScheduleOfTeachers)
                    .HasForeignKey(d => d.DateId)
                    .HasConstraintName("FK_ScheduleOfTeacher_Date");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.ScheduleOfTeachers)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK_ScheduleOfTeacher_Slot");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.ScheduleOfTeachers)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK_ScheduleOfTeacher_Teacher");
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("Slot");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Birthdate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Image)
                    .IsUnicode(false)
                    .HasColumnName("image");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RollNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.UserName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Account");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("Teacher");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.UserNameNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.UserName)
                    .HasConstraintName("FK_Teacher_Account");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
