﻿using HospitalRestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalRestApi.Repositories
{
    public class HospitalApiContext : DbContext
    {
        public HospitalApiContext(DbContextOptions<HospitalApiContext> options) : base(options)
        {
            
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Specialism> Specialisms { get; set; }
        public DbSet<Budgets> Budgets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>()
                .HasOne(patient => patient.AssignedDoctor)
                .WithMany(doctor => doctor.Patients)
                .HasForeignKey(key => key.DoctorId);

            modelBuilder.Entity<Patient>()
                .HasOne(patient => patient.AssignedNurse)
                .WithMany(nurse => nurse.Patients)
                .HasForeignKey(key => key.NurseId);

            modelBuilder.Entity<Specialism>()
                .HasMany(specialism => specialism.Doctors)
                .WithOne(doctor => doctor.Specialism)
                .HasForeignKey(key => key.SpecialismId);

            modelBuilder.Entity<Location>()
                .HasMany(hospital => hospital.Doctors)
                .WithOne(doctor => doctor.Location)
                .HasForeignKey(key => key.LocationId);

            modelBuilder.Entity<Location>()
                .HasMany(hospital => hospital.Nurses)
                .WithOne(nurse => nurse.Location)
                .HasForeignKey(key => key.LocationId);

            modelBuilder.Entity<Location>()
                .HasMany(hospital => hospital.Patients)
                .WithOne(patient => patient.Location)
                .HasForeignKey(key => key.LocationId);


        }

    }
}
