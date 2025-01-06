﻿// <auto-generated />
using System;
using InstagramDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InstagramDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241107204501_PostComplainPostIdNull")]
    partial class PostComplainPostIdNull
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InstagramDemo.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4794),
                            Name = "Haber"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4809),
                            Name = "Bilim"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 7, 23, 45, 0, 957, DateTimeKind.Local).AddTicks(4810),
                            Name = "Sanat"
                        });
                });

            modelBuilder.Entity("InstagramDemo.Entities.Hasthag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hasthags");
                });

            modelBuilder.Entity("InstagramDemo.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostComplain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostComplains");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostHashTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HashTagID")
                        .HasColumnType("int");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HashTagID");

                    b.HasIndex("PostID");

                    b.ToTable("PostHashTags");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("PostLikes");
                });

            modelBuilder.Entity("InstagramDemo.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InstagramDemo.Entities.Post", b =>
                {
                    b.HasOne("InstagramDemo.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");

                    b.HasOne("InstagramDemo.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostComplain", b =>
                {
                    b.HasOne("InstagramDemo.Entities.Post", "Post")
                        .WithMany("PostComplains")
                        .HasForeignKey("PostId");

                    b.HasOne("InstagramDemo.Entities.User", "User")
                        .WithMany("PostComplains")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostHashTag", b =>
                {
                    b.HasOne("InstagramDemo.Entities.Hasthag", "Hasthag")
                        .WithMany("PostHashTags")
                        .HasForeignKey("HashTagID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("InstagramDemo.Entities.Post", "Post")
                        .WithMany("PostHashTags")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hasthag");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("InstagramDemo.Entities.PostLike", b =>
                {
                    b.HasOne("InstagramDemo.Entities.Post", "Post")
                        .WithMany("PostLikes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InstagramDemo.Entities.User", "User")
                        .WithMany("PostLikes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InstagramDemo.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("InstagramDemo.Entities.Hasthag", b =>
                {
                    b.Navigation("PostHashTags");
                });

            modelBuilder.Entity("InstagramDemo.Entities.Post", b =>
                {
                    b.Navigation("PostComplains");

                    b.Navigation("PostHashTags");

                    b.Navigation("PostLikes");
                });

            modelBuilder.Entity("InstagramDemo.Entities.User", b =>
                {
                    b.Navigation("PostComplains");

                    b.Navigation("PostLikes");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
