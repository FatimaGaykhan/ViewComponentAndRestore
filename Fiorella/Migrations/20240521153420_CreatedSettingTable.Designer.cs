﻿// <auto-generated />
using System;
using Fiorella.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiorella.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240521153420_CreatedSettingTable")]
    partial class CreatedSettingTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiorella.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4400),
                            Description = "Reshadin Blogu",
                            Image = "blog-feature-img-1.jpg",
                            SoftDeleted = false,
                            Title = "Title1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4410),
                            Description = "Ilqarin Blogu",
                            Image = "blog-feature-img-3.jpg",
                            SoftDeleted = false,
                            Title = "Title2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4410),
                            Description = "Hacixanin Blogu",
                            Image = "blog-feature-img-4.jpg",
                            SoftDeleted = false,
                            Title = "Title3"
                        });
                });

            modelBuilder.Entity("Fiorella.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1111,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4440),
                            Name = "POPULAR",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1112,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450),
                            Name = "WINTER",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1113,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450),
                            Name = "VARIOUS",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1114,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4450),
                            Name = "EXOTIC",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1115,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460),
                            Name = "GREENS",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1116,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460),
                            Name = "CACTUSES",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1117,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4460),
                            Name = "ROSES",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Fiorella.Models.Expert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Experts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4420),
                            FullName = "Fatima Gaykhanova",
                            Image = "h3-team-img-1.png",
                            Position = "Florist",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4420),
                            FullName = "Inji Gaykhanova",
                            Image = "h3-team-img-2.png",
                            Position = "Manager",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4430),
                            FullName = "Fidan Gaykhanova",
                            Image = "h3-team-img-3.png",
                            Position = "Florist",
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4430),
                            FullName = "Gunel Hasanova",
                            Image = "h3-team-img-4.png",
                            Position = "Florist",
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Fiorella.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1006,
                            CategoryId = 1113,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4480),
                            Description = "Desc6",
                            Name = "Product6",
                            Price = 20m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1007,
                            CategoryId = 1114,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490),
                            Description = "Desc7",
                            Name = "Product7",
                            Price = 7000m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1008,
                            CategoryId = 1114,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490),
                            Description = "Desc8",
                            Name = "Product8",
                            Price = 2300m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1009,
                            CategoryId = 1115,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4490),
                            Description = "Desc9",
                            Name = "Product9",
                            Price = 240m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1010,
                            CategoryId = 1115,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500),
                            Description = "Desc10",
                            Name = "Product10",
                            Price = 750m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1111,
                            CategoryId = 1116,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500),
                            Description = "Desc11",
                            Name = "Product11",
                            Price = 300m,
                            SoftDeleted = false
                        },
                        new
                        {
                            Id = 1112,
                            CategoryId = 1116,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4500),
                            Description = "Desc12",
                            Name = "Product12",
                            Price = 450m,
                            SoftDeleted = false
                        });
                });

            modelBuilder.Entity("Fiorella.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            IsMain = true,
                            Name = "shop-14-img.jpg",
                            ProductId = 1006
                        },
                        new
                        {
                            Id = 1002,
                            IsMain = false,
                            Name = "shop-7-img.jpg",
                            ProductId = 1006
                        },
                        new
                        {
                            Id = 1003,
                            IsMain = true,
                            Name = "shop-10-img.jpg",
                            ProductId = 1007
                        },
                        new
                        {
                            Id = 1004,
                            IsMain = false,
                            Name = "shop-10-img.jpg",
                            ProductId = 1007
                        },
                        new
                        {
                            Id = 1005,
                            IsMain = true,
                            Name = "shop-9-img.jpg",
                            ProductId = 1008
                        },
                        new
                        {
                            Id = 1006,
                            IsMain = false,
                            Name = "shop-9-img.jpg",
                            ProductId = 1008
                        });
                });

            modelBuilder.Entity("Fiorella.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Settings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340),
                            Key = "HeaderLogo",
                            SoftDeleted = false,
                            Value = "logo.png"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4340),
                            Key = "Phone",
                            SoftDeleted = false,
                            Value = "243571623"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 5, 21, 19, 34, 20, 588, DateTimeKind.Local).AddTicks(4350),
                            Key = "Address",
                            SoftDeleted = false,
                            Value = "Ehmedli"
                        });
                });

            modelBuilder.Entity("Fiorella.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Fiorella.Models.SliderInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("SliderInfos");
                });

            modelBuilder.Entity("Fiorella.Models.Product", b =>
                {
                    b.HasOne("Fiorella.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Fiorella.Models.ProductImage", b =>
                {
                    b.HasOne("Fiorella.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Fiorella.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Fiorella.Models.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}