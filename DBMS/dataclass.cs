using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

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
        public string _Id { get; set; }
        public string AdminList_Name_Id { get; set; } public AdminList_Name AdminList_Name { get; set; } = null!;
        public string Item_Object_Code { get; set; } public Item_Object Item_Object { get; set; } = null!;

        public string Item_Type_Code { get; set; } public Item_Type Item_Type { get; set; } = null!;
        public string Item_AssetType_Code { get; set; } public Item_AssetType Item_AssetType { get; set; } = null!;
        public int? AssetManagementList_Id { get; set; } public AssetManagementList? AssetManagementList { get; set; }
        public string _Name { get; set; }
        public string _Manufacturer { get; set; }
        public string _SerialNumber { get; set; }
        public DateOnly? _PurchaseDate { get; set; }
        public int _Price { get; set; }
        public int _Quantity { get; set; }
        public string? _Memo { get; set; }
        public ICollection<StockItemList> StockItemLists { get; } = new List<StockItemList>();
        public ItemList(string _Id, string AdminList_Name_Id, string Item_Object_Code, string Item_Type_Code, string Item_AssetType_Code, int? AssetManagementList_Id, string _Name, string _Manufacturer, string _SerialNumber, DateOnly? _PurchaseDate, int _Price, int _Quantity, string? _Memo)
        {
            this._Id = _Id;
            this.AdminList_Name_Id = AdminList_Name_Id;
            this.Item_Object_Code = Item_Object_Code;
            this.Item_Type_Code = Item_Type_Code;
            this.Item_AssetType_Code = Item_AssetType_Code;
            this.AssetManagementList_Id = AssetManagementList_Id;
            this._Name = _Name;
            this._Manufacturer = _Manufacturer;
            this._SerialNumber = _SerialNumber;
            this._PurchaseDate = _PurchaseDate;
            this._Price = _Price;
            this._Quantity = _Quantity;
            this._Memo = _Memo;
        }
    }
    public class Item_Object
    {
        public string _Object { get; set; }
        public string _ObjectCode { get; set; }
        public ICollection<ItemList> ItemLists { get; } = new List<ItemList>();
        public Item_Object(string _Object, string _ObjectCode)
        {
            this._Object = _Object;
            this._ObjectCode = _ObjectCode;
        }
    }
    public class Item_Type
    {
        public string _Type { get; set; }
        public string _TypeCode { get; set; }
        public ICollection<ItemList> ItemLists { get; } = new List<ItemList>();
        public Item_Type(string _Type, string _TypeCode)
        {
            this._Type = _Type;
            this._TypeCode = _TypeCode;
        }
    }
    public class Item_AssetType
    {
        public string _AssetType { get; set; }
        public string _AssetTypeCode { get; set; }
        public ICollection<ItemList> ItemLists { get; } = new List<ItemList>();
        public Item_AssetType(string _AssetType, string _AssetTypeCode) 
        {
            this._AssetType = _AssetType;
            this._AssetTypeCode = _AssetTypeCode;
        }
    }

    public class AssetManagementList
    {
        public int _Id { get; set; }
        public string? ItemList_Id { get; set; } public ItemList? ItemList { get; set; }
        public AssetManagementList(int _Id, string ItemList_Id) 
        {
            this._Id = _Id;
            this.ItemList_Id = ItemList_Id;
        }
    }

    /* Admin  */
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
       
        public string _Id { get; set; }
        public string AdminList_Id { get; set; }
        public AdminList AdminList { get; set; } = null!;
        public string _Name { get; set; }
        public ICollection<ItemList> ItemLists { get; } = new List<ItemList>();

        public AdminList_Name(string _Id, string AdminList_Id, string _Name) 
        {
            this._Id = _Id;
            this.AdminList_Id = AdminList_Id;
            this._Name = _Name;
        }
    }

    /*     Warehouse Lists     */
    public class WarehouseList
    {
        public string _Id { get; set; }
        public int _Count { get; set; }
        public string CityList_Code { get; set; } public CityList CityList { get; set; } = null!;
        public string _Name { get; set; }
        public string? _ImagePath { get; set; }

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
        public int _No { get; set; }
        public string WarehouseList_Area_Id { get; set; } public WarehouseList_Area WarehouseList_Area { get; set; } = null!;
        public int _Width { get; set; }
        public int _Depth { get; set; }

        public int _Height { get; set; }
        public int _IsStock { get; set; }
        public ICollection<StockItemList> StockItemLists { get; } = new List<StockItemList>();
        public WarehouseList_Shelf(string _Id, int _No, string WarehouseList_Area_Id, int _Width, int _Depth, int _Height, int _IsStock) 
        {
            this._Id = _Id;
            this._No = _No;
            this.WarehouseList_Area_Id = WarehouseList_Area_Id;
            this._Width = _Width;
            this._Depth = _Depth;
            this._Height = _Height;
            this._IsStock = _IsStock;
        }
    }
    public class StockItemList
    {
        public string _Id { get; set; }
        public string ItemList_Id { get; set; }  public ItemList ItemList { get; set; } = null!;
        public string WarehouseList_Shelf_Id { get; set; } public WarehouseList_Shelf WarehouseList_Shelf { get; set; } = null!;
        public int _Quantity { get; set; }
        public DateOnly _ExpirationDate { get; set; }
        public DateOnly _CarryingInDate { get; set; }
        public DateOnly? _CarryingOutDate { get; set; }
        public DateOnly? _TakeOutDate { get; set; }
        public int _TakeOutQuantity { get; set; }
        public DateOnly? _TakeInDate { get; set; }
        public int _TakeInQuantity { get; set; }
        public StockItemList(string _Id, string ItemList_Id, string WarehouseList_Shelf_Id, DateOnly _ExpirationDate, DateOnly _CarryingInDate, DateOnly? _CarryingOutDate, DateOnly? _TakeOutDate, DateOnly? _TakeInDate)
        {
            this._Id = _Id;
            this.ItemList_Id = ItemList_Id;
            this.WarehouseList_Shelf_Id = WarehouseList_Shelf_Id;
            this._ExpirationDate = _ExpirationDate;
            this._CarryingInDate = _CarryingInDate;
            this._CarryingOutDate = _CarryingOutDate;
            this._TakeInDate = _TakeInDate;
            this._TakeOutDate = _TakeOutDate;
        }
    }

    /*     JoinTables     */
    public class Join_AdminList 
    {
        public string _Id { get; set; }
        public string _Region { get; set; }
        public string _Group { get; set; }
        public string _Name { get; set; }
        public Join_AdminList(string _Id, string _Region, string _Group, string _Name)
        {
            this._Id = _Id;
            this._Region = _Region;
            this._Group = _Group;
            this._Name = _Name;
        }
    }

    public class Join_Warehouse
    {
        public string _Id { get; set; }
        public string _City { get; set; }
        public string _Name { get; set; }
        public int _AreaNo { get; set; }
        public int _ShelfNo { get; set; }
        public int _IsStock { get; set; }
        public string _AddedItem { get; set; }
        public Join_Warehouse(string _Id, string _City, string _Name, int _AreaNo, int _ShelfNo, int _IsStock, string _AddedItem)
        {
            this._Id = _Id;
            this._City = _City;
            this._Name = _Name;
            this._AreaNo = _AreaNo;
            this._ShelfNo = _ShelfNo;
            this._IsStock = _IsStock;
            this._AddedItem = _AddedItem;
        }
    }
}