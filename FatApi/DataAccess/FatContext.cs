using FatApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FatApi.DataAccess
{
    public class FatContext : DbContext
    {
        public FatContext(DbContextOptions<FatContext> options) : base(options) { }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Difficulties> Difficulties { get; set; }
        public DbSet<Recipes> Recipes { get; set; }
        public DbSet<RecipesList> RecipesList { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Lists> List { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity => 
            {
                entity.ToTable("categories");

                entity.HasMany(x => x.Recipes)
                    .WithOne(x => x.Categories)
                    .HasForeignKey(x => x.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Category)
                    .HasMaxLength(20)
                    .IsRequired();
            });

            modelBuilder.Entity<Difficulties>(entity =>
            {
                entity.ToTable("difficulties");

                entity.HasMany(x => x.Recipes)
                    .WithOne(x => x.Difficulties)
                    .HasForeignKey(x => x.DifficultyId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Difficulty)
                    .HasMaxLength(20)
                    .IsRequired();
            });

            modelBuilder.Entity<Recipes>(entity =>
            {
                entity.ToTable("recipes");

                entity.HasMany(x => x.RecipesList)
                    .WithOne(x => x.Recipes)
                    .HasForeignKey(x => x.RecipeId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(x => x.Reviews)
                    .WithOne(x => x.Recipes)
                    .HasForeignKey(x => x.RecipeId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Name)
                    .HasMaxLength(50)
                    .IsRequired();

                //entity.Property(x => x.Image)
                //    .HasColumnType("LONGBLOB")
                //    .IsRequired();

                entity.Property(x => x.Description)
                    .HasMaxLength(450)
                    .IsUnicode(true)
                    .IsRequired();

                entity.Property(x => x.Time)
                    .IsRequired();

                entity.Property(x => x.Cost)
                    .IsRequired();
            });

            modelBuilder.Entity<RecipesList>(entity =>
            {
                entity.ToTable("recipes_list");

                entity.HasKey(entity => entity.Id);
            });

            modelBuilder.Entity<Reviews>(entity =>
            {
                entity.ToTable("reviews");

                entity.HasKey(x => x.Id);

                entity.Property(x => x.Review)
                    .HasMaxLength(150)
                    .IsRequired();
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasKey(x => x.Id);

                entity.HasMany(x => x.Recipes)
                    .WithOne(x => x.Users)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(x => x.List)
                    .WithOne(x => x.Users)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(x => x.Reviews)
                    .WithOne(x => x.Users)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.Property(x => x.Name)
                    .HasMaxLength(25)
                    .IsUnicode(true)
                    .IsRequired();

                entity.Property(x => x.Email)
                    .HasMaxLength(25)
                    .IsUnicode(true)
                    .IsRequired();

                entity.Property(x => x.Password)
                    .HasMaxLength(16)
                    .IsRequired();
            });

            modelBuilder.Entity<Lists>(entity =>
            {
                entity.ToTable("list");

                entity.HasKey(x => x.Id);

                entity.HasMany(x => x.RecipesList)
                    .WithOne(x => x.List)
                    .HasForeignKey(x => x.ListId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
