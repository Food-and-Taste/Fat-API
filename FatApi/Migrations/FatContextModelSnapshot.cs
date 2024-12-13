﻿// <auto-generated />
using FatApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FatApi.Migrations
{
    [DbContext(typeof(FatContext))]
    partial class FatContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FatApi.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.Difficulties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("difficulties", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.Ingredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ingredients", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("list", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(450)
                        .IsUnicode(true)
                        .HasColumnType("varchar(450)");

                    b.Property<int>("DifficultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("UserId");

                    b.ToTable("recipes", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.RecipesIngredients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("recipes_ingredients", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.RecipesList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ListId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ListId");

                    b.HasIndex("RecipeId");

                    b.ToTable("recipes_list", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.Reviews", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(true)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("FatApi.Entities.List", b =>
                {
                    b.HasOne("FatApi.Entities.Users", "Users")
                        .WithMany("List")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FatApi.Entities.Recipes", b =>
                {
                    b.HasOne("FatApi.Entities.Categories", "Categories")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FatApi.Entities.Difficulties", "Difficulties")
                        .WithMany("Recipes")
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FatApi.Entities.Users", "Users")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Difficulties");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FatApi.Entities.RecipesIngredients", b =>
                {
                    b.HasOne("FatApi.Entities.Ingredients", "Ingredients")
                        .WithMany("RecipesIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FatApi.Entities.Recipes", "Recipes")
                        .WithMany("RecipesIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ingredients");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("FatApi.Entities.RecipesList", b =>
                {
                    b.HasOne("FatApi.Entities.List", "List")
                        .WithMany("RecipesList")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FatApi.Entities.Recipes", "Recipes")
                        .WithMany("RecipesList")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("List");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("FatApi.Entities.Reviews", b =>
                {
                    b.HasOne("FatApi.Entities.Users", "Users")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("FatApi.Entities.Categories", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("FatApi.Entities.Difficulties", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("FatApi.Entities.Ingredients", b =>
                {
                    b.Navigation("RecipesIngredients");
                });

            modelBuilder.Entity("FatApi.Entities.List", b =>
                {
                    b.Navigation("RecipesList");
                });

            modelBuilder.Entity("FatApi.Entities.Recipes", b =>
                {
                    b.Navigation("RecipesIngredients");

                    b.Navigation("RecipesList");
                });

            modelBuilder.Entity("FatApi.Entities.Users", b =>
                {
                    b.Navigation("List");

                    b.Navigation("Recipes");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
