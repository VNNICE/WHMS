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
        public DbSet<Item_Object> Item_Objects { get; set; }
        public DbSet<Item_Type> Item_Types { get; set; }
        public DbSet<Item_AssetType> Item_AssetTypes { get; set; }
        public DbSet<AssetManagementList> AssetManagementLists { get; set; }
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
                i.HasMany(j => j.WarehouseLists).WithOne(j => j.CityList).HasForeignKey(j => j.CityList_Code);
            });

            //Related Entity for ItemList 
            modelBuilder.Entity<ItemList>(i =>
            {
                i.HasKey(j => j._Id);
                
                i.HasOne(j => j.WarehouseList_Shelf).WithMany(j => j.ItemLists).HasForeignKey(j=>j.WarehouseShelf_Id);
                i.HasOne(j => j.Item_Object).WithMany(j => j.ItemLists).HasForeignKey(j => j.Item_Object_Code);
                i.HasOne(j => j.Item_Type).WithMany(j => j.ItemLists).HasForeignKey(j => j.Item_Type_Code);
                i.HasOne(j => j.Item_AssetType).WithMany(j => j.ItemLists).HasForeignKey(j => j.Item_AssetType_Code);
                i.HasOne(j => j.AssetManagementList).WithOne(j => j.ItemList).HasForeignKey<AssetManagementList>(e => e.ItemList_Id);
            });
            modelBuilder.Entity<Item_Object> (i =>
            {
                i.HasKey(j => j._ObjectCode);
            });

            modelBuilder.Entity<Item_Type>(i =>
            {
                i.HasKey(j => j._TypeCode);
            });

            modelBuilder.Entity<Item_AssetType>(i =>
            {
                i.HasKey(j => j._AssetTypeCode);
            });

            modelBuilder.Entity<AssetManagementList>(i =>
            {
                i.HasKey(j => j._Id);
            });
            ///
            //Related Entity for  Admin List
            modelBuilder.Entity<AdminList>(i =>
            {
                i.HasKey(j => j._Id);
                i.HasMany(j => j.AdminList_Names).WithOne(j => j.AdminList).HasForeignKey(j => j.AdminList_Id);
            });

            modelBuilder.Entity<AdminList_Name>(i =>
            {
                i.HasKey(j => j._Id);
                i.HasIndex(j => j._Name).IsUnique();
            });
            ///
            //Related Entity for Warehouse
            modelBuilder.Entity<WarehouseList>(i =>
            {
                i.HasKey(j => j._Id);
                i.Property(j => j._Id).IsRequired();
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
            ///
            modelBuilder.Entity<Functions_Stock>(i =>
            {
                i.HasKey(j => j._Id);
            });
        }
    }
}