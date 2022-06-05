﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vaccination_app.Context;

namespace vaccination_app.Migrations.Vaccination
{
    [DbContext(typeof(VaccinationContext))]
    [Migration("20220519004133_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vaccination_app.VaccinationDB.Vaccination", b =>
                {
                    b.Property<int>("Child_Id")
                        .HasColumnType("int");

                    b.Property<int>("Hospital_Id")
                        .HasColumnType("int");

                    b.Property<string>("ROA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("int");

                    b.Property<int>("Vaccination_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Vaccine_Id")
                        .HasColumnType("int");

                    b.ToTable("Vaccination");
                });
#pragma warning restore 612, 618
        }
    }
}
