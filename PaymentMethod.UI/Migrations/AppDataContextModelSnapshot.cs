﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentMethod.UI.Data;

namespace PaymentMethod.UI.Migrations
{
    [DbContext(typeof(AppDataContext))]
    partial class AppDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PaymentMethod.UI.Domains.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("BankCode")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DefaultBank")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UseCommonPaymentPage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.BankParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("BankParameters");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<bool>("CampaignCard")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("ManufacturerCard")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("CreditCards");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCardInstallment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("Installment")
                        .HasColumnType("int");

                    b.Property<decimal>("InstallmentRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CreditCardId");

                    b.ToTable("CreditCardInstallments");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCardPrefix", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.ToTable("CreditCardPrefixes");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.PaymentTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BankErrorMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("BankRequest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankResponse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardHolderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardPrefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<int>("ExtraInstallment")
                        .HasColumnType("int");

                    b.Property<int>("Installment")
                        .HasColumnType("int");

                    b.Property<Guid>("OrderNumber")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("PaidDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAgent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserIpAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.ToTable("PaymentTransactions");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.BankParameter", b =>
                {
                    b.HasOne("PaymentMethod.UI.Domains.Bank", "Bank")
                        .WithMany("Parameters")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCard", b =>
                {
                    b.HasOne("PaymentMethod.UI.Domains.Bank", "Bank")
                        .WithMany("CreditCards")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCardInstallment", b =>
                {
                    b.HasOne("PaymentMethod.UI.Domains.Bank", null)
                        .WithMany("Installments")
                        .HasForeignKey("BankId");

                    b.HasOne("PaymentMethod.UI.Domains.CreditCard", "CreditCard")
                        .WithMany("Installments")
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCardPrefix", b =>
                {
                    b.HasOne("PaymentMethod.UI.Domains.CreditCard", "CreditCard")
                        .WithMany("Prefixes")
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.PaymentTransaction", b =>
                {
                    b.HasOne("PaymentMethod.UI.Domains.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.Bank", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("Installments");

                    b.Navigation("Parameters");
                });

            modelBuilder.Entity("PaymentMethod.UI.Domains.CreditCard", b =>
                {
                    b.Navigation("Installments");

                    b.Navigation("Prefixes");
                });
#pragma warning restore 612, 618
        }
    }
}