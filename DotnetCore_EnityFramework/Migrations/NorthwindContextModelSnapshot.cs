﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DotnetCore_EnityFramework.Model;

namespace DotnetCore_EnityFramework.Migrations
{
    [DbContext(typeof(NorthwindContext))]
    partial class NorthwindContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Categories", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("image");

                    b.HasKey("CategoryId")
                        .HasName("PK_Categories");

                    b.HasIndex("CategoryName")
                        .HasName("CategoryName");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.CustomerCustomerDemo", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)");

                    b.Property<string>("CustomerTypeId")
                        .HasColumnName("CustomerTypeID")
                        .HasColumnType("nchar(10)");

                    b.HasKey("CustomerId", "CustomerTypeId")
                        .HasName("PK_CustomerCustomerDemo");

                    b.HasIndex("CustomerTypeId");

                    b.ToTable("CustomerCustomerDemo");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.CustomerDemographics", b =>
                {
                    b.Property<string>("CustomerTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerTypeID")
                        .HasColumnType("nchar(10)");

                    b.Property<string>("CustomerDesc")
                        .HasColumnType("ntext");

                    b.HasKey("CustomerTypeId")
                        .HasName("PK_CustomerDemographics");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Customers", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)");

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("CustomerId")
                        .HasName("PK_Customers");

                    b.HasIndex("City")
                        .HasName("City");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("Region")
                        .HasName("Region");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Employees", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EmployeeID");

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime");

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Extension")
                        .HasMaxLength(4);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(24);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("image");

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(255);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.Property<int?>("ReportsTo");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(25);

                    b.HasKey("EmployeeId")
                        .HasName("PK_Employees");

                    b.HasIndex("LastName")
                        .HasName("LastName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.HasIndex("ReportsTo");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.EmployeeTerritories", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<string>("TerritoryId")
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.HasKey("EmployeeId", "TerritoryId")
                        .HasName("PK_EmployeeTerritories");

                    b.HasIndex("TerritoryId");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.OrderDetails", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnName("OrderID");

                    b.Property<int>("ProductId")
                        .HasColumnName("ProductID");

                    b.Property<float>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<short>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.Property<decimal>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("0");

                    b.HasKey("OrderId", "ProductId")
                        .HasName("PK_Order_Details");

                    b.HasIndex("OrderId")
                        .HasName("OrdersOrder_Details");

                    b.HasIndex("ProductId")
                        .HasName("ProductsOrder_Details");

                    b.ToTable("Order Details");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Orders", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OrderID");

                    b.Property<string>("CustomerId")
                        .HasColumnName("CustomerID")
                        .HasColumnType("nchar(5)");

                    b.Property<int?>("EmployeeId")
                        .HasColumnName("EmployeeID");

                    b.Property<decimal?>("Freight")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("0");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("RequiredDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ShipAddress")
                        .HasMaxLength(60);

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15);

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15);

                    b.Property<string>("ShipName")
                        .HasMaxLength(40);

                    b.Property<string>("ShipPostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("ShipRegion")
                        .HasMaxLength(15);

                    b.Property<int?>("ShipVia");

                    b.Property<DateTime?>("ShippedDate")
                        .HasColumnType("datetime");

                    b.HasKey("OrderId")
                        .HasName("PK_Orders");

                    b.HasIndex("CustomerId")
                        .HasName("CustomersOrders");

                    b.HasIndex("EmployeeId")
                        .HasName("EmployeesOrders");

                    b.HasIndex("OrderDate")
                        .HasName("OrderDate");

                    b.HasIndex("ShipPostalCode")
                        .HasName("ShipPostalCode");

                    b.HasIndex("ShipVia")
                        .HasName("ShippersOrders");

                    b.HasIndex("ShippedDate")
                        .HasName("ShippedDate");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Products", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductID");

                    b.Property<int?>("CategoryId")
                        .HasColumnName("CategoryID");

                    b.Property<bool>("Discontinued")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(20);

                    b.Property<short?>("ReorderLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int?>("SupplierId")
                        .HasColumnName("SupplierID");

                    b.Property<decimal?>("UnitPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("money")
                        .HasDefaultValueSql("0");

                    b.Property<short?>("UnitsInStock")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<short?>("UnitsOnOrder")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.HasKey("ProductId")
                        .HasName("PK_Products");

                    b.HasIndex("CategoryId")
                        .HasName("CategoryID");

                    b.HasIndex("ProductName")
                        .HasName("ProductName");

                    b.HasIndex("SupplierId")
                        .HasName("SuppliersProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("RegionDescription")
                        .IsRequired()
                        .HasColumnType("nchar(50)");

                    b.HasKey("RegionId");

                    b.ToTable("Region");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Shippers", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ShipperID");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.HasKey("ShipperId")
                        .HasName("PK_Shippers");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Suppliers", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("SupplierID");

                    b.Property<string>("Address")
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .HasMaxLength(15);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("ContactName")
                        .HasMaxLength(30);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(30);

                    b.Property<string>("Country")
                        .HasMaxLength(15);

                    b.Property<string>("Fax")
                        .HasMaxLength(24);

                    b.Property<string>("HomePage")
                        .HasColumnType("ntext");

                    b.Property<string>("Phone")
                        .HasMaxLength(24);

                    b.Property<string>("PostalCode")
                        .HasMaxLength(10);

                    b.Property<string>("Region")
                        .HasMaxLength(15);

                    b.HasKey("SupplierId")
                        .HasName("PK_Suppliers");

                    b.HasIndex("CompanyName")
                        .HasName("CompanyName");

                    b.HasIndex("PostalCode")
                        .HasName("PostalCode");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Territories", b =>
                {
                    b.Property<string>("TerritoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TerritoryID")
                        .HasMaxLength(20);

                    b.Property<int>("RegionId")
                        .HasColumnName("RegionID");

                    b.Property<string>("TerritoryDescription")
                        .IsRequired()
                        .HasColumnType("nchar(50)");

                    b.HasKey("TerritoryId")
                        .HasName("PK_Territories");

                    b.HasIndex("RegionId");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.CustomerCustomerDemo", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Customers", "Customer")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerId");

                    b.HasOne("DotnetCore_EnityFramework.Model.CustomerDemographics", "CustomerType")
                        .WithMany("CustomerCustomerDemo")
                        .HasForeignKey("CustomerTypeId");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Employees", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Employees", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo")
                        .HasConstraintName("FK_Employees_Employees");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.EmployeeTerritories", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Employees", "Employee")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("DotnetCore_EnityFramework.Model.Territories", "Territory")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryId");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.OrderDetails", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Orders", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("DotnetCore_EnityFramework.Model.Products", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Orders", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Customers", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Orders_Customers");

                    b.HasOne("DotnetCore_EnityFramework.Model.Employees", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Orders_Employees");

                    b.HasOne("DotnetCore_EnityFramework.Model.Shippers", "ShipViaNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ShipVia");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Products", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Categories", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Products_Categories");

                    b.HasOne("DotnetCore_EnityFramework.Model.Suppliers", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("DotnetCore_EnityFramework.Model.Territories", b =>
                {
                    b.HasOne("DotnetCore_EnityFramework.Model.Region", "Region")
                        .WithMany("Territories")
                        .HasForeignKey("RegionId")
                        .HasConstraintName("FK_Territories_Region");
                });
        }
    }
}
