﻿// <auto-generated />
using System;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
  [DbContext(typeof(MainContext))]
  [Migration("20191205193306_NameUser")]
  partial class NameUser
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
          .HasAnnotation("Relational:MaxIdentifierLength", 128)
          .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

      modelBuilder.Entity("Domain.Entity.ProductCategory", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<string>("CategoryName")
                      .IsRequired();

            b.Property<bool>("IsActive");

            b.Property<Guid>("SupplierId");

            b.HasKey("Id");

            b.HasIndex("SupplierId");

            b.ToTable("ProductCategory");
          });

      modelBuilder.Entity("Domain.Entity.ProductLine", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<bool>("IsActive");

            b.Property<string>("Name")
                      .IsRequired();

            b.Property<Guid>("ProductCategoryId");

            b.HasKey("Id");

            b.HasIndex("ProductCategoryId");

            b.ToTable("ProductLine");
          });

      modelBuilder.Entity("Domain.Entity.Supplier", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<Guid?>("AddressId");

            b.Property<string>("cpnj")
                      .IsRequired();

            b.Property<string>("CorporateName")
                      .IsRequired();

            b.Property<string>("Email")
                      .IsRequired();

            b.Property<string>("Telephone")
                      .IsRequired();

            b.Property<string>("TradingName")
                      .IsRequired();

            b.HasKey("Id");

            b.HasIndex("AddressId");

            b.ToTable("Supplier");
          });

      modelBuilder.Entity("Domain.Entity.User", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<bool>("IsActive")
                      .HasColumnName("IsActive");

            b.Property<string>("Login")
                      .IsRequired()
                      .HasColumnName("Login");

            b.Property<string>("Name")
                      .IsRequired()
                      .HasColumnName("Name");

            b.Property<string>("Password")
                      .IsRequired()
                      .HasColumnName("Password");

            b.HasKey("Id");

            b.ToTable("User");
          });

      modelBuilder.Entity("Domain.ValueObjects.Address", b =>
          {
            b.Property<Guid>("Id")
                      .ValueGeneratedOnAdd();

            b.Property<string>("City");

            b.Property<int>("HouseNumber");

            b.Property<string>("Neighborhood");

            b.Property<string>("State");

            b.Property<string>("Street");

            b.HasKey("Id");

            b.ToTable("Address");
          });

      modelBuilder.Entity("Domain.Entity.ProductCategory", b =>
          {
            b.HasOne("Domain.Entity.Supplier", "Supplier")
                      .WithMany()
                      .HasForeignKey("SupplierId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Domain.Entity.ProductLine", b =>
          {
            b.HasOne("Domain.Entity.ProductCategory", "ProductCategory")
                      .WithMany()
                      .HasForeignKey("ProductCategoryId")
                      .OnDelete(DeleteBehavior.Cascade);
          });

      modelBuilder.Entity("Domain.Entity.Supplier", b =>
          {
            b.HasOne("Domain.ValueObjects.Address", "Address")
                      .WithMany()
                      .HasForeignKey("AddressId");
          });
#pragma warning restore 612, 618
    }
  }
}
