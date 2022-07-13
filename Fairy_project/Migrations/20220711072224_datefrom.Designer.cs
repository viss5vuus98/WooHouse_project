﻿// <auto-generated />
using System;
using Fairy_project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fairy_project.Migrations
{
    [DbContext(typeof(ServerContext))]
    [Migration("20220711072224_datefrom")]
    partial class datefrom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fairy_project.Models.Booth", b =>
                {
                    b.Property<int>("boothId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("boothId"), 1L, 1);

                    b.Property<string>("boothImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("boothNumber")
                        .HasColumnType("int");

                    b.Property<int>("checkStatus")
                        .HasColumnType("int");

                    b.Property<int>("e_Id")
                        .HasColumnType("int");

                    b.Property<string>("mf_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mf_Id")
                        .HasColumnType("int");

                    b.Property<string>("mf_P_img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mf_logo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("boothId");

                    b.ToTable("booths");
                });

            modelBuilder.Entity("Fairy_project.Models.Exhibition", b =>
                {
                    b.Property<int>("exhibitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("exhibitId"), 1L, 1);

                    b.Property<DateTime>("datefrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateto")
                        .HasColumnType("datetime2");

                    b.Property<string>("exhibitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("exhibitStatus")
                        .HasColumnType("int");

                    b.Property<string>("exhibit_P_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exhibit_Pre_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exhibit_T_img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("exhibitId");

                    b.ToTable("exhibitions");
                });

            modelBuilder.Entity("Fairy_project.Models.Manufactures", b =>
                {
                    b.Property<int>("manufactureName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("manufactureName"), 1L, 1);

                    b.Property<string>("manufacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manufactureAcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mfEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mfPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mfPhoneNum")
                        .HasColumnType("int");

                    b.HasKey("manufactureName");

                    b.ToTable("manufactures");
                });

            modelBuilder.Entity("Fairy_project.Models.Member", b =>
                {
                    b.Property<int>("memberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("memberId"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("memberAc")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("memberName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("memberId");

                    b.ToTable("members");
                });

            modelBuilder.Entity("Fairy_project.Models.Permissions", b =>
                {
                    b.Property<string>("account")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("permissionsLv")
                        .HasColumnType("int");

                    b.HasKey("account");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Fairy_project.Models.Ticket", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderId"), 1L, 1);

                    b.Property<int>("e_Id")
                        .HasColumnType("int");

                    b.Property<int>("m_Id")
                        .HasColumnType("int");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.ToTable("tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
