using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_Web.Class
{
    public class Cart
    {
        int idCart;
        string idProduct;
        string mau;
        int priceProduct;
        int size;
        int soLuong;
        int total;
        public Cart() { }
        public Cart(int idCart, string idProduct, string mau, int size, int soLuong, int total, int priceProduct)
        {
            this.idCart = idCart;
            this.idProduct = idProduct;
            this.mau = mau;
            this.size = size;
            this.soLuong = soLuong;
            this.total = total;
            this.priceProduct = priceProduct;
        }
        public int IDCart
        {
            get { return idCart; }
            set { idCart = value; }
        } 
        public string IDProduct
            { get { return idProduct; } set { idProduct = value; } }
        public string Mau
        { get { return mau; } set { mau = value; } }
        public int Size
            { get { return size; } set { size = value; } }
        public int SoLuong
        { get { return soLuong; } set { soLuong = value; } }
            public int Total
            { get { return total; } set { total = value; } }
        public int PriceProduct
        { get { return priceProduct; } set { priceProduct = value; } }
    }
}