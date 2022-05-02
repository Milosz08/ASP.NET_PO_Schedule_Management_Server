﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using asp_net_po_schedule_management_server.DbConfig;

namespace asp_net_po_schedule_management_server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220501222307_AddOtpTokenMigration")]
    partial class AddOtpTokenMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("primary-key");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("city");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created-date");

                    b.Property<string>("DictionaryHash")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("dictionary-hash");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<bool>("FirstAccess")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("first-access");

                    b.Property<bool>("HasPicture")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("has-picture");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("login");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nationality");

                    b.Property<string>("Password")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("password");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint")
                        .HasColumnName("role-key");

                    b.Property<string>("Shortcut")
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("shortcut");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("surname");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated-date");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("person");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.RefreshToken", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("primary-key");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created-date");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person-key");

                    b.Property<string>("TokenValue")
                        .HasColumnType("longtext")
                        .HasColumnName("token-value");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated-date");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("jwt-tokens");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.ResetPasswordOtp", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("primary-key");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created-date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user-email");

                    b.Property<string>("Otp")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("user-otp");

                    b.Property<DateTime>("OtpExpired")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("otp-expired");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint")
                        .HasColumnName("person-key");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated-date");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("reset-password-otp");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("primary-key");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created-date");

                    b.Property<string>("DictionaryHash")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("dictionary-hash");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated-date");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.Person", b =>
                {
                    b.HasOne("asp_net_po_schedule_management_server.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.RefreshToken", b =>
                {
                    b.HasOne("asp_net_po_schedule_management_server.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("asp_net_po_schedule_management_server.Entities.ResetPasswordOtp", b =>
                {
                    b.HasOne("asp_net_po_schedule_management_server.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
