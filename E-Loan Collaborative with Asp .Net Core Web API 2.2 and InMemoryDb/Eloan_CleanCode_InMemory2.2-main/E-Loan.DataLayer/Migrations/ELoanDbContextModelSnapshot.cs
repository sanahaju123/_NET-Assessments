﻿// <auto-generated />
using System;
using E_Loan.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_Loan.DataLayer.Migrations
{
    [DbContext(typeof(ELoanDbContext))]
    partial class ELoanDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("E_Loan.Entities.LoanApprovaltrans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LoanCloserDate");

                    b.Property<double>("MonthlyPayment");

                    b.Property<DateTime>("PaymentStartDate");

                    b.Property<double>("SanctionedAmount");

                    b.Property<double>("Termofloan");

                    b.Property<DateTime>("UpdatedOn");

                    b.HasKey("Id");

                    b.ToTable("loanApprovaltrans");
                });

            modelBuilder.Entity("E_Loan.Entities.LoanMaster", b =>
                {
                    b.Property<int>("LoanId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppliedBy");

                    b.Property<int>("Billing_Indicator");

                    b.Property<int>("BusinessStructure");

                    b.Property<string>("ContactAddress");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email");

                    b.Property<int>("LStatus");

                    b.Property<long>("LoanAmount");

                    b.Property<string>("LoanName")
                        .IsRequired();

                    b.Property<string>("ManagerRemark");

                    b.Property<string>("Phone");

                    b.Property<int>("Tax_Indicator");

                    b.HasKey("LoanId");

                    b.ToTable("loanMasters");
                });

            modelBuilder.Entity("E_Loan.Entities.LoanProcesstrans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AcresofLand");

                    b.Property<string>("AddressofProperty")
                        .IsRequired();

                    b.Property<string>("AppraisedBy")
                        .IsRequired();

                    b.Property<long>("LandValueinRs");

                    b.Property<int>("LoanId");

                    b.Property<int>("ManagerId");

                    b.Property<long>("SuggestedAmount");

                    b.Property<DateTime>("UpdatedOn");

                    b.Property<DateTime>("ValuationDate");

                    b.HasKey("Id");

                    b.ToTable("loanProcesstrans");
                });

            modelBuilder.Entity("E_Loan.Entities.UserMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Contact");

                    b.Property<string>("Email");

                    b.Property<bool>("Enabled");

                    b.Property<string>("IdProofNumber");

                    b.Property<int?>("IdproofTypes");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("userMasters");
                });
#pragma warning restore 612, 618
        }
    }
}
