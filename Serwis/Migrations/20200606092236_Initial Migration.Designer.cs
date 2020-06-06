﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Serwis;

namespace Serwis.Migrations
{
    [DbContext(typeof(SerwisContext))]
    [Migration("20200606092236_Initial Migration")]
    partial class InitialMigration
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

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyEmail");

                    b.Property<string>("CompanyLogin");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyPassword");

                    b.Property<string>("CompanyPhone");

                    b.HasKey("CompanyID");

                    b.ToTable("Companys");
                });
#pragma warning restore 612, 618
        }
    }
}
