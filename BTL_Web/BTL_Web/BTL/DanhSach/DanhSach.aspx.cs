using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.DanhSach
{
    public partial class DanhSach : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            string hang = Request.QueryString["hang"];
            string sort = Request.QueryString["sort"];
            string op = "";
            List<Product> listProduct = products.Where(product => product.HangProduct == hang && product.TrangThaiProduct==1).ToList();
            if(sort=="0")
            {
                listProduct = listProduct.OrderBy(product => product.PriceProduct).ToList();
            }
            if(sort=="1")
            {
                listProduct = listProduct.OrderByDescending(product => product.PriceProduct).ToList();
            }
            tieuDe.InnerHtml = hang;
            amount.InnerHtml = listProduct.Count.ToString();
            foreach(Product product1 in listProduct)
            {
                op += $"<article class='product' data-id ='{product1.IdProduct}'>"
                    + "<ul class='feature'>"
                    + "<li class='feature_item img'>"
                    + $"<img src='{product1.ImagePath}' alt='Ảnh sp'>"
                    + "</li>"
                    + $"<li class='feature_item name'>{product1.NameProduct}</li>"
                    + $"<li class='feature_item name'>{product1.PriceProduct.ToString("N0", new CultureInfo("de-DE"))}</li>"
                    + "</ul>"
                    + "</article>";
            }
            product_list.InnerHtml = op;
        }
    }
}