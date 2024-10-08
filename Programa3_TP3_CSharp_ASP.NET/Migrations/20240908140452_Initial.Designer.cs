﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Programa3_TP3_CSharp_ASP.NET.Data;

#nullable disable

namespace Programa3_TP3_CSharp_ASP.NET.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240908140452_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Programa3_TP3_CSharp_ASP.NET.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoriaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Programa3_TP3_CSharp_ASP.NET.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Programa3_TP3_CSharp_ASP.NET.Models.Categoria", b =>
                {
                    b.HasOne("Programa3_TP3_CSharp_ASP.NET.Models.Produto", "Produto")
                        .WithMany("Categorias")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Programa3_TP3_CSharp_ASP.NET.Models.Produto", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
