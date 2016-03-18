using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PetCupid.Database;

namespace PetCupid.Migrations
{
    [DbContext(typeof(PetsDbContext))]
    partial class PetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("PetCupid.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Image");

                    b.Property<string>("Kind");

                    b.Property<string>("Name");

                    b.Property<string>("ProfileText");

                    b.HasKey("Id");
                });
        }
    }
}
