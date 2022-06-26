using ArtifactManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtifactManager.Data
{
    public class ArtifactManagerContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Entity> Entities { get; set; }
        public DbSet<Privelege> Priveleges { get; set; }
        public DbSet<Models.Attribute> Attributes { get; set; }
        public DbSet<CurrentEntityAttribute> CurrentEntityAttribute { get; set; }
        public DbSet<CurrentRolePrivilege> CurrentRolePrivileges { get; set; }
        public DbSet<CurrentUserCategory> CurrentUserCategories { get; set; }
        public DbSet<CurrentUserRole> CurrentUserRoles { get; set; }


        public void ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArtifactManagerDB;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Username).IsUnicode();
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Username);
            modelBuilder.Entity<User>().HasData(new User { UserID = 1, FirstName = "Admin", LastName = "Admin", Username = "admin", Password = "Admin-10" });

            modelBuilder.Entity<Entity>().Property(u => u.Name).IsUnicode();
            modelBuilder.Entity<Entity>().HasAlternateKey(u => u.Name);

            modelBuilder.Entity<Models.Attribute>().Property(u => u.Name).IsUnicode();
            modelBuilder.Entity<Models.Attribute>().HasAlternateKey(u => u.Name);

            modelBuilder.Entity<Category>().Property(c => c.Name).IsUnicode();

            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, Name = "Guest"}, 
                new Role { RoleID = 2, Name = "User" }, 
                new Role { RoleID = 3, Name = "Admin" });


            //ENTITY'S ATTRIBUTES
            modelBuilder.Entity<CurrentEntityAttribute>().
                HasOne<Models.Attribute>(ceaa => ceaa.Attribute).
                WithMany(a => a.CurrentEntityAttributes).
                HasForeignKey(ceaa => ceaa.AttributeID);
            modelBuilder.Entity<CurrentEntityAttribute>().
                HasOne<Entity>(ceaa => ceaa.Entity).
                WithMany(a => a.CurrentEntityAttributes).
                HasForeignKey(ceaa => ceaa.EntityID);

            //USER'S ROLES
            modelBuilder.Entity<CurrentUserRole>().
                HasOne<User>(cur => cur.User).
                WithMany(u => u.CurrentUserRoles).
                HasForeignKey(cur => cur.UserID).
                OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CurrentUserRole>().
                HasOne<Role>(cur => cur.Role).
                WithMany(r => r.CurrentUserRoles).
                HasForeignKey(cur => cur.RoleID).
                OnDelete(DeleteBehavior.Cascade);

            //USER'S CATEGORIES
            modelBuilder.Entity<CurrentUserCategory>().
                HasOne<User>(cuc => cuc.User).
                WithMany(u => u.CurrentUserCategories).
                HasForeignKey(cuc => cuc.UserID).
                OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<CurrentUserCategory>().
                HasOne<Category>(cuc => cuc.Category).
                WithMany(c => c.CurrentUserCategories).
                HasForeignKey(cuc => cuc.CategoryID).
                OnDelete(DeleteBehavior.Cascade);

            //ROLE'S PRIVELEGES
            modelBuilder.Entity<CurrentRolePrivilege>().
                HasOne<Role>(crp => crp.Role).
                WithMany(r => r.CurrentRolePrivileges).
                HasForeignKey(crp => crp.RoleID);
            modelBuilder.Entity<CurrentRolePrivilege>().
                HasOne<Privelege>(crp => crp.Privelege).
                WithMany(c => c.CurrentRolePrivileges).
                HasForeignKey(crp => crp.PrivelegeID);

            //CATEGORY'S ENTITIES
            modelBuilder.Entity<Entity>().
                HasOne<Category>(crp => crp.Category).
                WithMany(c => c.Entities).
                HasForeignKey(crp => crp.CategoryID).
                OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
