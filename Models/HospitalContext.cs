using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab2_EF.Models;

public partial class HospitalContext : DbContext
{
    public HospitalContext()
    {
    }

    public HospitalContext(DbContextOptions<HospitalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Caseof> Caseofs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Dayweek> Dayweeks { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<Maindiag> Maindiags { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Proced> Proceds { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Spec> Specs { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Street> Streets { get; set; }

    public virtual DbSet<Sysoperator> Sysoperators { get; set; }

    public virtual DbSet<Sysrole> Sysroles { get; set; }

    public virtual DbSet<Sysuser> Sysusers { get; set; }

    public virtual DbSet<Typecase> Typecases { get; set; }

    public virtual DbSet<Visitschedule> Visitschedules { get; set; }
    public virtual DbSet<PatientSearchDto> SearchResults { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=kozyrev;Username=postgres;Password=admin");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Area>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("area_pkey");

            entity.ToTable("area");

            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Caseof>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("caseof_pkey");

            entity.ToTable("caseof");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Typecaseid).HasColumnName("typecaseid");
            entity.Property(e => e.Visitscheduleid).HasColumnName("visitscheduleid");

            entity.HasOne(d => d.Typecase).WithMany(p => p.Caseofs)
                .HasForeignKey(d => d.Typecaseid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkcaseof341318");

            entity.HasOne(d => d.Visitschedule).WithMany(p => p.Caseofs)
                .HasForeignKey(d => d.Visitscheduleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkcaseof307873");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("category_pkey");

            entity.ToTable("category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(7)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Dayweek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dayweek_pkey");

            entity.ToTable("dayweek");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("emp_pkey");

            entity.ToTable("emp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Areaid).HasColumnName("areaid");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.CertDate).HasColumnName("cert_date");
            entity.Property(e => e.Fio)
                .HasMaxLength(70)
                .HasColumnName("fio");
            entity.Property(e => e.Specid).HasColumnName("specid");
            entity.Property(e => e.Sysuserid).HasColumnName("sysuserid");

            entity.HasOne(d => d.Area).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Areaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkemp449830");

            entity.HasOne(d => d.Category).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Categoryid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkemp146429");

            entity.HasOne(d => d.Spec).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Specid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkemp435400");

            entity.HasOne(d => d.Sysuser).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Sysuserid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkemp760712");
        });

        modelBuilder.Entity<Maindiag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("maindiag_pkey");

            entity.ToTable("maindiag");

            entity.Property(e => e.Id)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Snils).HasName("patient_pkey");

            entity.ToTable("patient");

            entity.HasIndex(e => e.CardNum, "patient_card_num_key").IsUnique();

            entity.HasIndex(e => e.Polis, "patient_polis_key").IsUnique();

            entity.Property(e => e.Snils)
                .HasMaxLength(14)
                .HasColumnName("snils");
            entity.Property(e => e.Birthdate).HasColumnName("birthdate");
            entity.Property(e => e.CardNum)
                .HasMaxLength(255)
                .HasColumnName("card_num");
            entity.Property(e => e.Fio)
                .HasMaxLength(70)
                .HasColumnName("fio");
            entity.Property(e => e.FlatNum)
                .HasMaxLength(7)
                .HasColumnName("flat_num");
            entity.Property(e => e.HouseNum)
                .HasMaxLength(15)
                .HasColumnName("house_num");
            entity.Property(e => e.Pol)
                .HasMaxLength(1)
                .HasColumnName("pol");
            entity.Property(e => e.Polis).HasColumnName("polis");
            entity.Property(e => e.Streetid).HasColumnName("streetid");
            entity.Property(e => e.Workplace)
                .HasMaxLength(255)
                .HasColumnName("workplace");

            entity.HasOne(d => d.Street).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Streetid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkpatient653356");
        });

        modelBuilder.Entity<Proced>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("proced_pkey");

            entity.ToTable("proced");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caseofid).HasColumnName("caseofid");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Pdate).HasColumnName("pdate");

            entity.HasOne(d => d.Caseof).WithMany(p => p.Proceds)
                .HasForeignKey(d => d.Caseofid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkproced692842");

            entity.HasOne(d => d.Emp).WithMany(p => p.Proceds)
                .HasForeignKey(d => d.Empid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkproced81016");
        });

        modelBuilder.Entity<Schedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("schedule_pkey");

            entity.ToTable("schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Dayweekid).HasColumnName("dayweekid");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Statusid).HasColumnName("statusid");
            entity.Property(e => e.Workfrom).HasColumnName("workfrom");
            entity.Property(e => e.Workto).HasColumnName("workto");

            entity.HasOne(d => d.Dayweek).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.Dayweekid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkschedule669049");

            entity.HasOne(d => d.Emp).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.Empid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkschedule185788");

            entity.HasOne(d => d.Status).WithMany(p => p.Schedules)
                .HasForeignKey(d => d.Statusid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkschedule708382");
        });

        modelBuilder.Entity<Spec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("spec_pkey");

            entity.ToTable("spec");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");
            entity.Property(e => e.Vtime).HasColumnName("vtime");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_pkey");

            entity.ToTable("status");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Street>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("street_pkey");

            entity.ToTable("street");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Areaid).HasColumnName("areaid");
            entity.Property(e => e.Name)
                .HasMaxLength(60)
                .HasColumnName("name");

