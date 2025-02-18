﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_ForeignKey_Relations.Data;

#nullable disable

namespace WebAPIForeignKeyRelations.Migrations
{
    [DbContext(typeof(API_DBContext))]
    [Migration("20221214124900_Ex")]
    partial class Ex
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI_ForeignKey_Relations.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerAge")
                        .HasColumnType("int");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebAPI_ForeignKey_Relations.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productPrice")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebAPI_ForeignKey_Relations.Model.Customer", b =>
                {
                    b.HasOne("WebAPI_ForeignKey_Relations.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
