using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.TimKiem
{
    public partial class TimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            string search = Request.QueryString["search"];
            string sort = Request.QueryString["sort"];
            List<Product> productList = products
                .Where(product => product.NameProduct.ToLower().Contains(search.ToLower()) && product.TrangThaiProduct==1)
                .ToList();
            if (sort == "0")
            {
                productList = productList.OrderBy(product => product.PriceProduct).ToList();
            }
            if (sort == "1")
            {
                productList = productList.OrderByDescending(product => product.PriceProduct).ToList();
            }
            string op = "";
            string ketQuaSearch = "";
            if (productList.Count > 0)

            {
                ketQuaSearch = "Kết quả tìm: " + search;
                foreach (Product product1 in productList)
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
            }
            else
            {
                ketQuaSearch = "Không tìm thấy: " + search;
            }    
            tieuDe.InnerHtml = ketQuaSearch;
            amount.InnerHtml = productList.Count.ToString();
            product_list.InnerHtml = op;
        }
    }
}