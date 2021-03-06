﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PesquisaCrypto.Models;

namespace PesquisaCrypto.Migrations
{
    [DbContext(typeof(MoedasContexto))]
    [Migration("20180915210726_CriacaoBD")]
    partial class CriacaoBD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PesquisaCrypto.Models.Moedas", b =>
                {
                    b.Property<int>("MoedasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.HasKey("MoedasId");

                    b.ToTable("Moedas");
                });
#pragma warning restore 612, 618
        }
    }
}
