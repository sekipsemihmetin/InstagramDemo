using InstagramDemo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramDemo.Data
{
    public class AppDbContext:DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<PostLike> PostLikes { get; set; }
        public DbSet<Hasthag> Hasthags { get; set; }
        public DbSet<PostHashTag> PostHashTags { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<PostComplain>  PostComplains { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=192.168.1.100;database=InstagramDemo1Db;uid=SA;pwd=Password123;trustservercertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PostLike>().HasOne(x => x.User).WithMany(x => x.PostLikes).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PostLike>().HasOne(x => x.Post).WithMany(x => x.PostLikes).HasForeignKey(x => x.PostId);
            //------------------------------------------------
            modelBuilder.Entity<PostHashTag>().HasOne(x => x.Hasthag).WithMany(x => x.PostHashTags).HasForeignKey(x => x.HashTagID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PostHashTag>().HasOne(x => x.Post).WithMany(x => x.PostHashTags).HasForeignKey(x => x.PostID);
            //--------------------------------------------------
            modelBuilder.Entity<PostComplain>().HasOne(x => x.User).WithMany(x => x.PostComplains).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PostComplain>().HasOne(x => x.Post).WithMany(x => x.PostComplains).HasForeignKey(x => x.PostId
      );      //--------------------------------------------------
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Haber"
            }, new Category { Id=2,Name="Bilim"},
               new Category { Id=3,Name="Sanat"}

            );
            modelBuilder.Entity<User>().HasData(new User() { Username = "Admin", Password = "admin", Email = "admin@gmail.com", IsAdmin = true, Id = 3 });
            modelBuilder.Entity<User>().HasData(new User() { Username = "Admin1", Password = "admin1", Email = "admin1@gmail.com", IsAdmin = true, Id = 4 });


        }
    }
}
