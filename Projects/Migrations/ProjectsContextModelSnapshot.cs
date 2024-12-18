﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projects.Data;

#nullable disable

namespace Projects.Migrations
{
    [DbContext(typeof(ProjectsContext))]
    partial class ProjectsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Projects.Models.Category", b =>
                {
                    b.Property<int>("category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("admin_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("parentcategory_id")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("category_id");

                    b.HasIndex("parentcategory_id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Projects.Models.Project", b =>
                {
                    b.Property<int>("project_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("admin_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("begintime")
                        .HasColumnType("TEXT");

                    b.Property<int>("category_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("endtime")
                        .HasColumnType("TEXT");

                    b.Property<string>("level")
                        .HasColumnType("TEXT");

                    b.Property<string>("major")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("requirements")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("student_id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("teacher_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("project_id");

                    b.HasIndex("category_id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Projects.Models.Category", b =>
                {
                    b.HasOne("Projects.Models.Category", "parentCategory")
                        .WithMany()
                        .HasForeignKey("parentcategory_id");

                    b.Navigation("parentCategory");
                });

            modelBuilder.Entity("Projects.Models.Project", b =>
                {
                    b.HasOne("Projects.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });
#pragma warning restore 612, 618
        }
    }
}
