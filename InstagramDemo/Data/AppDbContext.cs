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


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=192.168.88.144;database=InstagramDemoDb;uid=SA;pwd=Password123;trustservercertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PostLike>().HasOne(x => x.User).WithMany(x => x.PostLikes).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PostLike>().HasOne(x => x.Post).WithMany(x => x.PostLikes).HasForeignKey(x => x.PostId);
            //------------------------------------------------
            modelBuilder.Entity<PostHashTag>().HasOne(x => x.Hasthag).WithMany(x => x.PostHashTags).HasForeignKey(x => x.HashTagID).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PostHashTag>().HasOne(x => x.Post).WithMany(x => x.PostHashTags).HasForeignKey(x => x.PostID);
        }
    }
}
