﻿// <auto-generated />
using AbdullahMvcAssignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AbdullahMvcAssignment.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20220705233428_inital")]
    partial class inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AbdullahMvcAssignment.Models.login", b =>
                {
                    b.Property<string>("uname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("upass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("uname");

                    b.ToTable("Login");
                });
#pragma warning restore 612, 618
        }
    }
}
