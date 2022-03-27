﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_strongfitgym.Models;

#nullable disable

namespace project_strongfitgym.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExercicioTreino", b =>
                {
                    b.Property<int>("ExerciciosExercicioID")
                        .HasColumnType("int");

                    b.Property<int>("TreinosTreinoID")
                        .HasColumnType("int");

                    b.HasKey("ExerciciosExercicioID", "TreinosTreinoID");

                    b.HasIndex("TreinosTreinoID");

                    b.ToTable("ExercicioTreino");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlunoID"), 1L, 1);

                    b.Property<string>("AlunoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonalID")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoID");

                    b.HasIndex("PersonalID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioID"), 1L, 1);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExercicioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExercicioID");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Personal", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalID"), 1L, 1);

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalID");

                    b.ToTable("Personais");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Treino", b =>
                {
                    b.Property<int>("TreinoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreinoID"), 1L, 1);

                    b.Property<int>("AlunoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.HasKey("TreinoID");

                    b.HasIndex("AlunoID");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("ExercicioTreino", b =>
                {
                    b.HasOne("project_strongfitgym.Models.Exercicio", null)
                        .WithMany()
                        .HasForeignKey("ExerciciosExercicioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project_strongfitgym.Models.Treino", null)
                        .WithMany()
                        .HasForeignKey("TreinosTreinoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project_strongfitgym.Models.Aluno", b =>
                {
                    b.HasOne("project_strongfitgym.Models.Personal", "Personal")
                        .WithMany("Alunos")
                        .HasForeignKey("PersonalID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Treino", b =>
                {
                    b.HasOne("project_strongfitgym.Models.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Aluno", b =>
                {
                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("project_strongfitgym.Models.Personal", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
