﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.eShopWeb.Infrastructure.Data;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20190818191507_UpdatedConstraints")]
    partial class UpdatedConstraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.catalog_brand_hilo", "'catalog_brand_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_hilo", "'catalog_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.catalog_type_hilo", "'catalog_type_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerId")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketId");

                    b.Property<int>("CatalogItemId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_brand_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogBrand");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("CatalogBrandId");

                    b.Property<int>("CatalogTypeId");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PictureUri");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_type_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("CatalogType");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuyerId");

                    b.Property<DateTimeOffset>("OrderDate");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Units");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate.BasketItem", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.BasketAggregate.Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogItem", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order", b =>
                {
                    b.OwnsOne("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Address", "ShipToAddress", b1 =>
                        {
                            b1.Property<int>("OrderId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100);

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(90);

                            b1.Property<string>("State")
                                .HasMaxLength(60);

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(180);

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(18);

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order")
                                .WithOne("ShipToAddress")
                                .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Address", "OrderId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.OrderItem", b =>
                {
                    b.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.OwnsOne("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.CatalogItemOrdered", "ItemOrdered", b1 =>
                        {
                            b1.Property<int>("OrderItemId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("CatalogItemId");

                            b1.Property<string>("PictureUri");

                            b1.Property<string>("ProductName")
                                .IsRequired()
                                .HasMaxLength(50);

                            b1.HasKey("OrderItemId");

                            b1.ToTable("OrderItems");

                            b1.HasOne("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.OrderItem")
                                .WithOne("ItemOrdered")
                                .HasForeignKey("Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate.CatalogItemOrdered", "OrderItemId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
