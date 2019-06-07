﻿// <auto-generated />
using System;
using ElectroBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElectroBackend.Migrations
{
    [DbContext(typeof(ElectroApiContext))]
    [Migration("20190604175231_update-tps")]
    partial class updatetps
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElectroBackend.Models.BusbarSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Value");

                    b.Property<int?>("WorkloadId");

                    b.HasKey("Id");

                    b.HasIndex("WorkloadId");

                    b.ToTable("BusbarSection");
                });

            modelBuilder.Entity("ElectroBackend.Models.Counter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("DateLastCheck");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Counter");
                });

            modelBuilder.Entity("ElectroBackend.Models.CounterBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CounterBrand");
                });

            modelBuilder.Entity("ElectroBackend.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CounterId");

                    b.Property<int?>("FiderId");

                    b.Property<int?>("LineId");

                    b.Property<string>("Name");

                    b.Property<string>("ObjectAddress");

                    b.Property<string>("ObjectName");

                    b.Property<string>("PlaceInstall");

                    b.Property<bool>("Status");

                    b.Property<int?>("TpId");

                    b.HasKey("Id");

                    b.HasIndex("CounterId");

                    b.HasIndex("FiderId");

                    b.HasIndex("LineId");

                    b.HasIndex("TpId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ElectroBackend.Models.CustomerUsage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerUsage");
                });

            modelBuilder.Entity("ElectroBackend.Models.ElectroObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ElectroObject");
                });

            modelBuilder.Entity("ElectroBackend.Models.Fider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Geocode");

                    b.Property<string>("Name");

                    b.Property<int>("Power");

                    b.Property<int>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("Fiders");
                });

            modelBuilder.Entity("ElectroBackend.Models.Line", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Geocode");

                    b.Property<string>("Name");

                    b.Property<int>("Power");

                    b.Property<int?>("SectionId");

                    b.Property<int>("Voltage");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("ElectroBackend.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateClose");

                    b.Property<DateTime>("DateStart");

                    b.Property<int?>("ElectroObjectId");

                    b.Property<string>("Message");

                    b.Property<string>("Name");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("ElectroObjectId");

                    b.HasIndex("TypeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ElectroBackend.Models.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("OrderType");
                });

            modelBuilder.Entity("ElectroBackend.Models.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LineId");

                    b.Property<string>("Name");

                    b.Property<int?>("WorkloadId");

                    b.HasKey("Id");

                    b.HasIndex("LineId");

                    b.HasIndex("WorkloadId");

                    b.ToTable("Phase");
                });

            modelBuilder.Entity("ElectroBackend.Models.PhaseValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PhaseId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("PhaseId");

                    b.ToTable("PhaseValue");
                });

            modelBuilder.Entity("ElectroBackend.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Geocode");

                    b.Property<string>("Name");

                    b.Property<int>("Power");

                    b.Property<int?>("TpId");

                    b.Property<int>("Voltage");

                    b.HasKey("Id");

                    b.HasIndex("TpId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("ElectroBackend.Models.Tp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FiderId");

                    b.Property<string>("Geocode");

                    b.Property<string>("Name");

                    b.Property<int>("Power");

                    b.Property<int?>("TransformerId");

                    b.Property<int>("Voltage");

                    b.HasKey("Id");

                    b.HasIndex("FiderId");

                    b.HasIndex("TransformerId");

                    b.ToTable("Tps");
                });

            modelBuilder.Entity("ElectroBackend.Models.Transformer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCheck");

                    b.Property<DateTime>("DateInstall");

                    b.Property<int?>("ModelId");

                    b.Property<string>("Name");

                    b.Property<int?>("TypeId");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.HasIndex("TypeId");

                    b.ToTable("Transformers");
                });

            modelBuilder.Entity("ElectroBackend.Models.TransformerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TransformerModel");
                });

            modelBuilder.Entity("ElectroBackend.Models.TransformerType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TransformerType");
                });

            modelBuilder.Entity("ElectroBackend.Models.TransformerWorkload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int?>("TransformerId");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("TransformerId");

                    b.ToTable("TransformerWorkload");
                });

            modelBuilder.Entity("ElectroBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessLevel");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Role");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ElectroBackend.Models.Workload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.Property<int?>("TpId");

                    b.HasKey("Id");

                    b.HasIndex("TpId");

                    b.ToTable("Workloads");
                });

            modelBuilder.Entity("ElectroBackend.Models.BusbarSection", b =>
                {
                    b.HasOne("ElectroBackend.Models.Workload")
                        .WithMany("BusbarSections")
                        .HasForeignKey("WorkloadId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Counter", b =>
                {
                    b.HasOne("ElectroBackend.Models.CounterBrand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Customer", b =>
                {
                    b.HasOne("ElectroBackend.Models.Counter", "Counter")
                        .WithMany()
                        .HasForeignKey("CounterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ElectroBackend.Models.Fider", "Fider")
                        .WithMany()
                        .HasForeignKey("FiderId");

                    b.HasOne("ElectroBackend.Models.Line", "Line")
                        .WithMany("Customers")
                        .HasForeignKey("LineId");

                    b.HasOne("ElectroBackend.Models.Tp", "Tp")
                        .WithMany()
                        .HasForeignKey("TpId");
                });

            modelBuilder.Entity("ElectroBackend.Models.CustomerUsage", b =>
                {
                    b.HasOne("ElectroBackend.Models.Customer", "Customer")
                        .WithMany("Usages")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Line", b =>
                {
                    b.HasOne("ElectroBackend.Models.Section", "Section")
                        .WithMany("Lines")
                        .HasForeignKey("SectionId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Order", b =>
                {
                    b.HasOne("ElectroBackend.Models.ElectroObject", "ElectroObject")
                        .WithMany()
                        .HasForeignKey("ElectroObjectId");

                    b.HasOne("ElectroBackend.Models.OrderType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Phase", b =>
                {
                    b.HasOne("ElectroBackend.Models.Line", "Line")
                        .WithMany()
                        .HasForeignKey("LineId");

                    b.HasOne("ElectroBackend.Models.Workload")
                        .WithMany("Phases")
                        .HasForeignKey("WorkloadId");
                });

            modelBuilder.Entity("ElectroBackend.Models.PhaseValue", b =>
                {
                    b.HasOne("ElectroBackend.Models.Phase", "Phase")
                        .WithMany("PhaseValues")
                        .HasForeignKey("PhaseId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Section", b =>
                {
                    b.HasOne("ElectroBackend.Models.Tp", "Tp")
                        .WithMany("Sections")
                        .HasForeignKey("TpId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Tp", b =>
                {
                    b.HasOne("ElectroBackend.Models.Fider", "Fider")
                        .WithMany("Tps")
                        .HasForeignKey("FiderId");

                    b.HasOne("ElectroBackend.Models.Transformer", "Transformer")
                        .WithMany()
                        .HasForeignKey("TransformerId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Transformer", b =>
                {
                    b.HasOne("ElectroBackend.Models.TransformerModel", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");

                    b.HasOne("ElectroBackend.Models.TransformerType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("ElectroBackend.Models.TransformerWorkload", b =>
                {
                    b.HasOne("ElectroBackend.Models.Transformer", "Transformer")
                        .WithMany("TransformerWorkloads")
                        .HasForeignKey("TransformerId");
                });

            modelBuilder.Entity("ElectroBackend.Models.Workload", b =>
                {
                    b.HasOne("ElectroBackend.Models.Tp", "Tp")
                        .WithMany()
                        .HasForeignKey("TpId");
                });
#pragma warning restore 612, 618
        }
    }
}
