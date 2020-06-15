﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Serwis;

namespace Serwis.Migrations
{
    [DbContext(typeof(SerwisContext))]
    [Migration("20200612165705_Product warranty DateTime change")]
    partial class ProductwarrantyDateTimechange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Serwis.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress")
                        .IsRequired();

                    b.Property<string>("CompanyEmail")
                        .IsRequired();

                    b.Property<string>("CompanyLogin")
                        .IsRequired();

                    b.Property<string>("CompanyName")
                        .IsRequired();

                    b.Property<string>("CompanyPassword")
                        .IsRequired();

                    b.Property<string>("CompanyPhone")
                        .IsRequired();

                    b.HasKey("CompanyID");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("Serwis.Models.Complaints", b =>
                {
                    b.Property<int>("ComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComplainDescription")
                        .IsRequired();

                    b.Property<int?>("EmployerID1");

                    b.Property<string>("FixDescription");

                    b.Property<int?>("ProductID1");

                    b.HasKey("ComplaintID");

                    b.HasIndex("EmployerID1");

                    b.HasIndex("ProductID1");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("Serwis.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID1");

                    b.Property<string>("CustomerAddress");

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("CustomerLogin")
                        .IsRequired();

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("CustomerPassword")
                        .IsRequired();

                    b.Property<string>("CustomerPhone");

                    b.Property<string>("CustomerVorname")
                        .IsRequired();

                    b.HasKey("CustomerID");

                    b.HasIndex("CompanyID1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Serwis.Models.Employer", b =>
                {
                    b.Property<int>("EmployerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployerEmail");

                    b.Property<string>("EmployerLogin")
                        .IsRequired();

                    b.Property<string>("EmployerName")
                        .IsRequired();

                    b.Property<string>("EmployerPassword")
                        .IsRequired();

                    b.Property<string>("EmployerPhone");

                    b.Property<string>("EmployerVorname")
                        .IsRequired();

                    b.Property<string>("Specialist");

                    b.HasKey("EmployerID");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("Serwis.Models.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CompanyID1");

                    b.Property<int?>("CustomerID1");

                    b.Property<string>("ProductCategory");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<string>("ProductState")
                        .IsRequired();

                    b.Property<DateTime>("ProductWarranty");

                    b.HasKey("ProductID");

                    b.HasIndex("CompanyID1");

                    b.HasIndex("CustomerID1");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Serwis.Models.Complaints", b =>
                {
                    b.HasOne("Serwis.Models.Employer", "EmployerID")
                        .WithMany("Complaints")
                        .HasForeignKey("EmployerID1");

                    b.HasOne("Serwis.Models.Products", "ProductID")
                        .WithMany("Complaints")
                        .HasForeignKey("ProductID1");
                });

            modelBuilder.Entity("Serwis.Models.Customer", b =>
                {
                    b.HasOne("Serwis.Models.Company", "CompanyID")
                        .WithMany("Customers")
                        .HasForeignKey("CompanyID1");
                });

            modelBuilder.Entity("Serwis.Models.Products", b =>
                {
                    b.HasOne("Serwis.Models.Company", "CompanyID")
                        .WithMany("Products")
                        .HasForeignKey("CompanyID1");

                    b.HasOne("Serwis.Models.Customer", "CustomerID")
                        .WithMany("Products")
                        .HasForeignKey("CustomerID1");
                });
#pragma warning restore 612, 618
        }
    }
}
