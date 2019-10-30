﻿// <auto-generated />
using System;
using AcademicReferenceManager.Repositories.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AcademicReferenceManager.Repositories.Migrations
{
    [DbContext(typeof(ArmDbContext))]
    [Migration("20191029222002_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("AcademicReferenceManager.Models.Entities.Friend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("AcademicReferenceManager.Models.Entities.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EditorFirstName");

                    b.Property<string>("EditorLastName");

                    b.Property<string>("Isbn");

                    b.Property<string>("Journal");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<int?>("Year");

                    b.HasKey("Id");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("AcademicReferenceManager.Models.Entities.PublicationToFriend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BorrowDate");

                    b.Property<int>("FriendId");

                    b.Property<int>("PublicationId");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("Id");

                    b.HasIndex("FriendId");

                    b.HasIndex("PublicationId");

                    b.ToTable("PublicationsToFriend");
                });

            modelBuilder.Entity("AcademicReferenceManager.Models.Entities.PublicationToFriend", b =>
                {
                    b.HasOne("AcademicReferenceManager.Models.Entities.Friend", "Friend")
                        .WithMany("PublicationsToFriend")
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AcademicReferenceManager.Models.Entities.Publication", "Publication")
                        .WithMany("PublicationsToFriend")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}