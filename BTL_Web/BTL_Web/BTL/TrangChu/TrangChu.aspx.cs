using BTL_Web.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTL_Web.BTL.TrangChu
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["danhsachProduct"];
            if(!IsPostBack)
            {
                string op = "";
                string op2 = "";
                int soLuong_sp = 0;
                int soLuong_sp2 = 0;
                op += "<h1>Sản phẩm bán chạy</h1>"
                    + "<section class='product_list'>";
                op2 += "<h1>Sản phẩm tiêu biểu</h1>"
                    + "<section class='product_list'>";
                for (int i =0;i<products.Count;i++)
                {
                    
                    if (products[i].TrangThaiProduct==1)
                    {
                        if (products[i].HangProduct.ToUpper()=="NIKE")
                        {
                            soLuong_sp++;
                            if (soLuong_sp <=8)
                            {
                                 op += $"<article class='product' data-id='{products[i].IdProduct}'>"
                                    + "<ul class='feature'>"
                                    + "<li class='feature_item img'>"
                                    + $"<img src='{products[i].ImagePath}' alt='ảnh sp'>"
                                    + "<li>"
                                    + "<li class='feature_item name'>" + products[i].NameProduct + "</li>"
                                    + "<li class='feature_item price'>" + products[i].PriceProduct.ToString("N0", new CultureInfo("de-DE")) + " đ</li>"
                                    + "</ul>"
                                    + "</article>";
                            }
                            
                        }
                        if (products[i].HangProduct.ToUpper() == "MLB")
                        {
                            soLuong_sp2++;
                            if(soLuong_sp2<=8)
                            {
                                op2 += $"<article class='product' data-id='{products[i].IdProduct}'>"
                                + "<ul class='feature'>"
                                + "<li class='feature_item img'>"
                                + $"<img src='{products[i].ImagePath}' alt='ảnh sp'>"
                                + "<li>"
                                + "<li class='feature_item name'>" + products[i].NameProduct + "</li>"
                                + "<li class='feature_item price'>" + products[i].PriceProduct.ToString("N0", new CultureInfo("de-DE")) + " đ</li>"
                                + "</ul>"
                                + "</article>";
                            } 
                        }
                        
                    }
                    if(soLuong_sp==8&&soLuong_sp2==8)
                    {
                        break;
                    }    
                }
                op += "</section>";
                op2 += "</section>";

                product_hotSell.InnerHtml = op;
                product_Note.InnerHtml = op2;
            }    
        }
    }
}