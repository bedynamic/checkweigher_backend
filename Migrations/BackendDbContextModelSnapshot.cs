﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace backend.Migrations
{
    [DbContext(typeof(BackendDbContext))]
    partial class BackendDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("backend.Models.TestValue", b =>
                {
                    b.Property<int>("TestValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TestValueDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("TestValueValue")
                        .HasColumnType("REAL");

                    b.HasKey("TestValueId");

                    b.ToTable("TestValues");
                });
#pragma warning restore 612, 618
        }
    }
}
