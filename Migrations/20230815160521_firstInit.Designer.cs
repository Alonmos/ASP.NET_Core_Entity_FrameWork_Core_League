﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using inter.Data;

#nullable disable

namespace inter.Migrations
{
    [DbContext(typeof(leagueDBContext))]
    [Migration("20230815160521_firstInit")]
    partial class firstInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgentsPlayers", b =>
                {
                    b.Property<int>("AgentsId")
                        .HasColumnType("int");

                    b.Property<int>("PlayersID")
                        .HasColumnType("int");

                    b.HasKey("AgentsId", "PlayersID");

                    b.HasIndex("PlayersID");

                    b.ToTable("AgentsPlayers");
                });

            modelBuilder.Entity("inter.Models.Agents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName")
                        .IsUnique()
                        .HasFilter("[FirstName] IS NOT NULL");

                    b.ToTable("Agents");
                });

            modelBuilder.Entity("inter.Models.Managers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamID");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("inter.Models.Owner", b =>
                {
                    b.Property<int>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("OwnerID");

                    b.HasIndex("TeamID")
                        .IsUnique();

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("inter.Models.Players", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DateOfBirth")
                        .HasPrecision(5, 2)
                        .HasColumnType("datetime2(5)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("ScoutID")
                        .HasColumnType("int");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ScoutID");

                    b.HasIndex("TeamID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("inter.Models.Scouts", b =>
                {
                    b.Property<int>("ScoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoutID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ScoutID");

                    b.ToTable("Scouts");
                });

            modelBuilder.Entity("inter.Models.ScoutsTeams", b =>
                {
                    b.Property<int>("ScoutsID")
                        .HasColumnType("int");

                    b.Property<int>("TeamsID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ScoutsID", "TeamsID");

                    b.HasIndex("TeamsID");

                    b.ToTable("ScoutsTeams");
                });

            modelBuilder.Entity("inter.Models.Teams", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("lastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("AgentsPlayers", b =>
                {
                    b.HasOne("inter.Models.Agents", null)
                        .WithMany()
                        .HasForeignKey("AgentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inter.Models.Players", null)
                        .WithMany()
                        .HasForeignKey("PlayersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("inter.Models.Managers", b =>
                {
                    b.HasOne("inter.Models.Teams", "Team")
                        .WithMany("Managers")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("inter.Models.Owner", b =>
                {
                    b.HasOne("inter.Models.Teams", "Teams")
                        .WithOne("Owner")
                        .HasForeignKey("inter.Models.Owner", "TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("inter.Models.Players", b =>
                {
                    b.HasOne("inter.Models.Scouts", "Scouts")
                        .WithMany("Players")
                        .HasForeignKey("ScoutID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inter.Models.Teams", "Teams")
                        .WithMany("Players")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scouts");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("inter.Models.ScoutsTeams", b =>
                {
                    b.HasOne("inter.Models.Scouts", "Scouts")
                        .WithMany("ScoutsTeams")
                        .HasForeignKey("ScoutsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("inter.Models.Teams", "Teams")
                        .WithMany("ScoutsTeams")
                        .HasForeignKey("TeamsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Scouts");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("inter.Models.Scouts", b =>
                {
                    b.Navigation("Players");

                    b.Navigation("ScoutsTeams");
                });

            modelBuilder.Entity("inter.Models.Teams", b =>
                {
                    b.Navigation("Managers");

                    b.Navigation("Owner")
                        .IsRequired();

                    b.Navigation("Players");

                    b.Navigation("ScoutsTeams");
                });
#pragma warning restore 612, 618
        }
    }
}