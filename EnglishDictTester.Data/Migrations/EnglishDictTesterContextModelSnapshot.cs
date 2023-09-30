﻿// <auto-generated />
using System;
using EnglishDictTester.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EnglishDictTester.Data.Migrations
{
    [DbContext(typeof(EnglishDictTesterContext))]
    partial class EnglishDictTesterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EnglishDictTester.Data.Models.Tests", b =>
                {
                    b.Property<int?>("testId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("testId"), 1L, 1);

                    b.Property<string>("answer")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("bgId")
                        .HasColumnType("int");

                    b.Property<string>("bgW")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("enId")
                        .HasColumnType("int");

                    b.Property<string>("enW")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("lngName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("testId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordBg", b =>
                {
                    b.Property<int?>("WordBgId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("WordBgId"), 1L, 1);

                    b.Property<string>("BgWord")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("WordBgId");

                    b.ToTable("WordBgs");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordEn", b =>
                {
                    b.Property<int?>("WordEnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("WordEnId"), 1L, 1);

                    b.Property<string>("EnWord")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Transcriptions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WordEnId");

                    b.ToTable("WordEns");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordsEnBg", b =>
                {
                    b.Property<int?>("WordEnId")
                        .HasColumnType("int");

                    b.Property<int?>("WordBgId")
                        .HasColumnType("int");

                    b.HasKey("WordEnId", "WordBgId");

                    b.HasIndex("WordBgId");

                    b.ToTable("WordsEnBgs");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordsEnBg", b =>
                {
                    b.HasOne("EnglishDictTester.Data.Models.WordBg", "WordBg")
                        .WithMany("WordsEnBgs")
                        .HasForeignKey("WordBgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishDictTester.Data.Models.WordEn", "WordEn")
                        .WithMany("WordsEnBgs")
                        .HasForeignKey("WordEnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WordBg");

                    b.Navigation("WordEn");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordBg", b =>
                {
                    b.Navigation("WordsEnBgs");
                });

            modelBuilder.Entity("EnglishDictTester.Data.Models.WordEn", b =>
                {
                    b.Navigation("WordsEnBgs");
                });
#pragma warning restore 612, 618
        }
    }
}