            entity.HasOne(d => d.Area).WithMany(p => p.Streets)
                .HasForeignKey(d => d.Areaid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkstreet430303");
        });

        modelBuilder.Entity<Sysoperator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sysoperator_pkey");

            entity.ToTable("sysoperator");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Sysuserid).HasColumnName("sysuserid");

            entity.HasOne(d => d.Sysuser).WithMany(p => p.Sysoperators)
                .HasForeignKey(d => d.Sysuserid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fksysoperato554970");
        });

        modelBuilder.Entity<Sysrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sysrole_pkey");

            entity.ToTable("sysrole");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Sysuser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sysuser_pkey");

            entity.ToTable("sysuser");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasColumnName("login");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .HasColumnName("password_hash");
            entity.Property(e => e.Sysroleid).HasColumnName("sysroleid");

            entity.HasOne(d => d.Sysrole).WithMany(p => p.Sysusers)
                .HasForeignKey(d => d.Sysroleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fksysuser302401");
        });

        modelBuilder.Entity<Typecase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("typecase_pkey");

            entity.ToTable("typecase");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Visitschedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("visitschedule_pkey");

            entity.ToTable("visitschedule");

            entity.HasIndex(e => e.Maindiagid, "fki_fkmaindiag");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Empid).HasColumnName("empid");
            entity.Property(e => e.Maindiagid)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("maindiagid");
            entity.Property(e => e.Patientsnils)
                .HasMaxLength(14)
                .HasColumnName("patientsnils");
            entity.Property(e => e.Scheduleid).HasColumnName("scheduleid");
            entity.Property(e => e.Vfrom)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("vfrom");
            entity.Property(e => e.Vto)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("vto");

            entity.HasOne(d => d.Emp).WithMany(p => p.Visitschedules)
                .HasForeignKey(d => d.Empid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkvisitsched405080");

            entity.HasOne(d => d.Maindiag).WithMany(p => p.Visitschedules)
                .HasForeignKey(d => d.Maindiagid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkmaindiag");

            entity.HasOne(d => d.PatientsnilsNavigation).WithMany(p => p.Visitschedules)
                .HasForeignKey(d => d.Patientsnils)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkvisitsched369478");

            entity.HasOne(d => d.Schedule).WithMany(p => p.Visitschedules)
                .HasForeignKey(d => d.Scheduleid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fkvisitsched309075");
        });
        modelBuilder.Entity<PatientSearchDto>().HasNoKey();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
