﻿// <auto-generated />
using System;
using HospitalRestApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalRestApi.Migrations
{
    [DbContext(typeof(HospitalApiContext))]
    partial class HospitalApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HospitalRestApi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<int>("SpecialismId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SpecialismId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumBeds")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NurseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Specialism", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SpecialityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialisms");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Doctor", b =>
                {
                    b.HasOne("HospitalRestApi.Models.Location", "Location")
                        .WithMany("Doctors")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalRestApi.Models.Specialism", "Specialism")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecialismId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Specialism");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Nurse", b =>
                {
                    b.HasOne("HospitalRestApi.Models.Location", null)
                        .WithMany("Nurses")
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Patient", b =>
                {
                    b.HasOne("HospitalRestApi.Models.Doctor", "AssignedDoctors")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalRestApi.Models.Nurse", "AssignedNurses")
                        .WithMany("Patients")
                        .HasForeignKey("NurseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedDoctors");

                    b.Navigation("AssignedNurses");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Doctor", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Location", b =>
                {
                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Nurse", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("HospitalRestApi.Models.Specialism", b =>
                {
                    b.Navigation("Doctors");
                });
#pragma warning restore 612, 618
        }
    }
}
