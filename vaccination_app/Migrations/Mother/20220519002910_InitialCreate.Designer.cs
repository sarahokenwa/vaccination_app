﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vaccination_app.Context;

namespace vaccination_app.Migrations.Mother
{
    [DbContext(typeof(MotherContext))]
    [Migration("20220519002910_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("vaccination_app.VaccinationDB.Mother", b =>
                {
                    b.Property<int>("Child_Id")
                        .HasColumnType("int");

                    b.Property<int>("Mother_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mother_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother_Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Mother");
                });
#pragma warning restore 612, 618
        }
    }
}
