﻿// <auto-generated />
using CadastroElogin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CadastroElogin.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220105025304_Migrations")]
    partial class Migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CadastroElogin.Models.Telefone", b =>
                {
                    b.Property<int>("Id_tel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celeluar")
                        .HasColumnType("char(11)");

                    b.Property<int>("Id_usuario")
                        .HasColumnType("int");

                    b.HasKey("Id_tel");

                    b.HasIndex("Id_usuario");

                    b.ToTable("Telefone");
                });

            modelBuilder.Entity("CadastroElogin.Models.Usuario", b =>
                {
                    b.Property<int>("Id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id_usuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("CadastroElogin.Models.Telefone", b =>
                {
                    b.HasOne("CadastroElogin.Models.Usuario", "Usuario")
                        .WithMany("telefones")
                        .HasForeignKey("Id_usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("CadastroElogin.Models.Usuario", b =>
                {
                    b.Navigation("telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
