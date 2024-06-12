using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DBMS
{
    public class DatabaseContext : DbContext
    {
        public DbSet<CityList> CityLists { get; set; }
        public DbSet<ItemList> ItemLists { get; set; }
        public DbSet<AdminList> AdminLists { get; set; }
        public DbSet<AdminList_Name> AdminList_Names { get; set; }
        public DbSet<WarehouseList> WarehouseLists { get; set; }
        public DbSet<WarehouseList_Area> WarehouseList_Areas { get; set; }
        public DbSet<WarehouseList_Shelf> WarehouseList_Shelf { get; set; }
        public DbSet<Functions_Stock> Functions_Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DataPath.dbPath}\\warehouseDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityList>(i =>
            {
                i.HasKey(j => j._Code);
                i.HasMany(j => j.WarehouseLists).WithOne(j => j.CityList).HasForeignKey(j => j.CityList_Code).IsRequired();
            });

            modelBuilder.Entity<ItemList>(i =>
            {
                i.HasKey(j => j._Id);
            });

            modelBuilder.Entity<AdminList>(i =>
            {
                i.HasKey(j => j._Id);
                i.HasMany(j => j.AdminList_Names).WithOne(j => j.AdminList).HasForeignKey(j => j.AdminList_Id).IsRequired();
            });

            modelBuilder.Entity<AdminList_Name>(i =>
            {
                i.HasKey(j => j._Name);
                i.HasOne(j => j.AdminList).WithMany(j => j.AdminList_Names).HasForeignKey(j => j.AdminList_Id).IsRequired();
            });

            modelBuilder.Entity<WarehouseList>(i =>
            {
                i.HasKey(j => j._Id);
                i.Property(j => j._Id).IsRequired();

                i.HasOne(j=>j.CityList).WithMany(j=>j.WarehouseLists).HasForeignKey(j => j.CityList_Code).IsRequired();

                i.HasIndex(j => j._Name).IsUnique();

                i.HasMany(j => j.WarehouseList_Areas).WithOne(j => j.WarehouseList).HasForeignKey(j => j.WarehouseList_Id).IsRequired().OnDelete(DeleteBehavior.Cascade); ;
            });

            modelBuilder.Entity<WarehouseList_Area>(i =>
            {
                i.HasKey(j => j._Id);
                i.Property(j => j._Id).IsRequired();

                i.HasMany(j => j.WarehouseList_Shelves).WithOne(j => j.WarehouseList_Area).HasForeignKey(j => j.WarehouseList_Area_Id).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<WarehouseList_Shelf>(i =>
            {
                i.HasKey(j => j._Id);
                i.Property(j=>j._Id).ValueGeneratedNever();
            });
            
            modelBuilder.Entity<Functions_Stock>(i =>
            {
                i.HasKey(j => j._Id);
            });
        }
    }
}