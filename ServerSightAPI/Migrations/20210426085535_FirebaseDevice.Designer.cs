﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ServerSightAPI.Configurations;

namespace ServerSightAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210426085535_FirebaseDevice")]
    partial class FirebaseDevice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.1.21102.2")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ServerSightAPI.Models.ApiKey", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<string>("OwnedById")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnedById");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("ServerSightAPI.Models.FirebaseDevice", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("DeviceKey")
                        .HasColumnType("text");

                    b.Property<string>("OwnedById")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnedById");

                    b.ToTable("FirebaseDevices");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.CpuUsageServer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<double>("AverageCpuUsagePastMinute")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("CpuUsageServers");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.HardDiskServer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("DiskName")
                        .HasColumnType("text");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.Property<float>("SpaceAvailable")
                        .HasColumnType("real");

                    b.Property<float>("SpaceTotal")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("HardDiskServers");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.NetworkAdapterServer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("AdapterName")
                        .HasColumnType("text");

                    b.Property<string>("Ip")
                        .HasColumnType("text");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("NetworkAdapterServers");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.NetworkUsage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<double>("DownloadInBytes")
                        .HasColumnType("double precision");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.Property<double>("UploadInBytes")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("NetworkUsage");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.PortServer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<int>("Port")
                        .HasColumnType("integer");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("PortServers");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.RamUsage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.Property<double>("TotalAvailableInBytes")
                        .HasColumnType("double precision");

                    b.Property<double>("UsageInBytes")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("RamUsages");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.Server", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("OwnedById")
                        .HasColumnType("text");

                    b.Property<bool>("PowerStatus")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("OwnedById");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.ServerEvent", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("EventType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServerId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("ServerEvents");
                });

            modelBuilder.Entity("ServerSightAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ServerSightAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ServerSightAPI.Models.ApiKey", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", "OwnedBy")
                        .WithMany()
                        .HasForeignKey("OwnedById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("OwnedBy");
                });

            modelBuilder.Entity("ServerSightAPI.Models.FirebaseDevice", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", "OwnedBy")
                        .WithMany()
                        .HasForeignKey("OwnedById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("OwnedBy");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.CpuUsageServer", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.HardDiskServer", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.NetworkAdapterServer", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.NetworkUsage", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.PortServer", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.RamUsage", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.Server", b =>
                {
                    b.HasOne("ServerSightAPI.Models.User", "OwnedBy")
                        .WithMany()
                        .HasForeignKey("OwnedById")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("OwnedBy");
                });

            modelBuilder.Entity("ServerSightAPI.Models.Server.ServerEvent", b =>
                {
                    b.HasOne("ServerSightAPI.Models.Server.Server", "Server")
                        .WithMany()
                        .HasForeignKey("ServerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Server");
                });
#pragma warning restore 612, 618
        }
    }
}