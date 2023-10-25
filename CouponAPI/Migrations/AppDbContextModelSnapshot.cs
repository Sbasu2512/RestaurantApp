﻿// <auto-generated />
using CouponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "05%OFF",
                            DiscountAmount = 5.0,
                            MinAmount = 5
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "10%OFF",
                            DiscountAmount = 10.0,
                            MinAmount = 10
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "15%OFF",
                            DiscountAmount = 15.0,
                            MinAmount = 15
                        },
                        new
                        {
                            CouponId = 4,
                            CouponCode = "20%OFF",
                            DiscountAmount = 20.0,
                            MinAmount = 20
                        },
                        new
                        {
                            CouponId = 5,
                            CouponCode = "25%OFF",
                            DiscountAmount = 25.0,
                            MinAmount = 25
                        });
                });
#pragma warning restore 612, 618
        }
    }
}