﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsuarioWebCRUD.Server;
using UsuarioWebCRUD.Server.Dal;

namespace UsuarioWebCRUD.Server.Migrations
{
    [DbContext(typeof(UserProfessionDbContext))]
    [Migration("20210215031520_Initials")]
    partial class Initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("UsuarioWebCRUD.Shared.Profession", b =>
                {
                    b.Property<int>("ProfessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProfessionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessionId");

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("UsuarioWebCRUD.Shared.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UsuarioWebCRUD.Shared.UserProfession", b =>
                {
                    b.Property<int>("UserProfessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProfessionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserProfessionId");

                    b.HasIndex("ProfessionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserProfessions");
                });

            modelBuilder.Entity("UsuarioWebCRUD.Shared.UserProfession", b =>
                {
                    b.HasOne("UsuarioWebCRUD.Shared.Profession", "Profession")
                        .WithMany()
                        .HasForeignKey("ProfessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UsuarioWebCRUD.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profession");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}