// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieDataContext))]
    partial class MovieDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission4.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Christopher Nolan",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Inception",
                            Year = (short)2010
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Action",
                            Director = "Bob Persichetti",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "Spider-Man: Into the Spider-Verse",
                            Year = (short)2018
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Action",
                            Director = "Michael Bay",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Transformers",
                            Year = (short)2007
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
