﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Collections;

namespace DBMS
{
    public class CityList
    {
        public string _Code { get; set; }
        public string _City { get; set; }
        public ICollection<WarehouseList> WarehouseLists { get; } = new List<WarehouseList>();
        public CityList(string _Code, string _City)
        {
            this._Code = _Code;
            this._City = _City;
        }
    }

    public class ItemList
    {
        public required int _Id { get; set;  }
        public required string _Name { get; set; }
        public required string _AssetType { get; set; }
        public required string _Manufacturer { get; set; }
        public required string _SerialNumber { get; set; }
        public int? _Price { get; set; }
        public required int _Quantity { get; set; }
        public string? _Memo { get; set; }
        public ItemList(int _Id, string _Name, string _SerialNumber, int _Quantity, string? _Memo)
        {
            this._Id = _Id;
            this._Name = _Name;
            this._SerialNumber = _SerialNumber;
            this._Quantity = _Quantity;
            this._Memo = _Memo;
        }
    }

    public class ItemList_Spec
    {
        public ItemList_Spec(string _Object, string _Type, string _AssetType)
        { 
            this._Object = _Object;
            this._Type = _Type;
        }
        public required int _Id { get; set; }
        public required string _Object { get; set; }
        public required string _Type { get; set; }
    }

    /*
     Admin
     */
    public class AdminList
    {
        public string _Id { get; set; }
        public string _Region { get; set; }
        public string _Group { get; set; }
        public ICollection<AdminList_Name> AdminList_Names { get; } = new List<AdminList_Name>();
        public AdminList(string _Id, string _Region, string _Group)
        {
            this._Id = _Id;
            this._Region = _Region;
            this._Group = _Group;
        }
    }

    public class AdminList_Name
    {
        public string _Name { get; set; }
        public AdminList AdminList { get; set; } = null!; public string AdminList_Id { get; set; }

        public AdminList_Name(string AdminList_Id, string _Name) 
        {
            this.AdminList_Id = AdminList_Id;
            this._Name = _Name;
        }
    }

    /*
     Warehouse Lists
     */
    public class WarehouseList
    {
        public string _Id { get; set; }
        public int _Count { get; set; }
        public string CityList_Code { get; set; } public CityList CityList { get; set; } = null!;
        public string _Name { get; set; }
        public string _ImagePath { get; set; }

        public ICollection<WarehouseList_Area> WarehouseList_Areas { get; } = new List<WarehouseList_Area>();
        public WarehouseList(string _Id, int _Count, string CityList_Code, string _Name, string imagePath)
        {
            this._Id = _Id;
            this._Count = _Count;
            this.CityList_Code = CityList_Code;
            this._Name = _Name;
            this._ImagePath = imagePath;
        }
    }
    public class WarehouseList_Area
    {
        public string _Id {  get; set; }
        public string WarehouseList_Id { get; set; } public WarehouseList WarehouseList { get; set; } = null!;
        public int _Area { get; set; }
        public string? _DrawingImagePath { get; set; }
        public string? _NowImagePath { get; set; }

        public int _Conditions = 0;
        public ICollection<WarehouseList_Shelf> WarehouseList_Shelves { get; } = new List<WarehouseList_Shelf>();
        public WarehouseList_Area(string _Id, string WarehouseList_Id, int _Area, string? _DrawingImagePath, string? _NowImagePath)
        { 
            this._Id = _Id;
            this.WarehouseList_Id = WarehouseList_Id;
            this._Area = _Area;
            this._DrawingImagePath = _DrawingImagePath;
            this._NowImagePath = _NowImagePath;
        }
    }
    public class WarehouseList_Shelf
    {
        public string _Id { get; set; }
        public string WarehouseList_Area_Id { get; set; } public WarehouseList_Area WarehouseList_Area { get; set; } = null!;
        public int _Width { get; set; }
        public int _Depth { get; set; }

        public int _Height { get; set; }
        public ICollection<ItemList> ItemLists { get; } = new List<ItemList>();
        public WarehouseList_Shelf(string _Id, string WarehouseList_Area_Id, int _Width, int _Depth, int _Height) 
        {
            this._Id = _Id;
            this.WarehouseList_Area_Id = WarehouseList_Area_Id;
            this._Width = _Width;
            this._Depth = _Depth;
            this._Height = _Height;
        }
    }

    /*
     Functions
     */
    public class Functions_Stock
    {
        public required string _Id;
        public required string _StockInfo;
        public required int _Quantity;
        public required DateTime _Date;
        public required string _Memo;
    }
}