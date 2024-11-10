using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_Web.Class
{
    public class Product
    {
        string id;
        string name;
        string hang;
        string imagePath;
        int price;
        int trangThai;
        public Product()
        { }
        public Product(string id, string name, string hang, int price, int trangThai, string imagePath)
        {
            this.id = id;
            this.name = name;
            this.hang = hang;
            this.price = price;
            this.trangThai = trangThai;
            this.imagePath = imagePath;
        }
        public string IdProduct
        {
            get { return id; }
            set { id = value; }
        }
        public string NameProduct
            { get { return name; } set { name = value; } }
        public string HangProduct
                { get { return hang; } set { hang = value; } }
        public int PriceProduct
            { get { return price; } set { price = value; } }
        public int TrangThaiProduct
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        public string ImagePath
            { get { return imagePath; } set { imagePath = value; } }
    }
}